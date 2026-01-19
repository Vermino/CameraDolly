namespace ACBindingsTest.Internal;


/// <summary>Defines a COM interface for asynchronous byte‑level pipe operations, inheriting from IUnknown to support reference counting and interface querying.</summary>
public unsafe struct AsyncIPipeByte
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIPipeByte_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeByte*, uint, int> Begin_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeByte*, byte*, uint*, int> Finish_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeByte*, byte*, uint, int> Begin_Push; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeByte*, int> Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

