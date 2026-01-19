namespace ACBindingsTest.Internal;


/// <summary>Manages a floating UI indicator overlay that displays borders, corners, and lock states for a chat window.</summary>
/// <remarks>Handles movement, resizing, visibility updates, and synchronization with player module options while registering event listeners for character session termination.</remarks>
public unsafe struct gmFloatyIndicatorsUI
{
    // Base Classes
    public ACBindingsTest.Internal.gmIndicatorsUI BaseClass_gmIndicatorsUI; // ACBindingsTest.Internal.gmIndicatorsUI

    // Child Types
    public unsafe struct gmFloatyIndicatorsUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmFloatyIndicatorsUI*, void> UpdateFromPlayerModule; // function pointer

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

    /// <summary>Attempts a dynamic cast of the current gmFloatyIndicatorsUI instance based on an integer type identifier.
    /// <code>Offset: 0x004D3B80
    /// UIElement* __thiscall gmFloatyIndicatorsUI::DynamicCast(gmFloatyIndicatorsUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The target type id used for casting.</param>
    /// <returns>A UIElement pointer matching the requested type, or nullptr if the type does not match supported values.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, uint, ACBindingsTest.Internal.UIElement*>)0x004D3B80)(ref this, i_eType);

    /// <summary>Ends the character session when a specific UI element sends a particular message, then delegates remaining handling to the base indicators UI class.
    /// <code>Offset: 0x004D3BF0
    /// UIElementMessageListenResult __thiscall gmFloatyIndicatorsUI::ListenToElementMessage(gmFloatyIndicatorsUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element message being processed.</param>
    /// <returns>The result from gmIndicatorsUI::ListenToElementMessage indicating whether the message was handled.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004D3BF0)(ref this, i_rMsg);

    /// <summary>Updates the floaty indicator UI to reflect whether the player module is locked, enabling or disabling the normal and locked border elements accordingly.
    /// <code>Offset: 0x004D3C20
    /// void __thiscall gmFloatyIndicatorsUI::UpdateLockedStatus(gmFloatyIndicatorsUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, void>)0x004D3C20)(ref this);

    /// <summary>Registers the Floaty Indicators UI element type with the UI system, linking a unique identifier to its creation routine for later instantiation.
    /// <code>Offset: 0x004D3E20
    /// void __cdecl gmFloatyIndicatorsUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D3E20)();

    /// <summary>Initializes the floaty indicators UI by locating and storing references to border and corner elements, reading the window ID attribute, registering notice handlers with the global event handler, and subscribing to a specific global message before completing initialization.
    /// <code>Offset: 0x004D3E40
    /// void __thiscall gmFloatyIndicatorsUI::PostInit(gmFloatyIndicatorsUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, void>)0x004D3E40)(ref this);

    /// <summary>Synchronizes the floaty indicator UI with player module options, applying focus and input changes based on chat window settings and updating lock state accordingly.
    /// <code>Offset: 0x004D4120
    /// void __thiscall gmFloatyIndicatorsUI::UpdateFromPlayerModule(gmFloatyIndicatorsUI*)</code>
    /// </summary>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, void>)0x004D4120)(ref this);

    /// <summary>Resizes the floaty indicator UI element to the specified dimensions and updates its chat window size if a window ID is assigned.
    /// <code>Offset: 0x004D4380
    /// void __thiscall gmFloatyIndicatorsUI::ResizeTo(gmFloatyIndicatorsUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_width">The new width in pixels for the indicator.</param>
    /// <param name="i_height">The new height in pixels for the indicator.</param>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, int, int, void>)0x004D4380)(ref this, i_width, i_height);

    /// <summary>Repositions the floaty indicator to a specified screen position, ensuring it stays within the bounds of its parent region and updating associated chat window options if applicable.
    /// <code>Offset: 0x004D44F0
    /// void __thiscall gmFloatyIndicatorsUI::MoveTo(gmFloatyIndicatorsUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">Target X coordinate for the indicator.</param>
    /// <param name="i_y">Target Y coordinate for the indicator.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, int, int, void>)0x004D44F0)(ref this, i_x, i_y);

    /// <summary>Sets the visibility state of the floaty indicator UI element and updates the player system’s chat window option when a valid window ID is present.
    /// <code>Offset: 0x004D46F0
    /// void __thiscall gmFloatyIndicatorsUI::SetVisible(gmFloatyIndicatorsUI*,bool)</code>
    /// </summary>
    /// <param name="i_fVisible">True to make the element visible; false hides it.</param>
    public void SetVisible(byte i_fVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyIndicatorsUI, byte, void>)0x004D46F0)(ref this, i_fVisible);
}

