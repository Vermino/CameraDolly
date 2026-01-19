namespace ACBindingsTest.Internal;


/// <summary>
/// Manages the graphical representation of an object by storing its geometry, materials, surfaces, physics polygons, spheres, BSP trees, bounding volumes, and identifiers for degradation.
/// </summary>
public unsafe struct CGfxObj
{
    // Base Classes
    public ACBindingsTest.Internal.DBObj BaseClass_DBObj; // ACBindingsTest.Internal.DBObj

    // Child Types
    public unsafe struct CGfxObj_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CMaterial* material;
    public uint num_surfaces;
    public ACBindingsTest.Internal.CSurface** m_rgSurfaces;
    public ACBindingsTest.Internal.CVertexArray vertex_array;
    public uint num_physics_polygons;
    public ACBindingsTest.Internal.CPolygon* physics_polygons;
    public ACBindingsTest.Internal.MeshBuffer* ructed_mesh;
    public int use_built_mesh;
    public ACBindingsTest.Internal.CSphere* physics_sphere;
    public ACBindingsTest.Internal.BSPTREE* physics_bsp;
    public ACBindingsTest.Internal.AC1Legacy.Vector3 sort_center;
    public uint num_polygons;
    public ACBindingsTest.Internal.CPolygon* polygons;
    public ACBindingsTest.Internal.CSphere* drawing_sphere;
    public ACBindingsTest.Internal.BSPTREE* drawing_bsp;
    public ACBindingsTest.Internal.BBox gfx_bound_box;
    public ACBindingsTest.Internal.IDClass____tagDataID m_didDegrade;

    // Methods

    /// <summary>Allocates memory for a new CGfxObj instance, initializes its members to default values, and returns a pointer to the base DBObj part of the object.
    /// <code>Offset: 0x004F7B10
    /// DBObj* __cdecl CGfxObj::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created CGfxObj instance cast as a DBObj; NULL if allocation fails.</returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004F7B10)();

    /// <summary>Enables UV animation for the object's constructed mesh and assigns the specified velocity vector to drive texture scrolling.
    /// <code>Offset: 0x00534F10
    /// bool __thiscall CGfxObj::TexVelocity(CGfxObj*,CVec2Duv)</code>
    /// </summary>
    /// <param name="delta">The 2D UV offset increment applied each frame, influencing how the texture scrolls over time.</param>
    /// <returns>True after configuring the UV animation; always returns true because configuration succeeds if a constructed mesh exists or simply succeeds otherwise.</returns>
    public byte TexVelocity(ACBindingsTest.Internal.CVec2Duv delta) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, ACBindingsTest.Internal.CVec2Duv, byte>)0x00534F10)(ref this, delta);

    /// <summary>Computes and stores the axis‑aligned bounding box for this graphics object based on its vertex array. When no vertices exist, both minimum and maximum bounds are initialized to zero vectors.
    /// <code>Offset: 0x00534F40
    /// void __thiscall CGfxObj::init_end(CGfxObj*)</code>
    /// </summary>
    public void init_end() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, void>)0x00534F40)(ref this);

    /// <summary>
    /// Releases all resources owned by the graphics object: deletes drawing and physics BSP trees, polygon arrays, physics sphere, vertex array, surface references, and the constructed mesh.
    /// 
    /// <code>Offset: 0x005352C0
    /// void __thiscall CGfxObj::Destroy(CGfxObj*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, void>)0x005352C0)(ref this);

    /// <summary>Prepares the graphics object for rendering by removing non‑portal nodes from its drawing BSP tree and attempting to build a runtime mesh, updating internal flags accordingly.
    /// <code>Offset: 0x005353F0
    /// bool __thiscall CGfxObj::InitLoad(CGfxObj*)</code>
    /// </summary>
    /// <returns>True when initialization completes; this implementation always returns true.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, byte>)0x005353F0)(ref this);

    /// <summary>Checks whether this object's physics representation collides with the spheres described in a transition. If no spheres exist, reports success; otherwise it tests each sphere for intersection and, depending on the insertion type, either performs an initial placement or queries the object's BSP tree for collisions.
    /// <code>Offset: 0x00535440
    /// TransitionState __thiscall CGfxObj::find_obj_collisions(CGfxObj*,CTransition*,float)</code>
    /// </summary>
    /// <param name="transition">The transition containing sphere data to test against the object.</param>
    /// <param name="scale">A scaling factor applied when evaluating collisions with the BSP tree.</param>
    /// <returns>A TransitionState value indicating success or collision status.</returns>
    public ACBindingsTest.Internal.TransitionState find_obj_collisions(ACBindingsTest.Internal.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, ACBindingsTest.Internal.CTransition*, float, ACBindingsTest.Internal.TransitionState>)0x00535440)(ref this, transition, scale);

    /// <summary>Collects qualified data identifiers from each surface of the graphics object and adds the object's degrade identifier to the supplied array.
    /// <code>Offset: 0x005355B0
    /// void __thiscall CGfxObj::GetSubDataIDs(CGfxObj*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The collection into which data IDs are inserted.</param>
    public void GetSubDataIDs(ACBindingsTest.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, ACBindingsTest.Internal.QualifiedDataIDArray*, void>)0x005355B0)(ref this, id_array);

    /// <summary>Serializes a CGfxObj's surfaces, vertex array, polygons and associated BSP trees into or from an Archive, allocating resources when loading.
    /// <code>Offset: 0x005356B0
    /// void __thiscall CGfxObj::Serialize(CGfxObj*,Archive*)</code>
    /// </summary>
    /// <param name="this">The graphics object instance to serialize.</param>
    /// <param name="io_archive">Archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CGfxObj, ACBindingsTest.Internal.Archive*, void>)0x005356B0)(ref this, io_archive);
}

