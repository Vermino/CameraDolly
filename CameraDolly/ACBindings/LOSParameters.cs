namespace ACBindingsTest.Internal;


/// <summary>Encapsulates parameters for a line‑of‑sight (LOS) calculation in the physics engine, tracking traversal state, intersection results, and related spatial data.</summary>
public unsafe struct LOSParameters
{
    // Members
    public ACBindingsTest.Internal.EtherealWeenieType m_weenie_LOS;
    public ACBindingsTest.Internal.EtherealPhysicsType m_physics_LOS;
    public ACBindingsTest.Internal.RayIntersectionType.Type m_intersect_type;
    public int m_bTraversePortals;
    public int m_bCheckedOutside;
    public uint m_initial_cell_id;
    public ACBindingsTest.Internal.Ray m_initial_ray;
    public ACBindingsTest.Internal.Ray m_current_ray;
    public uint m_current_cell_id;
    public float m_delta;
    public uint m_trace_result;
    public uint m_final_cell_id;
    public ACBindingsTest.Internal.Ray m_final_ray;
    public ACBindingsTest.Internal.Vector3 m_impact_normal;
    public uint m_portal_index;
    public ACBindingsTest.Internal.LandDefs.Direction m_dir;
    public uint m_next_block_id;

    // Methods
}

