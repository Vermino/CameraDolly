namespace ACBindingsTest.Internal;


/// <summary>Tracks the state of an individual quest, maintaining timing information and completion statistics for game logic synchronization.</summary>
public unsafe struct QuestProfile
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct QuestProfile_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.QuestProfile*, void> QuestProfile_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.QuestProfile*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.QuestProfile*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.QuestProfile*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public double _last_update;
    public int _real_time;
    public uint _num_completions;

    // Methods
}

