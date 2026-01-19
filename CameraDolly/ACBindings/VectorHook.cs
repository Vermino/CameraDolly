namespace ACBindingsTest.Internal;


/// <summary>Represents a physics object hook linking to a base entity, specifying a directed line from a start vector to an end vector within the legacy AC1 coordinate system.</summary>
public unsafe struct VectorHook
{
    // Base Classes
    public ACBindingsTest.Internal.PhysicsObjHook BaseClass_PhysicsObjHook; // ACBindingsTest.Internal.PhysicsObjHook

    // Child Types
    public unsafe struct VectorHook_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.VectorHook*, ACBindingsTest.Internal.CPhysicsObj*, int> Execute; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.AC1Legacy.Vector3 start_vector;
    public ACBindingsTest.Internal.AC1Legacy.Vector3 end_vector;

    // Methods
}

