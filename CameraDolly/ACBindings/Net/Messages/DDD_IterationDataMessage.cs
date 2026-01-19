namespace ACBindingsTest.Internal;


/// <summary>Holds iteration‑related information for distributed simulation messages, tracking total payload size, iteration metadata, and associated data messages.</summary>
public unsafe struct DDD_IterationDataMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_IterationDataMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_IterationDataMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbTotalData;
    public ACBindingsTest.Internal.MissingIteration m_IterationData;
    public ACBindingsTest.Internal.SmartArray___DDD_DataMessage_ptr m_Data;

    // Methods
}

