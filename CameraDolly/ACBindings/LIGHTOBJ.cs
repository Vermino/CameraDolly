namespace ACBindingsTest.Internal;


/// <summary>Represents a single lighting element within the rendering system, linking to detailed light parameters via LIGHTINFO, positioning it with a global offset Frame, and tracking its operational state.</summary>
public unsafe struct LIGHTOBJ
{
    // Members
    public ACBindingsTest.Internal.LIGHTINFO* lightinfo;
    public ACBindingsTest.Internal.Frame global_offset;
    public int state;

    // Methods
}

