namespace ACBindingsTest.Internal;


/// <summary>Node in a doubly linked list that stores an unsigned identifier and links to adjacent nodes.</summary>
public unsafe struct IDListNode
{
    // Members
    public uint id;
    public ACBindingsTest.Internal.IDListNode* prev;
    public ACBindingsTest.Internal.IDListNode* next;

    // Methods
}

