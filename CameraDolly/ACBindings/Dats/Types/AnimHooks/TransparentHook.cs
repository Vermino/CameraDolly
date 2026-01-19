namespace ACBindingsTest.Internal;


/// <summary>Gradually changes a physics object’s translucency from a starting to an ending value over a defined time period.</summary>
public unsafe struct TransparentHook
{
    // Base Classes
    public ACBindingsTest.Internal.CAnimHook BaseClass_CAnimHook; // ACBindingsTest.Internal.CAnimHook

    // Child Types
    public unsafe struct TransparentHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, void> TransparentHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, ACBindingsTest.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.TransparentHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public float start;
    public float end;
    public float time;

    // Methods

    /// <summary>Transitions the given physics object's translucency from a starting value to an ending value over the specified duration.
    /// <code>Offset: 0x00527830
    /// void __thiscall TransparentHook::Execute(TransparentHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The TransparentHook instance specifying start, end, and time parameters for the transition.</param>
    /// <param name="object">The CPhysicsObj whose translucency is adjusted.</param>
    public void Execute(ACBindingsTest.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.TransparentHook, ACBindingsTest.Internal.CPhysicsObj*, void>)0x00527830)(ref this, object_);

    /// <summary>Gets the type identifier of a TransparentHook instance.
    /// <code>Offset: 0x00683760
    /// int __thiscall TransparentHook::GetType(TransparentHook*)</code>
    /// </summary>
    /// <returns>An integer constant that represents the hook's type, currently 20.</returns>
    public int GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.TransparentHook, int>)0x00683760)(ref this);
}

