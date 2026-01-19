namespace ACBindingsTest.Internal;


/// <summary>
/// Encapsulates data for a house entity, including its unique identifier, hook usage status, version information, and associated group details within the packing system.
/// </summary>
public unsafe struct HouseWHouseData
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct HouseWHouseData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HouseWHouseData*, void> HouseWHouseData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HouseWHouseData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HouseWHouseData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HouseWHouseData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _wHouseIID;
    public int _iHooksInUse;
    public uint _version;
    public ACBindingsTest.Internal.HookGroupData _hookGroupData;

    // Methods
}

