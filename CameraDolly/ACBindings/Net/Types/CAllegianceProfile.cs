namespace ACBindingsTest.Internal;


/// <summary>Represents an allegiance profile within the system, encapsulating alignment information and associated data for efficient memory usage.</summary>
public unsafe struct CAllegianceProfile
{
    // Base Classes
    public ACBindingsTest.Internal.AllegianceProfile BaseClass_AllegianceProfile; // ACBindingsTest.Internal.AllegianceProfile

    // Child Types
    public unsafe struct CAllegianceProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceProfile*, void> CAllegianceProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAllegianceProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CAllegianceProfile() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates a new CAllegianceProfile object by invoking its base AllegianceProfile constructor and setting the appropriate vtable.
    /// <code>Offset: 0x0059A080
    /// void __thiscall CAllegianceProfile::CAllegianceProfile(CAllegianceProfile*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CAllegianceProfile, void>)0x0059A080)(ref this);
}

