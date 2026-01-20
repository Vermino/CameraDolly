using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using ACBindingsTest.Internal;
using Decal.Adapter;
using Newtonsoft.Json;
using UtilityBelt.Service;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = System.Numerics.Vector3;

namespace CameraDolly
{
    public unsafe class CameraPathManager : IDisposable
    {
        private static CameraPathManager _instance;

        public static CameraPathManager Instance
        {
            get
            {
                if (_instance == null) _instance = new CameraPathManager();
                return _instance;
            }
        }

        public CameraPath CurrentPath { get; private set; } = new CameraPath();
        public bool IsPlaying { get; private set; }
        public bool ShowPath { get; set; } = true;
        public bool DisableUiDuringPlayback { get; set; } = true;

        private float _playbackTime = 0f;
        private DateTime _lastFrameTime;

        /// <summary>
        /// Gets the current playback time in seconds.
        /// </summary>
        public float PlaybackTime => _playbackTime;

        private PathRenderer _pathRenderer = new PathRenderer();

        // Track which command frames have been fired during current playback
        private System.Collections.Generic.HashSet<int> _firedCommandFrames =
            new System.Collections.Generic.HashSet<int>();

        private bool _wasFreeCameraEnabledBeforePlayback;

        #region Command Dispatch P/Invoke

        [DllImport("Decal.dll")]
        static extern int DispatchOnChatCommand(ref IntPtr str, [MarshalAs(UnmanagedType.U4)] int target);

        private static bool Decal_DispatchOnChatCommand(string cmd)
        {
            IntPtr bstr = Marshal.StringToBSTR(cmd);
            try
            {
                bool eaten = (DispatchOnChatCommand(ref bstr, 1) & 0x1) > 0;
                return eaten;
            }
            finally
            {
                Marshal.FreeBSTR(bstr);
            }
        }

        /// <summary>
        /// Dispatches a chat command, first attempting plugin intercept.
        /// If no plugins consume the message, it invokes the chat parser directly.
        /// </summary>
        private static void DispatchChatToBoxWithPluginIntercept(string cmd)
        {
            if (!Decal_DispatchOnChatCommand(cmd))
                CoreManager.Current.Actions.InvokeChatParser(cmd);
        }

        #endregion


        public CameraPathManager()
        {
            // Ensure directory exists
            try
            {
                Directory.CreateDirectory(Path.Combine(PluginCore.AssemblyDirectory, "camerapaths"));
            }
            catch
            {
            }
        }

        public void AddKeyframe()
        {
            if (FreeCamera.Instance.Enabled && FreeCamera.Instance.CurrentPos != null)
            {
                var pos = FreeCamera.Instance.CurrentPos;
                var rot = new Quaternion(pos->frame.qx, pos->frame.qy, pos->frame.qz, pos->frame.qw);

                // Store as local frame coordinates (landblock + offset)
                CurrentPath.Items.Add(new PathKeyframe
                {
                    LocalPos = LocalPosition.FromPosition(pos),
                    Rotation = rot,
                    Time = 2.0f
                });
            }
        }

        /// <summary>
        /// Adds a keyframe at the specified index in the timeline.
        /// </summary>
        public void InsertKeyframe(int insertIndex)
        {
            if (FreeCamera.Instance.Enabled && FreeCamera.Instance.CurrentPos != null)
            {
                var pos = FreeCamera.Instance.CurrentPos;
                var rot = new Quaternion(pos->frame.qx, pos->frame.qy, pos->frame.qz, pos->frame.qw);

                // Store as local frame coordinates (landblock + offset)
                var kf = new PathKeyframe
                {
                    LocalPos = LocalPosition.FromPosition(pos),
                    Rotation = rot,
                    Time = 2.0f
                };

                if (insertIndex < 0 || insertIndex >= CurrentPath.Items.Count)
                    CurrentPath.Items.Add(kf);
                else
                    CurrentPath.Items.Insert(insertIndex, kf);
            }
        }

