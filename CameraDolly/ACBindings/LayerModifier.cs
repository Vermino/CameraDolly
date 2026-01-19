namespace ACBindingsTest.Internal;


/// <summary>Defines a polymorphic object with a virtual function table pointer for runtime dispatch.</summary>
/// <remarks>Serves as the foundation for derived types that provide specific behavior through virtual functions.</remarks>
public unsafe struct LayerModifier
{
    // Child Types

    /// <summary>Defines the interface for layer modifier implementations, providing function pointers to query type, size, modification capabilities, copy, application, serialization, and file‑node handling.</summary>
    public unsafe struct LayerModifier_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.LayerModType> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, uint> GetTCIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, uint> GetSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, byte> DoesModifyVertex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.LayerModifier*> Copy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, System.IntPtr, ACBindingsTest.Internal.VertexFormatInfo*, void> Apply; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.Matrix4*, void> ApplyTextureTransform; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.PFileNode*, ACBindingsTest.Internal.RenderMaterial*, uint, uint, byte> LoadFromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.LayerModifier*, ACBindingsTest.Internal.PFileNode*, ACBindingsTest.Internal.RenderMaterial*, uint, uint, byte> SaveToFileNode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

