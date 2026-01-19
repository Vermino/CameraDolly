namespace ACBindingsTest.Internal;


/// <summary>Combines an unsigned 64‑bit integer value with formatting metadata, providing a formatted string representation via the ToString method.</summary>
public unsafe struct Formatted_ULInt_StringInfoData
{
    // Base Classes
    public ACBindingsTest.Internal.ULInt_StringInfoData BaseClass_ULInt_StringInfoData; // ACBindingsTest.Internal.ULInt_StringInfoData
    public ACBindingsTest.Internal.Formatted_StringInfoData BaseClass_Formatted_StringInfoData; // ACBindingsTest.Internal.Formatted_StringInfoData

    // Child Types
    public unsafe struct Formatted_ULInt_StringInfoData_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Formatted_ULInt_StringInfoData*, void> Formatted_ULInt_StringInfoData_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Formatted_ULInt_StringInfoData*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public System.IntPtr GetSubPrivateIDs;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Formatted_ULInt_StringInfoData*, byte, byte> IsValid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Formatted_ULInt_StringInfoData*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public System.IntPtr ToString;

        // Methods
    }

    // Methods

    /// <summary>Formats the object's unsigned integer value into a string based on its base and grouping settings, writing the result into the supplied buffer.
    /// <code>Offset: 0x0042FAF0
    /// int* __thiscall Formatted_ULInt_StringInfoData::ToString(int,int*)</code>
    /// </summary>
    /// <param name="a2">Buffer where the formatted number will be stored; must accommodate the resulting string.</param>
    /// <returns>Pointer to the output buffer containing the null‑terminated formatted string.</returns>
    public int* ToString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.Formatted_ULInt_StringInfoData, int*, int*>)0x0042FAF0)(ref this, a2);
}

