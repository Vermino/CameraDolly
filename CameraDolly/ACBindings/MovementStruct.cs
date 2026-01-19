namespace ACBindingsTest.Internal;


/// <summary>Encapsulates movement data for an entity, detailing its type, motion state, identifiers, spatial position, size attributes, and a reference to additional parameters.</summary>
public unsafe struct MovementStruct
{
    // Members
    public ACBindingsTest.Internal.MovementTypes.Type type;
    public uint motion;
    public uint object_id;
    public uint top_level_id;
    public ACBindingsTest.Internal.Position pos;
    public float radius;
    public float height;
    public ACBindingsTest.Internal.MovementParameters* params_;

    // Methods
}

