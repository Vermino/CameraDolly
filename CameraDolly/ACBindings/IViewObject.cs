namespace ACBindingsTest.Internal;


/// <summary>Represents a COM interface that exposes an object’s visual representation, enabling rendering and manipulation of the view within OLE containers.</summary>
public unsafe struct IViewObject
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IViewObject_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint, int, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, uint, int> Draw; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint, int, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> GetColorSet; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint, int, System.IntPtr, uint*, int> Freeze; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint, int> Unfreeze; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint, uint, System.IntPtr, int> SetAdvise; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject*, uint*, uint*, System.IntPtr, int> GetAdvise; // function pointer

        // Methods
    }

    // Methods
}

