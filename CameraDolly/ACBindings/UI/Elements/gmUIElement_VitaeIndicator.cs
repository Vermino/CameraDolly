namespace ACBindingsTest.Internal;


/// <summary>Represents a UI element that displays the player’s vita level, updating visibility when vita changes occur.</summary>
public unsafe struct gmUIElement_VitaeIndicator
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Button BaseClass_UIElement_Button; // ACBindingsTest.Internal.UIElement_Button
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmUIElement_VitaeIndicator_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement_Scrollable*, void> AdjustToScrollableXYChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement_Scrollable*, byte, byte, byte, int> InqScrollDelta; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Attempts to cast the element to a UIElement based on a numeric type identifier, returning the base UIElement pointer when the requested type matches supported values.
    /// <code>Offset: 0x004E6AF0
    /// UIElement* __thiscall gmUIElement_VitaeIndicator::DynamicCast(gmUIElement_VitaeIndicator*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The type identifier used to determine whether a cast to UIElement is valid.</param>
    /// <returns>A pointer to the element’s UIElement base if the type ID matches one of the supported values; otherwise, nullptr.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, uint, ACBindingsTest.Internal.UIElement*>)0x004E6AF0)(ref this, i_eType);

    /// <summary>Returns the unique identifier for a vita indicator UI element.
    /// <code>Offset: 0x004E6B20
    /// unsigned int __thiscall gmUIElement_VitaeIndicator::GetUIElementType(SpellComponentTable*)</code>
    /// </summary>
    /// <returns>An unsigned integer representing the UI element type ID (268435462).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, uint>)0x004E6B20)(ref this);

    /// <summary>Initializes a vita indicator UI element after construction, configuring base button behaviour and registering global event handlers for vitae-related notifications.
    /// <code>Offset: 0x004E6B30
    /// void __thiscall gmUIElement_VitaeIndicator::PostInit(gmUIElement_VitaeIndicator*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, void>)0x004E6B30)(ref this);

    /// <summary>Create a new Vita indicator UI element, initializing it with the given layout and descriptor, configuring its input callbacks, and returning a pointer to the resulting UIElement.
    /// <code>Offset: 0x004E6B90
    /// UIElement* __cdecl gmUIElement_VitaeIndicator::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout description containing dimensions and elements for the UI.</param>
    /// <param name="full_desc">Full element descriptor defining properties of the specific UI component.</param>
    /// <returns>Pointer to the created UIElement instance; null if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x004E6B90)(layout, full_desc);

    /// <summary>Registers the Vitae Indicator UI element type under identifier 0x10000006, enabling its creation by the UI system.
    /// <code>Offset: 0x004E6C50
    /// void __cdecl gmUIElement_VitaeIndicator::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004E6C50)();

    /// <summary>Updates the vita indicator UI element by querying the current player's vitae enchantment and adjusting visibility based on its value; hides the indicator when the vitae level falls below one.
    /// <code>Offset: 0x004E6C70
    /// void __thiscall gmUIElement_VitaeIndicator::Update(gmUIElement_VitaeIndicator*)</code>
    /// </summary>
    public void Update() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, void>)0x004E6C70)(ref this);

    /// <summary>Processes a received player description notice and updates the vita indicator UI element accordingly.
    /// <code>Offset: 0x004E6D70
    /// void __thiscall gmUIElement_VitaeIndicator::RecvNotice_PlayerDescReceived(gmUIElement_VitaeIndicator*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="this">The current vita indicator instance.</param>
    /// <param name="i_playerDesc">Qualities describing the player, including attributes, spells, enchantments, and other gameplay data.</param>
    /// <param name="i_playerModule">Player module providing state information such as dirty flag and timestamps.</param>
    public void RecvNotice_PlayerDescReceived(ACBindingsTest.Internal.CACQualities* i_playerDesc, ACBindingsTest.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, ACBindingsTest.Internal.CACQualities*, ACBindingsTest.Internal.CPlayerModule*, void>)0x004E6D70)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Handles a vita change notification by updating the UI indicator accordingly.
    /// <code>Offset: 0x004E6D80
    /// void __thiscall gmUIElement_VitaeIndicator::RecvNotice_VitaeChanged(gmUIElement_VitaeIndicator*)</code>
    /// </summary>
    public void RecvNotice_VitaeChanged() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmUIElement_VitaeIndicator, void>)0x004E6D80)(ref this);
}

