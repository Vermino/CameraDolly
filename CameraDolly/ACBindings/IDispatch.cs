namespace ACBindingsTest.Internal;


/// <summary>Provides late‑binding support for COM components, enabling dynamic method and property access through dispatch identifiers.</summary>
public unsafe struct IDispatch
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IDispatch_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, ACBindingsTest.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, int, ACBindingsTest.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer

        // Methods
    }

    // Methods
}

