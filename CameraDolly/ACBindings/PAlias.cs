namespace ACBindingsTest.Internal;


/// <summary>Captures alias information including identifier, associated value(s), numeric representation, header index, symbol form, and descriptive comments.</summary>
/// <remarks>Used within the system to map symbolic names to concrete values, facilitating code generation or debugging tasks that require detailed alias metadata.</remarks>
public unsafe struct PAlias
{
    // Members
    public ACBindingsTest.Internal.PStringBase__sbyte m_str;
    public ACBindingsTest.Internal.SmartArray___PStringBase__sbyte m_val;
    public ulong m_realVal;
    public ushort m_headerIndex;
    public ACBindingsTest.Internal.PStringBase__sbyte m_symbol;
    public ACBindingsTest.Internal.PStringBase__sbyte m_comment_string;
    public ACBindingsTest.Internal.PStringBase__sbyte m_gen_comment;

    // Methods
}

