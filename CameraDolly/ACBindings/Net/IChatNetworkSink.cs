namespace ACBindingsTest.Internal;


/// <summary>Serves as a COM-style sink for handling incoming chat network events and messages.</summary>
public unsafe struct IChatNetworkSink
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IChatNetworkSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatNetworkSink*, ACBindingsTest.Internal.tagBLOB, int> OnNetworkData; // function pointer

        // Methods
    }

    // Methods
}

