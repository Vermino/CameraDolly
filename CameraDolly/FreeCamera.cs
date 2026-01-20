using System;
using System.Runtime.InteropServices;
using ImGuiNET;
using ACVector3 = ACBindingsTest.Internal.AC1Legacy.Vector3;
using NumVector3 = System.Numerics.Vector3;
using System.Collections.Generic;
using System.Drawing;
using ACBindingsTest;
using Decal.Adapter;

namespace CameraDolly
{
    public unsafe class FreeCamera : IDisposable
    {
        private bool _enabled;
        public bool Enabled => _enabled;

        // If false, disables manual WASD/Mouse control, but keeps camera override active.
        public bool IsInputEnabled { get; set; } = true;

        private ACBindingsTest.Internal.Position* _currentPos;
        public ACBindingsTest.Internal.Position* CurrentPos => _currentPos;
        public bool IsSmartBoxPtrValid { get; private set; } = true;
        public IntPtr CapturedSmartBoxPtr { get; private set; }
        public IntPtr GlobalSmartBoxPtr { get; private set; }

        // Native Hooking
        private static NativeHook _hook;
        private static NativeHook _hookUpdateViewer;

        // Delegate for CameraManager.UpdateCamera
        // Position* __thiscall CameraManager::UpdateCamera(CameraManager*, Position*, const Position*)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate ACBindingsTest.Internal.Position* UpdateCameraDelegate(IntPtr thisPtr,
            ACBindingsTest.Internal.Position* result, ACBindingsTest.Internal.Position* viewer_pos);

        private static UpdateCameraDelegate _originalUpdateCamera;
        private static UpdateCameraDelegate _detourDelegate;

        // Delegate for SmartBox::update_viewer
        // void __thiscall SmartBox::update_viewer(SmartBox*)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void UpdateViewerDelegate(IntPtr thisPtr);


        private static UpdateViewerDelegate _originalUpdateViewer;
        private static UpdateViewerDelegate _detourUpdateViewer;

        private static NativeHook _hookFindValidPosition;

