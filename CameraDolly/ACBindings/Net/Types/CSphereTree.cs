namespace ACBindingsTest.Internal;


/// <summary>Organizes a hierarchy of spheres into two levels for efficient spatial queries, including a root sphere and linked arrays of level‑1 nodes and level‑2 sphere references.</summary>
/// <remarks>Serves as the data structure underlying collision detection or visibility culling in the application’s 3D engine.</remarks>
public unsafe struct CSphereTree
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct CSphereTree_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CSphereTree*, void> CSphereTree_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CSphereTree*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CSphereTree*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CSphereTree*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CSphere top_sphere;
    public ushort num_level1;
    public ACBindingsTest.Internal.CSphereNode* level1_spherenodes;
    public ushort num_level2;
    public ACBindingsTest.Internal.CSphere* level2_spheres;

    // Methods
}

