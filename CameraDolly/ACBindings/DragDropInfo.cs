namespace ACBindingsTest.Internal;


/// <summary>Encapsulates information about a drag‑and‑drop operation within the UI system, tracking the involved element, its owner, potential catcher, and whether the transfer succeeded.</summary>
public unsafe struct DragDropInfo
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct DragDropInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DragDropInfo*, void> DragDropInfo_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement* element;
    public ACBindingsTest.Internal.UIElement* owner;
    public ACBindingsTest.Internal.UIElement* catcher;
    public byte success;

    // Methods
}

