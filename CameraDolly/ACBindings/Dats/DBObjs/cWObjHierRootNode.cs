namespace ACBindingsTest.Internal;


/// <summary>Root node of a packed object hierarchy used by the database engine, handling allocation, packing, and unpacking of child nodes.</summary>
/// <remarks>Inherits from SerializeUsingPackDBObj for pack/unpack support and contains a cWObjHierNode to represent hierarchical data.</remarks>
public unsafe struct cWObjHierRootNode
{
    // Base Classes
    public ACBindingsTest.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindingsTest.Internal.SerializeUsingPackDBObj
    public ACBindingsTest.Internal.cWObjHierNode BaseClass_cWObjHierNode; // ACBindingsTest.Internal.cWObjHierNode

    // Child Types
    public unsafe struct cWObjHierRootNode_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Generated Constructor
    public cWObjHierRootNode(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Create a new cWObjHierRootNode instance and return its DBObj base.
    /// <code>Offset: 0x004F7C40
    /// DBObj* __cdecl cWObjHierRootNode::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the freshly allocated DBObj; returns nullptr on memory‑allocation failure.</returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004F7C40)();

    /// <summary>Initializes a new cWObjHierRootNode, resetting internal state and invoking base constructors.
    /// <code>Offset: 0x004FD360
    /// int __thiscall cWObjHierRootNode::cWObjHierRootNode(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the DBObj base class constructor.</param>
    /// <returns>The constructed cWObjHierRootNode instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.cWObjHierRootNode, void**, int>)0x004FD360)(ref this, a2);

    /// <summary>Packs the root node hierarchy into binary format, writing to the supplied buffer when it has sufficient space.
    /// <code>Offset: 0x004FD720
    /// unsigned int __thiscall cWObjHierRootNode::Pack(cWObjHierRootNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a location where packed data will be stored.</param>
    /// <param name="size">Maximum number of bytes that may be written to the buffer.</param>
    /// <returns>Number of bytes required to pack the root node hierarchy; the buffer contains packed data only if size is large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.cWObjHierRootNode, void**, uint, uint>)0x004FD720)(ref this, addr, size);

    /// <summary>Unpacks a serialized object hierarchy into the root node, advancing the input buffer pointer and validating size constraints.
    /// <code>Offset: 0x004FD750
    /// int __thiscall cWObjHierRootNode::UnPack(cWObjHierRootNode*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read location in the source buffer; updated to point past the consumed data on success.</param>
    /// <param name="size">Number of bytes remaining in the source buffer that may be consumed during unpacking.</param>
    /// <returns>1 if the buffer contains a complete, valid representation and unpacking succeeds; 0 otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.cWObjHierRootNode, void**, uint, int>)0x004FD750)(ref this, addr, size);
}

