namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a Spell instance for transfer purposes, enabling the spell’s state to be serialized and passed between game systems or over a network.</summary>
public unsafe struct TransferSpell
{
    // Base Classes
    public ACBindingsTest.Internal.Spell BaseClass_Spell; // ACBindingsTest.Internal.Spell

    // Child Types
    public unsafe struct TransferSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, void> TransferSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, ACBindingsTest.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransferSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

