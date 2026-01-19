namespace ACBindingsTest.Internal;


/// <summary>Represents an object placement descriptor, linking a base class hash to its current animation frame for positioning in the scene.</summary>
public unsafe struct PlacementType
{
    // Base Classes
    public ACBindingsTest.Internal.LongHashData BaseClass_LongHashData; // ACBindingsTest.Internal.LongHashData

    // Child Types
    public unsafe struct PlacementType_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PlacementType*, void> PlacementType_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.AnimFrame anim_frame;

    // Methods
}

