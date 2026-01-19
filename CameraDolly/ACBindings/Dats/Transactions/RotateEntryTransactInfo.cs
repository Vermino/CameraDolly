namespace ACBindingsTest.Internal;


/// <summary>Captures transaction metadata for rotating a tree entry on disk, including parent offset, node index, sibling counts, and orientation flags.</summary>
public unsafe struct RotateEntryTransactInfo
{
    // Base Classes
    public ACBindingsTest.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindingsTest.Internal.DiskTransactInfo

    // Members
    public int m_nParentOffset;
    public ACBindingsTest.Internal.IDClass____tagDataID m_cEntryDID;
    public int m_nIndex;
    public int m_nNodeEntryCount;
    public int m_nSiblingEntryCount;
    public byte m_bLeftSibling;

    // Methods

    /// <summary>Serializes or deserializes RotateEntryTransactInfo data to and from an Archive according to the archive’s mode.
    /// <code>Offset: 0x00677800
    /// void __thiscall RotateEntryTransactInfo::Serialize(RotateEntryTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive handling the read/write of the transaction fields, including magic number, parent offset, entry ID, index, node/sibling counts, and left sibling flag.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RotateEntryTransactInfo, ACBindingsTest.Internal.Archive*, void>)0x00677800)(ref this, io_rcArchive);
}

