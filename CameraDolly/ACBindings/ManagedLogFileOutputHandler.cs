namespace ACBindingsTest.Internal;


/// <summary>Handles logging output to a text file, managing file creation, size limits, timestamping, and write statistics within the application’s logging subsystem.</summary>
public unsafe struct ManagedLogFileOutputHandler
{
    // Base Classes
    public ACBindingsTest.Internal.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindingsTest.Internal.Logger.ITextFileOutputHandler

    // Child Types
    public unsafe struct ManagedLogFileOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ManagedLogFileOutputHandler*, void> ManagedLogFileOutputHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ManagedLogFileOutputHandler*, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ManagedLogFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;
        public System.IntPtr GetLogRootName;
        public System.IntPtr ChangeDescription;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ManagedLogFileOutputHandler*, byte, void> UsePeriodicRealTimeEntries; // function pointer

        // Methods
    }

    /// <summary>Wraps a reference‑counted character string for asynchronous log file output, providing the underlying storage accessed by ManagedLogFileOutputHandler.</summary>
    public unsafe struct AsyncIOString
    {
        // Base Classes
        public ACBindingsTest.Internal.PStringBase__sbyte BaseClass_PStringBase__sbyte; // ACBindingsTest.Internal.PStringBase__sbyte

        // Methods
    }
    // ManagedLogFileOutputHandler::ReclaimBufferEnum
    public enum ReclaimBufferEnum : byte
    {
        ReclaimBuffer = 0x0
    }

    // Members
    public ACBindingsTest.Internal.PStringBase__sbyte m_strRootName;
    public ACBindingsTest.Internal.PStringBase__sbyte m_strUniqueKey;
    public ACBindingsTest.Internal.PStringBase__sbyte m_strFileName;
    public ACBindingsTest.Internal.PStringBase__sbyte m_strDescription;
    public System.IntPtr m_hLogFile;
    public uint m_cWrites;
    public uint m_cbWritten;
    public uint m_cTimesWrapped;
    public fixed sbyte m_szTimeLogCreated[26];
    public double m_timePrintRealTime;
    public byte m_fTimestampedOutput;
    public uint m_cbMaxSize;
    public ACBindingsTest.Internal.LOG_TRUNCATE_OP m_truncop;
    public uint m_dwCurrentFilePos;

    // Methods
}

