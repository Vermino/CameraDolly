namespace ACBindingsTest.Internal;


/// <summary>Encapsulates environment state by storing the number of cells and a pointer array to cell structures, facilitating serialization via PackDBObj.</summary>
public unsafe struct CEnvironment
{
    // Base Classes
    public ACBindingsTest.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindingsTest.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CEnvironment_vtbl
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
    public uint num_cells;
    public ACBindingsTest.Internal.CCellStruct* cells;

    // Methods

    /// <summary>Creates a new database object tied to the environment, initializing its virtual tables and base‑class data.
    /// <code>Offset: 0x004F7C00
    /// DBObj* __cdecl CEnvironment::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj instance, or nullptr if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004F7C00)();

    /// <summary>Retrieves a reference to the cell structure located at the specified index within the environment's cell array.
    /// <code>Offset: 0x00531930
    /// CCellStruct* __thiscall CEnvironment::get_cellstruct(CEnvironment*,unsigned int)</code>
    /// </summary>
    /// <param name="index">Zero‑based position of the desired cell.</param>
    /// <returns>A pointer to the requested CCellStruct instance.</returns>
    public ACBindingsTest.Internal.CCellStruct* get_cellstruct(uint index) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEnvironment, uint, ACBindingsTest.Internal.CCellStruct*>)0x00531930)(ref this, index);

    /// <summary>
    /// Determines the byte size required to serialize all cells contained within this environment by repeatedly calling each cell’s Pack routine.
    /// 
    /// <code>Offset: 0x00531940
    /// unsigned int __thiscall CEnvironment::pack_size(CEnvironment*)</code>
    /// </summary>
    /// <returns>
    /// The aggregate number of bytes needed to pack the entire environment object, including its header and individual cell data.
    /// </returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEnvironment, uint>)0x00531940)(ref this);

    /// <summary>Serializes the environment into a contiguous buffer, writing a loaded flag followed by each cell’s packed data when available.
    /// <code>Offset: 0x005319D0
    /// unsigned int __thiscall CEnvironment::Pack(CEnvironment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current write location in the destination buffer; upon return it points just past the last byte written.</param>
    /// <param name="size">The number of bytes remaining in the destination buffer. If this is less than the required packed size, no data is written but the function still returns the needed size.</param>
    /// <returns>The total number of bytes that would be written for a complete pack (the packed size). The function writes data only when the supplied buffer has at least this many bytes remaining.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEnvironment, void**, uint, uint>)0x005319D0)(ref this, addr, size);

    /// <summary>Deserializes an environment from a binary stream, allocating and initializing its cell structures.
    /// <code>Offset: 0x00531A30
    /// int __thiscall CEnvironment::UnPack(CEnvironment*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Remaining size of the buffer (unused within this function but provided for consistency).</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEnvironment, void**, uint, int>)0x00531A30)(ref this, addr, size);

    /// <summary>Destroys the environment by freeing all cell structures and associated BSP trees, then resets the internal cell pointer and count to zero.
    /// <code>Offset: 0x00531AE0
    /// void __thiscall CEnvironment::Destroy(CEnvironment*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CEnvironment, void>)0x00531AE0)(ref this);
}

