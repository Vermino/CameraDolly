namespace ACBindingsTest.Internal;


/// <summary>Manages light state changes for physics objects within the animation system, storing desired on/off status and inheriting common hook behavior.</summary>
public unsafe struct SetLightHook
{
    // Base Classes
    public ACBindingsTest.Internal.CAnimHook BaseClass_CAnimHook; // ACBindingsTest.Internal.CAnimHook

    // Child Types
    public unsafe struct SetLightHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, void> SetLightHook_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, ACBindingsTest.Internal.CPhysicsObj*, void> Execute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, int> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, uint> pack_size; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.SetLightHook*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Members
    public int _lights_on;

    // Methods

    /// <summary>Sets the lighting state of a physics object according to the hook’s configuration.
    /// <code>Offset: 0x00527BD0
    /// void __thiscall SetLightHook::Execute(SetLightHook*,CPhysicsObj*)</code>
    /// </summary>
    /// <param name="this">The light hook instance.</param>
    /// <param name="object">Physics object whose lights will be updated.</param>
    public void Execute(ACBindingsTest.Internal.CPhysicsObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.SetLightHook, ACBindingsTest.Internal.CPhysicsObj*, void>)0x00527BD0)(ref this, object_);
}

