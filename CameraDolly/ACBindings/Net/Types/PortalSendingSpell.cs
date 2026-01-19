namespace ACBindingsTest.Internal;


/// <summary>Encapsulates the data required to send a spell across a portal, holding the spell’s fundamental properties through its base Spell component.</summary>
public unsafe struct PortalSendingSpell
{
    // Base Classes
    public ACBindingsTest.Internal.Spell BaseClass_Spell; // ACBindingsTest.Internal.Spell

    // Child Types
    public unsafe struct PortalSendingSpell_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, void> PortalSendingSpell_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, void**, uint, int> UnPack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, ACBindingsTest.Internal.Spell*, ACBindingsTest.Internal.Spell*, void> SetEqual; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, double> InqDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, double, int> SetDuration; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsEnchantmentSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsBoostSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsProjectileSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsTransferSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsDispelSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> IsFellowshipSpell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, ACBindingsTest.Internal.Enchantment*, int> BuildEnchantment; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> AffectsHealth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> AffectsStamina; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, int> AffectsMana; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PortalSendingSpell*, uint> pack_size; // function pointer

        // Methods
    }

    // Methods
}

