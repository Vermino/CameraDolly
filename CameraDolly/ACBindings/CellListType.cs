namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a reference to an environment cell and the corresponding distance metric, enabling efficient proximity queries within the system.</summary>
public unsafe struct CellListType
{
    // Members
    public ACBindingsTest.Internal.CEnvCell* cell;
    public float dist;

    // Methods
}

