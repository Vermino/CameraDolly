namespace ACBindingsTest.Internal;


/// <summary>Provides an interface for COM RPC stub buffers, enabling serialization of method parameters and handling remote procedure calls.</summary>
public unsafe struct IRpcStubBuffer
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcStubBuffer_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, ACBindingsTest.Internal.IUnknown*, int> Connect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, void> Disconnect; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, System.IntPtr, ACBindingsTest.Internal.IRpcChannelBuffer*, int> Invoke; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, ACBindingsTest.Internal._GUID*, ACBindingsTest.Internal.IRpcStubBuffer*> IsIIDSupported; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, uint> CountRefs; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, void**, int> DebugServerQueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcStubBuffer*, System.IntPtr, void> DebugServerRelease; // function pointer

        // Methods
    }

    // Methods
}

