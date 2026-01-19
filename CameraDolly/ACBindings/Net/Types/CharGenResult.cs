namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a PackObj instance, providing aligned storage for serialized data within the application.</summary>
public unsafe struct CharGenResult
{
    // Base Classes
    public ACBindingsTest.Internal.PackObj BaseClass_PackObj; // ACBindingsTest.Internal.PackObj

    // Child Types
    public unsafe struct CharGenResult_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, void> CharGenResult_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, void**, uint, int> UnPack; // function pointer
        public System.IntPtr GetName;
        public System.IntPtr SetName;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, int> GetSlot; // function pointer
        public System.IntPtr GetClassID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, uint> GetStartArea; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, int> IsAdmin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, int> IsEnvoy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharGenResult*, int, int> VerifyCharacterGenerationResult; // function pointer

        // Methods
    }

    // Methods
}

