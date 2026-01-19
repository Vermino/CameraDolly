namespace ACBindingsTest.Internal;


/// <summary>Provides a user interface component for selecting and displaying colors, tracking the currently selected RGBA value and the index of that selection within an underlying image surface.</summary>
public unsafe struct UIElement_ColorPicker
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement BaseClass_UIElement; // ACBindingsTest.Internal.UIElement

    // Child Types
    public unsafe struct UIElement_ColorPicker_vtbl
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
    public byte m_bDisplaySelection;
    public ACBindingsTest.Internal.RGBAColor m_rgbaCurrentSelected;
    public uint m_nCurrentSelection;

    // Generated Constructor
    public UIElement_ColorPicker(ACBindingsTest.Internal.LayoutDesc* i_layout, ACBindingsTest.Internal.ElementDesc* i_full_desc) {
        _ConstructorInternal(i_layout, i_full_desc);
    }

    // Methods

    /// <summary>Initializes a UIElement_ColorPicker instance using the supplied layout and element description. Sets default color to fully transparent and configures internal state for color selection handling.
    /// <code>Offset: 0x0046B0C0
    /// void __thiscall UIElement_ColorPicker::UIElement_ColorPicker(UIElement_ColorPicker*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="i_layout">Layout information describing size and elements of the UI region.</param>
    /// <param name="i_full_desc">Full element descriptor containing properties, states, and child elements for the picker.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* i_layout, ACBindingsTest.Internal.ElementDesc* i_full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x0046B0C0)(ref this, i_layout, i_full_desc);

    /// <summary>Attempts to cast the color picker to a UIElement when the requested type matches the expected identifier.
    /// <code>Offset: 0x0046B120
    /// UIElement* __thiscall UIElement_ColorPicker::DynamicCast(UIElement_ColorPicker*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The identifier of the desired element type; if it equals 16, casting succeeds.</param>
    /// <returns>A pointer to the object as a UIElement or null if the type does not match 16.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, uint, ACBindingsTest.Internal.UIElement*>)0x0046B120)(ref this, i_eType);

    /// <summary>Creates a new UIElement_ColorPicker instance configured by the provided layout and element descriptor.
    /// <code>Offset: 0x0046B140
    /// UIElement* __cdecl UIElement_ColorPicker::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout definition for the user interface containing dimensions, elements, and headers.</param>
    /// <param name="full_desc">Descriptor detailing the color picker element's properties such as ID, type, state, edges, and children.</param>
    /// <returns>Pointer to the newly constructed UIElement representing the color picker, or nullptr if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x0046B140)(layout, full_desc);

    /// <summary>Sets the current selected color of the color picker to the specified RGBA value, updating internal state and notifying listeners.
    /// <code>Offset: 0x0046B170
    /// bool __thiscall UIElement_ColorPicker::SetCurrentSelectedColor(UIElement_ColorPicker*,const RGBAColor*)</code>
    /// </summary>
    /// <param name="i_rgba">Color to select within the picker’s image surface.</param>
    /// <returns>True if the color was found and selection updated; otherwise false when the image or surface is missing or the color cannot be located.</returns>
    public byte SetCurrentSelectedColor(ACBindingsTest.Internal.RGBAColor* i_rgba) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.RGBAColor*, byte>)0x0046B170)(ref this, i_rgba);

    /// <summary>Converts a linear index into an RGBA color value from the color picker’s image, returning true when successful.
    /// <code>Offset: 0x0046B220
    /// bool __thiscall UIElement_ColorPicker::IndexToRGBA(UIElement_ColorPicker*,const unsigned int*,RGBAColor*)</code>
    /// </summary>
    /// <param name="i_index">Pointer to the unsigned integer representing the pixel offset in row-major order within the image.</param>
    /// <param name="o_rgbaVal">Pointer to an RGBAColor structure that receives the extracted color components.</param>
    /// <returns>True if the index is valid and a color could be retrieved; otherwise, false.</returns>
    public byte IndexToRGBA(uint* i_index, ACBindingsTest.Internal.RGBAColor* o_rgbaVal) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, uint*, ACBindingsTest.Internal.RGBAColor*, byte>)0x0046B220)(ref this, i_index, o_rgbaVal);

    /// <summary>Handles a mouse click on the color picker, determining which color tile was selected based on the click position and updating the current selection state.
    /// <code>Offset: 0x0046B280
    /// void __thiscall UIElement_ColorPicker::HandleMouseClick(UIElement_ColorPicker*,const tagPOINT*)</code>
    /// </summary>
    /// <param name="i_ptElement">The point of the mouse click relative to the element.</param>
    public void HandleMouseClick(ACBindingsTest.Internal.tagPOINT* i_ptElement) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.tagPOINT*, void>)0x0046B280)(ref this, i_ptElement);

    /// <summary>Determines whether the color picker element should be interactive with mouse input by combining its inherent visibility logic with a state-based restriction.
    /// <code>Offset: 0x0046B300
    /// bool __thiscall UIElement_ColorPicker::GetShouldBeMouseVisible(UIElement_ColorPicker*)</code>
    /// </summary>
    /// <returns>True if the base UIElement reports it should be visible or if the element’s state is not equal to 13; otherwise false.</returns>
    public byte GetShouldBeMouseVisible() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, byte>)0x0046B300)(ref this);

    /// <summary>Draws the color picker UI element onto the provided surface, highlighting the currently selected color if one exists.
    /// <code>Offset: 0x0046B320
    /// void __thiscall UIElement_ColorPicker::DrawSelf(_DWORD*,Box2D*,int,_DWORD*,UISurface*)</code>
    /// </summary>
    /// <param name="a2">Rectangle defining the drawable region for this element.</param>
    /// <param name="a3">Z‑level or draw order index passed to the base renderer.</param>
    /// <param name="a4">Additional drawing context flags forwarded to the base implementation.</param>
    /// <param name="a5">Target surface onto which rendering occurs.</param>
    public void DrawSelf(ACBindingsTest.Internal.Box2D* a2, int a3, int* a4, ACBindingsTest.Internal.UISurface* a5) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.Box2D*, int, int*, ACBindingsTest.Internal.UISurface*, void>)0x0046B320)(ref this, a2, a3, a4, a5);

    /// <summary>Processes a BaseProperty for the UIElement_ColorPicker, updating either its displayed selection flag or current selected RGBA color as appropriate.
    /// <code>Offset: 0x0046B440
    /// void __thiscall UIElement_ColorPicker::OnSetAttribute(UIElement_ColorPicker*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="i_attribute">The property to apply; supports the display-selection boolean and the current-selected-color value.</param>
    public void OnSetAttribute(ACBindingsTest.Internal.BaseProperty* i_attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.BaseProperty*, void>)0x0046B440)(ref this, i_attribute);

    /// <summary>Processes mouse click messages for the color picker, invoking its internal handler when the message targets this element and has ID 25; otherwise delegates handling to the base UIElement class.
    /// <code>Offset: 0x0046B4E0
    /// UIElementMessageListenResult __thiscall UIElement_ColorPicker::ListenToElementMessage(UIElement_ColorPicker*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the message received from the UI system.</param>
    /// <returns>The result of handling the message: 2 if processed locally, or the value returned by the base class when the message is not handled here.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x0046B4E0)(ref this, i_rMsg);

    /// <summary>Retrieves the properties available on a color picker element by first collecting those inherited from its base UIElement class and then adding the properties defined for the color picker property group.
    /// <code>Offset: 0x0046B510
    /// bool __thiscall UIElement_ColorPicker::InqAvailableProperties(UIElement_ColorPicker*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="o_set">A non‑null set that will receive all gathered properties; passing null causes the method to return false immediately.</param>
    /// <returns>True when both the base class query and the color picker property group query succeed; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindingsTest.Internal.AvailablePropertySet* o_set) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_ColorPicker, ACBindingsTest.Internal.AvailablePropertySet*, byte>)0x0046B510)(ref this, o_set);
}

