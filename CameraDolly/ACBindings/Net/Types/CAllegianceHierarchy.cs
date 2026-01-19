namespace ACBindingsTest.Internal;


/// <summary>
/// Encapsulates the core AllegianceHierarchy data structure, providing a managed container for hierarchical allegiances.
/// </summary>
public unsafe struct CAllegianceHierarchy
{
    // Base Classes
    public ACBindingsTest.Internal.AllegianceHierarchy BaseClass_AllegianceHierarchy; // ACBindingsTest.Internal.AllegianceHierarchy

    // Child Types
    public unsafe struct CAllegianceHierarchy_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceHierarchy*, void> CAllegianceHierarchy_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceHierarchy*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceHierarchy*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceHierarchy*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceHierarchy*, uint> GetMinPackSize; // function pointer

        // Methods
    }

    // Methods
}

