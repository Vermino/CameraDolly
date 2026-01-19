namespace ACBindingsTest.Internal;


/// <summary>Entry in the alpha rendering queue, holding mesh buffer, associated surface and material, transformation matrix, and flags indicating a newly added object or clipmap override.</summary>
public unsafe struct AlphaListEntry
{
    // Members
    public ACBindingsTest.Internal.MeshBuffer* pMeshBuffer;
    public int surfaceNum;
    public ACBindingsTest.Internal.CSurface* surface;
    public ACBindingsTest.Internal.CMaterial* material;
    public ACBindingsTest.Internal.Matrix4 worldMatrix;
    public byte bNewObject;
    public byte overrideClipmapSetting;

    // Methods
}

