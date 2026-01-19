namespace ACBindingsTest.Internal;


/// <summary>Represents a node in the physics system’s hook chain, holding timing data and linkage for callbacks. Stores creation time, interpolation parameters, and optional user data used during physics processing.</summary>
public unsafe struct PhysicsObjHook
{
    // Child Types

    /// <summary>Virtual function table for PhysicsObjHook, exposing an Execute callback that processes CPhysicsObj instances.</summary>
    public unsafe struct PhysicsObjHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.PhysicsObjHook*, ACBindingsTest.Internal.CPhysicsObj*, int> Execute; // function pointer

        // Methods
    }
    // PhysicsObjHook::HookType
    public enum HookType : uint
    {
        CSetup = 0x1,
        MTABLE = 0x2,
        VELOCITY = 0x4,
        ACCELERATION = 0x8,
        OMEGA = 0x10,
        PARENT = 0x20,
        CHILDREN = 0x40,
        OBJSCALE = 0x80,
        FRICTION = 0x100,
        ELASTICITY = 0x200,
        TIMESTAMPS = 0x400,
        STABLE = 0x800,
        PETABLE = 0x1000,
        DEFAULT_SCRIPT = 0x2000,
        DEFAULT_SCRIPT_INTENSITY = 0x4000,
        POSITION = 0x8000,
        MOVEMENT = 0x10000,
        ANIMFRAME_ID = 0x20000,
        TRANSLUCENCY = 0x40000,
        FORCE_PhysicsDescInfo_32_BIT = 0x7FFFFFFF
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindingsTest.Internal.PhysicsObjHook.HookType hook_type;
    public double time_created;
    public double interpolation_time;
    public ACBindingsTest.Internal.PhysicsObjHook* prev;
    public ACBindingsTest.Internal.PhysicsObjHook* next;
    public System.IntPtr user_data;

    // Methods
}

