namespace ACBindingsTest.Internal;


/// <summary>Represents file name references used to locate map assets such as height, terrain, scene, and encounter type data within the application.</summary>
public unsafe struct FileNameDesc : System.IDisposable
{
    // Members
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte height_map;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte terrain_map;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte scene_map;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte encounter_type_map;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a FileNameDesc instance by decrementing the reference counts on its string buffers and releasing each buffer when the count reaches zero.
    /// <code>Offset: 0x00501450
    /// void __thiscall FileNameDesc::~FileNameDesc(FileNameDesc*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.FileNameDesc, void>)0x00501450)(ref this);
}

