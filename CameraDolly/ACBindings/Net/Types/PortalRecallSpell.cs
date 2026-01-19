namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a base Spell instance used to represent portal‑recall spells within the game’s spell system.</summary>
public unsafe struct PortalRecallSpell
{
    // Base Classes
    public ACBindingsTest.Internal.Spell BaseClass_Spell; // ACBindingsTest.Internal.Spell

    // Child Types
    public unsafe struct PortalRecallSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, void> PortalRecallSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, ACBindingsTest.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalRecallSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Copies the contents of src into dst when both pointers are valid.
    /// <code>Offset: 0x00599A40
    /// void __thiscall PortalRecallSpell::SetEqual(PortalSendingSpell*,const Spell*,const Spell*)</code>
    /// </summary>
    /// <param name="dst">Destination spell to receive data.</param>
    /// <param name="src">Source spell providing new values.</param>
    public void SetEqual(ACBindingsTest.Internal.Spell* dst, ACBindingsTest.Internal.Spell* src) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PortalRecallSpell, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void>)0x00599A40)(ref this, dst, src);
}

