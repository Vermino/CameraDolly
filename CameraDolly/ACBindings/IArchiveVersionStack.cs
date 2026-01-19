namespace ACBindingsTest.Internal;


/// <summary>Represents an archive version stack interface containing only a base class reference for type identification and internal handling.</summary>
public unsafe struct IArchiveVersionStack
{
    // Base Classes
    public ACBindingsTest.Internal.Interface BaseClass_Interface; // ACBindingsTest.Internal.Interface

    // Child Types
    public unsafe struct IArchiveVersionStack_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IArchiveVersionStack*, uint, uint> GetVersionByToken; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IArchiveVersionStack*, uint, uint, byte> SetVersion; // function pointer
        public fixed byte gap20[4];
        public System.IntPtr PushVersionRow;
        public System.IntPtr PopVersionRow;
        public System.IntPtr GetRowByHandle;
        public System.IntPtr GetCurrentVersionHandle;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IArchiveVersionStack*, void> Reset; // function pointer

        // Methods
    }

    // Methods
}

