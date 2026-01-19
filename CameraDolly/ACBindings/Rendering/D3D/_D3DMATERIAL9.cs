namespace ACBindingsTest.Internal;


/// <summary>Defines material properties used in rendering, including diffuse, ambient, specular and emissive color values, and a power factor.</summary>
public unsafe struct _D3DMATERIAL9
{
    // Members
    public ACBindingsTest.Internal._D3DCOLORVALUE Diffuse;
    public ACBindingsTest.Internal._D3DCOLORVALUE Ambient;
    public ACBindingsTest.Internal._D3DCOLORVALUE Specular;
    public ACBindingsTest.Internal._D3DCOLORVALUE Emissive;
    public float Power;

    // Methods
}

