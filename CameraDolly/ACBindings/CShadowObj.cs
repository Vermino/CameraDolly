namespace ACBindingsTest.Internal;


/// <summary>Links a physics object to its spatial cell, storing unique identifiers for efficient collision detection and management.</summary>
/// <remarks>Used internally by the game engine's physics subsystem to track objects across cells.</remarks>
public unsafe struct CShadowObj
{
    // Base Classes
    public ACBindingsTest.Internal.LongHashData BaseClass_LongHashData; // ACBindingsTest.Internal.LongHashData

    // Child Types
    public unsafe struct CShadowObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CShadowObj*, void> CShadowObj_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CPhysicsObj* physobj;
    public uint cell_id;
    public ACBindingsTest.Internal.CObjCell* cell;

    // Methods

    /// <summary>Links a shadow object to a physics object and synchronizes its identity with that of the physics object.
    /// <code>Offset: 0x0051C660
    /// void __thiscall CShadowObj::set_physobj(CShadowObj*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="physobj">The physics object to associate with this shadow object.</param>
    public void set_physobj(ACBindingsTest.Internal.CPhysicsObj* physobj) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CShadowObj, ACBindingsTest.Internal.CPhysicsObj*, void>)0x0051C660)(ref this, physobj);
}

