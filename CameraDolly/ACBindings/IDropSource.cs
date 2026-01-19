namespace ACBindingsTest.Internal;


/// <summary>Provides the COM interface used by applications to initiate drag‑and‑drop actions, exposing methods for querying drop support and controlling transfer behavior.</summary>
public unsafe struct IDropSource
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IDropSource_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropSource*, int, uint, int> QueryContinueDrag; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropSource*, uint, int> GiveFeedback; // function pointer

        // Methods
    }

    // Methods
}

