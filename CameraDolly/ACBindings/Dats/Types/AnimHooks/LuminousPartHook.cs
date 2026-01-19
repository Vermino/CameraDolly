namespace ACBindingsTest.Internal;


/// <summary>Specifies a luminosity transition applied to a specific component of a physics object over time, storing part index, start/end brightness and duration for use by the animation system.</summary>
public unsafe struct LuminousPartHook
{
    // Base Classes
    public ACBindingsTest.Internal.CAnimHook BaseClass_CAnimHook; // ACBindingsTest.Internal.CAnimHook

    // Child Types
    public unsafe struct LuminousPartHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, void> LuminousPartHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, ACBindingsTest.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LuminousPartHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public uint part;
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Retrieves an integer that identifies this luminous part hook’s type.
    /// <code>Offset: 0x00527470
    /// int __thiscall LuminousPartHook::GetType(LuminousPartHook*)</code>
    /// </summary>
    /// <returns>An integer value used by the animation system to distinguish a LuminousPartHook instance from other hook types.</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.LuminousPartHook, int>)0x00527470)(ref this);

    /// <summary>Applies a luminosity transition to a specified component of a physics object over time.
    /// <code>Offset: 0x00527930
    /// void __thiscall LuminousPartHook::Execute(LuminousPartHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="object">The physics object whose part will receive the luminosity change.</param>
    public void Execute(ACBindingsTest.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.LuminousPartHook, ACBindingsTest.Internal.CPhysicsObj*, void>)0x00527930)(ref this, object_);
}

