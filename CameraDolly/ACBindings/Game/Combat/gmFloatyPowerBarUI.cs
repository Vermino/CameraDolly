namespace ACBindingsTest.Internal;


/// <summary>Handles the floating power‑bar user interface, managing its position, size, visibility and lock status while integrating with player system options.</summary>
public unsafe struct gmFloatyPowerBarUI
{
    // Base Classes
    public ACBindingsTest.Internal.gmPowerbarUI BaseClass_gmPowerbarUI; // ACBindingsTest.Internal.gmPowerbarUI

    // Child Types
    public unsafe struct gmFloatyPowerBarUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmFloatyPowerBarUI*, void> UpdateFromPlayerModule; // function pointer

        // Methods
    }

    // Members
    public uint m_eWindowID;
    public ACBindingsTest.Internal.UIElement* m_pTopBorder;
    public ACBindingsTest.Internal.UIElement* m_pLeftBorder;
    public ACBindingsTest.Internal.UIElement* m_pBottomBorder;
    public ACBindingsTest.Internal.UIElement* m_pRightBorder;
    public ACBindingsTest.Internal.UIElement* m_pTopLeftCorner;
    public ACBindingsTest.Internal.UIElement* m_pTopRightCorner;
    public ACBindingsTest.Internal.UIElement* m_pBottomLeftCorner;
    public ACBindingsTest.Internal.UIElement* m_pBottomRightCorner;
    public ACBindingsTest.Internal.UIElement* m_pTopBorder_Locked;
    public ACBindingsTest.Internal.UIElement* m_pLeftBorder_Locked;
    public ACBindingsTest.Internal.UIElement* m_pBottomBorder_Locked;
    public ACBindingsTest.Internal.UIElement* m_pRightBorder_Locked;
    public ACBindingsTest.Internal.UIElement* m_pTopLeftCorner_Locked;
    public ACBindingsTest.Internal.UIElement* m_pTopRightCorner_Locked;
    public ACBindingsTest.Internal.UIElement* m_pBottomLeftCorner_Locked;
    public ACBindingsTest.Internal.UIElement* m_pBottomRightCorner_Locked;

    // Methods

    /// <summary>Returns a UIElement pointer from a gmFloatyPowerBarUI instance based on the requested type identifier.
    /// <code>Offset: 0x004D1AA0
    /// UIElement* __thiscall gmFloatyPowerBarUI::DynamicCast(gmFloatyPowerBarUI*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The gmFloatyPowerBarUI object to cast.</param>
    /// <param name="i_eType">Identifier of the desired element type.</param>
    /// <returns>Pointer to the UIElement that matches i_eType. If i_eType is 268435539 or 268435471, returns the base UIElement; if i_eType is 3, returns the object itself; otherwise returns null.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, uint, ACBindingsTest.Internal.UIElement*>)0x004D1AA0)(ref this, i_eType);

    /// <summary>Updates the power‑bar UI to reflect a locked or unlocked state by activating or deactivating user interaction on its borders and corners.
    /// <code>Offset: 0x004D1B10
    /// void __thiscall gmFloatyPowerBarUI::UpdateLockedStatus(gmFloatyPowerBarUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, void>)0x004D1B10)(ref this);

    /// <summary>Registers the FloatyPowerBarUI element type with the UI system, allowing instances to be created and managed by the framework.
    /// <code>Offset: 0x004D1D10
    /// void __cdecl gmFloatyPowerBarUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D1D10)();

    /// <summary>Initializes the floaty power bar UI element by configuring its window ID, locating and storing references to border and corner sub‑elements (both normal and locked variants), registering notice handlers for power‑bar updates, and setting up global message handling.
    /// <code>Offset: 0x004D1D30
    /// void __thiscall gmFloatyPowerBarUI::PostInit(gmFloatyPowerBarUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, void>)0x004D1D30)(ref this);

    /// <summary>Handles global messages for the floaty power bar UI; updates lock status when a specific message is received.
    /// <code>Offset: 0x004D2020
    /// void __thiscall gmFloatyPowerBarUI::ListenToGlobalMessage(gmFloatyPowerBarUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="this">Pointer to the gmFloatyPowerBarUI instance receiving the message.</param>
    /// <param name="i_messageID">Identifier of the global message.</param>
    /// <param name="i_data_int">Additional integer data associated with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, uint, int, void>)0x004D2020)(ref this, i_messageID, i_data_int);

    /// <summary>Updates the floaty power bar UI to match current player settings, adjusting visibility, focus handling, and lock status based on chat window options and other player module properties.
    /// <code>Offset: 0x004D2030
    /// void __thiscall gmFloatyPowerBarUI::UpdateFromPlayerModule(gmFloatyPowerBarUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, void>)0x004D2030)(ref this);

    /// <summary>Resizes the floaty power bar UI to the specified width and height, updating its visual bounds and notifying the player module of the new dimensions when a window ID is set.
    /// <code>Offset: 0x004D2290
    /// void __thiscall gmFloatyPowerBarUI::ResizeTo(gmFloatyPowerBarUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_width">Desired width in pixels.</param>
    /// <param name="i_height">Desired height in pixels.</param>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, int, int, void>)0x004D2290)(ref this, i_width, i_height);

    /// <summary>Moves the float power bar UI element to the supplied x and y screen coordinates, clamping it within its parent container’s bounds.
    /// <code>Offset: 0x004D2400
    /// void __thiscall gmFloatyPowerBarUI::MoveTo(gmFloatyPowerBarUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">Target horizontal position for the UI element.</param>
    /// <param name="i_y">Target vertical position for the UI element.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, int, int, void>)0x004D2400)(ref this, i_x, i_y);

    /// <summary>Sets the visibility state of the floaty power bar UI element and updates the related chat window option in the player system.
    /// <code>Offset: 0x004D2600
    /// void __thiscall gmFloatyPowerBarUI::SetVisible(gmFloatyPowerBarUI*,bool)</code>
    /// </summary>
    /// <param name="i_fVisible">True to show the element, false to hide it.</param>
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, byte, void>)0x004D2600)(ref this, i_fVisible);

    /// <summary>Invokes a registered UI element callback to refresh the floaty power bar; ignores player quality and module arguments.
    /// <code>Offset: 0x004D71A0
    /// void __thiscall gmFloatyPowerBarUI::RecvNotice_PlayerDescReceived(gmFloatyPowerBarUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    /// <param name="i_playerDesc">Player qualities descriptor (unused).</param>
    /// <param name="i_playerModule">Player module information (unused).</param>
    public void RecvNotice_PlayerDescReceived(ACBindingsTest.Internal.CACQualities* i_playerDesc, ACBindingsTest.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyPowerBarUI, ACBindingsTest.Internal.CACQualities*, ACBindingsTest.Internal.CPlayerModule*, void>)0x004D71A0)(ref this, i_playerDesc, i_playerModule);
}

