namespace ACBindingsTest.Internal;


/// <summary>Provides a container panel within the game's UI, handling child elements, visibility toggling, and notification callbacks for show/hide events.</summary>
/// <remarks>The struct inherits from <c>UIElement_Field</c> to integrate with the UI element hierarchy and implements <c>gmNoticeHandler</c> to receive global messages. It maintains an array of child panel information, tracks the currently displayed panel, and supports stretch mode adjustments during layout updates.</remarks>
public unsafe struct gmPanelUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindingsTest.Internal.UIElement_Field
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmPanelUI_vtbl
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

    /// <summary>Stores a reference to a UI element belonging to a panel and records the panel’s unique identifier for layout management.</summary>
    public unsafe struct PanelChildInfo
    {
        // Members
        public ACBindingsTest.Internal.UIElement* child;
        public uint panelID;

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SmartArray___gmPanelUI_PanelChildInfo m_childrenInfoArray;
    public ACBindingsTest.Internal.UIElement* m_currentlyShownPanel;
    public ACBindingsTest.Internal.UIElement* m_previouslyShownPanel;
    public ACBindingsTest.Internal.UIElement* m_pPanelPagesFrame;
    public byte m_bStretchMode;

    // Generated Constructor
    public gmPanelUI(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Handles element messages for the panel UI. When a message with ID 24 is received from one of its child elements, it updates that child's parent panel visibility based on the child's state flag; otherwise forwards the message to the base UIElement implementation.
    /// <code>Offset: 0x004BD300
    /// UIElementMessageListenResult __thiscall gmPanelUI::ListenToElementMessage(gmPanelUI*,const UIElementMessageInfo*)</code>
    /// </summary>
    /// <param name="i_rMsg">Information about the UI element event being processed, including source element and message type.</param>
    /// <returns>Result indicating whether the message was handled by this panel or passed to the base class.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(ACBindingsTest.Internal.UIElementMessageInfo* i_rMsg) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004BD300)(ref this, i_rMsg);

    /// <summary>Shows or hides a UI panel identified by its ID, updating internal references and notifying the system of visibility changes.
    /// <code>Offset: 0x004BD380
    /// void __thiscall gmPanelUI::RecvNotice_SetPanelVisibility(gmPanelUI*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="i_ePanelID">The identifier of the panel to be shown or hidden.</param>
    /// <param name="i_bVisible">True to display the panel; false to hide it.</param>
    public void RecvNotice_SetPanelVisibility(uint i_ePanelID, byte i_bVisible) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, uint, byte, void>)0x004BD380)(ref this, i_ePanelID, i_bVisible);

    /// <summary>Constructs a panel UI element from the supplied layout and element description, initializing internal structures and registering necessary callbacks.
    /// <code>Offset: 0x004BD510
    /// void __thiscall gmPanelUI::gmPanelUI(gmPanelUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing display dimensions and element mappings.</param>
    /// <param name="full_desc">Element descriptor containing visual and behavioral properties for the panel.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x004BD510)(ref this, layout, full_desc);

    /// <summary>Returns a pointer to the requested UIElement type if this gmPanelUI instance matches that type; otherwise returns null.
    /// <code>Offset: 0x004BD570
    /// UIElement* __thiscall gmPanelUI::DynamicCast(gmPanelUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">Identifier of the desired element type.</param>
    /// <returns>Pointer cast to UIElement, or nullptr when the type does not match.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, uint, ACBindingsTest.Internal.UIElement*>)0x004BD570)(ref this, i_eType);

    /// <summary>Retrieves the identifier for this panel’s UI element type.
    /// <code>Offset: 0x004BD590
    /// unsigned int __thiscall gmPanelUI::GetUIElementType(gmPanelUI*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the UI element type.</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, uint>)0x004BD590)(ref this);

    /// <summary>
    /// Creates a new panel UI element from the specified layout and element descriptors.
    /// 
    /// <code>Offset: 0x004BD5A0
    /// UIElement* __cdecl gmPanelUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor providing display dimensions, elements, and header strings.</param>
    /// <param name="full_desc">Root element descriptor defining the panel’s properties and children.</param>
    /// <returns>Pointer to the newly created UIElement instance, or nullptr if allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x004BD5A0)(layout, full_desc);

    /// <summary>Destroys a gmPanelUI object, releasing its child panels, unregistering from global messages, and cleaning up any dynamically allocated resources.
    /// <code>Offset: 0x004BD5D0
    /// void __thiscall gmPanelUI::~gmPanelUI(gmPanelUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, void>)0x004BD5D0)(ref this);

    /// <summary>Registers the gmPanelUI class as a UI element, enabling its creation through the UI system.
    /// <code>Offset: 0x004BD630
    /// void __cdecl gmPanelUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004BD630)();

    /// <summary>Collects predefined child UI elements, records their element pointers and associated panel IDs into the panel’s children info array, then unregisters any pending input action callbacks for each child.
    /// <code>Offset: 0x004BD670
    /// void __thiscall gmPanelUI::SetupChildren(gmPanelUI*)</code>
    /// </summary>
    public void SetupChildren() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, void>)0x004BD670)(ref this);

    /// <summary>Sets up the panel after construction by registering notice handlers with the global event system, adding a global message listener, building its child UI elements, and triggering the relevant input action callback according to whether a panel is currently displayed.
    /// <code>Offset: 0x004BDCA0
    /// void __thiscall gmPanelUI::PostInit(gmPanelUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmPanelUI, void>)0x004BDCA0)(ref this);
}

