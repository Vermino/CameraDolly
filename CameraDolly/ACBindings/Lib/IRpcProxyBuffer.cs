namespace ACBindingsTest.Internal;


/// <summary>Acting as a proxy buffer for RPC operations, this structure facilitates the marshaling of COM interface pointers across process boundaries.</summary>
public unsafe struct IRpcProxyBuffer
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcProxyBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcProxyBuffer*, ACBindingsTest.Internal.IRpcChannelBuffer*, int> Connect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcProxyBuffer*, void> Disconnect; // function pointer

        // Methods
    }

    // Methods
}

