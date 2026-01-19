namespace ACBindingsTest.Internal;


/// <summary>Represents an entry in a hash table that maps unsigned integer keys to arbitrary data pointers, linked via the next field for chaining within a bucket.</summary>
public unsafe struct LongNIHashData
{
    // Members
    public ACBindingsTest.Internal.LongNIHashData* next;
    public System.IntPtr data;
    public uint key;

    // Methods
}

