namespace ACBindingsTest.Internal;


/// <summary>Defines a COM interface representing an embedded browser control, exposing standard IUnknown methods and serving as the foundation for browser-specific interactions.</summary>
public unsafe struct IBrowserControl
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IBrowserControl_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int*, int, int, int, int, ACBindingsTest.Internal.IBrowserCallback*, byte> Create; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int, int, void> Move; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int, int, void> Resize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int*> GetHWND; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, sbyte*, uint, sbyte*, sbyte*, System.IntPtr, uint, int> Navigate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int> Stop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int> GoBack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int> GoForward; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int> GoHome; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, int> GoSearch; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IBrowserControl*, byte, int> Refresh; // function pointer

        // Methods
    }

    // Methods
}

