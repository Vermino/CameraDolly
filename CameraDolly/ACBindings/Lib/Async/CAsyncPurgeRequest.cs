namespace ACBindingsTest.Internal;


/// <summary>Represents an asynchronous purge operation in the cache system, leveraging the base async request infrastructure to trigger removal of cached entries.</summary>
/// <remarks>Aligned on a 4‑byte boundary for compatibility with legacy memory layouts.</remarks>
public unsafe struct CAsyncPurgeRequest
{
    // Base Classes
    public ACBindingsTest.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindingsTest.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncPurgeRequest_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncPurgeRequest*, void> CAsyncPurgeRequest_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncPurgeRequest*, byte> bAllDependanciesDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncPurgeRequest*, byte> ReadyToUnhash; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CAsyncPurgeRequest*, void> ReleaseDBObj; // function pointer

        // Methods
    }

    // Methods
}

