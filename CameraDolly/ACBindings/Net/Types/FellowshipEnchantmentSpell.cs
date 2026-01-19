namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an EnchantmentSpell instance, serving as a distinct type within the system.</summary>
public unsafe struct FellowshipEnchantmentSpell
{
    // Base Classes
    public ACBindingsTest.Internal.EnchantmentSpell BaseClass_EnchantmentSpell; // ACBindingsTest.Internal.EnchantmentSpell

    // Child Types
    public unsafe struct FellowshipEnchantmentSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, void> FellowshipEnchantmentSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, ACBindingsTest.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.FellowshipEnchantmentSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

