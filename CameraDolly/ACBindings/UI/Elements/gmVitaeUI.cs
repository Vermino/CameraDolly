namespace ACBindingsTest.Internal;


/// <summary>Provides a UI component that displays and updates the player’s Vitae level, showing percentage and experience progress within the game interface.</summary>
public unsafe struct gmVitaeUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindingsTest.Internal.UIElement_Field
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler
    public ACBindingsTest.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindingsTest.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmVitaeUI_vtbl
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

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement_Text* m_pMainText;
    public float m_currentVitae;

    // Generated Constructor
    public gmVitaeUI(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the vita UI by configuring its main text element, registering for global event notices, and subscribing a quality change handler.
    /// <code>Offset: 0x004A75C0
    /// void __thiscall gmVitaeUI::PostInit(gmVitaeUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, void>)0x004A75C0)(ref this);

    /// <summary>Destroys a gmVitaeUI instance, unregistering its notice handler from the global event system, deregistering quality change callbacks, restoring base class vtables before invoking base destructors.
    /// <code>Offset: 0x004A7620
    /// void __thiscall gmVitaeUI::~gmVitaeUI(gmVitaeUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, void>)0x004A7620)(ref this);

    /// <summary>Performs a type-based cast of the gmVitaeUI instance into an appropriate UIElement-derived pointer, returning either its base UIElement or the object itself when the requested type matches known identifiers.
    /// <code>Offset: 0x004A7680
    /// UIElement* __thiscall gmVitaeUI::DynamicCast(gmVitaeUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Numeric identifier of the element type to request. Known values include 268435488 for the base UIElement and 3 for gmVitaeUI itself.</param>
    /// <returns>Pointer to the requested element type if this object matches that type; otherwise null.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, uint, ACBindingsTest.Internal.UIElement*>)0x004A7680)(ref this, i_eType);

    /// <summary>Retrieves the unique type identifier for a gmVitaeUI element.
    /// <code>Offset: 0x004A76A0
    /// unsigned int __thiscall gmVitaeUI::GetUIElementType(gmVitaeUI*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, uint>)0x004A76A0)(ref this);

    /// <summary>Creates a Vita UI element from the specified layout and element description, initializing base classes, handlers, and default state.
    /// <code>Offset: 0x004A76B0
    /// void __thiscall gmVitaeUI::gmVitaeUI(gmVitaeUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor containing display properties and elements.</param>
    /// <param name="full_desc">Full element description for the UI component.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x004A76B0)(ref this, layout, full_desc);

    /// <summary>Registers the GM VITA UI element class with the UI framework, making it available for instantiation in layouts.
    /// <code>Offset: 0x004A7760
    /// void __cdecl gmVitaeUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A7760)();

    /// <summary>Updates the Vitae UI element to display the current vitae percentage and experience progress, retrieving player data from the interface system. Returns true if the update succeeded; otherwise false.
    /// <code>Offset: 0x004A7780
    /// bool __thiscall gmVitaeUI::Update(gmVitaeUI*)</code>
    /// </summary>
    /// <returns>True when the Vitae text was successfully updated; false if required interfaces could not be obtained or an error occurred.</returns>
    public byte Update() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, byte>)0x004A7780)(ref this);

    /// <summary>Handles incoming element messages for the Vitae UI component, triggering an update when a specific internal message is received and then delegating to the base UI element handler.
    /// <code>Offset: 0x004A7A50
    /// UIElementMessageListenResult __thiscall gmVitaeUI::ListenToElementMessage(gmVitaeUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing the ID of the message, source element, parameters, and positional data.</param>
    /// <returns>Result from the base UIElement::ListenToElementMessage call indicating how the message was processed.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004A7A50)(ref this, i_rMsg);

    /// <summary>Updates the Vitae display in gmVitaeUI when a player description notice is received.
    /// <code>Offset: 0x004A7A80
    /// void __thiscall gmVitaeUI::RecvNotice_PlayerDescReceived(gmVitaeUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player quality data providing the current Vitae value.</param>
    /// <param name="i_playerModule">Player module information; currently unused for updating Vitae.</param>
    public void RecvNotice_PlayerDescReceived(ACBindingsTest.Internal.CACQualities* i_playerDesc, ACBindingsTest.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, ACBindingsTest.Internal.CACQualities*, ACBindingsTest.Internal.CPlayerModule*, void>)0x004A7A80)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Receives a notification that the player's Vitae value has changed, retrieves the updated value via CACQualities, updates the stored state and UI text, and adjusts panel visibility accordingly.
    /// <code>Offset: 0x004A7AA0
    /// void __thiscall gmVitaeUI::RecvNotice_VitaeChanged(gmVitaeUI*)</code>
    /// </summary>
    public void RecvNotice_VitaeChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, void>)0x004A7AA0)(ref this);

    /// <summary>Refreshes the vitae UI after a quality is removed from an object.
    /// <code>Offset: 0x004A7B80
    /// void __thiscall gmVitaeUI::OnQualityRemoved(gmVitaeUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="cwobj">The object whose quality has been removed.</param>
    /// <param name="stype">The type of stat that was removed.</param>
    /// <param name="senum">An identifier for the specific stat instance within its type.</param>
    public void OnQualityRemoved(ACBindingsTest.Internal.CWeenieObject* cwobj, ACBindingsTest.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitaeUI, ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.StatType, uint, void>)0x004A7B80)(ref this, cwobj, stype, senum);
}

