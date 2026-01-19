namespace ACBindingsTest.Internal;


/// <summary>Defines encounter metadata for the game’s encounter system, holding a count of types, an array of EncounterType pointers, and a map buffer.</summary>
/// <remarks>Serves as a container for all encounter-related data required by runtime components.</remarks>
public unsafe struct CEncounterDesc
{
    // Members
    public uint num_encounter_type;
    public ACBindingsTest.Internal.EncounterType** encounter_table;
    public byte* encounter_map;

    // Methods

    /// <summary>Releases all resources associated with the encounter description, including allocated encounter types and map data. All EncounterType objects and their embedded buffers are properly deallocated before clearing internal pointers.
    /// <code>Offset: 0x00503440
    /// void __thiscall CEncounterDesc::Destroy(CEncounterDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEncounterDesc, void>)0x00503440)(ref this);
}

