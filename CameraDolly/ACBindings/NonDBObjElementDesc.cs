namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an ElementDesc instance within a 4‑byte aligned structure.</summary>
/// <remarks>Provides a lightweight wrapper that can be distinguished by type while reusing all layout and state functionality of ElementDesc.</remarks>
public unsafe struct NonDBObjElementDesc
{
    // Base Classes
    public ACBindingsTest.Internal.ElementDesc BaseClass_ElementDesc; // ACBindingsTest.Internal.ElementDesc

    // Child Types
    public unsafe struct NonDBObjElementDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, void> NonDBObjElementDesc_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.PFileNode*, byte> ToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.PFileNode*, byte> FromFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.PFileNode*, byte> PositionToFileNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.PFileNode*, byte*, byte> HandleNode; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.PFileNode*, byte> CheckFFN; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.NonDBObjElementDesc*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.Box2D*, uint, uint, uint, uint, void> UpdateSizeAndPosition; // function pointer

        // Methods
    }

    // Methods
}

