using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using ACBindingsTest.Internal;
using Decal.Adapter;
using Decal.Adapter.Wrappers;
using ImGuiNET;

namespace CameraDolly
{
    public struct ActorState
    {
        public int Guid;
        public int CellId;
        public Vector3 Position;
        public Quaternion Rotation;
        public double Timestamp;
    }

    public class ReplaySystem : IDisposable
    {
        private static ReplaySystem _instance;
        public static ReplaySystem Instance => _instance ?? (_instance = new ReplaySystem());

        private Dictionary<int, LinkedList<ActorState>> _historyBuffer = new Dictionary<int, LinkedList<ActorState>>();
        private double _maxHistorySeconds = 10.0;
        public double ReplayDuration { get; set; } = 5.0;

        public bool IsReplaying { get; private set; }
        private double _replayStartTime;
        private double _replayTargetTime;
        private double _replayCurrentTime;
        private int _replayKillerId;
        private int _replayVictimId;
        private DateTime _lastFrameTime;

        private bool _wasFreeCameraEnabled;
        private bool _wasFreeCameraInputEnabled;

        public ReplaySystem()
        {
            CoreManager.Current.RenderFrame += Current_RenderFrame;
            CoreManager.Current.WindowMessage += Current_WindowMessage;
            try
            {
                CoreManager.Current.CharacterFilter.Death += CharacterFilter_Death;
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        private void CharacterFilter_Death(object sender, DeathEventArgs e)
        {
            try
            {
                // Auto-trigger replay on death
                // We try to find the killer, but CharacterFilter.Death event usually contains text message.
                // We might need to infer killer from WorldFilter or just default to 0 (victim POV fallback).

                int victimId = CoreManager.Current.CharacterFilter.Id;
                int killerId = 0; // Default to unknown (ReplaySystem will fallback to victim POV)

                // Experimental: Try to find a recent attacker or check who has high threat/aggro if exposed.
                // For now, we rely on the fallback.

                StartReplay(victimId, killerId);

                PluginCore.Log($"Killcam triggered for victim {victimId}");
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        private void Current_WindowMessage(object sender, WindowMessageEventArgs e)
        {
            if (IsReplaying)
            {
                // Cinematic Input Gate: Block world interactions
                // 0x0201 WM_LBUTTONDOWN - 0x0209 WM_MBUTTONDBLCLK
                if (e.Msg >= 0x0201 && e.Msg <= 0x0209)
                {
                    // If UI doesn't want it, eat it so game doesn't get it (prevent moving/interacting)
                    if (!ImGui.GetIO().WantCaptureMouse)
                    {
                        e.Eat = true;
                    }
                }
            }
        }

        private void Current_RenderFrame(object sender, EventArgs e)
        {
            try
            {
                if (IsReplaying)
                {
                    UpdatePlayback();
                }
                else
                {
                    RecordFrame();
                }
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        private void RecordFrame()
        {
            double now = DateTime.UtcNow.TimeOfDay.TotalSeconds;

            // Record Players
            foreach (var wo in CoreManager.Current.WorldFilter.GetByObjectClass(ObjectClass.Player))
            {
                RecordActor(wo, now);
            }
            // Record Monsters
            foreach (var wo in CoreManager.Current.WorldFilter.GetByObjectClass(ObjectClass.Monster))
            {
                RecordActor(wo, now);
            }
        }

        private void RecordActor(WorldObject wo, double timestamp)
        {
            if (!_historyBuffer.ContainsKey(wo.Id))
            {
                _historyBuffer[wo.Id] = new LinkedList<ActorState>();
            }

            var list = _historyBuffer[wo.Id];

            var decalPos = wo.Offset();
            var pos = new Vector3((float)decalPos.X, (float)decalPos.Y, (float)decalPos.Z);

            // Try to get heading
            Quaternion rot = Quaternion.Identity;
            try
            {
                // Heading is usually 0-360 degrees, 0=N, 90=E
                double heading = wo.Values(DoubleValueKey.Heading);
                // AC heading: 0 is North (Y+), 90 is East (X+).
                // Rotation around Z axis.
                // Convert to radians.
                float rad = (float)(heading * Math.PI / 180.0);
                // Create Quaternion around Z.
                // Note: AC might use different sign convention.
                // FreeCamera calculates:
                // _yaw = Atan2(fwd.X, fwd.Y)
                // q = CreateFromAxisAngle(Z, -_yaw)
                // If heading is clockwise from North:
                // Heading 90 (East) -> Rot -90?
                // Let's assume standard positive rotation around Z (CCW).
                // If 90 is East (X+), and 0 is North (Y+), then 0 -> (0,1), 90 -> (1,0).
                // This is Clockwise (-Z).
                // So rot = -rad?
                rot = Quaternion.CreateFromAxisAngle(Vector3.UnitZ, -rad); // Guessing sign
            }
            catch { }

            var state = new ActorState
            {
                Guid = wo.Id,
                CellId = wo.Values(LongValueKey.Landblock),
                Position = pos,
                Rotation = rot,
                Timestamp = timestamp
            };

            list.AddLast(state);

            // Prune old history
            while (list.First.Value.Timestamp < timestamp - _maxHistorySeconds)
            {
                list.RemoveFirst();
            }
        }

        public void StartReplay(int victimId, int killerId)
        {
            if (IsReplaying) return;

            _replayVictimId = victimId;
            _replayKillerId = killerId;

            double now = DateTime.UtcNow.TimeOfDay.TotalSeconds;
            _replayDuration = ReplayDuration;
            _replayTargetTime = now;
            _replayCurrentTime = now - _replayDuration;
            _lastFrameTime = DateTime.UtcNow;

            // Save state
            _wasFreeCameraEnabled = FreeCamera.Instance.Enabled;
            _wasFreeCameraInputEnabled = FreeCamera.Instance.IsInputEnabled;

            IsReplaying = true;

            // Force enable FreeCamera
            if (!_wasFreeCameraEnabled)
            {
                unsafe
                {
                    if (ACBindingsTest.Internal.SmartBox.smartbox != null)
                    {
                        FreeCamera.Instance.Enable(&((ACBindingsTest.Internal.SmartBox*)*ACBindingsTest.Internal.SmartBox.smartbox)->viewer);
                    }
                }
            }

            // Disable manual input on FreeCamera
            FreeCamera.Instance.IsInputEnabled = false;
        }

        public void StopReplay()
        {
            if (!IsReplaying) return;

            IsReplaying = false;

            // Restore FreeCamera state
            FreeCamera.Instance.IsInputEnabled = _wasFreeCameraInputEnabled;
            if (!_wasFreeCameraEnabled)
            {
                FreeCamera.Instance.Disable();
            }
        }

        private void UpdatePlayback()
        {
            var now = DateTime.UtcNow;
            double dt = (now - _lastFrameTime).TotalSeconds;
            _lastFrameTime = now;

            _replayCurrentTime += dt;

            if (_replayCurrentTime >= _replayTargetTime)
            {
                StopReplay();
                return;
            }

            // Find Killer State
            if (_historyBuffer.TryGetValue(_replayKillerId, out var history))
            {
                var state = GetStateAtTime(history, _replayCurrentTime);
                if (state.HasValue)
                {
                    UpdateCamera(state.Value);
                }
            }
            else if (_historyBuffer.TryGetValue(_replayVictimId, out var victimHistory))
            {
                 // Fallback to victim if killer not found
                 var state = GetStateAtTime(victimHistory, _replayCurrentTime);
                 if (state.HasValue) UpdateCamera(state.Value);
            }
        }

        private ActorState? GetStateAtTime(LinkedList<ActorState> history, double time)
        {
            if (history.Count == 0) return null;

            // Simple search (can be optimized)
            var node = history.First;
            while (node != null && node.Next != null)
            {
                if (node.Value.Timestamp <= time && node.Next.Value.Timestamp >= time)
                {
                    var s1 = node.Value;
                    var s2 = node.Next.Value;
                    double total = s2.Timestamp - s1.Timestamp;
                    if (total <= 0.0001) return s1;

                    double t = (time - s1.Timestamp) / total;

                    var pos = Vector3.Lerp(s1.Position, s2.Position, (float)t);
                    var rot = Quaternion.Slerp(s1.Rotation, s2.Rotation, (float)t);

                    return new ActorState
                    {
                        CellId = s1.CellId,
                        Position = pos,
                        Rotation = rot,
                        Timestamp = time
                    };
                }
                node = node.Next;
            }

            // Clamp to ends
            if (time < history.First.Value.Timestamp) return history.First.Value;
            if (time > history.Last.Value.Timestamp) return history.Last.Value;

            return null;
        }

        private unsafe void UpdateCamera(ActorState state)
        {
             if (FreeCamera.Instance.Enabled && FreeCamera.Instance.CurrentPos != null)
             {
                 // Apply state to FreeCamera
                 FreeCamera.Instance.CurrentPos->objcell_id = (uint)state.CellId;

                 // Apply eye height offset for POV
                 float eyeHeight = 1.7f;
                 FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.x = state.Position.X;
                 FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.y = state.Position.Y;
                 FreeCamera.Instance.CurrentPos->frame.m_fOrigin.BaseClass_Vector3.z = state.Position.Z + eyeHeight;

                 FreeCamera.Instance.CurrentPos->frame.qx = state.Rotation.X;
                 FreeCamera.Instance.CurrentPos->frame.qy = state.Rotation.Y;
                 FreeCamera.Instance.CurrentPos->frame.qz = state.Rotation.Z;
                 FreeCamera.Instance.CurrentPos->frame.qw = state.Rotation.W;

                 FreeCamera.Instance.CurrentPos->frame.cache();
             }
        }

        public void Dispose()
        {
            try
            {
                CoreManager.Current.CharacterFilter.Death -= CharacterFilter_Death;
            }
            catch { }
            CoreManager.Current.RenderFrame -= Current_RenderFrame;
            CoreManager.Current.WindowMessage -= Current_WindowMessage;
            _instance = null;
        }
    }
}
