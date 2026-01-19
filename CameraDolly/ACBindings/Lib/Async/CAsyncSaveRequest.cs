namespace ACBindingsTest.Internal;


/// <summary>Asynchronous save request for a disk controller, encapsulating target file identifier, save flags, iteration counter, buffer pack, and associated disk controller pointer.</summary>
public unsafe struct CAsyncSaveRequest
{
    // Base Classes
    public ACBindingsTest.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindingsTest.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncSaveRequest_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncSaveRequest*, void> CAsyncSaveRequest_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncSaveRequest*, byte> bAllDependanciesDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncSaveRequest*, byte> ReadyToUnhash; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncSaveRequest*, void> ReleaseDBObj; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.Cache_Pack_t Buf;
    public ulong idTargetDatFile;
    public uint dwDiskControllerSaveFlags;
    public uint idIteration;
    public ACBindingsTest.Internal.DiskController* pDisk;

    // Methods
}

