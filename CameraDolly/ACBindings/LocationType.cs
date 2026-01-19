namespace ACBindingsTest.Internal;


/// <summary>Represents a spatial location tied to an object part, containing its unique hash, part identifier, and transformation frame.</summary>
public unsafe struct LocationType
{
    // Base Classes
    public ACBindingsTest.Internal.LongHashData BaseClass_LongHashData; // ACBindingsTest.Internal.LongHashData

    // Child Types
    public unsafe struct LocationType_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LocationType*, void> LocationType_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint part_id;
    public ACBindingsTest.Internal.Frame frame;

    // Methods
}

