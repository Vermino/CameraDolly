namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a data message transmitted through the system’s messaging infrastructure, holding a file identifier, a qualified data reference, optional compressed payload information, and iteration metadata for tracking state changes.</summary>
public unsafe struct DDD_DataMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_DataMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_DataMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ulong m_idDatFile;
    public ACBindingsTest.Internal.QualifiedDataID m_qdid;
    public ACBindingsTest.Internal.Cache_Pack_t m_cpData;
    public int m_idIteration;
    public byte m_bCompressed;

    // Generated Constructor
    public DDD_DataMessage() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Gets the size in bytes of the compressed payload stored within a data message, excluding any header or metadata.
    /// <code>Offset: 0x004F7F20
    /// unsigned int __thiscall DDD_DataMessage::GetCompressedSize(DDD_DataMessage*)</code>
    /// </summary>
    /// <returns>The length of the compressed data portion, or zero if the buffer holds insufficient data.</returns>
    public uint GetCompressedSize() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DDD_DataMessage, uint>)0x004F7F20)(ref this);

    /// <summary>Initializes a new DDD_DataMessage instance by setting its base message type to 63458 and preparing the internal cache pack with default values.
    /// <code>Offset: 0x004F8350
    /// void __thiscall DDD_DataMessage::DDD_DataMessage(DDD_DataMessage*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DDD_DataMessage, void>)0x004F8350)(ref this);

    /// <summary>Serializes a DDD_DataMessage to or from an Archive, handling alignment and conditional field access based on the archive's mode.
    /// <code>Offset: 0x004F8820
    /// void __thiscall DDD_DataMessage::Serialize(DDD_DataMessage*,Archive*)</code>
    /// </summary>
    /// <param name="this">The data message instance to serialize.</param>
    /// <param name="io_archive">Archive used for input or output; its flags indicate whether to read or write fields.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DDD_DataMessage, ACBindingsTest.Internal.Archive*, void>)0x004F8820)(ref this, io_archive);
}

