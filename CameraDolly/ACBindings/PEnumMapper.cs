namespace ACBindingsTest.Internal;


/// <summary>Maintains mappings between enumeration values and their textual representations, including alias handling and case‑insensitive lookups. Supports inheritance depth and numbering strategies for flexible enum serialization.</summary>
public unsafe struct PEnumMapper
{
    // Child Types
    // PEnumMapper::NumberingType
    public enum NumberingType : byte
    {
        NORMAL_NUMBERING = 0x0,
        SEQUENTIAL_NUMBERING = 0x1,
        BITFIELD_NUMBERING = 0x2,
        BITFIELD32_NUMBERING = 0x3,
        BITFIELD64_NUMBERING = 0x4
    }

    // Members
    public ACBindingsTest.Internal.SmartArray___PEnum m_enum_array;
    public ACBindingsTest.Internal.SmartArray___PAlias m_alias_array;
    public ACBindingsTest.Internal.EnumMapper m_enum_mapper;
    public ACBindingsTest.Internal.AutoGrowHashTable___CaseInsensitiveStringBase___PStringBase__sbyte__uint m_all_mappings;
    public uint m_nextEnumValue;
    public uint m_inheritance_depth;
    public uint m_numbering_type;
    public byte m_allCode;

    // Methods
}

