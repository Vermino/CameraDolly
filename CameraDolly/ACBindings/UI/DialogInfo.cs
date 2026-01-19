namespace ACBindingsTest.Internal;


/// <summary>Holds metadata and references required by a dialog component, including its property collection, runtime instance, owning framework, and contextual identifier.</summary>
public unsafe struct DialogInfo
{
    // Members
    public ACBindingsTest.Internal.PropertyCollection data;
    public ACBindingsTest.Internal.Dialog* pointer;
    public ACBindingsTest.Internal.UIFramework* parent;
    public uint context;

    // Methods
}

