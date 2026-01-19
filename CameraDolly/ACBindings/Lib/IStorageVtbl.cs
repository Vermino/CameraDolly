namespace ACBindingsTest.Internal;


/// <summary>VTable for the COM IStorage interface, containing function pointers that provide storage manipulation capabilities such as creating streams, opening storages, committing changes, and enumerating elements.</summary>
public unsafe struct IStorageVtbl
{
    // Members
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint> AddRef; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStorage*, uint> Release; // function pointer
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

