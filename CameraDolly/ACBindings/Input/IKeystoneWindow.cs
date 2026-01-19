namespace ACBindingsTest.Internal;


/// <summary>Encapsulates an IKeystoneBaseWindow instance, providing a distinct window type within the Keystone application.</summary>
public unsafe struct IKeystoneWindow
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindingsTest.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneWindow_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IResourceNotify*, ACBindingsTest.Internal.IResourceNotify*, ACBindingsTest.Internal.KS_STATUS, int> NotifyResourceStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IResourceNotify*, ushort*> GetName; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, uint, uint, int, int> SendMessageA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*> GetFirstChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*> GetNextSibling; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.Region*> GetRegion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*, int> SetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*, int> SetFirstChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.IKeystoneBaseWindow*, int> SetNextSibling; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.Region*, int> SetRegion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, System.IntPtr, int> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, System.IntPtr, int> SerializeForPrint; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, int> SetFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, float> GetZOrder; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, float, int> SetZOrder; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, int> IsAbsolute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneBaseWindow*, ACBindingsTest.Internal.E_BASEWINDOW_TYPE> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, uint, uint, int, int> DefWindowProcA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.tagRECT*> GetLogicalSurfaceDimensions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr> GetClientAreaTextures; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr, int> SetClientAreaTextures; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneResourceKSML*> GetDocumentSource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.tagRECT*> GetScrollRect; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> GetScrollX; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> GetScrollY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int, int> SetScrollX; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int, int> SetScrollY; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneResourceImage*, ACBindingsTest.Internal.tagPOINT*, int> SetCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> IsVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ushort*, ACBindingsTest.Internal.IKeystoneControl*> GetControlByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.tagPOINT*, ACBindingsTest.Internal.IKeystoneControl*> GetControlFromPoint; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, uint, ACBindingsTest.Internal.IKeystoneControl*> TranslateAcceleratorA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ushort*, ushort*, int> RegisterAccelerator; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int, int> ShowWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ushort*, ACBindingsTest.Internal.IKeystoneControl**, int> CreateElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> ReLayout; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> PopulateControlCatalog; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneControl*, int> SetFocusControl; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneControl*> GetFocusControl; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ushort*, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> Open; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr> GetASPCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr> GetSoundCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int, uint> GetWindowLongA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneControl*, int> AddDirtyControl; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneControl*, uint, int> TrackMouseEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ACBindingsTest.Internal.IKeystoneControl*, uint, int> UnTrackMouseEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr, System.IntPtr, int> Back; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr, System.IntPtr, int> Forward; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, int> IsDirty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, uint, int> SwapToNextDocument; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneWindow*, ushort*, int> Print; // function pointer

        // Methods
    }

    // Methods
}

