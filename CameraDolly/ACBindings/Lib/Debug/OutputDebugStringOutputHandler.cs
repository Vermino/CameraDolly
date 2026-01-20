namespace ACBindingsTest.Internal;


/// <summary>Implements Logger::ILoggingOutputHandler, forwarding logged events to the debugger’s output window when a debugger is present.</summary>
public unsafe struct OutputDebugStringOutputHandler
{
    // Base Classes
    public ACBindingsTest.Internal.Logger.ILoggingOutputHandler BaseClass_Logger_ILoggingOutputHandler; // ACBindingsTest.Internal.Logger.ILoggingOutputHandler

    // Child Types
    public unsafe struct OutputDebugStringOutputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OutputDebugStringOutputHandler*, void> OutputDebugStringOutputHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OutputDebugStringOutputHandler*, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult> Write; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OutputDebugStringOutputHandler*, void> Flush; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Sends the supplied log message to the debugger’s output window when a debugger is attached.
    /// <code>Offset: 0x0040EA20
    /// Logger::LoggerWriteResult __thiscall OutputDebugStringOutputHandler::Write(OutputDebugStringOutputHandler*,Logger::LoggingSeverity,unsigned int,const char*)</code>
    /// </summary>
    /// <param name="ls">Severity level of the logged event.</param>
    /// <param name="lc">Log count or sequence number associated with the event.</param>
    /// <param name="szMsg">Text of the log entry to be displayed.</param>
    /// <returns>Always returns 1, indicating that the message was processed successfully.</returns>
    public ACBindingsTest.Internal.Logger.LoggerWriteResult Write(ACBindingsTest.Internal.Logger.LoggingSeverity ls, uint lc, sbyte* szMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OutputDebugStringOutputHandler, ACBindingsTest.Internal.Logger.LoggingSeverity, uint, sbyte*, ACBindingsTest.Internal.Logger.LoggerWriteResult>)0x0040EA20)(ref this, ls, lc, szMsg);
}

