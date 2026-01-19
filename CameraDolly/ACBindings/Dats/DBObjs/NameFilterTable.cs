namespace ACBindingsTest.Internal;


/// <summary>
/// Maps language identifiers to name‑filter data entries, functioning as a database object that supports efficient retrieval of localized filtering rules within the system.
/// </summary>
public unsafe struct NameFilterTable
{
    // Base Classes
    public ACBindingsTest.Internal.DBObj BaseClass_DBObj; // ACBindingsTest.Internal.DBObj

    // Child Types
    public unsafe struct NameFilterTable_vtbl
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
    public ACBindingsTest.Internal.HashTable__uint___NameFilterLanguageData m_LanguageData;

    // Methods

    /// <summary>
    /// Allocates and constructs a new NameFilterTable object, initializing its base DBObj structure and internal language data hash table.
    /// 
    /// <code>Offset: 0x004F7D40
    /// DBObj* __cdecl NameFilterTable::Allocator()</code>
    /// </summary>
    /// <returns>
    /// Pointer to the newly constructed NameFilterTable cast as DBObj*, or nullptr if memory allocation fails.
    /// </returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004F7D40)();

    /// <summary>Serializes the NameFilterTable object to or from an Archive, delegating to its DBObj base class and handling the internal language‑data hash table based on the archive’s flags.
    /// <code>Offset: 0x00680900
    /// void __thiscall NameFilterTable::Serialize(NameFilterTable*,Archive*)</code>
    /// </summary>
    /// <param name="rArchive">The Archive instance used for serialization.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.NameFilterTable, ACBindingsTest.Internal.Archive*, void>)0x00680900)(ref this, rArchive);
}

