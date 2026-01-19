namespace ACBindingsTest.Internal;


/// <summary>Represents the IDataAdviseHolder COM interface, enabling clients to register and manage advisory connections with data objects.</summary>
public unsafe struct IDataAdviseHolder
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IDataAdviseHolder_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataAdviseHolder*, ACBindingsTest.Internal.IDataObject*, System.IntPtr, uint, System.IntPtr, uint*, int> Advise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataAdviseHolder*, uint, int> Unadvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataAdviseHolder*, System.IntPtr, int> EnumAdvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataAdviseHolder*, ACBindingsTest.Internal.IDataObject*, uint, uint, int> SendOnDataChange; // function pointer

        // Methods
    }

    // Methods
}

