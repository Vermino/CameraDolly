namespace ACBindingsTest.Internal;


/// <summary>Handles asynchronous communication of 32‑bit integers over a pipe, exposing the interface through COM’s IUnknown.</summary>
public unsafe struct AsyncIPipeLong
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct AsyncIPipeLong_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeLong*, uint, int> Begin_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeLong*, int*, uint*, int> Finish_Pull; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeLong*, int*, uint, int> Begin_Push; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.AsyncIPipeLong*, int> Finish_Push; // function pointer

        // Methods
    }

    // Methods
}

