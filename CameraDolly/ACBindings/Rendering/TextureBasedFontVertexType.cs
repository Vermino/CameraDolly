namespace ACBindingsTest.Internal;


/// <summary>Defines a single vertex used to render bitmap fonts, storing 3D origin, diffuse color, and texture mapping coordinates.</summary>
public unsafe struct TextureBasedFontVertexType
{
    // Members
    public ACBindingsTest.Internal.Vector3 Origin;
    public uint Diffuse;
    public ACBindingsTest.Internal.TexCoordPair TexCoord;

    // Methods
}

