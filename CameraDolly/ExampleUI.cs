using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using ACBindingsTest.Internal;
using Decal.Adapter;
using Decal.Adapter.Wrappers;
using ImGuiNET;
using ImGuizmoNET;
using UtilityBelt.Service;
using Hud = UtilityBelt.Service.Views.Hud;
using Quaternion = System.Numerics.Quaternion;
using Vector2 = System.Numerics.Vector2;
using Vector3 = System.Numerics.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace CameraDolly
{
    internal unsafe class ExampleUI : IDisposable
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        /// <summary>
        /// The UBService Hud
        /// </summary>
        private readonly Hud hud;

        /// <summary>
        /// The default value for TestText.
        /// </summary>
        public const string DefaultTestText = "Some Test Text";

        /// <summary>
        /// Some test text. This value is used to the text input in our UI.
        /// </summary>
        public string TestText = DefaultTestText.ToString();

        private FreeCamera _freeCamera = new FreeCamera();
        private bool _fogDisabled = false;

        // Timeline state - _selectedKeyframe syncs with GizmoController after timeline draw
        private int _selectedKeyframe = -1;
        private int _selectedCommandFrame = -1;
        private float _scrubTime = 0f;
        private readonly CameraH _cameraH;
        private readonly GizmoController _gizmoController;

        public ExampleUI()
        {
            // Create a new UBService Hud
            hud = UBService.Huds.CreateHud("Camera Dolly");
            _cameraH = new CameraH();
            _gizmoController = new GizmoController(_cameraH);

            // set to show our icon in the UBService HudBar
            hud.ShowInBar = true;
            //hud.Visible = true;
            hud.WindowSettings |= ImGuiWindowFlags.AlwaysAutoResize;

            // subscribe to the hud render event so we can draw some controls
            hud.OnRender += Hud_OnRender;

            SmartBox.DisableFogging(_fogDisabled ? 1 : 0);
            CoreManager.Current.RenderFrame += Current_RenderFrame;
        }

        private void Current_RenderFrame(object sender, EventArgs e)
        {
            try
            {
                // Check for Escape key async (works even if UI is hidden/not rendering)
                // 0x1B is VK_ESCAPE
                if ((GetAsyncKeyState(0x1B) & 0x8000) != 0)
                {
                    if (CameraPathManager.Instance.IsPlaying)
                    {
                        CameraPathManager.Instance.Stop();
                    }
                }

                CameraPathManager.Instance.Update();
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        /// <summary>
        /// Called every time the ui is redrawing.
        /// </summary>
        private void Hud_OnRender(object sender, EventArgs e)
        {
            try
            {
                var io = ImGui.GetIO();

                if (ImGui.IsKeyDown(ImGuiKey.Escape) && CameraPathManager.Instance.IsPlaying)
                {
                    CameraPathManager.Instance?.Stop();
                }

                if (ImGui.BeginTabBar("Tabs"))
                {
                    // Free Camera tab removed, consolidated into Camera Paths

                    if (ImGui.BeginTabItem("Camera Paths"))
                    {
                        DrawCameraPathsTab();
                        ImGui.EndTabItem();
                    }

                    ImGui.EndTabBar();
                }

                if (_freeCamera.Enabled)
                {
                    _freeCamera.Update();
                }

                // CameraPathManager.Update() is now called in Current_RenderFrame


                // Sync gizmo selection FROM local field (timeline might have changed it)
                _gizmoController.SelectedKeyframe = _selectedKeyframe;

                ImGuizmo.Enable(true);
                ImGuizmo.AllowAxisFlip(false);
                ImGuizmo.SetOrthographic(false);
                ImGuizmoNET.ImGuizmo.SetDrawlist(ImGui.GetForegroundDrawList());
                ImGuizmoNET.ImGuizmo.SetRect(0, 0, io.DisplaySize.X, io.DisplaySize.Y);
                _gizmoController.DrawGizmo();

                // After gizmo draw, sync back (gizmo picking might have changed it)
                _selectedKeyframe = _gizmoController.SelectedKeyframe;
            }
            catch (Exception ex)
            {
                PluginCore.Log(ex);
            }
        }

        private void DrawCameraPathsTab()
        {
            var mgr = CameraPathManager.Instance;
            _cameraH.Update();

            // --- Free Camera Controls (Moved here) ---
            ImGui.Text("Free Camera Options");

            bool freeCamCallback = _freeCamera.Enabled;
            if (ImGui.Checkbox("Enable Free Camera", ref freeCamCallback))
            {
                if (freeCamCallback)
                    _freeCamera.Enable(&((SmartBox*)*SmartBox.smartbox)->viewer);
                else
                    _freeCamera.Disable();
            }

            ImGui.SameLine();
            if (ImGui.Checkbox("Disable Fog", ref _fogDisabled))
            {
                SmartBox.DisableFogging(_fogDisabled ? 1 : 0);
            }

            if (_freeCamera.Enabled)
            {
                ImGui.SameLine();
                ImGui.TextColored(new Vector4(0, 1, 0, 1), "Active");

                ImGui.SameLine();
                float speed = _freeCamera.Speed;
                ImGui.SetNextItemWidth(100);
                if (ImGui.SliderFloat("Speed", ref speed, 0.001f, 0.5f, "%.3f"))
                {
                    _freeCamera.Speed = speed;
                }

                ImGui.Text("Controls: YGHJ (Move), U/I (Up/Down), Shift (Speed)"); // Simple instruction line
            }
            else
            {
                ImGui.SameLine();
                ImGui.TextColored(new Vector4(1, 0, 0, 1), "Inactive");
            }

            ImGui.Separator();
            // -----------------------------------------

            // Make the Camera Paths content resizable
            if (ImGui.BeginChild("CameraPathsContent", new Vector2(600, 400), true, ImGuiWindowFlags.None))
            {
                // Row 1: Path name and Save/Load
                ImGui.SetNextItemWidth(200);
                string currentName = mgr.CurrentPath.Name ?? "New Path";
                if (ImGui.InputText("##PathName", ref currentName, 64)) mgr.CurrentPath.Name = currentName;

                ImGui.SameLine();
                if (ImGui.Button("Save")) mgr.Save(currentName);

                ImGui.SameLine();
                ImGui.SetNextItemWidth(150);
                string preview = "Load...";
                if (ImGui.BeginCombo("##LoadCombo", preview))
                {
                    foreach (var pathName in mgr.GetAvailablePaths())
                    {
                        if (ImGui.Selectable(pathName))
                        {
                            mgr.Load(pathName);
                        }
                    }

                    ImGui.EndCombo();
                }

                // Row 2: Add Keyframe and Command Frame
                if (ImGui.Button("Add Keyframe"))
                {
                    mgr.AddKeyframe();
                }

                ImGui.SameLine();
                if (ImGui.Button("Add Command Frame"))
                {
                    mgr.CurrentPath.CommandFrames.Add(new CommandFrame { Time = _scrubTime });
                }


                // Row 3: Playback controls
                if (mgr.IsPlaying)
                {
                    if (ImGui.Button("Stop")) mgr.Stop();
                }
                else
                {
                    if (ImGui.Button("Play")) mgr.Play();
                }

                ImGui.SameLine();
                bool showPath = mgr.ShowPath;
                if (ImGui.Checkbox("ShowPaths", ref showPath)) mgr.ShowPath = showPath;

                ImGui.SameLine();
                bool disableUi = mgr.DisableUiDuringPlayback;
                if (ImGui.Checkbox("Hide UI", ref disableUi)) mgr.DisableUiDuringPlayback = disableUi;

                ImGui.SameLine();
                bool looping = mgr.CurrentPath.IsLooping;
                if (ImGui.Checkbox("Loop", ref looping)) mgr.CurrentPath.IsLooping = looping;

                ImGui.SameLine();
                bool reverse = mgr.CurrentPath.IsReverse;
                if (ImGui.Checkbox("Reverse", ref reverse)) mgr.CurrentPath.IsReverse = reverse;

                if (mgr.IsPlaying)
                {
                    ImGui.SameLine();
                    ImGui.TextColored(new Vector4(0, 1, 0, 1), "Playing...");
                }

                ImGui.Separator();

                // Item count
                ImGui.Text($"Items: {mgr.CurrentPath.Items.Count} | Commands: {mgr.CurrentPath.CommandFrames.Count}");

                if (mgr.IsPlaying)
                {
                    _scrubTime = mgr.PlaybackTime;
                }

                // Render the timeline with scrubbing
                float childWidth = ImGui.GetContentRegionAvail().X - 20;
                if (KeyframeTimeline.Draw(mgr.CurrentPath.Items, mgr.CurrentPath.CommandFrames,
                        ref _selectedKeyframe, ref _selectedCommandFrame, ref _scrubTime, childWidth))
                {
                    mgr.ScrubToTime(_scrubTime);
                }

                // Show selected item details
                if (_selectedKeyframe >= 0 && _selectedKeyframe < mgr.CurrentPath.Items.Count)
                {
                    var item = mgr.CurrentPath.Items[_selectedKeyframe];

                    if (item is PathKeyframe kf)
                    {
                        ImGui.Text($"Keyframe {_selectedKeyframe}:");
                        ImGui.SameLine();
                        ImGui.SetNextItemWidth(100);
                        float speed = kf.Speed;
                        if (ImGui.SliderFloat("Speed##sel", ref speed, 0.01f, 1.0f, "%.3f"))
                            kf.Speed = speed;

                        ImGui.SameLine();
                        ImGui.Text(
                            $"Pos: {kf.GetGlobalPosition().X:F0}, {kf.GetGlobalPosition().Y:F0}, {kf.GetGlobalPosition().Z:F0}");
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Del##sel"))
                    {
                        mgr.CurrentPath.Items.RemoveAt(_selectedKeyframe);
                        _selectedKeyframe = mgr.CurrentPath.Items.Count > 0
                            ? Math.Min(_selectedKeyframe, mgr.CurrentPath.Items.Count - 1)
                            : -1;
                    }
                }

                // Show selected command frame details
                if (_selectedCommandFrame >= 0 && _selectedCommandFrame < mgr.CurrentPath.CommandFrames.Count)
                {
                    var cmdFrame = mgr.CurrentPath.CommandFrames[_selectedCommandFrame];

                    ImGui.Separator();
                    ImGui.Text($"Command Frame {_selectedCommandFrame} @ {cmdFrame.Time:F2}s:");

                    ImGui.SameLine();
                    if (ImGui.Button("Del##cmdSel"))
                    {
                        mgr.CurrentPath.CommandFrames.RemoveAt(_selectedCommandFrame);
                        _selectedCommandFrame = mgr.CurrentPath.CommandFrames.Count > 0
                            ? Math.Min(_selectedCommandFrame, mgr.CurrentPath.CommandFrames.Count - 1)
                            : -1;
                    }
                    else
                    {
                        // List commands with ability to edit/remove
                        for (int i = 0; i < cmdFrame.Commands.Count; i++)
                        {
                            string cmd = cmdFrame.Commands[i];
                            ImGui.SetNextItemWidth(200);
                            if (ImGui.InputText($"##cmd{i}", ref cmd, 256))
                            {
                                cmdFrame.Commands[i] = cmd;
                            }

                            ImGui.SameLine();
                            if (ImGui.Button($"X##delCmd{i}"))
                            {
                                cmdFrame.Commands.RemoveAt(i);
                                break;
                            }
                        }

                        if (ImGui.Button("+ Add Command"))
                        {
                            cmdFrame.Commands.Add("/say Hello!");
                        }
                    }
                }

                ImGui.TextColored(new Vector4(0.6f, 0.6f, 0.6f, 1f),
                    "Drag items to adjust timing | Esc to stop playback");
            }

            ImGui.EndChild();
        }


        public void Dispose()
        {
            CoreManager.Current.RenderFrame -= Current_RenderFrame;
            // Removed debug ray cleanup
            hud.Dispose();
            _freeCamera.Dispose();
            CameraPathManager.Instance.ShowPath = false;
            CameraPathManager.Instance.Dispose();
        }
    }
}