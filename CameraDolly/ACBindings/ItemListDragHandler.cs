namespace ACBindingsTest.Internal;


/// <summary>Handles drag‑over logic for item lists in the UI, determining whether items or spells may be dropped onto a given element during a drag operation.</summary>
/// <param name="catchElement">The UI element that is currently under the mouse cursor.</param>
/// <param name="dropItemID">Identifier of the dragged item, if any.</param>
/// <param name="dropSpellID">Identifier of the dragged spell, if any.</param>
/// <param name="dropFlags">Additional flags describing the drag operation (e.g., copy or move).</param>
/// <returns>True if the drop is allowed onto this element; otherwise false.</returns>
public unsafe struct ItemListDragHandler
{
    // Child Types
    public unsafe struct ItemListDragHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ItemListDragHandler*, ACBindingsTest.Internal.UIElement_UIItem*, uint, uint, ACBindingsTest.Internal.DropItemFlags, byte> OnItemListDragOver; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Determines whether a dragged item or spell can be dropped onto the specified UI element during a drag‑over event.
    /// <code>Offset: 0x004A38F0
    /// bool __thiscall ItemListDragHandler::OnItemListDragOver(ItemListDragHandler*,UIElement_UIItem*,unsigned int,unsigned int,DropItemFlags)</code>
    /// </summary>
    /// <param name="catchElement">The UI element that is currently under the mouse cursor.</param>
    /// <param name="dropItemID">Identifier of the item being dragged, if any.</param>
    /// <param name="dropSpellID">Identifier of the spell being dragged, if any.</param>
    /// <param name="dropFlags">Additional flags describing the drag operation (e.g., copy or move).</param>
    /// <returns>True if the drop is allowed onto this element; otherwise false.</returns>
    public byte OnItemListDragOver(ACBindingsTest.Internal.UIElement_UIItem* catchElement, uint dropItemID, uint dropSpellID, ACBindingsTest.Internal.DropItemFlags dropFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ItemListDragHandler, ACBindingsTest.Internal.UIElement_UIItem*, uint, uint, ACBindingsTest.Internal.DropItemFlags, byte>)0x004A38F0)(ref this, catchElement, dropItemID, dropSpellID, dropFlags);
}

