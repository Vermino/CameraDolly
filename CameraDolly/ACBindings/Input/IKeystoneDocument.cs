namespace ACBindingsTest.Internal;


/// <summary>Represents a document view within the Keystone UI framework, providing base window functionality via its embedded IKeystoneBaseWindow.</summary>
public unsafe struct IKeystoneDocument
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindingsTest.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneDocument_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.KS_STATUS> GetStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.IKeystoneResourceKSML*> GetDocumentSource; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr, void> SetASPCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr, void> SetSoundCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr, void> SetWndProc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr> GetASPCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr> GetSoundCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, System.IntPtr> GetWndProc; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ushort*, ACBindingsTest.Internal.IKeystoneControl**, int> CreateElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.tagRECT*, int> SetLogicalSurfaceDimensions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.tagRECT*> GetLogicalSurfaceDimensions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ushort*> GetGet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.Region*> GetLayoutArea; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, ACBindingsTest.Internal.Region*, void> SetLayoutArea; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, int, void> InsertLineBreak; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, void> AdjustForMargin; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneDocument*, int> IsInIFrame; // function pointer

        // Methods
    }

    // Methods
}

