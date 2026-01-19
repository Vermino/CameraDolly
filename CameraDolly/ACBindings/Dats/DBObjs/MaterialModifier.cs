namespace ACBindingsTest.Internal;


/// <summary>Represents a material modifier that associates a database object with an array of property overrides, enabling dynamic adjustment of material attributes.</summary>
public unsafe struct MaterialModifier : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.DBObj BaseClass_DBObj; // ACBindingsTest.Internal.DBObj

    // Child Types
    public unsafe struct MaterialModifier_vtbl
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
    public ACBindingsTest.Internal.SmartArray___MaterialProperty_ptr properties;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Collects sub‑data identifiers from all material properties and appends them to the specified array.
    /// <code>Offset: 0x004503F0
    /// void __thiscall MaterialModifier::GetSubDataIDs(MaterialModifier*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the gathered data IDs.</param>
    public void GetSubDataIDs(ACBindingsTest.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, ACBindingsTest.Internal.QualifiedDataIDArray*, void>)0x004503F0)(ref this, id_array);

    /// <summary>Verifies that every material property in the modifier can provide its sub‑objects; returns true only when all calls succeed.
    /// <code>Offset: 0x00450420
    /// bool __thiscall MaterialModifier::GetSubObjects(MaterialModifier*)</code>
    /// </summary>
    /// <returns>True if all properties report success; false if any fails.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, byte>)0x00450420)(ref this);

    /// <summary>Releases sub-objects for every property stored in this material modifier, propagating failures.
    /// <code>Offset: 0x00450450
    /// bool __thiscall MaterialModifier::ReleaseSubObjects(MaterialModifier*)</code>
    /// </summary>
    /// <returns>True when all property sub-objects were released successfully; otherwise false.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, byte>)0x00450450)(ref this);

    /// <summary>Releases all sub‑objects of the modifier’s properties, deletes each property object, clears the property array, and frees allocated memory when necessary.
    /// <code>Offset: 0x004504C0
    /// void __thiscall MaterialModifier::End(MaterialModifier*)</code>
    /// </summary>
    /// <param name="this">The MaterialModifier instance to clean up.</param>
    public void End() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, void>)0x004504C0)(ref this);

    /// <summary>Creates a new MaterialModifier instance, initializing its base DBObj fields and vtable pointer.
    /// <code>Offset: 0x004505A0
    /// DBObj* __cdecl MaterialModifier::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated DBObj representing the MaterialModifier; null if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.DBObj*>)0x004505A0)();

    /// <summary>Destroys a MaterialModifier object, freeing its property array and invoking the base class destructor for cleanup.
    /// <code>Offset: 0x004505F0
    /// void __thiscall MaterialModifier::~MaterialModifier(MaterialModifier*)</code>
    /// </summary>
    /// <param name="this">Pointer to the MaterialModifier instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, void>)0x004505F0)(ref this);

    /// <summary>Copies all material properties from the current modifier into a target DBObj, expanding its internal array as required.
    /// <code>Offset: 0x00450680
    /// bool __thiscall MaterialModifier::CopyInto(MaterialModifier*,DBObj*)</code>
    /// </summary>
    /// <param name="retval">The destination DBObj that will receive the copied properties.</param>
    /// <returns>True if every property was successfully copied; otherwise false.</returns>
    public byte CopyInto(ACBindingsTest.Internal.DBObj* retval) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, ACBindingsTest.Internal.DBObj*, byte>)0x00450680)(ref this, retval);

    /// <summary>Serializes the MaterialModifier, including its base class and associated material properties, to or from an Archive. Handles both reading and writing of property data according to archive flags.
    /// <code>Offset: 0x00450700
    /// void __thiscall MaterialModifier::Serialize(MaterialModifier*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive used for serialization; determines read/write mode via its flags.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.MaterialModifier, ACBindingsTest.Internal.Archive*, void>)0x00450700)(ref this, io_archive);
}

