namespace CameraDolly
{
    /// <summary>
    /// Centralized native function addresses from PDB symbols.
    /// </summary>
    public static class NativeAddresses
    {
        // CameraManager
        public const int CameraUpdate = 0x00456780;

        // SmartBox
        public const int SmartBoxUpdateViewer = 0x00453D80;

        // CTransition
        public const int FindValidPosition = 0x0050CDE0;

        // CameraSet
        public const int MouseLookHandler = 0x00458EA0;
    }
}
