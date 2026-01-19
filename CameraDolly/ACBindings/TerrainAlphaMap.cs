namespace ACBindingsTest.Internal;


/// <summary>Encapsulates terrain texture mapping data, linking a terrain code with its associated texture ID and image resource.</summary>
public unsafe struct TerrainAlphaMap
{
    // Members
    public uint tcode;
    public ACBindingsTest.Internal.IDClass____tagDataID tex_gid;
    public ACBindingsTest.Internal.ImgTex* texture;

    // Methods
}