        /// <summary>
        /// Updates a keyframe's properties while trying to maintain the timing of the path.
        /// </summary>
        public void UpdateKeyframe(int index, LocalPosition? newPos, Quaternion? newRot)
        {
            if (index < 0 || index >= CurrentPath.Items.Count) return;
            if (!(CurrentPath.Items[index] is PathKeyframe kf)) return;

            // 1. Capture durations of affected segments
            // Moving index 'i' impacts segments where 'i' is used as a control point.
            // Catmull-Rom uses i-1, i, i+1, i+2 for a segment.
            // So segments starting at i-2, i-1, i, i+1 are affected.
            var affectedSegments = new Dictionary<int, float>();
            for (int i = index - 2; i <= index + 1; i++)
            {
                if (i >= 0 && i < CurrentPath.Items.Count - 1)
                {
                    float dist = SplineUtility.GetSegmentLength(CurrentPath.Items, i);
                    float speed = CurrentPath.Items[i].Speed;
                    if (speed <= 0.001f) speed = 0.001f;
                    affectedSegments[i] = dist / speed;
                }
            }

            // 2. Apply changes
            if (newPos.HasValue) kf.LocalPos = newPos.Value;
            if (newRot.HasValue) kf.Rotation = newRot.Value;

            // 3. Restore durations by adjusting speed
            foreach (var kvp in affectedSegments)
            {
                int segIdx = kvp.Key;
                float targetDuration = kvp.Value;

                float newDist = SplineUtility.GetSegmentLength(CurrentPath.Items, segIdx);

                // NewSpeed = NewDist / TargetDuration
                // Avoid division by zero
                if (targetDuration > 0.001f)
                {
                    float newSpeed = newDist / targetDuration;
                    if (newSpeed < 0.001f) newSpeed = 0.001f;
                    CurrentPath.Items[segIdx].Speed = newSpeed;
                }
            }
        }

        public void Play()
        {
            if (CurrentPath.Items.Count < 2) return;

            if (DisableUiDuringPlayback)
            {
                UBService.Huds.DisableAllRendering.Value = true;
                *SceneTool.m_RenderUIObjects = 0;
                *Device.m_fMouseIsShown = 0;
            }

            IsPlaying = true;
            _lastFrameTime = DateTime.UtcNow;
            _firedCommandFrames.Clear(); // Reset fired commands for new playback

            if (CurrentPath.IsReverse)
                _playbackTime = SplineUtility.CalculateTotalDuration(CurrentPath.Items);
            else
                _playbackTime = 0f;

            // Auto-enable free camera if needed
            _wasFreeCameraEnabledBeforePlayback = FreeCamera.Instance.Enabled;
            if (!_wasFreeCameraEnabledBeforePlayback)
            {
                if (ACBindingsTest.Internal.SmartBox.smartbox != null)
                {
                    FreeCamera.Instance.Enable(
                        &((ACBindingsTest.Internal.SmartBox*)*ACBindingsTest.Internal.SmartBox.smartbox)->viewer);
                }
            }
        }

        public void Stop()
        {
            // Always ensure rendering is re-enabled when passing through Stop()
            if (UBService.Huds.DisableAllRendering.Value)
            {
                UBService.Huds.DisableAllRendering.Value = false;
                *SceneTool.m_RenderUIObjects = 1;
            }

            IsPlaying = false;
            _firedCommandFrames.Clear(); // Reset fired commands when stopped

            // Restore free camera state
            if (!_wasFreeCameraEnabledBeforePlayback && FreeCamera.Instance.Enabled)
            {
                FreeCamera.Instance.Disable();
            }
        }

        /// <summary>
        /// Scrubs to a specific time position and moves the camera there.
        /// </summary>
        public void ScrubToTime(float time)
        {
            if (CurrentPath.Items.Count < 2) return;
            if (!FreeCamera.Instance.Enabled) return;

            float totalDuration = SplineUtility.CalculateTotalDuration(CurrentPath.Items);
            time = Math.Max(0, Math.Min(totalDuration, time));

            EvaluateAtTime(time, out LocalPosition localPos, out Quaternion rot);
            SetCameraPosition(localPos, rot);
        }

        /// <summary>
        /// Gets the total duration of the current path in seconds.
        /// </summary>
        public float GetTotalDuration()
        {
            return SplineUtility.CalculateTotalDuration(CurrentPath.Items);
        }

