namespace ACBindingsTest.Internal.Logger;


/// <summary>Extends generic logging functionality to write text-based logs into files, enabling persistent storage of log data.</summary>
public unsafe struct ITextFileOutputHandler
{
    // Base Classes
    public ACBindingsTest.Internal.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindingsTest.Internal.Logger.ILoggingOutputHandler

    // Child Types
    public unsafe struct ITextFileOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ITextFileOutputHandler*, void> Logger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ITextFileOutputHandler*, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ITextFileOutputHandler*, void> Flush; // function pointer
        public System.IntPtr ChangeLogFile;
        public System.IntPtr GetLogFileName;

        // Methods
    }

    // Methods
}

