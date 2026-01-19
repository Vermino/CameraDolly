namespace ACBindingsTest.Internal;


/// <summary>Provides an interface for handling asynchronous cache callbacks through a virtual function table.</summary>
public unsafe struct AsyncCacheCallback
{
    // Child Types

    /// <summary>Defines the vtable layout for asynchronous cache callbacks, providing hooks invoked when a context or top‑level request completes.</summary>
    public unsafe struct AsyncCacheCallback_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AsyncCacheCallback*, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.AsyncResult, uint, void> OnContextFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AsyncCacheCallback*, ACBindingsTest.Internal.AsyncContext, ACBindingsTest.Internal.QualifiedDataID, ACBindingsTest.Internal.AsyncResult, uint, int, System.IntPtr, void> OnTopLevelRequestFinished; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

