namespace ACBindingsTest.Internal;


/// <summary>Defines the vtable layout for COM’s IUnknown interface, exposing QueryInterface, AddRef, and Release operations for interface discovery and object lifetime management.</summary>
public unsafe struct IUnknownVtbl
{
    // Members
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
    public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer

    // Methods
}