        /// <summary>
        /// Executes command frames that should fire at the given playback time.
        /// </summary>
        private void ExecuteCommandFrames(float currentTime)
        {
            if (CurrentPath.CommandFrames == null || CurrentPath.CommandFrames.Count == 0)
                return;

            for (int i = 0; i < CurrentPath.CommandFrames.Count; i++)
            {
                // Skip if already fired during this playback session
                if (_firedCommandFrames.Contains(i))
                    continue;

                var cmdFrame = CurrentPath.CommandFrames[i];

                // Check if we've crossed this command frame's time
                bool shouldFire;
                if (CurrentPath.IsReverse)
                {
                    // In reverse, fire when we go below the command time
                    shouldFire = currentTime <= cmdFrame.Time;
                }
                else
                {
                    // In forward, fire when we go past the command time
                    shouldFire = currentTime >= cmdFrame.Time;
                }

                if (shouldFire)
                {
                    _firedCommandFrames.Add(i);

                    // Execute all commands in this frame
                    foreach (var cmd in cmdFrame.Commands)
                    {
                        if (!string.IsNullOrWhiteSpace(cmd))
                        {
                            try
                            {
                                DispatchChatToBoxWithPluginIntercept(cmd);
                            }
                            catch (Exception ex)
                            {
                                PluginCore.Log(ex);
                            }
                        }
                    }
                }
            }
        }

        public void Update()
        {
            // Handle Playback
            if (IsPlaying)
            {
                var now = DateTime.UtcNow;
                float dt = (float)(now - _lastFrameTime).TotalSeconds;
                _lastFrameTime = now;

                if (CurrentPath.IsReverse)
                    _playbackTime -= dt;
                else
                    _playbackTime += dt;

                float totalDuration = SplineUtility.CalculateTotalDuration(CurrentPath.Items);

                if (CurrentPath.IsReverse)
                {
                    if (_playbackTime <= 0)
                    {
                        if (CurrentPath.IsLooping)
                            _playbackTime += totalDuration;
                        else
                        {
                            Stop();
                            return;
                        }
                    }
                }
                else
                {
                    if (_playbackTime >= totalDuration)
                    {
                        if (CurrentPath.IsLooping)
                            _playbackTime %= totalDuration;
                        else
                        {
                            Stop();
                            return;
                        }
                    }
                }

                // Interpolate
                EvaluateAtTime(_playbackTime, out LocalPosition newLocalPos, out Quaternion newRot);

                // Apply to Camera
                SetCameraPosition(newLocalPos, newRot);

                // Execute command frames that have been crossed
                ExecuteCommandFrames(_playbackTime);
            }

            // Drawing
            if (ShowPath)
            {
                _pathRenderer.DrawPath(CurrentPath);
            }
            else
            {
                _pathRenderer.Clear();
            }
        }

        private void SetCameraPosition(LocalPosition localPos, Quaternion rotation)
        {
            if (!FreeCamera.Instance.Enabled || FreeCamera.Instance.CurrentPos == null) return;

            // Apply local frame coordinates directly
            FreeCamera.Instance.CurrentPos->objcell_id = localPos.LandblockId;
            FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.x = localPos.Offset.X;
            FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.y = localPos.Offset.Y;
            FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.z = localPos.Offset.Z;

            FreeCamera.Instance.CurrentPos->frame.qx = rotation.X;
            FreeCamera.Instance.CurrentPos->frame.qy = rotation.Y;
            FreeCamera.Instance.CurrentPos->frame.qz = rotation.Z;
            FreeCamera.Instance.CurrentPos->frame.qw = rotation.W;

            FreeCamera.Instance.CurrentPos->frame.cache();
        }


        private Quaternion CalculateLookAtRotation(Vector3 cameraGlobalPos, int targetId, Vector3 offset)
        {
            try
            {
                var obj = CoreManager.Current.WorldFilter[targetId];
                if (obj != null)
                {
                    var coords = obj.Coordinates();
                    float tEW = (float)coords.East;
                    float tNS = (float)coords.North;
                    float tZ = (float)coords.Up;

                    Vector3 targetGlobal = new Vector3(tEW, tNS, tZ);
                    Vector3 dir = targetGlobal - cameraGlobalPos;

                    // Scale EW/NS to match Z units (approximate)
                    dir.X *= 240.0f;
                    dir.Y *= 240.0f;

                    if (dir.LengthSquared() < 0.001f) return Quaternion.Identity;

                    dir = Vector3.Normalize(dir);

                    float yaw = (float)Math.Atan2(dir.X, dir.Y);
                    float pitch = (float)Math.Asin(Math.Max(-1, Math.Min(1, dir.Z)));

                    var qPitch = Quaternion.CreateFromAxisAngle(Vector3.UnitX, pitch);
                    var qYaw = Quaternion.CreateFromAxisAngle(Vector3.UnitZ, -yaw);

                    return qYaw * qPitch;
                }
            }
            catch { }
            return Quaternion.Identity;
        }

