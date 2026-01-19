namespace ACBindingsTest.Internal;


/// <summary>Handles chat options configuration within the player settings system, providing UI elements and option linkage for sliders and checkboxes.</summary>
public unsafe struct gmChatOptionsUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.PlayerOptionPage BaseClass_PlayerOptionPage; // ACBindingsTest.Internal.PlayerOptionPage
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmChatOptionsUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, byte, ACBindingsTest.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult, ACBindingsTest.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> SaveCurrentValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> RestoreDefaultValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> RestoreSavedValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, void> InitOptions; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.DualHash___UIOption_Slider_ptr___UIOption_Slider_ptr m_hashSliderLinks;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Handles UI element messages for the chat options page, performing cleanup, focus loss or action handling based on message and element IDs.
    /// <code>Offset: 0x0049E620
    /// UIElementMessageListenResult __thiscall gmChatOptionsUI::ListenToElementMessage(gmConfigUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing element ID, message type, and associated data.</param>
    /// <returns>Result indicating whether the message was processed by this handler or forwarded to the base UIElement implementation.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x0049E620)(ref this, i_rMsg);

    /// <summary>Add a new checkbox bitfield option to the chat options page, configuring it with the supplied property ID and user data. Creates child checkboxes for the various chat filter categories and registers the option on the page.
    /// <code>Offset: 0x0049F020
    /// UIOption_CheckboxBitfield64* __thiscall gmChatOptionsUI::AddCheckboxBitfield64Option(gmChatOptionsUI*,const unsigned int*,unsigned int)</code>
    /// </summary>
    /// <param name="i_ePropName">Pointer to the property ID used for the checkbox option.</param>
    /// <param name="i_nUserData">Numeric code indicating special handling (e.g., gameplay filter) and user data for the option.</param>
    /// <returns>Pointer to the newly created UIOption_CheckboxBitfield64 object, or null if the option could not be added.</returns>
    public ACBindingsTest.Internal.UIOption_CheckboxBitfield64* AddCheckboxBitfield64Option(uint* i_ePropName, uint i_nUserData) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, uint*, uint, ACBindingsTest.Internal.UIOption_CheckboxBitfield64*>)0x0049F020)(ref this, i_ePropName, i_nUserData);

    /// <summary>
    /// Initializes the chat options interface after layout loading by retrieving and storing the options list box element, unregistering any prior input callbacks, and notifying that options have changed to refresh the UI.
    /// 
    /// <code>Offset: 0x0049F380
    /// void __thiscall gmChatOptionsUI::PostInit(gmChatOptionsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, void>)0x0049F380)(ref this);

    /// <summary>Handles a chat option change by enforcing linked slider constraints and then delegating to the base option page handler.
    /// <code>Offset: 0x0049F890
    /// void __thiscall gmChatOptionsUI::OnOptionChanged(gmChatOptionsUI*,const UIOption*)</code>
    /// </summary>
    /// <param name="pOption">The UI option that triggered the change event.</param>
    public void OnOptionChanged(ACBindingsTest.Internal.UIOption* pOption) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, ACBindingsTest.Internal.UIOption*, void>)0x0049F890)(ref this, pOption);

    /// <summary>Casts the current gmChatOptionsUI instance to a UIElement pointer when requested type identifier matches that of UIElement, otherwise returns null.
    /// <code>Offset: 0x0049FDA0
    /// UIElement* __thiscall gmChatOptionsUI::DynamicCast(gmChatOptionsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier representing the desired type to cast to.</param>
    /// <returns>Pointer to this object as a UIElement if the type matches; otherwise nullptr.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, uint, ACBindingsTest.Internal.UIElement*>)0x0049FDA0)(ref this, i_eType);

    /// <summary>Identifies this UI element as a chat options panel within the interface system.
    /// <code>Offset: 0x0049FDC0
    /// unsigned int __thiscall gmChatOptionsUI::GetUIElementType(gmChatOptionsUI*)</code>
    /// </summary>
    /// <returns>The constant representing the chat options UI element type (268435522).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, uint>)0x0049FDC0)(ref this);

    /// <summary>Destroys a gmChatOptionsUI instance, freeing all UI slider links and performing cleanup of inherited notice and option page components.
    /// <code>Offset: 0x0049FDD0
    /// void __thiscall gmChatOptionsUI::~gmChatOptionsUI(gmChatOptionsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, void>)0x0049FDD0)(ref this);

    /// <summary>Registers the gmChatOptionsUI element class with the UI system by associating it with a unique type identifier and constructor callback.
    /// <code>Offset: 0x0049FF00
    /// void __cdecl gmChatOptionsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0049FF00)();

    /// <summary>Initializes the chat options user interface by creating option sections, registering sliders and checkbox groups, linking related UI elements, and setting up gameplay option properties for chat visibility, transparency, text filtering, and floaty chat windows.
    /// <code>Offset: 0x0049FF20
    /// void __thiscall gmChatOptionsUI::InitOptions(gmChatOptionsUI*)</code>
    /// </summary>
    public void InitOptions() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmChatOptionsUI, void>)0x0049FF20)(ref this);
}

