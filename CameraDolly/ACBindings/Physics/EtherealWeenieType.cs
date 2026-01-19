namespace ACBindingsTest.Internal;


/// <summary>Specifies which weenie types are ethereal versus solid, maintaining a bitmask of all relevant type identifiers and separate arrays for each category.</summary>
public unsafe struct EtherealWeenieType
{
    // Members
    public ulong m_wtype_mask;
    public ACBindingsTest.Internal.SmartArray__uint m_ethereal_list;
    public ACBindingsTest.Internal.SmartArray__uint m_solid_list;

    // Methods
}

