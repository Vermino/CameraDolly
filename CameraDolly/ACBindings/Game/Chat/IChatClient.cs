namespace ACBindingsTest.Internal;


/// <summary>Wraps an IChatNetworkSink instance, representing a chat client.</summary>
public unsafe struct IChatClient
{
    // Base Classes
    public ACBindingsTest.Internal.IChatNetworkSink BaseClass_IChatNetworkSink; // ACBindingsTest.Internal.IChatNetworkSink

    // Child Types
    public unsafe struct IChatClient_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatNetworkSink*, ACBindingsTest.Internal.tagBLOB, int> OnNetworkData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ACBindingsTest.Internal.IChatNetwork*, ACBindingsTest.Internal.IChatClientEventSink*, ACBindingsTest.Internal.IChatClientAsyncResultSink*, ushort*, int> Init; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, int> Term; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, int> UseTime; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, double, int> SetTime; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, int> SetDisplayName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, uint, ushort*, int> EnterRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, ushort*, ACBindingsTest.Internal.tagBLOB, ACBindingsTest.Internal.tagBLOB, int> EnterRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, uint, int> ExitRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, ACBindingsTest.Internal.tagBLOB, ACBindingsTest.Internal.tagBLOB, int> ExitRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, ushort*, ACBindingsTest.Internal.tagBLOB, ACBindingsTest.Internal.tagBLOB, int> SendToRoomByName; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, uint, ushort*, ACBindingsTest.Internal.tagBLOB, ACBindingsTest.Internal.tagBLOB, int> SendToRoomByID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, int> Squelch; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClient*, ushort*, int> UnSquelch; // function pointer

        // Methods
    }

    // Methods
}

