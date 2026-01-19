namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an error message transmitted in the DDD system, providing a message type identifier, unique data ID, and detailed client error information.</summary>
public unsafe struct DDD_ErrorMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_ErrorMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_ErrorMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.QualifiedDataID m_qdid;
    public ACBindingsTest.Internal.CliDatError m_eError;

    // Methods

    /// <summary>Serializes the error message data to or from an Archive, handling alignment and field ordering based on operation mode.
    /// <code>Offset: 0x004F8A70
    /// void __thiscall DDD_ErrorMessage::Serialize(DDD_ErrorMessage*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization; its flags determine whether fields are written or read.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DDD_ErrorMessage, ACBindingsTest.Internal.Archive*, void>)0x004F8A70)(ref this, io_archive);
}

