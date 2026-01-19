namespace ACBindingsTest.Internal;


/// <summary>Provides parameters for alpha conversion operations, including source and destination buffer arguments along with the width and height of the area to process.</summary>
public unsafe struct AlphaConvertArgs
{
    // Members
    public ACBindingsTest.Internal.BlitBufferArgs cSrcArgs;
    public ACBindingsTest.Internal.BlitBufferArgs cDstArgs;
    public uint nWidth;
    public uint nHeight;

    // Methods
}

