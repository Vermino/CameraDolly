namespace ACBindingsTest.Internal;


/// <summary>IDropTarget defines the contract for objects that accept drag-and-drop data, providing methods to handle drag enter, over, drop, and leave events.</summary>
/// <remarks>This interface is part of the OLE drag-and-drop subsystem and is implemented by controls that need to receive dragged items from other applications or components. It typically inherits from IUnknown.</remarks>
public unsafe struct IDropTarget
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IDropTarget_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropTarget*, ACBindingsTest.Internal.IDataObject*, uint, int*, uint*, int> DragEnter; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropTarget*, uint, int*, uint*, int> DragOver; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropTarget*, int> DragLeave; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IDropTarget*, ACBindingsTest.Internal.IDataObject*, uint, int*, uint*, int> Drop; // function pointer

        // Methods
    }

    // Methods
}

