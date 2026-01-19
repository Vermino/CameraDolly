namespace ACBindingsTest.Internal;


/// <summary>Represents an aligned collection of LBRange objects stored within a PackableNIList, enabling efficient packing and quick access to range data.</summary>
public unsafe struct LBRanges
{
    // Base Classes
    public ACBindingsTest.Internal.PackableNIList___LBRange BaseClass_PackableNIList; // ACBindingsTest.Internal.PackableNIList___LBRange

    // Child Types
    public unsafe struct LBRanges_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBRanges*, void> LBRanges_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBRanges*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBRanges*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBRanges*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

