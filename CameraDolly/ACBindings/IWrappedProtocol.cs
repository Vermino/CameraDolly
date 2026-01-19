namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an IUnknown interface reference used within the application.</summary>
/// <remarks>The struct aligns its member to a 4-byte boundary to satisfy binary layout constraints.</remarks>
public unsafe struct IWrappedProtocol
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IWrappedProtocol_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IWrappedProtocol*, int*, uint, int> GetWrapperCode; // function pointer

        // Methods
    }

    // Methods
}

