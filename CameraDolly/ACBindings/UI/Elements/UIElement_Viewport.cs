namespace ACBindingsTest.Internal;


/// <summary>
/// Viewport element provides a camera view into the game world, integrating rendering through CreatureMode while exposing standard UIElement behavior and hierarchy support.
/// </summary>
public unsafe struct UIElement_Viewport
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement BaseClass_UIElement; // ACBindingsTest.Internal.UIElement
    public ACBindingsTest.Internal.CreatureMode BaseClass_CreatureMode; // ACBindingsTest.Internal.CreatureMode

    // Child Types
    public unsafe struct UIElement_Viewport_vtbl
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

    // Methods

    /// <summary>Attempts to treat a UIElement_Viewport instance as a UIElement, returning the instance only when the requested type identifier equals 13.
    /// <code>Offset: 0x0046BD20
    /// UIElement* __thiscall UIElement_Viewport::DynamicCast(UIElement_Viewport*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The type identifier to test against; 13 indicates a UIElement match.</param>
    /// <returns>A pointer to this UIElement_Viewport casted as UIElement if i_eType is 13; otherwise null.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, uint, ACBindingsTest.Internal.UIElement*>)0x0046BD20)(ref this, i_eType);

    /// <summary>Creates a new UIElement_Viewport object initialized with the supplied layout and element description.
    /// <code>Offset: 0x0046BD40
    /// UIElement* __cdecl UIElement_Viewport::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Pointer to the LayoutDesc defining viewport dimensions and contained elements.</param>
    /// <param name="full_desc">Pointer to the ElementDesc describing the root element of the viewport.</param>
    /// <returns>A pointer to the newly created UIElement_Viewport instance, or nullptr if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x0046BD40)(layout, full_desc);

    /// <summary>Forwards a property assignment to the UIElement base class implementation for the viewport element.
    /// <code>Offset: 0x0046BD80
    /// void __thiscall UIElement_Viewport::OnSetAttribute(UIElement_Viewport*,const BaseProperty*)</code>
    /// </summary>
    /// <param name="attribute">The BaseProperty being applied to the viewport.</param>
    public void OnSetAttribute(ACBindingsTest.Internal.BaseProperty* attribute) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, ACBindingsTest.Internal.BaseProperty*, void>)0x0046BD80)(ref this, attribute);

    /// <summary>Create a new viewport UI object and assign it to the supplied output pointer; returns true on success.
    /// <code>Offset: 0x0046BDA0
    /// bool __thiscall UIElement_Viewport::MakeUIObject(UIElement_Viewport*,UIObject**)</code>
    /// </summary>
    /// <param name="o_pcUIObject">Receives the newly created UIObject instance; must be null before calling.</param>
    /// <returns>True if the UI object was successfully allocated and assigned; otherwise false.</returns>
    public byte MakeUIObject(ACBindingsTest.Internal.UIObject** o_pcUIObject) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, ACBindingsTest.Internal.UIObject**, byte>)0x0046BDA0)(ref this, o_pcUIObject);

    /// <summary>Initializes the UIElement_Viewport, setting up its creature mode by allocating an environment cell and assigning it to the creature_cell field; falls back to nullptr on allocation failure.
    /// <code>Offset: 0x0046BDF0
    /// void __thiscall UIElement_Viewport::PostInit(UIElement_Viewport*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, void>)0x0046BDF0)(ref this);

    /// <summary>Configures the viewport's camera by setting its world position and viewing direction.
    /// <code>Offset: 0x0046BE10
    /// void __thiscall UIElement_Viewport::SetCamera(UIElement_Viewport*,const Vector3*,const Vector3*)</code>
    /// </summary>
    /// <param name="position">Camera position in world coordinates.</param>
    /// <param name="direction">Direction vector representing where the camera looks.</param>
    public void SetCamera(ACBindingsTest.Internal.Vector3* position, ACBindingsTest.Internal.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, ACBindingsTest.Internal.Vector3*, ACBindingsTest.Internal.Vector3*, void>)0x0046BE10)(ref this, position, direction);

    /// <summary>Sets a single directional light on the viewport, replacing all previously configured lights.
    /// <code>Offset: 0x0046BE40
    /// void __thiscall UIElement_Viewport::SetLight(UIElement_Viewport*,LIGHTINFO::LightType,float,const Vector3*)</code>
    /// </summary>
    /// <param name="lightType">Specifies the type of light to add (e.g., point, spotlight).</param>
    /// <param name="intensity">The strength or brightness of the light.</param>
    /// <param name="direction">Pointer to a Vector3 defining the light's direction in world space.</param>
    public void SetLight(ACBindingsTest.Internal.LIGHTINFO.LightType lightType, float intensity, ACBindingsTest.Internal.Vector3* direction) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, ACBindingsTest.Internal.LIGHTINFO.LightType, float, ACBindingsTest.Internal.Vector3*, void>)0x0046BE40)(ref this, lightType, intensity, direction);

    /// <summary>Queries the set of available properties for a UIElement_Viewport, augmenting the supplied property set with viewport‑specific entries.
    /// <code>Offset: 0x0046BED0
    /// bool __thiscall UIElement_Viewport::InqAvailableProperties(UIElement_Viewport*,AvailablePropertySet*)</code>
    /// </summary>
    /// <param name="set">The collection into which viewport properties will be added; may be null, in which case the call fails.</param>
    /// <returns>True if the query succeeded and the set contains at least the base class properties plus any viewport properties; otherwise false.</returns>
    public byte InqAvailableProperties(ACBindingsTest.Internal.AvailablePropertySet* set) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.UIElement_Viewport, ACBindingsTest.Internal.AvailablePropertySet*, byte>)0x0046BED0)(ref this, set);
}

