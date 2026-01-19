namespace ACBindingsTest.Internal;


/// <summary>Iterates through child nodes of a PFileNode with mutable access, tracking the current position and applying an optional string filter.</summary>
public unsafe struct PFileNodeIter_NonConst
{
    // Members
    public ACBindingsTest.Internal.PFileNode* file_node;
    public uint curr_index;
    public ACBindingsTest.Internal.PStringBase__sbyte search_string;

    // Methods
}

