namespace ACBindingsTest.Internal;


/// <summary>
/// Stores metadata for a specific data type, including its name, root paths, and a hash table mapping data identifiers to file entries.
/// Maintains reference‑counted string buffers and supports efficient lookup of associated TFileEntry objects.
/// </summary>
public unsafe struct TDBTypeEntry : System.IDisposable
{
    // Members
    public byte bRecursed;
    public byte bRegistered;
    public ACBindingsTest.Internal.PStringBase__sbyte pRootGamePath;
    public ACBindingsTest.Internal.PStringBase__sbyte pRootEngPath;
    public ACBindingsTest.Internal.PStringBase__sbyte TypeName;
    public ACBindingsTest.Internal.IDClass____tagDataID HighestDIDAssigned;
    public ACBindingsTest.Internal.AutoGrowHashTable___IDClass____tagDataID___TFileEntry_ptr DIDs;

    // Generated Constructor
    public TDBTypeEntry() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a TDBTypeEntry instance, freeing its hash table of file entries and releasing any reference‑counted string buffers associated with the type name and root paths.
    /// <code>Offset: 0x0067A200
    /// void __thiscall TDBTypeEntry::~TDBTypeEntry(TDBTypeEntry*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.TDBTypeEntry, void>)0x0067A200)(ref this);

    /// <summary>Initializes a TDBTypeEntry instance by setting its string members to an empty state, establishing reference counts for the shared null buffer, and preparing an AutoGrowHashTable with a 2048-entry capacity for data ID mapping.
    /// <code>Offset: 0x0067B2A0
    /// void __thiscall TDBTypeEntry::TDBTypeEntry(TDBTypeEntry*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.TDBTypeEntry, void>)0x0067B2A0)(ref this);
}

