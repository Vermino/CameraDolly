namespace ACBindingsTest.Internal;


/// <summary>Defines a COM interface used by the application for configuring movie playback sessions.</summary>
/// <remarks>Inherits from IUnknown to support standard COM operations. No additional members or methods are present in this decompiled representation.</remarks>
public unsafe struct IAMovieSetup
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IAMovieSetup_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAMovieSetup*, int> Register; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAMovieSetup*, int> Unregister; // function pointer

        // Methods
    }

    // Methods
}