        private void EvaluateAtTime(float time, out LocalPosition localPos, out Quaternion rot)
        {
            float t = time;
            for (int i = 0; i < CurrentPath.Items.Count - 1; i++)
            {
                float dist = SplineUtility.GetSegmentLength(CurrentPath.Items, i);
                float speed = CurrentPath.Items[i].Speed;
                if (speed <= 0.001f) speed = 0.001f;
                float duration = dist / speed;

                if (t <= duration)
                {
                    float segT = t / duration;
                    if (segT < 0) segT = 0;
                    if (segT > 1) segT = 1;

                    // Use global coordinates for interpolation (handles cross-landblock paths)
                    Vector3 p0 = i > 0
                        ? CurrentPath.Items[i - 1].GetGlobalPosition()
                        : CurrentPath.Items[i].GetGlobalPosition();
                    Vector3 p1 = CurrentPath.Items[i].GetGlobalPosition();
                    Vector3 p2 = CurrentPath.Items[i + 1].GetGlobalPosition();
                    Vector3 p3 = i < CurrentPath.Items.Count - 2 ? CurrentPath.Items[i + 2].GetGlobalPosition() : p2;

                    // Interpolate in global space
                    Vector3 globalPos = SplineUtility.CatmullRom(p0, p1, p2, p3, segT);

                    // Convert back to local frame
                    localPos = LocalPosition.FromGlobal(globalPos);

                    // Handle rotation based on item types
                    var item1 = CurrentPath.Items[i] as PathKeyframe;
                    var item2 = CurrentPath.Items[i + 1] as PathKeyframe;

                    Quaternion r1 = item1?.GetTargetRotation() ?? Quaternion.Identity;
                    Quaternion r2 = item2?.GetTargetRotation() ?? Quaternion.Identity;

                    if (item1 != null && item1.LookAtTarget)
                    {
                        r1 = CalculateLookAtRotation(item1.GetGlobalPosition(), item1.TargetId, item1.TargetOffset);
                    }
                    if (item2 != null && item2.LookAtTarget)
                    {
                        r2 = CalculateLookAtRotation(item2.GetGlobalPosition(), item2.TargetId, item2.TargetOffset);
                    }

                    // Regular interpolation between rotations
                    rot = Quaternion.Slerp(r1, r2, segT);
                    return;
                }

                t -= duration;
            }

            // Fallback to end
            var lastItem = CurrentPath.Items[CurrentPath.Items.Count - 1];
            if (lastItem is PathKeyframe lastKf)
                localPos = lastKf.LocalPos;
            else
                localPos = new LocalPosition();
            rot = lastItem.GetTargetRotation();
        }

        public void Save(string name)
        {
            try
            {
                CurrentPath.Name = name;
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    TypeNameHandling = TypeNameHandling.Auto,
                    TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                    SerializationBinder = new SerializationBinder()
                    {
                        BindParentType = GetType()
                    }
                };
                var json = JsonConvert.SerializeObject(CurrentPath, settings);
                File.WriteAllText(Path.Combine(PluginCore.AssemblyDirectory, "camerapaths", $"{name}.json"), json);
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        public void Load(string name)
        {
            try
            {
                var path = Path.Combine(PluginCore.AssemblyDirectory, "camerapaths", $"{name}.json");
                if (File.Exists(path))
                {
                    var json = File.ReadAllText(path);
                    var settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                        SerializationBinder = new SerializationBinder()
                        {
                            BindParentType = GetType()
                        }
                    };
                    CurrentPath = JsonConvert.DeserializeObject<CameraPath>(json, settings);
                    Stop();
                }
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        public List<string> GetAvailablePaths()
        {
            try
            {
                var dir = Path.Combine(PluginCore.AssemblyDirectory, "camerapaths");
                if (!Directory.Exists(dir)) return new List<string>();
                return Directory.GetFiles(dir, "*.json").Select(Path.GetFileNameWithoutExtension).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public void Dispose()
        {
            _pathRenderer?.Dispose();
        }
    }
}
