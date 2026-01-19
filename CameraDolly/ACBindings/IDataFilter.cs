namespace ACBindingsTest.Internal;


/// <summary>Defines a COM‑compatible interface for data filtering functionality.</summary>
/// <remarks>Currently contains no additional members; serves as the base for concrete implementation classes.</remarks>
public unsafe struct IDataFilter
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IDataFilter_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoEncode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataFilter*, uint, int, byte*, int, byte*, int, int*, int*, uint, int> DoDecode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDataFilter*, uint, int> SetEncodingLevel; // function pointer

        // Methods
    }

    // Methods
}

