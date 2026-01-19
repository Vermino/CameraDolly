namespace ACBindingsTest.Internal;


/// <summary>Wraps an AllegianceData instance, providing a custom virtual table for polymorphic handling of alliance data within the system. Stores and manages alliance information such as name, title, membership status, and related metadata. Acts as a lightweight container that facilitates serialization and deserialization via PackObj functions.</summary>
public unsafe struct CAllegianceData
{
    // Base Classes
    public ACBindingsTest.Internal.AllegianceData BaseClass_AllegianceData; // ACBindingsTest.Internal.AllegianceData

    // Child Types
    public unsafe struct CAllegianceData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceData*, void> CAllegianceData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceData() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a new CAllegianceData instance and initializes its base AllegianceData subobject.
    /// <code>Offset: 0x0059A040
    /// void __thiscall CAllegianceData::CAllegianceData(CAllegianceData*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CAllegianceData, void>)0x0059A040)(ref this);
}

