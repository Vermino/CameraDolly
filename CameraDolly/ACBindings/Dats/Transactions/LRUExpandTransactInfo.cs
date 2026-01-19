namespace ACBindingsTest.Internal;


/// <summary>Manages metadata needed for expanding a least‑recently‑used (LRU) cache transaction, storing base disk transaction details, young offset, free block pointer, and the target data identifier.</summary>
public unsafe struct LRUExpandTransactInfo
{
    // Base Classes
    public ACBindingsTest.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindingsTest.Internal.DiskTransactInfo

    // Child Types
    public unsafe struct LRUExpandTransactInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.AddObjectTransactInfo*> DynamicCast_AddObject; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.DeleteLeafTransactInfo*> DynamicCast_DeleteLeaf; // function pointer
        public fixed byte gap14[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.DeleteInternalTransactInfo*> DynamicCast_DeleteInternal; // function pointer
        public fixed byte gap1C[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.MergeNodesTransactInfo*> DynamicCast_MergeNodes; // function pointer
        public fixed byte gap24[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.UpdateObjectTransactInfo*> DynamicCast_UpdateObject; // function pointer
        public fixed byte gap2C[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.SplitNodeTransactInfo*> DynamicCast_SplitNode; // function pointer
        public fixed byte gap34[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.RotateEntryTransactInfo*> DynamicCast_RotateEntry; // function pointer
        public fixed byte gap3C[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.LRUExpandTransactInfo*> DynamicCast_LRUExpand; // function pointer
        public fixed byte gap44[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LRUExpandTransactInfo*, ACBindingsTest.Internal.LRUDeleteTransactInfo*> DynamicCast_LRUDelete; // function pointer

        // Methods
    }

    // Members
    public int m_nYoungOffset;
    public int m_nFirstFreeBlock;
    public ACBindingsTest.Internal.IDClass____tagDataID m_cTargetDID;

    // Generated Constructor
    public LRUExpandTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes an LRUExpandTransactInfo instance for expanding disk transactions, setting type to LRU_EXPAND_TRANS, magic number, and resetting offsets and target ID.
    /// <code>Offset: 0x00677920
    /// void __thiscall LRUExpandTransactInfo::LRUExpandTransactInfo(LRUExpandTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.LRUExpandTransactInfo, void>)0x00677920)(ref this);
}

