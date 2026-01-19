namespace ACBindingsTest.Internal;


/// <summary>Provides an interface for receiving callbacks when asynchronous chat client operations complete.</summary>
public unsafe struct IChatClientAsyncResultSink
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IChatClientAsyncResultSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClientAsyncResultSink*, int, ushort*, ACBindingsTest.Internal.tagBLOB, void> OnEnterRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClientAsyncResultSink*, int, ushort*, ACBindingsTest.Internal.tagBLOB, void> OnExitRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClientAsyncResultSink*, int, ushort*, ushort*, ACBindingsTest.Internal.tagBLOB, void> OnSendToRoomByNameResult; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClientAsyncResultSink*, int, uint, ushort*, ACBindingsTest.Internal.tagBLOB, void> OnSendToRoomByIDResult; // function pointer

        // Methods
    }

    // Methods
}

