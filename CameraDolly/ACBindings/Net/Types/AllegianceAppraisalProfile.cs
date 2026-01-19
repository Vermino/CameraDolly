namespace ACBindingsTest.Internal;


/// <summary>Encapsulates appraisal data for an allegiance, storing its name, primary and secondary titles, and follower count.</summary>
public unsafe struct AllegianceAppraisalProfile
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct AllegianceAppraisalProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AllegianceAppraisalProfile*, void> AllegianceAppraisalProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AllegianceAppraisalProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AllegianceAppraisalProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AllegianceAppraisalProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte m_AllegianceName;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte _mtitle;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte _ptitle;
    public int _followers;

    // Methods
}

