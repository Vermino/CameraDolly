namespace ACBindingsTest.Internal;


/// <summary>Encapsulates arguments for a blit operation, specifying source and destination buffer parameters, dimensions, mode, and an optional alpha modifier.</summary>
public unsafe struct BlitArgs
{
    // Members
    public ACBindingsTest.Internal.BlitMode eMode;
    public ACBindingsTest.Internal.BlitBufferArgs cSrcArgs;
    public ACBindingsTest.Internal.BlitBufferArgs cDstArgs;
    public uint nWidth;
    public uint nHeight;
    public byte i8AlphaModifier;

    // Methods
}

