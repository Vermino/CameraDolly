namespace ACBindingsTest.Internal;


/// <summary>Tracks historical iterations of data entries, maintaining metadata such as GUID stamps, file identifiers, and the current iteration state. Stores and manages a collection of iteration records in an auto‑growing hash table while supporting write operations through a dedicated interface.</summary>
public unsafe struct DataHistory
{
    // Child Types

    /// <summary>Tracks an individual data identifier within a history log, recording its qualified ID, size after compression, and the type of update performed.</summary>
    public unsafe struct DataIDHistoryData
    {
        // Members
        public ACBindingsTest.Internal.QualifiedDataID qdid;
        public uint cbCompressed;
        public ACBindingsTest.Internal.DataHistory.UpdateType utAction;

        // Methods
    }

    /// <summary>Holds information for a single iteration in the data history, including identifiers, compression statistics, and build context.</summary>
    public unsafe struct IterationData
    {
        // Members
        public ACBindingsTest.Internal.SmartArray___DataHistory_DataIDHistoryData m_IDs;
        public uint m_cbCompressed;
        public uint m_nIDsToPatch;
        public uint m_nIDsToPurge;
        public ACBindingsTest.Internal.DataHistory.IterationType m_IterationType;
        public int m_AliasedIteration;
        public ACBindingsTest.Internal.IterationKey m_Key;
        public ACBindingsTest.Internal.PStringBase__sbyte m_BuildString;

        // Methods
    }
    // DataHistory::IterationType
    public enum IterationType : byte
    {
        Normal_Iteration = 0x0,
        NoPatch_Iteration = 0x1,
        Alias_Iteration = 0x2,
        Invalid_IterationType = 0x3
    }
    // DataHistory::UpdateType
    public enum UpdateType : byte
    {
        utPatch = 0x0,
        utPurge = 0x1,
        utIgnore = 0x2,
        utInvalid = 0x3
    }

    /// <summary>Handles write‑only information for a history entry, storing the file name, the current iteration context, and a hash table for reverse data lookup.</summary>
    public unsafe struct WriteOnlyData
    {
        // Members
        public ACBindingsTest.Internal.PStringBase__ushort HistFileName;
        public ACBindingsTest.Internal.DataHistory.IterationData* pCurrentIteration;
        public ACBindingsTest.Internal.AutoGrowHashTable___QualifiedDataID__int BackHash;

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.AutoGrowHashTable__int___DataHistory_IterationData m_Iterations;
    public ACBindingsTest.Internal.CMostlyConsecutiveIntSet m_IterList;
    public ACBindingsTest.Internal.DatIDStamp m_guidStamp;
    public ulong m_CorrespondingDatFileID;
    public int m_idCurrentIteration;
    public byte m_bNewXPackMode;
    public ACBindingsTest.Internal.PStringBase__sbyte m_CurrentBuildString;
    public ACBindingsTest.Internal.DataHistory.WriteOnlyData* m_pWriteData;

    // Methods
}

