namespace ACBindingsTest.Internal;


/// <summary>Manages a collection of index buffers used for rendering mesh data, handling reference counting and ensuring proper cleanup upon destruction.</summary>
public unsafe struct RenderMeshIndicesArray : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshIndicesArray_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.RenderMeshIndicesArray*, void> RenderMeshIndicesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SmartArray___RenderIndexBuffer_ptr m_IndexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a RenderMeshIndicesArray instance, releasing each owned index buffer and freeing internal storage according to allocation flags. The object's reference‑count base class is reset to its original state.
    /// <code>Offset: 0x00445100
    /// void __thiscall RenderMeshIndicesArray::~RenderMeshIndicesArray(RenderMeshIndicesArray*)</code>
    /// </summary>
    /// <param name="this">Pointer to the RenderMeshIndicesArray object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RenderMeshIndicesArray, void>)0x00445100)(ref this);
}

