namespace ACBindingsTest.Internal;


/// <summary>Defines a Direct3D 9 light source with type, color properties, spatial position and direction, attenuation parameters, and cutoff angles for spotlights.</summary>
public unsafe struct _D3DLIGHT9
{
    // Members
    public ACBindingsTest.Internal._D3DLIGHTTYPE Type;
    public ACBindingsTest.Internal._D3DCOLORVALUE Diffuse;
    public ACBindingsTest.Internal._D3DCOLORVALUE Specular;
    public ACBindingsTest.Internal._D3DCOLORVALUE Ambient;
    public ACBindingsTest.Internal._D3DVECTOR Position;
    public ACBindingsTest.Internal._D3DVECTOR Direction;
    public float Range;
    public float Falloff;
    public float Attenuation0;
    public float Attenuation1;
    public float Attenuation2;
    public float Theta;
    public float Phi;

    // Methods
}

