namespace ACBindingsTest.Internal;


/// <summary>Serves as a COM event sink for chat client notifications, enabling applications to handle events from the chat system.</summary>
/// <remarks>Implements IUnknown and is used to receive callbacks in an event‑driven chat architecture.</remarks>
public unsafe struct IChatClientEventSink
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IChatClientEventSink_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatClientEventSink*, uint, ushort*, ushort*, ACBindingsTest.Internal.tagBLOB, void> OnSendToRoom; // function pointer

        // Methods
    }

    // Methods
}

