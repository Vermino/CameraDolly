namespace ACBindingsTest.Internal;


/// <summary>Implements the IRpcChannelBuffer2 COM interface by embedding an IRpcChannelBuffer baseclass, providing RPC channel buffering capabilities for remote procedure calls.</summary>
public unsafe struct IRpcChannelBuffer2
{
    // Base Classes
    public ACBindingsTest.Internal.IRpcChannelBuffer BaseClass_IRpcChannelBuffer; // ACBindingsTest.Internal.IRpcChannelBuffer

    // Child Types
    public unsafe struct IRpcChannelBuffer2_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, System.IntPtr, ACBindingsTest.Internal._GUID*, int> GetBuffer; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, System.IntPtr, uint*, int> SendReceive; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, System.IntPtr, int> FreeBuffer; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, uint*, void**, int> GetDestCtx; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer*, int> IsConnected; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer2*, uint*, int> GetProtocolVersion; // function pointer

        // Methods
    }

    // Methods
}

