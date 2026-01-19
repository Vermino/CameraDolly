namespace ACBindingsTest.Internal;


/// <summary>
/// Represents the COM ISequentialStream interface, providing sequential read and write operations for data streams. Inherits from IUnknown to enable reference counting and interface querying.
/// </summary>
public unsafe struct ISequentialStream
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct ISequentialStream_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ISequentialStream*, System.IntPtr, uint, uint*, int> Read; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ISequentialStream*, void*, uint, uint*, int> Write; // function pointer

        // Methods
    }

    // Methods
}

