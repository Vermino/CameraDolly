namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a networked game entity, storing base class data, update timing, and managing network blobs for state synchronization.</summary>
public unsafe struct CWeenieObject
{
    // Base Classes
    public ACBindingsTest.Internal.LongHashData BaseClass_LongHashData; // ACBindingsTest.Internal.LongHashData
    public ACBindingsTest.Internal.NoticeRegistrar BaseClass_NoticeRegistrar; // ACBindingsTest.Internal.NoticeRegistrar

    // Statics
    public static ACBindingsTest.Internal.CObjectMaint** objMaint = (ACBindingsTest.Internal.CObjectMaint**)0x00842B98;

    // Child Types
    public unsafe struct CWeenieObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, void> CWeenieObject_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, void> ObjectBeingDeleted; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, void> process_netblobs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int, void> SetParentedState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsThePlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.ITEM_TYPE> InqType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsPlayerKiller; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsPK; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsPKLite; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsImpenetrable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsCreature; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, float, float*, byte> InqJumpVelocity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, float*, byte> InqRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, float*, byte> InqMaxRunRate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, float, byte> CanJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, float, int*, byte> JumpStaminaCost; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.CWeenieObject*, int> CanMoveInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> CanBypassMoveRestrictions; // function pointer
        public fixed byte gap4C[8];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.AtkCollisionProfile*, int> DoCollision; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, uint, void> DoCollisionEnd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.ObjCollisionProfile*, int> InqCollisionProfile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, void> ResetCollisions; // function pointer
        public System.IntPtr InqIconID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.PScriptType, float, int> PlayScript; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, uint> GetNumEmitters; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, ACBindingsTest.Internal.AC1Legacy.Vector3*, int> GetGlobalVelocity; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsHook; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsStorage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CWeenieObject*, int> IsCorpse; // function pointer

        // Methods
    }

    // Members
    public double update_time;
    public System.IntPtr netblob_list;
    public ACBindingsTest.Internal.TSRecv blobOrdering;

    // Methods

    /// <summary>Enqueues a NetBlob into the object's network blob ordering structure, scheduling it for later handling.
    /// <code>Offset: 0x00509F00
    /// void __thiscall CWeenieObject::queue_netblob(CWeenieObject*,unsigned int,NetBlob*)</code>
    /// </summary>
    /// <param name="inStamp">Timestamp or sequence identifier used to order the blob.</param>
    /// <param name="blob">The NetBlob to be queued.</param>
    public void queue_netblob(uint inStamp, ACBindingsTest.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CWeenieObject, uint, ACBindingsTest.Internal.NetBlob*, void>)0x00509F00)(ref this, inStamp, blob);

    /// <summary>Verifies that a received network blob matches the object's expected sequence and updates ordering state accordingly.
    /// <code>Offset: 0x00509F30
    /// int __thiscall CWeenieObject::fIsNextBlob(CWeenieObject*,unsigned int,NetBlob*,NetBlob**)</code>
    /// </summary>
    /// <param name="inStamp">Identifier for the incoming blob, used to determine if it is the next in order.</param>
    /// <param name="pBlob">The NetBlob instance being validated against the current ordering.</param>
    /// <param name="ppBlobIndicated">Output parameter set when the blob passes validation or indicates the next expected blob.</param>
    /// <returns>Non‑zero status code on success; zero if the blob is out of sequence or invalid.</returns>
    public int fIsNextBlob(uint inStamp, ACBindingsTest.Internal.NetBlob* pBlob, ACBindingsTest.Internal.NetBlob** ppBlobIndicated) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CWeenieObject, uint, ACBindingsTest.Internal.NetBlob*, ACBindingsTest.Internal.NetBlob**, int>)0x00509F30)(ref this, inStamp, pBlob, ppBlobIndicated);

    /// <summary>Queues a NetBlob for later transmission, creating the object's internal list when required.
    /// <code>Offset: 0x00509F50
    /// void __thiscall CWeenieObject::queue_netblob(CWeenieObject*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The network packet to enqueue; its reference count is increased before insertion.</param>
    public void queue_netblob(ACBindingsTest.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CWeenieObject, ACBindingsTest.Internal.NetBlob*, void>)0x00509F50)(ref this, blob);

    /// <summary>Processes queued network blobs by delivering ready entries to the UI event system and then freeing associated resources.
    /// <code>Offset: 0x00509FD0
    /// void __thiscall CWeenieObject::process_netblobs(CWeenieObject*)</code>
    /// </summary>
    public void process_netblobs() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CWeenieObject, void>)0x00509FD0)(ref this);
}

