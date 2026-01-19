namespace ACBindingsTest.Internal;


/// <summary>Represents a COM interface for compound file storage, enabling creation and manipulation of nested storages and streams.</summary>
public unsafe struct IStorage
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IStorage_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, uint, uint, uint, ACBindingsTest.Internal.IStream**, int> CreateStream; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, System.IntPtr, uint, uint, ACBindingsTest.Internal.IStream**, int> OpenStream; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, uint, uint, uint, ACBindingsTest.Internal.IStorage**, int> CreateStorage; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, ACBindingsTest.Internal.IStorage*, uint, ushort**, uint, ACBindingsTest.Internal.IStorage**, int> OpenStorage; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint, ACBindingsTest.Internal._GUID*, ushort**, ACBindingsTest.Internal.IStorage*, int> CopyTo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, ACBindingsTest.Internal.IStorage*, ushort*, uint, int> MoveElementTo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint, int> Commit; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, int> Revert; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint, System.IntPtr, uint, System.IntPtr, int> EnumElements; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, int> DestroyElement; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, ushort*, int> RenameElement; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ushort*, System.IntPtr, System.IntPtr, System.IntPtr, int> SetElementTimes; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ACBindingsTest.Internal._GUID*, int> SetClass; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint, uint, int> SetStateBits; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, System.IntPtr, uint, int> Stat; // function pointer

        // Methods
    }

    // Methods
}

