namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a <c>Font</c> instance to support localized font definitions within the database system. Serves as a wrapper for local fonts, enabling distinction between global and local resources during lookup.</summary>
public unsafe struct FontLocal
{
    // Base Classes
    public ACBindingsTest.Internal.Font BaseClass_Font; // ACBindingsTest.Internal.Font

    // Child Types
    public unsafe struct FontLocal_vtbl
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

    // Methods

    /// <summary>Retrieves a database object representing either a global or local font based on the supplied identifier.
    /// <code>Offset: 0x0044B680
    /// DBObj* __cdecl FontLocal::GetGlobalOrLocalFont(int)</code>
    /// </summary>
    /// <param name="a1">The font identifier used to determine which variant (global or local) is retrieved.</param>
    /// <returns>A pointer to the corresponding DBObj, or nullptr if no matching object exists.</returns>
    public static ACBindingsTest.Internal.DBObj* GetGlobalOrLocalFont(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindingsTest.Internal.DBObj*>)0x0044B680)(a1);

    /// <summary>Retrieves the database object type identifier for a FontLocal instance.
    /// <code>Offset: 0x004F8300
    /// unsigned int __thiscall FontLocal::GetDBOType(FontLocal*)</code>
    /// </summary>
    /// <returns>The DBO type value, which is 47.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.FontLocal, uint>)0x004F8300)(ref this);

    /// <summary>Allocates a new font object, initializes its core fields and file name buffers, then returns a pointer to its underlying DBObj base class.
    /// <code>Offset: 0x004F8800
    /// DBObj* __thiscall FontLocal::Allocate(FontLocal*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated object's DBObj base; returns null if allocation fails.</returns>
    public ACBindingsTest.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.FontLocal, ACBindingsTest.Internal.DBObj*>)0x004F8800)(ref this);
}

