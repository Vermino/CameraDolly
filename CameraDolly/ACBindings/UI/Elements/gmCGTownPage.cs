namespace ACBindingsTest.Internal;


/// <summary>
/// Manages the town selection page in character creation, storing UI controls for each available town and updating the player’s start area based on user choice.
/// </summary>
public unsafe struct gmCGTownPage
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindingsTest.Internal.UIElement_Field
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmCGTownPage_vtbl
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
    // gmCGTownPage::ETown
    public enum ETown : byte
    {
        ECG_TOWN_INVALID = 0x0,
        ECG_TOWN_HOLTBURG = 0x1,
        ECG_TOWN_SHOUSHI = 0x2,
        ECG_TOWN_YARAQ = 0x3,
        ECG_TOWN_SANAMAR = 0x4
    }

    // Members
    public ACBindingsTest.Internal.CPlayerSystem* m_pPlayerSystem;
    public ACBindingsTest.Internal.gmCharGenMainUI* m_pMainFramework;
    public ACBindingsTest.Internal.UIElement_Button* m_pSanamarButton;
    public ACBindingsTest.Internal.UIElement_Button* m_pHoltButton;
    public ACBindingsTest.Internal.UIElement_Button* m_pYaraqButton;
    public ACBindingsTest.Internal.UIElement_Button* m_pShoushiButton;
    public ACBindingsTest.Internal.UIElement_Text* m_pTextBox;
    public ACBindingsTest.Internal.gmCGTownPage.ETown m_eCurTown;

    // Methods

    /// <summary>Returns a pointer to the UIElement representation of the gmCGTownPage object for the specified type identifier, or null when the type is unsupported.
    /// <code>Offset: 0x0047C490
    /// UIElement* __thiscall gmCGTownPage::DynamicCast(gmCGTownPage*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric identifier of the desired type. Specific values correspond to the base UIElement class (268435517) and the gmCGTownPage class itself (3).</param>
    /// <returns>Pointer to a UIElement subobject matching the requested type, or null if the type is not supported.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, uint, ACBindingsTest.Internal.UIElement*>)0x0047C490)(ref this, i_eType);

    /// <summary>Returns the unique identifier for the gmCGTownPage UI element type.
    /// <code>Offset: 0x0047C4B0
    /// unsigned int __thiscall gmCGTownPage::GetUIElementType(gmCGTownPage*)</code>
    /// </summary>
    /// <returns>An unsigned integer (268435517) that represents this element type within the UI framework.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, uint>)0x0047C4B0)(ref this);

    /// <summary>Creates a new UI element for the town page using the specified layout and element description.
    /// <code>Offset: 0x0047C4C0
    /// UIElement* __cdecl gmCGTownPage::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining dimensions and child elements.</param>
    /// <param name="full_desc">Full element description used to initialize the UI element hierarchy.</param>
    /// <returns>Pointer to the newly created UIElement, or null if allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x0047C4C0)(layout, full_desc);

    /// <summary>Registers the GM CG Town page UI element class for instantiation within the UI system.
    /// <code>Offset: 0x0047C580
    /// void __cdecl gmCGTownPage::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x0047C580)();

    /// <summary>Updates the UI text box with a combined description and usage guide for the chosen town.
    /// <code>Offset: 0x0047C5A0
    /// void __thiscall gmCGTownPage::SetTownString(gmCGTownPage*,gmCGTownPage::ETown)</code>
    /// </summary>
    /// <param name="eTown">The enum value indicating which town’s information to display.</param>
    public void SetTownString(ACBindingsTest.Internal.gmCGTownPage.ETown eTown) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, ACBindingsTest.Internal.gmCGTownPage.ETown, void>)0x0047C5A0)(ref this, eTown);

    /// <summary>Changes the current character‑generation town to the specified value, updating button states, notifying the player system of the chosen start area, and refreshing the on‑screen town label.
    /// <code>Offset: 0x0047C710
    /// void __thiscall gmCGTownPage::SetTown(gmCGTownPage*,gmCGTownPage::ETown)</code>
    /// </summary>
    /// <param name="eTown">The enum value representing the town to select.</param>
    public void SetTown(ACBindingsTest.Internal.gmCGTownPage.ETown eTown) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, ACBindingsTest.Internal.gmCGTownPage.ETown, void>)0x0047C710)(ref this, eTown);

    /// <summary>Refreshes the selected town on the UI page so that it reflects the character’s starting location determined during character creation.
    /// <code>Offset: 0x0047C810
    /// void __thiscall gmCGTownPage::Update(gmCGTownPage*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, void>)0x0047C810)(ref this);

    /// <summary>Handles UI messages for the town selection page, updating the current town when a town button is pressed and adjusting UI state accordingly.
    /// <code>Offset: 0x0047C830
    /// UIElementMessageListenResult __thiscall gmCGTownPage::ListenToElementMessage(gmCGTownPage*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Message information containing the source element id and message type.</param>
    /// <returns>Result from the base class indicating whether the message was processed.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x0047C830)(ref this, i_rMsg);

    /// <summary>Initializes the town selection page by locating its button and text controls, storing references to the main UI framework and player system, and setting the current town according to the character generation state.
    /// <code>Offset: 0x0047CA80
    /// void __thiscall gmCGTownPage::InitializePage(gmCGTownPage*,gmCharGenMainUI*)</code>
    /// </summary>
    /// <param name="pMain">Reference to the main character‑generation user interface used for accessing shared resources.</param>
    public void InitializePage(ACBindingsTest.Internal.gmCharGenMainUI* pMain) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmCGTownPage, ACBindingsTest.Internal.gmCharGenMainUI*, void>)0x0047CA80)(ref this, pMain);
}

