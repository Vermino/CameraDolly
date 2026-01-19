namespace ACBindingsTest.Internal;


/// <summary>
/// Manages the player inventory interface by composing sub‑components for paper‑doll view, backpack list, 3‑D items panel and title text; handles event notifications to update UI state accordingly.
/// </summary>
public unsafe struct gmInventoryUI
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement_Field BaseClass_UIElement_Field; // ACBindingsTest.Internal.UIElement_Field
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmInventoryUI_vtbl
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
    public ACBindingsTest.Internal.gmPaperDollUI* m_paperDollUI;
    public ACBindingsTest.Internal.gmBackpackUI* m_backpackUI;
    public ACBindingsTest.Internal.gm3DItemsUI* m_3DItemsUI;
    public ACBindingsTest.Internal.UIElement_Text* m_titleText;

    // Generated Constructor
    public gmInventoryUI(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Methods

    /// <summary>Initializes an inventory UI instance with the supplied layout and element descriptions. Sets up the base UI element, configures notice handling callbacks, and clears sub‑component pointers for paper doll, backpack, 3D items, and title text.
    /// <code>Offset: 0x004A69E0
    /// void __thiscall gmInventoryUI::gmInventoryUI(gmInventoryUI*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout descriptor defining display size and elements.</param>
    /// <param name="full_desc">Full element description containing state, geometry, and child information.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x004A69E0)(ref this, layout, full_desc);

    /// <summary>Returns a UIElement pointer matching the requested type identifier; otherwise returns null.
    /// <code>Offset: 0x004A6A30
    /// UIElement* __thiscall gmInventoryUI::DynamicCast(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_eType">The unique type identifier used for casting.</param>
    /// <returns>A pointer to the corresponding UIElement, or nullptr if the type does not match.</returns>
    public ACBindingsTest.Internal.UIElement* DynamicCast(uint i_eType) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, ACBindingsTest.Internal.UIElement*>)0x004A6A30)(ref this, i_eType);

    /// <summary>Retrieves the unique UI element type identifier for the inventory UI.
    /// <code>Offset: 0x004A6A50
    /// unsigned int __thiscall gmInventoryUI::GetUIElementType(gmInventoryUI*)</code>
    /// </summary>
    /// <returns>The integer value representing the UI element type (e.g., 268435491).</returns>
    public uint GetUIElementType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint>)0x004A6A50)(ref this);

    /// <summary>Creates a new UI element representing the inventory user interface based on the supplied layout and element description.
    /// <code>Offset: 0x004A6A60
    /// UIElement* __cdecl gmInventoryUI::Create(const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Describes display dimensions, element headers, and state headers for the UI layout.</param>
    /// <param name="full_desc">Defines the root element’s properties, children, states, and visual appearance of the inventory UI.</param>
    /// <returns>A pointer to the newly constructed UIElement, or null if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.UIElement* Create(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, ACBindingsTest.Internal.UIElement*>)0x004A6A60)(layout, full_desc);

    /// <summary>Updates the backpack UI to reflect the character’s current load level using the supplied quality information.
    /// <code>Offset: 0x004A6A90
    /// void __thiscall gmInventoryUI::RecvNotice_UpdateCharacterInformation(gmInventoryUI*,const CACQualities*)</code>
    /// </summary>
    /// <param name="i_playerDesc">The player description containing updated character qualities and load data.</param>
    public void RecvNotice_UpdateCharacterInformation(ACBindingsTest.Internal.CACQualities* i_playerDesc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, ACBindingsTest.Internal.CACQualities*, void>)0x004A6A90)(ref this, i_playerDesc);

    /// <summary>Refreshes the inventory UI by rebuilding item lists when the active container changes and updating the character's paper‑doll view accordingly.
    /// <code>Offset: 0x004A6AC0
    /// void __thiscall gmInventoryUI::RecvNotice_SetDisplayInventory(gmInventoryUI*,int)</code>
    /// </summary>
    /// <param name="display">Requested inventory display index; currently unused but retained for compatibility with the notice system.</param>
    public void RecvNotice_SetDisplayInventory(int display) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, int, void>)0x004A6AC0)(ref this, display);

    /// <summary>Notifies the inventory UI that an item's attributes have changed. If the change applies to the currently selected target in SmartBox and includes the primary attribute flag, refreshes the character's paper doll inventory display.
    /// <code>Offset: 0x004A6B80
    /// void __thiscall gmInventoryUI::RecvNotice_ItemAttributesChanged(gmInventoryUI*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_target">Index of the item or target whose attributes were modified.</param>
    /// <param name="i_attrib">Bitmask describing which attributes changed; bit 0 indicates a primary update requiring UI refresh.</param>
    public void RecvNotice_ItemAttributesChanged(uint i_target, uint i_attrib) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, uint, void>)0x004A6B80)(ref this, i_target, i_attrib);

    /// <summary>Receives a server notice that an inventory item has moved, updates the UI to reflect the new container or location, and forwards the change to the paper‑doll view if present.
    /// <code>Offset: 0x004A6BB0
    /// void __thiscall gmInventoryUI::RecvNotice_ServerSaysMoveItem(gmInventoryUI*,unsigned int,unsigned int,unsigned int,unsigned int,unsigned int,int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="itemID">Identifier of the item being moved.</param>
    /// <param name="oldContainer">The ID of the container from which the item was removed.</param>
    /// <param name="oldWielder">The previous wielder (e.g., character or object) holding the item.</param>
    /// <param name="oldLocation">The prior location type of the item within its container.</param>
    /// <param name="newContainer">The ID of the container to which the item is moved.</param>
    /// <param name="place">Index or position within the new container where the item should appear.</param>
    /// <param name="newWielder">The new wielder that will hold the item after the move.</param>
    /// <param name="newLocation">The new location type of the item within its container.</param>
    public void RecvNotice_ServerSaysMoveItem(uint itemID, uint oldContainer, uint oldWielder, uint oldLocation, uint newContainer, int place, uint newWielder, uint newLocation) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, uint, uint, uint, uint, int, uint, uint, void>)0x004A6BB0)(ref this, itemID, oldContainer, oldWielder, oldLocation, newContainer, place, newWielder, newLocation);

    /// <summary>Completes a pending item transition in the player’s inventory UI by removing any pending items from the first registered item list and reassigning its parent container.
    /// <code>Offset: 0x004A6C20
    /// void __thiscall gmInventoryUI::RecvNotice_EndPendingInPlayer(gmInventoryUI*)</code>
    /// </summary>
    public void RecvNotice_EndPendingInPlayer() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, void>)0x004A6C20)(ref this);

    /// <summary>Initializes the inventory UI component by locating child elements such as the paper‑doll view, backpack pane, 3‑D items panel, and title text, then registers event handlers for a range of inventory‐related notifications.
    /// <code>Offset: 0x004A6CB0
    /// void __thiscall gmInventoryUI::PostInit(gmInventoryUI*)</code>
    /// </summary>
    public void PostInit() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, void>)0x004A6CB0)(ref this);

    /// <summary>Registers gmInventoryUI as a UI element type by adding its unique identifier and factory method to the UI registration system, enabling runtime creation of this UI component.
    /// <code>Offset: 0x004A6DD0
    /// void __cdecl gmInventoryUI::Register()</code>
    /// </summary>
    public static void Register() => ((delegate* unmanaged[Cdecl]<void>)0x004A6DD0)();

    /// <summary>Opens the container with the given ID in the inventory UI if it belongs to the player and meets activation criteria.
    /// <code>Offset: 0x004A6DF0
    /// void __thiscall gmInventoryUI::RecvNotice_OpenContainedContainer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_containerID">Identifier of the container to open.</param>
    public void RecvNotice_OpenContainedContainer(uint i_containerID) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, void>)0x004A6DF0)(ref this, i_containerID);

    /// <summary>Shows an inventory item as pending in the player’s UI when it is received but not yet fully added, inserting it into the item list if necessary.
    /// <code>Offset: 0x004A6EC0
    /// void __thiscall gmInventoryUI::RecvNotice_ShowPendingInPlayer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_itemID">The identifier of the item to mark as pending.</param>
    public void RecvNotice_ShowPendingInPlayer(uint i_itemID) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, void>)0x004A6EC0)(ref this, i_itemID);

    /// <summary>Updates the inventory UI title to reflect the current player and refreshes item lists when a player description notice is received.
    /// <code>Offset: 0x004A6F30
    /// void __thiscall gmInventoryUI::RecvNotice_PlayerDescReceived(gmInventoryUI*,const CACQualities*,const CPlayerModule*)</code>
    /// </summary>
    public void RecvNotice_PlayerDescReceived(ACBindingsTest.Internal.CACQualities* i_playerDesc, ACBindingsTest.Internal.CPlayerModule* i_playerModule) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, ACBindingsTest.Internal.CACQualities*, ACBindingsTest.Internal.CPlayerModule*, void>)0x004A6F30)(ref this, i_playerDesc, i_playerModule);

    /// <summary>Updates the inventory UI title to reflect the contents of the specified container, using a special label for the backpack or inserting the container’s name otherwise.
    /// <code>Offset: 0x004A7000
    /// void __thiscall gmInventoryUI::RecvNotice_NewParentContainer(gmInventoryUI*,unsigned int)</code>
    /// </summary>
    /// <param name="i_newContainerID">Identifier of the newly selected parent container.</param>
    public void RecvNotice_NewParentContainer(uint i_newContainerID) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmInventoryUI, uint, void>)0x004A7000)(ref this, i_newContainerID);
}

