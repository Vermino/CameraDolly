namespace ACBindingsTest.Internal;


/// <summary>Encapsulates flags and material properties that dictate how a surface is rendered, including lighting, fog, dye colors, ambient illumination, and alpha testing.</summary>
public unsafe struct MaterialGraphicsStatesType
{
    // Members
    public byte WantFFLighting;
    public byte WantFFDyeColorInTFactor;
    public byte WantFFSpecularLighting;
    public byte WantFFVertexDiffuse;
    public byte WantFFVertexSpecular;
    public byte WantFFDistanceFog;
    public ACBindingsTest.Internal.RGBAColor MaterialDiffuseColor;
    public ACBindingsTest.Internal.RGBAColor MaterialSpecularColor;
    public float MaterialSpecularPower;
    public ACBindingsTest.Internal.RGBAColor MaterialDyeColor;
    public ACBindingsTest.Internal.RGBAColor AmbientLight;
    public uint MaterialAlphaTestRef;

    // Methods
}

