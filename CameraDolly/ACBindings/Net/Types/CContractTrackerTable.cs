namespace ACBindingsTest.Internal;


/// <summary>Provides a hashed collection of contract tracker entries keyed by unique identifier, enabling efficient lookup and management of active contracts.</summary>
public unsafe struct CContractTrackerTable : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct CContractTrackerTable_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CContractTrackerTable*, void> CContractTrackerTable_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CContractTrackerTable*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CContractTrackerTable*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CContractTrackerTable*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.PackableHashTable__uint___CContractTracker _contractTrackerHash;

    // Generated Constructor
    public CContractTrackerTable() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a CContractTrackerTable instance by clearing its internal hash table and freeing any allocated bucket memory.
    /// <code>Offset: 0x00560020
    /// void __thiscall CContractTrackerTable::~CContractTrackerTable(CContractTrackerTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CContractTrackerTable, void>)0x00560020)(ref this);

    /// <summary>Initializes a new contract tracker table, setting up its base object and internal hash table with default parameters.
    /// <code>Offset: 0x0059A250
    /// void __thiscall CContractTrackerTable::CContractTrackerTable(CContractTrackerTable*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CContractTrackerTable, void>)0x0059A250)(ref this);
}