        // Offsets


        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect,
            out uint lpflOldProtect);

        private const uint PAGE_EXECUTE_READWRITE = 0x40;


        // Delegate for CameraSet::MouseLookHandler
        // void __thiscall CameraSet::MouseLookHandler(CameraSet*, int i_nXMove, int i_nYMove)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate void MouseLookHandlerDelegate(IntPtr thisPtr, int xMove, int yMove);

        private static NativeHook _hookMouseLook;
        private static MouseLookHandlerDelegate _originalMouseLook;
        private static MouseLookHandlerDelegate _detourMouseLook;

        private float _yaw;
        private float _pitch;

        // UI Controls
        // UI Controls
        private float _speed = 0.005f;

        public float Speed
        {
            get => _speed;
            set => _speed = value;
        }


        public static FreeCamera Instance { get; private set; }

        public FreeCamera()
        {
            Instance = this;
            _currentPos =
                (ACBindingsTest.Internal.Position*)Marshal.AllocHGlobal(sizeof(ACBindingsTest.Internal.Position));
            *_currentPos = new ACBindingsTest.Internal.Position();

            // Initialize CameraManager Hook
            try
            {
                // Only install hook once
                if (_hook == null)
                {
                    // Target CameraManager.UpdateCamera
                    IntPtr targetAddr = (IntPtr)NativeAddresses.CameraUpdate;


                    // Use a safe 7-byte hook size
                    _hook = new NativeHook(targetAddr, 7);
                    _hook.Install();

                    _originalUpdateCamera =
                        Marshal.GetDelegateForFunctionPointer<UpdateCameraDelegate>(_hook.Trampoline);
                    _detourDelegate = new UpdateCameraDelegate(Detour);

                    // Activate the hook logic
                    _hook.Apply(Marshal.GetFunctionPointerForDelegate(_detourDelegate));
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                PluginCore.Log($"FreeCamera: CameraManager hook error: {ex.Message}");
            }

            // Initialize SmartBox::update_viewer Hook
            try
            {
                if (_hookUpdateViewer == null)
                {
                    // Target SmartBox::update_viewer
                    IntPtr targetAddr = (IntPtr)NativeAddresses.SmartBoxUpdateViewer;


                    _hookUpdateViewer = new NativeHook(targetAddr, 9); // Explicit size for 0x174 stack frame
                    _hookUpdateViewer.Install();

                    _originalUpdateViewer =
                        Marshal.GetDelegateForFunctionPointer<UpdateViewerDelegate>(_hookUpdateViewer.Trampoline);
                    _detourUpdateViewer = new UpdateViewerDelegate(DetourUpdateViewer);

                    _hookUpdateViewer.Apply(Marshal.GetFunctionPointerForDelegate(_detourUpdateViewer));
                }

                if (_hookFindValidPosition == null)
                {
                    // Target CTransition::find_valid_position
                    IntPtr targetAddr = (IntPtr)NativeAddresses.FindValidPosition;

                    // Create and install ASM Shellcode Bypass (No managed detour!)
                    _shellcodePtr = AssembleCollisionBypass();

                    if (_shellcodePtr != IntPtr.Zero)
                    {
                        // Use NativeHook to patch the JMP to our shellcode.
                        // We install it with size 6 (to handle NOPs correctly), but we Apply() our custom shellcode address.
                        _hookFindValidPosition = new NativeHook(targetAddr, 6);
                        _hookFindValidPosition.Install(); // prepares trampoline (unused) and validation

                        _hookFindValidPosition.Apply(_shellcodePtr); // Jumps to shellcode
                    }
                }
            }
            catch (Exception ex)
            {
                PluginCore.Log($"FreeCamera: SmartBox/Collision hook error: {ex.Message}");
            }

            // Initialize CameraSet::MouseLookHandler Hook - blocks native mouse look when FreeCamera is enabled
            try
            {
                if (_hookMouseLook == null)
                {
                    // Target CameraSet::MouseLookHandler
                    IntPtr targetAddr = (IntPtr)NativeAddresses.MouseLookHandler;


                    _hookMouseLook = new NativeHook(targetAddr, 6);
                    _hookMouseLook.Install();

                    _originalMouseLook =
                        Marshal.GetDelegateForFunctionPointer<MouseLookHandlerDelegate>(_hookMouseLook.Trampoline);
                    _detourMouseLook = DetourMouseLook;

                    _hookMouseLook.Apply(Marshal.GetFunctionPointerForDelegate(_detourMouseLook));
                }
            }
            catch (Exception ex)
            {
                PluginCore.Log($"FreeCamera: MouseLook hook error: {ex.Message}");
            }
        }
        // Static Detour Method
        // private static int _detourCounter = 0; // Removed debug counter

        private static ACBindingsTest.Internal.Position* Detour(IntPtr thisPtr,
            ACBindingsTest.Internal.Position* result,
            ACBindingsTest.Internal.Position* viewer_pos)
        {
            try
            {
                // Call original first to let the game do its calculations (and handle side effects)
                ACBindingsTest.Internal.Position* ret = _originalUpdateCamera(thisPtr, result, viewer_pos);

                // If enabled and position is valid, force our position into the result
                if (Instance != null && Instance._enabled && Instance._currentPos != null)
                {
                    // Overwrite the calculated result with our free camera position
                    *result = *Instance._currentPos;
                }

                return ret; // Usually ret == result
            }
            catch (Exception)
            {
                // If something goes wrong, try to return something sane (the arg)
                return result;
            }
        }

        private static void DetourUpdateViewer(IntPtr thisPtr)
        {
            try
            {
                if (Instance != null && Instance._enabled)
                {
                    Instance.CapturedSmartBoxPtr = thisPtr;
                    if (ACBindingsTest.Internal.SmartBox.smartbox != null)
                    {
                        Instance.GlobalSmartBoxPtr = (IntPtr)(*ACBindingsTest.Internal.SmartBox.smartbox);
                        Instance.IsSmartBoxPtrValid = Instance.CapturedSmartBoxPtr == Instance.GlobalSmartBoxPtr;
                    }
                }
            }
            catch (Exception)
            {
            }

            // Fix for Culling/Streaming: Override position BEFORE calling original
            // This tricks the game into culling based on the camera position instead of the player
            try
            {
                if (Instance != null && Instance._enabled && Instance._currentPos != null && thisPtr != IntPtr.Zero)
                {
                    var smartBox = (ACBindingsTest.Internal.SmartBox*)thisPtr;

                    // Override both the cell ID and position
                    smartBox->viewer.objcell_id = Instance._currentPos->objcell_id;
                    smartBox->viewer.frame.m_fOrigin = Instance._currentPos->frame.m_fOrigin;
                }
            }
            catch (Exception)
            {
            }

            // Always call original update_viewer - handles cells, lights, rendering setup
            _originalUpdateViewer(thisPtr);

            // AFTER original runs, override the position AND cell with our normalized free camera position
            // We do this again to ensure the rendering camera is correct, in case the function reset it or we want to be sure.
            try
            {
                if (Instance != null && Instance._enabled && Instance._currentPos != null && thisPtr != IntPtr.Zero)
                {
                    var smartBox = (ACBindingsTest.Internal.SmartBox*)thisPtr;

                    // Override both the cell ID and position from our normalized free camera position
                    smartBox->viewer.objcell_id = Instance._currentPos->objcell_id;
                    smartBox->viewer.frame.m_fOrigin = Instance._currentPos->frame.m_fOrigin;

                    // Also update the frame rotation to match our free camera
                    smartBox->viewer.frame.qw = Instance._currentPos->frame.qw;
                    smartBox->viewer.frame.qx = Instance._currentPos->frame.qx;
                    smartBox->viewer.frame.qy = Instance._currentPos->frame.qy;
                    smartBox->viewer.frame.qz = Instance._currentPos->frame.qz;
                }
            }
            catch (Exception)
            {
            }
        }


        private static void DetourMouseLook(IntPtr thisPtr, int xMove, int yMove)
        {
            try
            {
                if (Instance != null && Instance._enabled)
                {
                    return;
                }
            }
            catch
            {
            }

            _originalMouseLook(thisPtr, xMove, yMove);
        }

        public void Enable(ACBindingsTest.Internal.Position* startPos)
        {
            if (_enabled) return;

            // Copy startup position
            *_currentPos = *startPos;
            _currentPos->frame.m_fOrigin.BaseClass_Vector3.z += 0.0f;

            // Extract Yaw/Pitch from properties for smooth start
            var q = new System.Numerics.Quaternion(
                _currentPos->frame.qx,
                _currentPos->frame.qy,
                _currentPos->frame.qz,
                _currentPos->frame.qw);

            // Forward vector (AC uses Y as Forward)
            var fwd = System.Numerics.Vector3.Transform(System.Numerics.Vector3.UnitY, q);

            // Atan2(y, x) gives angle from X axis.
            // We want angle from Y axis (North/Forward).
            // -X = East? AC coords: N=Y+, E=X+ usually?
            // Let's assume standard atan2(x, y) = angle from Y axis CCW? No.
            // atan2(x, y) gives angle relative to Y+ in many systems (like compass).
            _yaw = (float)Math.Atan2(fwd.X, fwd.Y);
            _pitch = (float)Math.Asin(Clamp(fwd.Z, -0.99f, 0.99f));

            // Negate pitch to match mouse delta direction? We'll see.
            // Mouse up (Delta Y < 0) -> Look up (Pitch increases).

            _enabled = true;
        }

        public void Disable()
        {
            _enabled = false;
        }

        private IntPtr _shellcodePtr = IntPtr.Zero;

        private IntPtr AssembleCollisionBypass()
        {
            try
            {
                List<byte> code = new List<byte>();

                // --- ASM Shellcode Logic ---
                // 1. Check if we should bypass ([ECX+4] == 92)
                // 2. If NO (!= 92), Jump to Original
                // 3. If YES:
                //    Check if end_pos pointer ([ECX+0xB8]) is valid
                //    If INVALID (== 0), Jump to Original
                //    Else, Copy begin_cell to curr_cell, Copy end_pos to curr_pos, Return 1

                // 0: CMP DWORD PTR [ECX+4], 0x5C (92)
                code.AddRange(new byte[] { 0x83, 0x79, 0x04, 0x5C });

                // 4: JNE +45 (0x2D) -> Jump to Original Code Block (offset will be recalculated)
                code.AddRange(new byte[] { 0x75, 0x2D });

                // 6: MOV EAX, [ECX+0xB8] (Load end_pos pointer)
                code.AddRange(new byte[] { 0x8B, 0x81, 0xB8, 0x00, 0x00, 0x00 });

                // 12: TEST EAX, EAX (Check for NULL)
                code.AddRange(new byte[] { 0x85, 0xC0 });

                // 14: JZ +35 (0x23) -> Jump to Original Code Block (offset will be recalculated)
                code.AddRange(new byte[] { 0x74, 0x23 });

                // --- Copy begin_cell to curr_cell ---
                // 16: MOV EDX, [ECX+0xB0] (Load begin_cell pointer)
                code.AddRange(new byte[] { 0x8B, 0x91, 0xB0, 0x00, 0x00, 0x00 });
                // 22: MOV [ECX+0xBC], EDX (Store to curr_cell)
                code.AddRange(new byte[] { 0x89, 0x91, 0xBC, 0x00, 0x00, 0x00 });

                // --- Copy end_pos data to curr_pos ---
                // 28: PUSH ESI
                code.Add(0x56);
                // 29: PUSH EDI
                code.Add(0x57);
                // 30: LEA EDI, [ECX+0xC0] (Destination: curr_pos)
                code.AddRange(new byte[] { 0x8D, 0xB9, 0xC0, 0x00, 0x00, 0x00 });
                // 36: MOV ESI, EAX (Source: end_pos pointer)
                code.AddRange(new byte[] { 0x8B, 0xF0 });
                // 38: MOV ECX, 18 (Count: 18 DWORDs = 72 Bytes)
                code.AddRange(new byte[] { 0xB9, 0x12, 0x00, 0x00, 0x00 });
                // 43: REP MOVSD
                code.AddRange(new byte[] { 0xF3, 0xA5 });
                // 45: POP EDI
                code.Add(0x5F);
                // 46: POP ESI
                code.Add(0x5E);

                // 47: MOV EAX, 1 (Return Success)
                code.AddRange(new byte[] { 0xB8, 0x01, 0x00, 0x00, 0x00 });
                // 52: RET
                code.Add(0xC3);

                // --- Original Code Block (Offset 53) ---
                // 53: MOV EAX, [ECX+0x174] (Original Instruction)
                code.AddRange(new byte[] { 0x8B, 0x81, 0x74, 0x01, 0x00, 0x00 });

                // 59: JMP Back to Target+6
                code.Add(0xE9);
                // Placeholder for Delta
                code.AddRange(new byte[] { 0x00, 0x00, 0x00, 0x00 });

                // Fix up jump offsets now that we know code size
                // JNE at offset 5 -> Original Code Block at offset 53
                code[5] = (byte)(53 - 6); // 53 - (4 + 2) = 47 = 0x2F
                // JZ at offset 15 -> Original Code Block at offset 53
                code[15] = (byte)(53 - 16); // 53 - (14 + 2) = 37 = 0x25

                // Allocate Memory
                IntPtr mem = Marshal.AllocHGlobal((int)code.Count);
                if (mem == IntPtr.Zero) return IntPtr.Zero;

                // Calculate Jump Delta
                // Delta = Dest - (Src + 5)
                // Dest = Target + 6 = 0x0050CDE0 + 6
                // Src = mem + 59
                int targetAddr = 0x0050CDE0;
                int jmpOffset = 59;
                int delta = (targetAddr + 6) - (mem.ToInt32() + jmpOffset + 5);

                // Write Delta
                byte[] deltaBytes = BitConverter.GetBytes(delta);
                code[60] = deltaBytes[0];
                code[61] = deltaBytes[1];
                code[62] = deltaBytes[2];
                code[63] = deltaBytes[3];

                // Copy to Allocated Memory
                Marshal.Copy(code.ToArray(), 0, mem, code.Count);

                // Make Executable
                uint oldProtect;
                VirtualProtect(mem, (uint)code.Count, PAGE_EXECUTE_READWRITE, out oldProtect);


                return mem;
            }
            catch (Exception ex)
            {
                return IntPtr.Zero;
            }
        }


        public void Update()
        {
            if (!_enabled) return;
            if (!IsInputEnabled) return;

            var io = ImGui.GetIO();

            // Get mouse state directly from IO
            bool rightMouseDown = io.MouseDown[1]; // Index 1 = Right mouse button
            var mouseDelta = io.MouseDelta;

            // Mouse Look - use IO directly for reliable input detection
            if (rightMouseDown)
            {
                if (mouseDelta.X != 0 || mouseDelta.Y != 0)
                {
                    float sensitivity = 0.005f;

                    // Mouse X -> Yaw (Left/Right)
                    // Moving mouse Right (Delta X > 0) -> Turn Right -> Decrease Yaw? (Depends on Coord system)
                    // AC: Y+ Forward, X+ East. 
                    // Yaw 0 = North. Yaw -90 = East?
                    // Let's try: Right (-DeltaX) converts to turning frame CW.
                    _yaw += mouseDelta.X * sensitivity;

                    // Mouse Y -> Pitch (Up/Down)
                    // Moving mouse Up (Delta Y < 0) -> Look Up -> Increase Pitch
                    // Moving mouse Down (Delta Y > 0) -> Look Down -> Decrease Pitch
                    _pitch -= mouseDelta.Y * sensitivity;

                    // Clamp pitch to avoid flipping
                    float pitchLimit = (float)(Math.PI / 2.0f) - 0.1f;
                    _pitch = Clamp(_pitch, -pitchLimit, pitchLimit);

                    // Reconstruct Quaternion
                    // 1. Pitch around Local X (Right) -> Result points Up/Down
                    // 2. Yaw around Global Z (Up) -> Result points Compass Dir
                    // Order: Pitch then Yaw? No, usually Body then World.
                    // If we pitch around X, we get a pitched vector. Then we rotate that around Z.

                    var qPitch =
                        System.Numerics.Quaternion.CreateFromAxisAngle(NumVector3.UnitX, _pitch);
                    var qYaw = System.Numerics.Quaternion.CreateFromAxisAngle(NumVector3.UnitZ,
                        -_yaw); // -Yaw to match standard angle direction?

                    // Combine: Yaw * Pitch (Rotation order: Pitch first applied to object, then Yaw applied to result)
                    // Note: qYaw * qPitch means "Apply Pitch then Yaw" in many systems (v * pitch * yaw).
                    // Or "Yaw applied 'after' Pitch" in composition.
                    var newQ = qYaw * qPitch;
                    newQ = System.Numerics.Quaternion.Normalize(newQ);

                    _currentPos->frame.qx = newQ.X;
                    _currentPos->frame.qy = newQ.Y;
                    _currentPos->frame.qz = newQ.Z;
                    _currentPos->frame.qw = newQ.W;

                    // CRITICAL: Rebuild the rotation matrix (m_fl2gv) from the quaternion
                    // The renderer uses m_fl2gv, not the quaternion directly
                    _currentPos->frame.cache();
                }
            }

            // Only process movement keys if ImGui doesn't want keyboard input (not typing in a text field)
            if (!io.WantCaptureKeyboard)
            {
                NumVector3 inputMove = NumVector3.Zero;
                float speed = _speed;

                if (ImGui.IsKeyDown(ImGuiKey.LeftShift)) speed *= 4.0f; // Shift multiplier

                if (ImGui.IsKeyDown(ImGuiKey.Y)) inputMove.Y += 1; // Forward
                if (ImGui.IsKeyDown(ImGuiKey.H)) inputMove.Y -= 1; // Backward
                if (ImGui.IsKeyDown(ImGuiKey.G)) inputMove.X -= 1; // Left
                if (ImGui.IsKeyDown(ImGuiKey.J)) inputMove.X += 1; // Right

                // World Z Movement (Independent of Rotation)
                float zMove = 0;
                if (ImGui.IsKeyDown(ImGuiKey.U)) zMove += 1; // Up (World Z)
                if (ImGui.IsKeyDown(ImGuiKey.I)) zMove -= 1; // Down (World Z)

                if (inputMove != NumVector3.Zero || zMove != 0)
                {
                    // Movement relative to camera direction
                    if (inputMove != NumVector3.Zero)
                    {
                        // Use full quaternion (yaw + pitch) for forward/backward movement
                        // This makes the camera fly in the direction it's looking
                        var qFull = System.Numerics.Quaternion.CreateFromAxisAngle(NumVector3.UnitZ,
                                        -_yaw) *
                                    System.Numerics.Quaternion.CreateFromAxisAngle(NumVector3.UnitX,
                                        _pitch);

                        // Forward direction uses full rotation (including pitch)
                        NumVector3 forward = NumVector3.Transform(NumVector3.UnitY, qFull);

                        // Right vector uses only yaw (strafe stays planar)
                        var qYawOnly =
                            System.Numerics.Quaternion.CreateFromAxisAngle(NumVector3.UnitZ, -_yaw);
                        NumVector3 right = NumVector3.Transform(NumVector3.UnitX, qYawOnly);

                        // Normalize to be safe
                        if (forward.LengthSquared() > 0) forward = NumVector3.Normalize(forward);
                        if (right.LengthSquared() > 0) right = NumVector3.Normalize(right);

                        NumVector3 moveDir = (forward * inputMove.Y) + (right * inputMove.X);
                        if (moveDir.LengthSquared() > 0)
                            moveDir = NumVector3.Normalize(moveDir) * speed;

                        _currentPos->frame.m_fOrigin.BaseClass_Vector3.x += moveDir.X;
                        _currentPos->frame.m_fOrigin.BaseClass_Vector3.y += moveDir.Y;
                        _currentPos->frame.m_fOrigin.BaseClass_Vector3.z += moveDir.Z;
                    }

                    // Apply Vertical World Movement (U/I keys for absolute up/down)
                    if (zMove != 0)
                    {
                        _currentPos->frame.m_fOrigin.BaseClass_Vector3.z += zMove * speed;
                    }

                    // Normalize position to handle landblock boundary crossing
                    LandblockCoordinates.NormalizePosition(ref *_currentPos);
                }
            }
        }

        private float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public void Dispose()
        {
            try
            {
                _hookMouseLook?.Dispose();
                _hookMouseLook = null;
            }
            catch
            {
            }

            try
            {
                _hookUpdateViewer?.Dispose();
                _hookUpdateViewer = null;

                _hookFindValidPosition?.Dispose();
                _hookFindValidPosition = null;
            }
            catch
            {
            }

            try
            {
                _hook?.Dispose();
                _hook = null;
            }
            catch
            {
            }

            if (Instance == this) Instance = null;

            if (_currentPos != null)
            {
                Marshal.FreeHGlobal((IntPtr)_currentPos);
                _currentPos = null;
            }
        }
    }
}
