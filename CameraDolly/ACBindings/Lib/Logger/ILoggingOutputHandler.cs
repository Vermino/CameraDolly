namespace ACBindingsTest.Internal.Logger;


/// <summary>Provides an abstraction for handling log output, enabling implementations to direct messages to various destinations such as files, consoles, or network streams.</summary>
public unsafe struct ILoggingOutputHandler
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct ILoggingOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ILoggingOutputHandler*, void> Logger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ILoggingOutputHandler*, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Logger.ILoggingOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods
}

