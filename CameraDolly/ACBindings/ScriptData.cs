namespace ACBindingsTest.Internal;


/// <summary>Represents a timing node for executing physics scripts, holding the start time and pointer to the script along with linkage to subsequent nodes.</summary>
public unsafe struct ScriptData
{
    // Members
    public double start_time;
    public ACBindingsTest.Internal.PhysicsScript* script;
    public ACBindingsTest.Internal.ScriptData* next_data;

    // Methods
}

