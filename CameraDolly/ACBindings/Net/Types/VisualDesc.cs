namespace ACBindingsTest.Internal;


/// <summary>Wraps a PackObj used for describing visual data packs in the system.</summary>
public unsafe struct VisualDesc
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct VisualDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VisualDesc*, void> VisualDesc_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VisualDesc*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VisualDesc*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VisualDesc*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VisualDesc*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

