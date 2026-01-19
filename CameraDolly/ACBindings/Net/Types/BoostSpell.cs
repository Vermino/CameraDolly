namespace ACBindingsTest.Internal;


/// <summary>Wraps a Spell instance for use when applying temporary boosts in gameplay scenarios.</summary>
public unsafe struct BoostSpell
{
    // Base Classes
    public ACBindingsTest.Internal.Spell BaseClass_Spell; // ACBindingsTest.Internal.Spell

    // Child Types
    public unsafe struct BoostSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, void> BoostSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, ACBindingsTest.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BoostSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Replaces the BoostSpell's current spell data with that of another Spell instance, ensuring proper cleanup before copying.
    /// <code>Offset: 0x00599FB0
    /// void __thiscall BoostSpell::SetEqual(BoostSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    /// <param name="dst">The Spell within the BoostSpell to be updated.</param>
    /// <param name="src">The source Spell whose state will be copied into dst.</param>
    public void SetEqual(ACBindingsTest.Internal.Spell* dst, ACBindingsTest.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BoostSpell, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void>)0x00599FB0)(ref this, dst, src);
}

