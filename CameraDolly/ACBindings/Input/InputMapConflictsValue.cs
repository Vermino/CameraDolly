namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an input map identifier together with the list of other maps that conflict with it, aiding conflict resolution within the input handling subsystem.</summary>
public unsafe struct InputMapConflictsValue
{
    // Members
    public uint m_eInputMap;
    public ACBindingsTest.Internal.List__uint m_listConflictingInputMaps;

    // Methods
}

