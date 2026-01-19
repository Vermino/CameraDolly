namespace ACBindingsTest.Internal;


/// <summary>Provides sorting information for an object cell, holding the base cell data and an optional building reference for ordering decisions.</summary>
public unsafe struct CSortCell
{
    // Base Classes
    public ACBindingsTest.Internal.CObjCell BaseClass_CObjCell; // ACBindingsTest.Internal.CObjCell

    // Child Types
    public unsafe struct CSortCell_vtbl
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
        public fixed byte gap58[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CEnvCell*> GetAsEnvCell; // function pointer
        public fixed byte gap60[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CLandCell*> GetAsLandCell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.BoundingType> IsInView; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.AC1Legacy.Vector3*, float> GetViewerDistance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, void> grab_visible_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, void> release_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, uint, ACBindingsTest.Internal.CPhysicsObj*> get_object; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.Position*, uint, ACBindingsTest.Internal.CSphere*, ACBindingsTest.Internal.CELLARRAY*, ACBindingsTest.Internal.SPHEREPATH*, void> find_transit_cells; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.AC1Legacy.Vector3*, int> point_in_cell; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CTransition*, ACBindingsTest.Internal.TransitionState> find_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CTransition*, ACBindingsTest.Internal.TransitionState> find_env_collisions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CTransition*, int> handle_move_restriction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.CPolygon*, ACBindingsTest.Internal.Position*, ACBindingsTest.Internal.SURFCHAR> walkable_surface_type; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, ACBindingsTest.Internal.LOSParameters*, uint> Trace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CObjCell*, void> init_static_objects; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CBuildingObj* building;

    // Generated Constructor
    public CSortCell() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a CSortCell object by constructing its base cell components and resetting the building pointer to null.
    /// <code>Offset: 0x00534CF0
    /// void __thiscall CSortCell::CSortCell(CSortCell*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, void>)0x00534CF0)(ref this);

    /// <summary>Determines whether the cell currently contains a building object.
    /// <code>Offset: 0x00534D40
    /// int __thiscall CSortCell::has_building(CSortCell*)</code>
    /// </summary>
    /// <returns>Non‑zero when a building is present; zero indicates no building.</returns>
    public int has_building() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, int>)0x00534D40)(ref this);

    /// <summary>Associates the specified building object with the sort cell, assigning it only if no building is currently linked.
    /// <code>Offset: 0x00534D70
    /// void __thiscall CSortCell::add_building(CSortCell*,CBuildingObj*)</code>
    /// </summary>
    /// <param name="object">The building object to associate with this sort cell.</param>
    public void add_building(ACBindingsTest.Internal.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, ACBindingsTest.Internal.CBuildingObj*, void>)0x00534D70)(ref this, object_);

    /// <summary>Removes a building from the sorting cell by clearing its internal reference.
    /// <code>Offset: 0x00534D90
    /// void __thiscall CSortCell::remove_building(CSortCell*,CBuildingObj*)</code>
    /// </summary>
    /// <param name="object">The building object that should be removed; currently unused in the implementation.</param>
    public void remove_building(ACBindingsTest.Internal.CBuildingObj* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, ACBindingsTest.Internal.CBuildingObj*, void>)0x00534D90)(ref this, object_);

    /// <summary>Locates transit cells for a building by evaluating the supplied sphere data, populating the cell array and path structures with the results.
    /// <code>Offset: 0x00534DA0
    /// void __thiscall CSortCell::find_transit_cells(CSortCell*,const Position*,const unsigned int,const CSphere*,CELLARRAY*,SPHEREPATH*)</code>
    /// </summary>
    /// <param name="p">The reference position from which to start searching for transit cells.</param>
    /// <param name="num_sphere">The count of spheres provided in the traversal sequence.</param>
    /// <param name="sphere">Pointer to the first sphere (or array) used to test transit conditions against the building.</param>
    /// <param name="cell_array">Container that receives the identified transit cells for further processing.</param>
    /// <param name="path">Structure that records detailed transit information, including path steps and collision data.</param>
    public void find_transit_cells(ACBindingsTest.Internal.Position* p, uint num_sphere, ACBindingsTest.Internal.CSphere* sphere, ACBindingsTest.Internal.CELLARRAY* cell_array, ACBindingsTest.Internal.SPHEREPATH* path) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, ACBindingsTest.Internal.Position*, uint, ACBindingsTest.Internal.CSphere*, ACBindingsTest.Internal.CELLARRAY*, ACBindingsTest.Internal.SPHEREPATH*, void>)0x00534DA0)(ref this, p, num_sphere, sphere, cell_array, path);

    /// <summary>Finds transit cells for specified physics parts by delegating to the associated building object when present.
    /// <code>Offset: 0x00534DC0
    /// void __thiscall CSortCell::find_transit_cells(CSortCell*,const unsigned int,CPhysicsPart**,CELLARRAY*)</code>
    /// </summary>
    /// <param name="num_parts">Number of physics parts being considered.</param>
    /// <param name="parts">Array of pointers to the physics parts.</param>
    /// <param name="cell_array">Output array populated with discovered transit cells.</param>
    public void find_transit_cells(uint num_parts, ACBindingsTest.Internal.CPhysicsPart** parts, ACBindingsTest.Internal.CELLARRAY* cell_array) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, uint, ACBindingsTest.Internal.CPhysicsPart**, ACBindingsTest.Internal.CELLARRAY*, void>)0x00534DC0)(ref this, num_parts, parts, cell_array);

    /// <summary>Determines whether the cell’s building collides with the given transition path, updating collision state as needed.
    /// <code>Offset: 0x00534DE0
    /// TransitionState __thiscall CSortCell::find_collisions(CSortCell*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">Transition data containing sphere path, object information, and current collision status to be updated during detection.</param>
    /// <returns>Returns OK_TS when no critical error occurs; otherwise returns an error code (e.g., if the building is missing or a collision check fails).</returns>
    public ACBindingsTest.Internal.TransitionState find_collisions(ACBindingsTest.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, ACBindingsTest.Internal.CTransition*, ACBindingsTest.Internal.TransitionState>)0x00534DE0)(ref this, transition);

    /// <summary>Retrieves a physics object by identifier from the cell, searching first in its local object list and then within its associated building if present.
    /// <code>Offset: 0x00534E00
    /// CPhysicsObj* __thiscall CSortCell::get_object(CSortCell*,const unsigned int)</code>
    /// </summary>
    /// <param name="obj_iid">The unique identifier of the desired object.</param>
    /// <returns>A pointer to the found CPhysicsObj instance or null if no matching object exists.</returns>
    public ACBindingsTest.Internal.CPhysicsObj* get_object(uint obj_iid) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CSortCell, uint, ACBindingsTest.Internal.CPhysicsObj*>)0x00534E00)(ref this, obj_iid);
}

