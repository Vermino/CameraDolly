namespace ACBindingsTest.Internal;


/// <summary>Represents an interface for chat network functionality, providing a foundation for communication operations within the application.</summary>
/// <remarks>Inherited from IUnknown, enabling reference counting and interface querying.</remarks>
public unsafe struct IChatNetwork
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IChatNetwork_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatNetwork*, ACBindingsTest.Internal.tagBLOB, int> SendData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IChatNetwork*, int> UseTime; // function pointer

        // Methods
    }

    // Methods
}

