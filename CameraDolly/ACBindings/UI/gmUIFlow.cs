namespace ACBindingsTest.Internal;


/// <summary>Manages the client UI flow by coordinating mode transitions, registering UI elements and event listeners, and handling character error and server death notices.</summary>
public unsafe struct gmUIFlow : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIFlow BaseClass_UIFlow; // ACBindingsTest.Internal.UIFlow
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmUIFlow_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFlow*, ACBindingsTest.Internal.UIFlow.Enum19> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFlow*, uint, void> QueueUIMode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFlow*, uint, ACBindingsTest.Internal.StringInfo*, void> QueueUIModeWithError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFlow*, ACBindingsTest.Internal.UIPersistantData*> GetPersistantData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFlow*, void> Update; // function pointer

        // Methods
    }

    // Generated Constructor
    public gmUIFlow() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the UI flow system by setting up vtables, registering UI elements and modes, queuing the initial mode, configuring the cursor element, and registering notice handlers with the global event handler.
    /// <code>Offset: 0x0047AA10
    /// void __thiscall gmUIFlow::gmUIFlow(gmUIFlow*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIFlow, void>)0x0047AA10)(ref this);

    /// <summary>Destroys a gmUIFlow object, unregistering all global notice handlers, cleaning up UI resources, and invoking the destructors of its embedded UIFlow and NoticeHandler components.
    /// <code>Offset: 0x0047AB20
    /// void __thiscall gmUIFlow::~gmUIFlow(gmUIFlow*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIFlow, void>)0x0047AB20)(ref this);

    /// <summary>Translates character error codes into localized message identifiers and forwards them to the notice handler with an appropriate notice type.
    /// <code>Offset: 0x0047ABC0
    /// void __thiscall gmUIFlow::RecvNotice_CharacterError(gmUIFlow*,charError)</code>
    /// </summary>
    /// <param name="error">The character error code specifying the failure that occurred, such as logon errors, server crashes, or account issues.</param>
    public void RecvNotice_CharacterError(ACBindingsTest.Internal.charError error) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIFlow, ACBindingsTest.Internal.charError, void>)0x0047ABC0)(ref this, error);

    /// <summary>Handles a notification that the server has died by displaying an error message when appropriate.
    /// <code>Offset: 0x0047ADA0
    /// void __thiscall gmUIFlow::RecvNotice_ServerDied(gmUIFlow*)</code>
    /// </summary>
    public void RecvNotice_ServerDied() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIFlow, void>)0x0047ADA0)(ref this);
}

