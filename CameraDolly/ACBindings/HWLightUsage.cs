namespace ACBindingsTest.Internal;


/// <summary>Represents a hardware light usage record, indicating whether its state carries over, the light’s classification type, and its unique index.</summary>
public unsafe struct HWLightUsage
{
    // Members
    public byte carryOver;
    public int lightClass;
    public int index;

    // Methods
}

