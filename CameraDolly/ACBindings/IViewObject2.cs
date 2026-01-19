namespace ACBindingsTest.Internal;


/// <summary>Extends the core IViewObject interface with additional functionality for rendering, visibility control, and interaction within Windows applications.</summary>
public unsafe struct IViewObject2
{
    // Base Classes
    public ACBindingsTest.Internal.IViewObject BaseClass_IViewObject; // ACBindingsTest.Internal.IViewObject

    // Child Types
    public unsafe struct IViewObject2_vtbl
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
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IViewObject2*, uint, int, System.IntPtr, System.IntPtr, int> GetExtent; // function pointer

        // Methods
    }

    // Methods
}

