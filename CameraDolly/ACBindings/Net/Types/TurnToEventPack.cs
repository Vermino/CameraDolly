namespace ACBindingsTest.Internal;


/// <summary>
/// Encapsulates a command to rotate toward an absolute heading, with the target degrees and execution flag bundled for event processing.
/// </summary>
public unsafe struct TurnToEventPack
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct TurnToEventPack_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TurnToEventPack*, void> TurnToEventPack_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TurnToEventPack*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TurnToEventPack*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TurnToEventPack*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float absolute_degrees;
    public int run;

    // Methods
}

