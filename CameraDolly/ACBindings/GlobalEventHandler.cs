namespace ACBindingsTest.Internal;


/// <summary>Singleton event handler that registers notice handlers globally, using an embedded NoticeRegistrar for storage and lifecycle management.</summary>
/// <remarks>Only one instance exists; GetGlobalEventHandler returns the shared pointer. Construction assigns this instance to a static member; destruction clears it.</remarks>
public unsafe struct GlobalEventHandler : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.NoticeRegistrar BaseClass_NoticeRegistrar; // ACBindingsTest.Internal.NoticeRegistrar

    // Statics
    public static ACBindingsTest.Internal.GlobalEventHandler** geh = (ACBindingsTest.Internal.GlobalEventHandler**)0x00838374;

    // Child Types
    public unsafe struct GlobalEventHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GlobalEventHandler*, void> GlobalEventHandler_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GlobalEventHandler*, uint, ACBindingsTest.Internal.NoticeHandler*, byte> RegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GlobalEventHandler*, uint, ACBindingsTest.Internal.NoticeHandler*, byte> UnRegisterNoticeHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GlobalEventHandler*, ACBindingsTest.Internal.NoticeHandler*, byte> UnRegisterAllNoticeHandlers; // function pointer
        public System.IntPtr GetNoticeHandlers;

        // Methods
    }

    // Generated Constructor
    public GlobalEventHandler() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a GlobalEventHandler instance by constructing its base NoticeRegistrar and registering the handler globally.
    /// <code>Offset: 0x0043C640
    /// void __thiscall GlobalEventHandler::GlobalEventHandler(GlobalEventHandler*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.GlobalEventHandler, void>)0x0043C640)(ref this);

    /// <summary>Destroys the GlobalEventHandler instance, resetting internal state and delegating cleanup of registered handlers to its base class NoticeRegistrar.
    /// <code>Offset: 0x0043C660
    /// void __thiscall GlobalEventHandler::~GlobalEventHandler(GlobalEventHandler*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.GlobalEventHandler, void>)0x0043C660)(ref this);

    /// <summary>Retrieves the singleton instance of GlobalEventHandler.
    /// <code>Offset: 0x0043C680
    /// GlobalEventHandler* __cdecl GlobalEventHandler::GetGlobalEventHandler()</code>
    /// </summary>
    /// <returns>A pointer to the global event handler instance, or nullptr if none has been initialized.</returns>
    public static ACBindingsTest.Internal.GlobalEventHandler* GetGlobalEventHandler() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.GlobalEventHandler*>)0x0043C680)();
}

