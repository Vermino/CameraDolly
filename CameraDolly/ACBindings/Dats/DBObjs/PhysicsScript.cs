namespace ACBindingsTest.Internal;


/// <summary>Encapsulates physics simulation data and configuration for a script object, storing serialized base properties, script‑specific data entries, and the script’s total length.</summary>
public unsafe struct PhysicsScript
{
    // Base Classes
    public ACBindingsTest.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindingsTest.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct PhysicsScript_vtbl
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

    // Members
    public ACBindingsTest.Internal.OldSmartArray___PhysicsScriptData_ptr script_data;
    public double length;

    // Methods

    /// <summary>Allocates and constructs a new DBObj instance configured for PhysicsScript, initializing virtual table pointers and default member values.
    /// <code>Offset: 0x004F7EB0
    /// DBObj* __cdecl PhysicsScript::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the initialized DBObj, or nullptr if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004F7EB0)();

    /// <summary>Retrieves the database object type identifier for physics script objects.
    /// <code>Offset: 0x005221F0
    /// unsigned int __thiscall PhysicsScript::GetDBOType(PhysicsScript*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the PhysicsScript DBO type (currently 43).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, uint>)0x005221F0)(ref this);

    /// <summary>Destroys a physics script by deleting all associated PhysicsScriptData entries, invoking each entry’s hook destructor when present, freeing allocated memory, and resetting internal state to zero.
    /// <code>Offset: 0x00522210
    /// void __thiscall PhysicsScript::Destroy(PhysicsScript*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, void>)0x00522210)(ref this);

    /// <summary>Collects sub-data identifiers from all script data hooks into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x00522280
    /// void __thiscall PhysicsScript::GetSubDataIDs(PhysicsScript*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive collected sub‑data IDs.</param>
    public void GetSubDataIDs(ACBindingsTest.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, ACBindingsTest.Internal.QualifiedDataIDArray*, void>)0x00522280)(ref this, id_array);

    /// <summary>Computes the byte count needed to pack all script hooks, accounting for per‑hook sizes and 4‑byte alignment, including a 4‑byte header.
    /// <code>Offset: 0x005222B0
    /// unsigned int __thiscall PhysicsScript::pack_size(PhysicsScript*)</code>
    /// </summary>
    /// <returns>The total size in bytes required for the packed representation.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, uint>)0x005222B0)(ref this);

    /// <summary>Serializes a PhysicsScript instance into a binary buffer, writing its timestamp followed by each associated animation hook's packed representation, then aligns the buffer to 4‑byte boundaries.
    /// <code>Offset: 0x00522300
    /// unsigned int __thiscall PhysicsScript::Pack(PhysicsScript*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that points to the current write position in the buffer; updated to the end of the written data upon successful packing.</param>
    /// <param name="size">Maximum number of bytes available for writing. If this is less than the required size, no data is written but the required packed size is still returned.</param>
    /// <returns>The total number of bytes that would be written if the buffer were large enough (the pack size).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, void**, uint, uint>)0x00522300)(ref this, addr, size);

    /// <summary>Unpacks serialized physics script data from the buffer pointed to by <paramref name="addr"/>, populating an internal array of PhysicsScriptData objects and sorting them for efficient access.
    /// <code>Offset: 0x005223D0
    /// int __thiscall PhysicsScript::UnPack(PhysicsScript*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="this">The PhysicsScript instance receiving the unpacked data.</param>
    /// <param name="addr">Pointer to a pointer that indicates the current read position within the input buffer. The function advances this pointer as it consumes data.</param>
    /// <param name="size">Size of the remaining buffer, passed to animation hook unpacking routines.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PhysicsScript, void**, uint, int>)0x005223D0)(ref this, addr, size);
}

