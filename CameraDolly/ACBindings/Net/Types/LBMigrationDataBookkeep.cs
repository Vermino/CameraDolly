namespace ACBindingsTest.Internal;


/// <summary>Tracks migration state for a simulation region, including block identifiers, checkpoint timestamps, and event queues used during load‑balancing operations.</summary>
public unsafe struct LBMigrationDataBookkeep
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct LBMigrationDataBookkeep_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBMigrationDataBookkeep*, void> LBMigrationDataBookkeep_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBMigrationDataBookkeep*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBMigrationDataBookkeep*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LBMigrationDataBookkeep*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.LBRange region;
    public int numBlksWithObjects;
    public uint* lbIDs;
    public double* m_rgCheckpointTimes;
    public int numEvQueues;
    public ACBindingsTest.Internal.LBEventQueue* lbEvqs;

    // Methods
}

