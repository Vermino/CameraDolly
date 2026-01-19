namespace ACBindingsTest.Internal;


/// <summary>
/// Manages the user interface presented after a disconnection, providing feedback through a root element and optional error message.
/// Handles relevant UI messages and coordinates transitions to other UI modes.
/// </summary>
public unsafe struct gmDisconnectedUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindingsTest.Internal.UIMainFramework
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmDisconnectedUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, void> gmDisconnectedUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, uint, uint, ACBindingsTest.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, ACBindingsTest.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmDisconnectedUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement* m_disconnectedField;
    public ACBindingsTest.Internal.UIElement_Text* m_errorText;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys the gmDisconnectedUI instance, unregistering UI messages, removing root elements, clearing error text, and invoking base class destructors.
    /// <code>Offset: 0x004EA600
    /// void __thiscall gmDisconnectedUI::~gmDisconnectedUI(gmDisconnectedUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmDisconnectedUI, void>)0x004EA600)(ref this);

    /// <summary>
    /// Responds to UI element messages, queuing a specific UI mode when the disconnect field (ID 268436504) sends message type 1; otherwise forwards the message to the base framework.
    /// 
    /// <code>Offset: 0x004EA650
    /// UIElementMessageListenResult __thiscall gmDisconnectedUI::ListenToElementMessage(gmDisconnectedUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message, including element ID and message type.</param>
    /// <returns>Result of processing the message as returned by UIFramework::ListenToElementMessage.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmDisconnectedUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004EA650)(ref this, i_rMsg);

    /// <summary>Updates the text element that displays disconnection errors, if present, with information from the supplied StringInfo instance.
    /// <code>Offset: 0x004EA680
    /// void __thiscall gmDisconnectedUI::SetErrorMsg(gmDisconnectedUI*,const StringInfo*)</code>
    /// </summary>
    /// <param name="err">StringInfo containing the error message to display; it is forwarded directly to the underlying UIElement_Text::SetStringInfo call.</param>
    public void SetErrorMsg(ACBindingsTest.Internal.StringInfo* err) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmDisconnectedUI, ACBindingsTest.Internal.StringInfo*, void>)0x004EA680)(ref this, err);

    /// <summary>Registers the gmDisconnectedUI framework with UIFlow, enabling it within the user interface system.
    /// <code>Offset: 0x004EA770
    /// void __cdecl gmDisconnectedUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">The registration mode or flags passed to UIFlow::RegisterFrameworkClass during class registration.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA770)(mode);
}

