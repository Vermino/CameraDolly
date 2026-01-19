namespace ACBindingsTest.Internal;


/// <summary>Represents eye strip graphic configuration, storing identifiers for the normal and bald icons along with their associated object descriptors.</summary>
public unsafe struct EyesStrip_CG
{
    // Child Types

    /// <summary>Defines the vtable layout for EyesStrip_CG, exposing a pointer to its Serialize method used during archiving.</summary>
    public unsafe struct EyesStrip_CG_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.EyesStrip_CG*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindingsTest.Internal.IDClass____tagDataID iconImage;
    public ACBindingsTest.Internal.IDClass____tagDataID iconImage_Bald;
    public ACBindingsTest.Internal.ObjDesc objDesc;
    public ACBindingsTest.Internal.ObjDesc objDesc_Bald;

    // Methods

    /// <summary>Serializes EyesStrip_CG data to or from an Archive, handling icon image identifiers and object descriptors for normal and bald forms.
    /// <code>Offset: 0x005BEC00
    /// void __thiscall EyesStrip_CG::Serialize(EyesStrip_CG*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive used for reading or writing serialized data.</param>
    public void Serialize(ACBindingsTest.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.EyesStrip_CG, ACBindingsTest.Internal.Archive*, void>)0x005BEC00)(ref this, io_archive);
}

