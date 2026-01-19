namespace ACBindingsTest.Internal;


/// <summary>Represents a node in the behavior tree memory structure, storing timestamp, dirty status, pointers to adjacent nodes, offset data, and the core BTNode payload.</summary>
public unsafe struct BTMemNode
{
    // Members
    public int time_stamp_lm;
    public byte dirty_fm;
    public ACBindingsTest.Internal.BTMemNode* ahead_pm;
    public ACBindingsTest.Internal.BTMemNode* behind_pm;
    public int offset_m;
    public ACBindingsTest.Internal.BTNode node_m;

    // Methods
}

