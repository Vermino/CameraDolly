namespace ACBindingsTest.Internal;


/// <summary>Represents an asynchronous pipe interface for double‑precision values, providing COM‑compatible mechanisms for inter‑component communication.</summary>
/// <remarks>Contains an <c>IUnknown</c> base class to support reference counting and interface querying.</remarks>
public unsafe struct AsyncIPipeDouble
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIPipeDouble_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeDouble*, uint, int> Begin_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeDouble*, double*, uint*, int> Finish_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeDouble*, double*, uint, int> Begin_Push; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeDouble*, int> Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

