namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an AllegianceNode instance, providing aligned storage and integration into the application’s allegiance data model.</summary>
public unsafe struct CAllegianceNode
{
    // Base Classes
    public ACBindingsTest.Internal.AllegianceNode BaseClass_AllegianceNode; // ACBindingsTest.Internal.AllegianceNode

    // Child Types
    public unsafe struct CAllegianceNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceNode*, void> CAllegianceNode_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceNode*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceNode*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceNode*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Methods
}

