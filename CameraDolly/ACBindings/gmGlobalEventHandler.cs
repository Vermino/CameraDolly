namespace ACBindingsTest.Internal;


/// <summary>Provides global event handling by wrapping a GlobalEventHandler instance, enabling centralized registration and dispatch of notices across the application.</summary>
public unsafe struct gmGlobalEventHandler
{
    // Base Classes
    public ACBindingsTest.Internal.GlobalEventHandler BaseClass_GlobalEventHandler; // ACBindingsTest.Internal.GlobalEventHandler

    // Child Types
    public unsafe struct gmGlobalEventHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmGlobalEventHandler*, void> gmGlobalEventHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmGlobalEventHandler*, uint, ACBindingsTest.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmGlobalEventHandler*, uint, ACBindingsTest.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmGlobalEventHandler*, ACBindingsTest.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Methods
}

