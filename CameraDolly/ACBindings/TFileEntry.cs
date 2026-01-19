namespace ACBindingsTest.Internal;


/// <summary>
/// Represents a single file entry in the application's data system, encapsulating its path, name, unique identifier, database classification, type, authoritativeness status, and last modification time.
/// </summary>
public unsafe struct TFileEntry
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TFileEntry_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TFileEntry*, void> TFileEntry_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.PStringBase__sbyte m_pPath;
    public ACBindingsTest.Internal.PStringBase__sbyte m_pFileName;
    public ACBindingsTest.Internal.IDClass____tagDataID m_did;
    public uint m_dbtype;
    public ACBindingsTest.Internal.FileEntryType m_EntryType;
    public byte m_bAuthoritative;
    public int m_tFileWriteTime;

    // Methods

    /// <summary>Updates the file entry’s internal identifier to the value supplied via the provided pointer, managing reference counts for the old and new identifiers.
    /// <code>Offset: 0x006794B0
    /// LONG __thiscall TFileEntry::SetPath(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer containing the new identifier.</param>
    /// <returns>When the identifier changes, returns the incremented reference count of the new identifier; if unchanged, returns the existing identifier value.</returns>
    public int SetPath(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.TFileEntry, int*, int>)0x006794B0)(ref this, a2);
}

