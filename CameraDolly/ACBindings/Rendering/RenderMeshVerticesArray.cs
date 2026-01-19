namespace ACBindingsTest.Internal;


/// <summary>Holds an array of vertex buffer pointers for rendering meshes, managing reference counts and memory allocation to ensure efficient GPU resource reuse.</summary>
public unsafe struct RenderMeshVerticesArray : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct RenderMeshVerticesArray_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.RenderMeshVerticesArray*, void> RenderMeshVerticesArray_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SmartArray___RenderVertexBuffer_ptr m_VertexArrays;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases all stored vertex buffer references, decrements their reference counts, frees any allocated memory for the vertex array, and resets the container’s internal state to empty.
    /// <code>Offset: 0x00445040
    /// void __thiscall RenderMeshVerticesArray::~RenderMeshVerticesArray(RenderMeshVerticesArray*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RenderMeshVerticesArray, void>)0x00445040)(ref this);
}

