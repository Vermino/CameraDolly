using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CameraDolly
{
    public unsafe class NativeHook : IDisposable
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

        private IntPtr _targetAddress;
        private byte[] _originalBytes;
        private IntPtr _trampoline;
        private bool _isInstalled;
        private int _hookSize;
        private const uint PAGE_EXECUTE_READWRITE = 0x40;

        public IntPtr Trampoline => _trampoline;

        public NativeHook(IntPtr targetAddress, int manualHookSize = 0)
        {
            _targetAddress = targetAddress;
            _hookSize = manualHookSize;
        }

        public void Install()
        {
            if (_isInstalled) return;

            // Analyze prologue to determine safe hook size (at least 5 bytes)
            byte* ptr = (byte*)_targetAddress;

            if (_hookSize == 0)
            {
                // Auto-detect logic
                // Common Prologue: PUSH EBP; MOV EBP, ESP (55 8B EC) - 3 bytes
                if (ptr[0] == 0x55 && ptr[1] == 0x8B && ptr[2] == 0xEC)
                {
                    // Check next instructions
                    // SUB ESP, <byte> (83 EC XX) - 3 bytes -> Total 6
                    if (ptr[3] == 0x83 && ptr[4] == 0xEC)
                    {
                        _hookSize = 6;
                    }
                    // SUB ESP, <imm32> (81 EC XX XX XX XX) - 6 bytes -> Total 3+6=9
                    else if (ptr[3] == 0x81 && ptr[4] == 0xEC)
                    {
                        _hookSize = 9;
                    }
                    // PUSH <reg> (50..57) - 1 byte
                    // If we have 2 pushes, 3+1+1 = 5.
                    else if (IsPush(ptr[3]) && IsPush(ptr[4]))
                    {
                        _hookSize = 5;
                    }
                    else
                    {
                        // Default to 5
                        _hookSize = 5;
                    }
                }
                else
                {
                    // Unknown prologue
                    _hookSize = 5;
                }
            }

            // Save original bytes
            _originalBytes = new byte[_hookSize];
            Marshal.Copy(_targetAddress, _originalBytes, 0, _hookSize);

            // Create Trampoline
            // Trampoline: [Original Bytes] [JMP Back to Target+Size]
            _trampoline = Marshal.AllocHGlobal(_hookSize + 5);

            // Allow Write Exec on Trampoline
            VirtualProtect(_trampoline, (uint)(_hookSize + 5), PAGE_EXECUTE_READWRITE, out _);

            // Write Original Bytes to Trampoline
            byte* tPtr = (byte*)_trampoline;
            for (int i = 0; i < _hookSize; i++)
            {
                tPtr[i] = _originalBytes[i];
            }

            // Write JMP Back to Target+_hookSize
            // JMP Rel32 = E9 <delta>
            // Delta = Dest - (Src + 5)
            // Dest = _targetAddress + _hookSize
            // Src = _trampoline + _hookSize
            tPtr[_hookSize] = 0xE9;
            int deltaBack = (int)((long)(_targetAddress + _hookSize) - (long)(_trampoline + _hookSize) - 5);
            *(int*)(tPtr + _hookSize + 1) = deltaBack;

            _isInstalled = true; // Mark as ready

            // Note: We do NOT apply the hook yet. Caller must call Apply().
        }

        public void Apply(IntPtr detourAddress)
        {
            if (!_isInstalled) Install(); // Ensure trampline is ready if not already

            uint oldProtect;
            VirtualProtect(_targetAddress, (uint)_hookSize, PAGE_EXECUTE_READWRITE, out oldProtect);

            byte* ptr = (byte*)_targetAddress;
            ptr[0] = 0xE9; // JMP
            int delta = (int)((long)detourAddress - (long)_targetAddress - 5);
            *(int*)(ptr + 1) = delta;

            // NOP remaining bytes
            for (int i = 5; i < _hookSize; i++)
            {
                ptr[i] = 0x90;
            }

            VirtualProtect(_targetAddress, (uint)_hookSize, oldProtect, out _);
        }

        public void Uninstall()
        {
            if (_originalBytes == null) return;

            uint oldProtect;
            VirtualProtect(_targetAddress, (uint)_hookSize, PAGE_EXECUTE_READWRITE, out oldProtect);

            Marshal.Copy(_originalBytes, 0, _targetAddress, _hookSize);

            VirtualProtect(_targetAddress, (uint)_hookSize, oldProtect, out _);

            if (_trampoline != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_trampoline);
                _trampoline = IntPtr.Zero;
            }
        }

        public void Dispose()
        {
            Uninstall();
        }

        private bool IsPush(byte b)
        {
            return b >= 0x50 && b <= 0x57;
        }
    }
}
