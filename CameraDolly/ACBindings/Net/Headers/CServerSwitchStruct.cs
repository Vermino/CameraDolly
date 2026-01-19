namespace ACBindingsTest.Internal;


/// <summary>Tracks a server switch event by recording the time of occurrence and its classification.</summary>
/// <remarks>The dwSeqNo member stores a timestamp (CTimestamp) indicating when the switch was logged, while Type specifies the transition category via ServerSwitchType.</remarks>
public unsafe struct CServerSwitchStruct
{
    // Members
    public ACBindingsTest.Internal.CTimestamp__uint dwSeqNo;
    public ACBindingsTest.Internal.ServerSwitchType Type;

    // Methods
}

