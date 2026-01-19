namespace ACBindingsTest.Internal;


/// <summary>Maintains an efficient association between identifier keys and enumeration values, enabling rapid lookup during runtime processing and data serialization.</summary>
public unsafe struct DualEnumIDMap
{
    // Base Classes
    public ACBindingsTest.Internal.EnumIDMap BaseClass_EnumIDMap; // ACBindingsTest.Internal.EnumIDMap

    // Child Types
    public unsafe struct DualEnumIDMap_vtbl
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
    public ACBindingsTest.Internal.HashTable___IDClass____tagDataID__uint m_IDToEnum;

    // Methods

    /// <summary>Translates a data identifier into its corresponding enumeration value using an internal hash table.
    /// <code>Offset: 0x00415CE0
    /// char __thiscall DualEnumIDMap::DIDToEnum(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The data identifier (ID) to look up.</param>
    /// <param name="a3">Receives the mapped enumeration value when the lookup succeeds.</param>
    /// <returns>Non‑zero if the ID was found and *a3 was set; zero otherwise.</returns>
    public sbyte DIDToEnum(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DualEnumIDMap, uint, int*, sbyte>)0x00415CE0)(ref this, a2, a3);

    /// <summary>Initializes the internal ID‑to‑enum hash table by copying mappings from the base enumeration tables, reporting errors if an ID appears more than once.
    /// <code>Offset: 0x00416180
    /// bool __thiscall DualEnumIDMap::InitLoad(DualEnumIDMap*)</code>
    /// </summary>
    /// <returns>True if all entries were inserted successfully; false if duplicate IDs were detected.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DualEnumIDMap, byte>)0x00416180)(ref this);

    /// <summary>Creates a new DualEnumIDMap instance, initializes its internal hash tables, and returns a pointer to the DBObj base component.
    /// <code>Offset: 0x004FB7E0
    /// DBObj* __thiscall DualEnumIDMap::Allocate(DualEnumIDMap*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj object, or nullptr if memory allocation fails.</returns>
    public ACBindingsTest.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DualEnumIDMap, ACBindingsTest.Internal.DBObj*>)0x004FB7E0)(ref this);
}

