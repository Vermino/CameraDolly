namespace ACBindingsTest.Internal;


/// <summary>
/// Holds metadata and a collection of hook identifiers mapped to integer parameters, supporting serialization via PackObj.
/// </summary>
public unsafe struct HookGroupData
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct HookGroupData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HookGroupData*, void> HookGroupData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HookGroupData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HookGroupData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.HookGroupData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint _version;
    public ACBindingsTest.Internal.PackableHashTable__uint__int _data;

    // Methods
}

