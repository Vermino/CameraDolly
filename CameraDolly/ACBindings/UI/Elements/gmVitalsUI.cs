namespace ACBindingsTest.Internal;


/// <summary>Tracks the player’s health, stamina, and mana UI components, updating meter visuals and labels when character attributes change.</summary>
public unsafe struct gmVitalsUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindingsTest.Internal.UIElement_Field
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler
    public ACBindingsTest.Internal.QualityChangeHandler BaseClass_QualityChangeHandler; // ACBindingsTest.Internal.QualityChangeHandler

    // Child Types
    public unsafe struct gmVitalsUI_vtbl
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
    public ACBindingsTest.Internal.UIElement_Meter* m_pHealthMeter;
    public ACBindingsTest.Internal.UIElement_Meter* m_pStaminaMeter;
    public ACBindingsTest.Internal.UIElement_Meter* m_pManaMeter;
    public ACBindingsTest.Internal.UIElement_Text* m_pHealthLabel;
    public ACBindingsTest.Internal.UIElement_Text* m_pStaminaLabel;
    public ACBindingsTest.Internal.UIElement_Text* m_pManaLabel;

    // Generated Constructor
    public gmVitalsUI(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a gmVitalsUI instance by unregistering all notice handlers and quality change callbacks, then cleaning up its base class components.
    /// <code>Offset: 0x004C07A0
    /// void __thiscall gmVitalsUI::~gmVitalsUI(gmVitalsUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, void>)0x004C07A0)(ref this);

    /// <summary>Attempts to cast a gmVitalsUI instance to the specified UIElement-derived type based on an integer type ID.
    /// <code>Offset: 0x004C0850
    /// UIElement* __thiscall gmVitalsUI::DynamicCast(gmVitalsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired type; 268435465 requests the base UIElement, 3 requests the gmVitalsUI itself.</param>
    /// <returns>Pointer to the requested element if the cast matches the object's type hierarchy; otherwise null.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, uint, ACBindingsTest.Internal.UIElement*>)0x004C0850)(ref this, i_eType);

    /// <summary>Processes UI element messages for the vitals interface, performing special handling for message ID 28 with parameters 7 or 10 before delegating to the base implementation.
    /// <code>Offset: 0x004C0880
    /// UIElementMessageListenResult __thiscall gmVitalsUI::ListenToElementMessage(gmVitalsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="this">The gmVitalsUI instance receiving the message.</param>
    /// <param name="i_rMsg">Information about the element message being processed.</param>
    /// <returns>Result of processing the message as returned by UIElement::ListenToElementMessage.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004C0880)(ref this, i_rMsg);

    /// <summary>Initializes a vitals user interface element with the given layout and description, creating internal references for health, stamina, and mana meters and labels.
    /// <code>Offset: 0x004C08D0
    /// void __thiscall gmVitalsUI::gmVitalsUI(gmVitalsUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">The layout descriptor providing size, positioning, and child elements for the UI component.</param>
    /// <param name="full_desc">A full element description that defines properties and states used by the vitals UI.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x004C08D0)(ref this, layout, full_desc);

    /// <summary>Initializes the vitals UI by locating health, stamina, and mana meter and label elements within its child hierarchy and storing references to them for later use.
    /// <code>Offset: 0x004C0960
    /// void __thiscall gmVitalsUI::PostInit(gmVitalsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, void>)0x004C0960)(ref this);

    /// <summary>Creates and initializes a gmVitalsUI instance from the provided layout and element description.
    /// <code>Offset: 0x004C0A60
    /// UIElement* __cdecl gmVitalsUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout definition for the vitals UI.</param>
    /// <param name="full_desc">Full element descriptor describing the vitals UI components.</param>
    /// <returns>A pointer to the newly created UIElement representing the vitals UI, or nullptr on failure.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x004C0A60)(layout, full_desc);

    /// <summary>Registers the Vitals UI element class with the UI system, allowing instances to be created through the registered factory.
    /// <code>Offset: 0x004C0A90
    /// void __cdecl gmVitalsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004C0A90)();

    /// <summary>Updates the health, stamina, and mana meters and their associated labels to reflect the player’s current attribute values retrieved from the game interface system.
    /// <code>Offset: 0x004C0AB0
    /// void __thiscall gmVitalsUI::Update(gmVitalsUI*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, void>)0x004C0AB0)(ref this);

    /// <summary>Refreshes the vitals UI in response to a quality change on a game object.
    /// <code>Offset: 0x004C0E70
    /// void __thiscall gmVitalsUI::OnQualityChanged(gmVitalsUI*,CWeenieObject*,StatType,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmVitalsUI instance handling the update.</param>
    /// <param name="cwobj">Game object whose quality changed.</param>
    /// <param name="stype">Stat type that triggered the change.</param>
    /// <param name="senum">Enumeration value related to the quality change event.</param>
    public void OnQualityChanged(ACBindingsTest.Internal.CWeenieObject* cwobj, ACBindingsTest.Internal.StatType stype, uint senum) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.StatType, uint, void>)0x004C0E70)(ref this, cwobj, stype, senum);

    /// <summary>Receives a player description notice and refreshes the corresponding vitals UI.
    /// <code>Offset: 0x004C0E80
    /// void __thiscall gmVitalsUI::RecvNotice_PlayerDescReceived(gmVitalsUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities data received from the server.</param>
    /// <param name="i_playerModule">Reference to the player's module containing state information.</param>
    public void RecvNotice_PlayerDescReceived(ACBindingsTest.Internal.CACQualities* i_playerDesc, ACBindingsTest.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmVitalsUI, ACBindingsTest.Internal.CACQualities*, ACBindingsTest.Internal.CPlayerModule*, void>)0x004C0E80)(ref this, i_playerDesc, i_playerModule);
}

