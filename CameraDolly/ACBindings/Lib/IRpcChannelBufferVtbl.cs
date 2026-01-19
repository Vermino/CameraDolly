namespace ACBindingsTest.Internal;


/// <summary>Represents a virtual table for RPC channel buffer operations, defining function pointers for QueryInterface, AddRef, Release, GetBuffer, SendReceive, FreeBuffer, GetDestCtx, and IsConnected.</summary>
public unsafe struct IRpcChannelBufferVtbl
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

    // Methods
}

