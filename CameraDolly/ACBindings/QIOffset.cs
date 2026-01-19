namespace ACBindingsTest.Internal;


/// <summary>
/// Maps a unique GUID key to its corresponding integer offset, enabling efficient lookup of data positions.
/// </summary>
public unsafe struct QIOffset
{
    // Members
    public ACBindingsTest.Internal._GUID* key;
    public int ofs;

    // Methods
}

