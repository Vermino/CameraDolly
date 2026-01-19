namespace ACBindingsTest.Internal;


/// <summary>Represents a node within a doubly‑linked list, providing pointers to the next and previous elements for bidirectional navigation.</summary>
public unsafe struct DLListData
{
    // Members
    public ACBindingsTest.Internal.DLListData* dllist_next;
    public ACBindingsTest.Internal.DLListData* dllist_prev;

    // Methods
}

