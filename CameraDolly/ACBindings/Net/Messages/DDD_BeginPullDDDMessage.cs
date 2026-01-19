namespace ACBindingsTest.Internal;


/// <summary>Initiates a pull operation by specifying the expected data size, the iterations to retrieve, and their corresponding keys.</summary>
public unsafe struct DDD_BeginPullDDDMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_BeginPullDDDMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_BeginPullDDDMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_cbDataExpected;
    public ACBindingsTest.Internal.SmartArray___QualifiedIteration m_IterationsToDownload;
    public ACBindingsTest.Internal.HashTable___QualifiedIteration___IterationKey m_Keys;

    // Methods
}

