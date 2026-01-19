namespace ACBindingsTest.Internal;


/// <summary>Defines a second‑level attribute structure that combines a pack object header with an associated skill formula, facilitating compact storage and calculation of attribute data.</summary>
public unsafe struct Attribute2ndBase
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct Attribute2ndBase_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Attribute2ndBase*, void> Attribute2ndBase_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Attribute2ndBase*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Attribute2ndBase*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Attribute2ndBase*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SkillFormula _formula;

    // Methods
}

