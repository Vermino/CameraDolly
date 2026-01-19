namespace ACBindingsTest.Internal;


/// <summary>
/// Floating examination UI that displays item, character, or spell information in a movable and resizable window. The interface manages border and corner elements, synchronizes its position and size with the player module, and updates lock state to enable or disable dragging.
/// </summary>
public unsafe struct gmFloatyExaminationUI
{
    // Base Classes
    public ACBindingsTest.Internal.gmExaminationUI BaseClass_gmExaminationUI; // ACBindingsTest.Internal.gmExaminationUI

    // Child Types
    public unsafe struct gmFloatyExaminationUI_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmFloatyExaminationUI*, void> UpdateFromPlayerModule; // function pointer

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

    /// <summary>Tries to cast this gmFloatyExaminationUI instance to the type indicated by i_eType, returning a UIElement pointer if the cast is valid; otherwise returns null.
    /// <code>Offset: 0x004D4880
    /// UIElement* __thiscall gmFloatyExaminationUI::DynamicCast(gmFloatyExaminationUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The numeric identifier of the desired type (e.g., 3 for gmFloatyExaminationUI).</param>
    /// <returns>Pointer to the requested base class if compatible, or nullptr when the object cannot be cast to that type.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, uint, ACBindingsTest.Internal.UIElement*>)0x004D4880)(ref this, i_eType);

    /// <summary>
    /// Handles UI element messages for the floaty examination interface, performing cleanup when receiving a close message from its designated border element before delegating remaining processing to the base examination UI handler.
    /// 
    /// <code>Offset: 0x004D48F0
    /// UIElementMessageListenResult __thiscall gmFloatyExaminationUI::ListenToElementMessage(gmFloatyExaminationUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the incoming UI element message, including sender ID and message type.</param>
    /// <returns>Result of processing the message as determined by the base examination UI listener.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004D48F0)(ref this, i_rMsg);

    /// <summary>Updates the visual locked state of the examination UI borders and corners based on the current player lock status. When the UI is locked, normal border elements are deactivated and locked variants shown; when unlocked, the reverse occurs.
    /// <code>Offset: 0x004D4930
    /// void __thiscall gmFloatyExaminationUI::UpdateLockedStatus(gmFloatyExaminationUI*)</code>
    /// </summary>
    public void UpdateLockedStatus() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, void>)0x004D4930)(ref this);

    /// <summary>Registers the floaty examination UI element class with the UI system.
    /// <code>Offset: 0x004D4B30
    /// void __cdecl gmFloatyExaminationUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004D4B30)();

    /// <summary>Initializes the floaty examination UI by locating child elements for borders and corners, registering event handlers with the global event handler, and setting up global message listening.
    /// <code>Offset: 0x004D4B50
    /// void __thiscall gmFloatyExaminationUI::PostInit(gmFloatyExaminationUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, void>)0x004D4B50)(ref this);

    /// <summary>Synchronizes the floating examination UI with the current player module settings, updating focus, lock status, and other properties based on chat window options.
    /// <code>Offset: 0x004D4E80
    /// void __thiscall gmFloatyExaminationUI::UpdateFromPlayerModule(gmFloatyExaminationUI*)</code>
    /// </summary>
    /// <param name="this">The gmFloatyExaminationUI instance to update.</param>
    public void UpdateFromPlayerModule() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, void>)0x004D4E80)(ref this);

    /// <summary>Resizes the floaty examination UI element to the specified width and height, then propagates the new size to the associated chat window options in the player module.
    /// <code>Offset: 0x004D50A0
    /// void __thiscall gmFloatyExaminationUI::ResizeTo(gmFloatyExaminationUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_width">The desired width of the UI element.</param>
    /// <param name="i_height">The desired height of the UI element.</param>
    public void ResizeTo(int i_width, int i_height) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, int, int, void>)0x004D50A0)(ref this, i_width, i_height);

    /// <summary>Moves the floating examination UI to a new screen location, clamping it within its parent region when allowed by OnAction. After repositioning, updates the current player's chat window options to store the new coordinates.
    /// <code>Offset: 0x004D5210
    /// void __thiscall gmFloatyExaminationUI::MoveTo(gmFloatyExaminationUI*,const int,const int)</code>
    /// </summary>
    /// <param name="i_x">Desired X coordinate for the UI position.</param>
    /// <param name="i_y">Desired Y coordinate for the UI position.</param>
    public void MoveTo(int i_x, int i_y) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmFloatyExaminationUI, int, int, void>)0x004D5210)(ref this, i_x, i_y);
}

