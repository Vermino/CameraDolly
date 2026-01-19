namespace ACBindingsTest.Internal;


/// <summary>Facilitates thread‑safe routing of log output to multiple file handlers, maintaining a hash table of handlers indexed by identifiers and protecting access with a spin lock.</summary>
public unsafe struct MultiThreadOutputRouter
{
    // Base Classes
    public ACBindingsTest.Internal.Logger.ITextFileOutputHandler BaseClass_Logger_ITextFileOutputHandler; // ACBindingsTest.Internal.Logger.ITextFileOutputHandler

    // Child Types
    public unsafe struct MultiThreadOutputRouter_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.MultiThreadOutputRouter*, void> MultiThreadOutputRouter_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.MultiThreadOutputRouter*, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.MultiThreadOutputRouter*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CSpinLock m_critsec;
    public ACBindingsTest.Internal.HashTable__uint___Logger_ITextFileOutputHandler_ptr m_hash;

    // Methods
}

