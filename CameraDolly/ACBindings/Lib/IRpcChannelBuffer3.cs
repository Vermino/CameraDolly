namespace ACBindingsTest.Internal;


/// <summary>Provides the third iteration of the RPC Channel Buffer interface, extending base functionality from IRpcChannelBuffer2 to support additional communication features for COM remote calls.</summary>
public unsafe struct IRpcChannelBuffer3
{
    // Base Classes
    public ACBindingsTest.Internal.IRpcChannelBuffer2 BaseClass_IRpcChannelBuffer2; // ACBindingsTest.Internal.IRpcChannelBuffer2

    // Child Types
    public unsafe struct IRpcChannelBuffer3_vtbl
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
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, int> Send; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, uint, uint*, int> Receive; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, int> Cancel; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, ACBindingsTest.Internal._GUID*, void**, int> GetCallContext; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, void**, int> GetDestCtxEx; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, uint*, int> GetState; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcChannelBuffer3*, System.IntPtr, System.IntPtr, int> RegisterAsync; // function pointer

        // Methods
    }

    // Methods
}

