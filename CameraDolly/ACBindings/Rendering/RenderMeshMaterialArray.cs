namespace ACBindingsTest.Internal;


/// <summary>Manages the collection of material instances used by a render mesh, providing reference‑counted ownership and dynamic array handling for efficient resource cleanup. Pairs data identifiers with MaterialInstance pointers to enable rapid lookup and deterministic deallocation during object destruction.</summary>
public unsafe struct RenderMeshMaterialArray : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshMaterialArray_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.RenderMeshMaterialArray*, void> RenderMeshMaterialArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SmartArray____STL_pair___IDClass____tagDataID___MaterialInstance_ptr m_Materials;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a RenderMeshMaterialArray instance by releasing each MaterialInstance, clearing its internal SmartArray, deallocating any allocated memory as needed, and restoring base class virtual function tables.
    /// <code>Offset: 0x00444FD0
    /// void __thiscall RenderMeshMaterialArray::~RenderMeshMaterialArray(RenderMeshMaterialArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RenderMeshMaterialArray, void>)0x00444FD0)(ref this);
}

