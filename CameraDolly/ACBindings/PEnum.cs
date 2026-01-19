namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an enumeration entry, storing its name, header index, assignment status, scope flags (client/server/internal), symbol, source file, comment string, and a reference to related data node.</summary>
public unsafe struct PEnum
{
    // Members
    public ACBindingsTest.Internal.PStringBase__sbyte m_str;
    public ACBindingsTest.Internal._DEC988EAE5BED182094ACFC0893DFC8E ___u1;
    public ushort m_headerIndex;
    public byte m_assigned_value;
    public byte m_forced_value;
    public byte m_client;
    public byte m_server;
    public byte m_internal;
    public ACBindingsTest.Internal.PStringBase__sbyte m_symbol;
    public ACBindingsTest.Internal.PStringBase__sbyte m_filename;
    public ACBindingsTest.Internal.PStringBase__sbyte m_comment_string;
    public ACBindingsTest.Internal.PFileNode* m_data_node;

    // Methods
}

