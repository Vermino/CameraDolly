namespace ACBindingsTest.Internal;


/// <summary>Represents a binary data stream providing sequential and random access operations such as read, write, seek, and other manipulation methods.</summary>
public unsafe struct IStream
{
    // Base Classes
    public ACBindingsTest.Internal.ISequentialStream BaseClass_ISequentialStream; // ACBindingsTest.Internal.ISequentialStream

    // Child Types
    public unsafe struct IStream_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ISequentialStream*, System.IntPtr, uint, uint*, int> Read; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ISequentialStream*, void*, uint, uint*, int> Write; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal._LARGE_INTEGER, uint, ACBindingsTest.Internal._ULARGE_INTEGER*, int> Seek; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal._ULARGE_INTEGER, int> SetSize; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal._ULARGE_INTEGER, ACBindingsTest.Internal._ULARGE_INTEGER*, ACBindingsTest.Internal._ULARGE_INTEGER*, int> CopyTo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, uint, int> Commit; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, int> Revert; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal._ULARGE_INTEGER, ACBindingsTest.Internal._ULARGE_INTEGER, uint, int> LockRegion; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal._ULARGE_INTEGER, ACBindingsTest.Internal._ULARGE_INTEGER, uint, int> UnlockRegion; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, System.IntPtr, uint, int> Stat; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IStream*, ACBindingsTest.Internal.IStream**, int> Clone; // function pointer

        // Methods
    }

    // Methods
}

