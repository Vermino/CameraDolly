namespace ACBindingsTest.Internal;


/// <summary>Holds state necessary for handling exceptions on a worker thread, linking the original exception data with its debug context and the function’s return status.</summary>
public unsafe struct ExceptionThreadInfo
{
    // Base Classes
    public ACBindingsTest.Internal.DebugWorkerThreadData BaseClass_DebugWorkerThreadData; // ACBindingsTest.Internal.DebugWorkerThreadData

    // Members
    public System.IntPtr pep;
    public uint dwRetVal;
    public ACBindingsTest.Internal.DbgReportContext ctxt;

    // Methods
}

