namespace ACBindingsTest.Internal;


/// <summary>COM interface enabling interaction with audio services through IDispatch.</summary>
public unsafe struct IBasicAudio
{
    // Base Classes
    public ACBindingsTest.Internal.IDispatch BaseClass_IDispatch; // ACBindingsTest.Internal.IDispatch

    // Child Types
    public unsafe struct IBasicAudio_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, uint*, int> GetTypeInfoCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, uint, uint, System.IntPtr, int> GetTypeInfo; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, ACBindingsTest.Internal._GUID*, ushort**, uint, uint, int*, int> GetIDsOfNames; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDispatch*, int, ACBindingsTest.Internal._GUID*, uint, ushort, System.IntPtr, System.IntPtr, System.IntPtr, uint*, int> Invoke; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IBasicAudio*, int, int> put_Volume; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IBasicAudio*, int*, int> get_Volume; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IBasicAudio*, int, int> put_Balance; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IBasicAudio*, int*, int> get_Balance; // function pointer

        // Methods
    }

    // Methods
}

