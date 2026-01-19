namespace ACBindingsTest.Internal;


/// <summary>Encapsulates all data necessary to describe an active player session, such as unique identifiers, display names, network address, and spatial coordinates. Serves as the primary structure exchanged during login, matchmaking, and state updates.</summary>
public unsafe struct FullPlayerData
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct FullPlayerData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FullPlayerData*, void> FullPlayerData_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FullPlayerData*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FullPlayerData*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FullPlayerData*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint bookieID;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte character_name;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte player_name;
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte ip_address;
    public ACBindingsTest.Internal.Position position;

    // Methods
}

