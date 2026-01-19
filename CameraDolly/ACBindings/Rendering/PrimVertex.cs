namespace ACBindingsTest.Internal;


/// <summary>Represents a vertex used in primitive rendering, holding an origin point and one set of texture coordinates.</summary>
public unsafe struct PrimVertex
{
    // Members
    public ACBindingsTest.Internal.Vector3 m_vOrigin;
    public fixed byte m_UVs_Raw[8];
    public ACBindingsTest.Internal.TexCoordPair* m_UVs => (ACBindingsTest.Internal.TexCoordPair*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref m_UVs_Raw[0]);

    // Methods
}

