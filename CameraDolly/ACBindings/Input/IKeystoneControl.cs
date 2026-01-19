namespace ACBindingsTest.Internal;


/// <summary>Facilitates control operations for Keystone windows, extending the base window functionality provided by IKeystoneBaseWindow.</summary>
public unsafe struct IKeystoneControl
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneBaseWindow BaseClass_IKeystoneBaseWindow; // ACBindingsTest.Internal.IKeystoneBaseWindow

    // Child Types
    public unsafe struct IKeystoneControl_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ACBindingsTest.Internal.Region**, ACBindingsTest.Internal.tagPOINT*, uint*, int> GetDimensions; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, int> GetTabStop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, int> GetTabIndex; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*, ushort*> GetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*, ushort*> GetDefaultAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*> GetTagName; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*, ushort*, int> SetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*, ushort*, int> SetDefaultAttribute; // function pointer
        public System.IntPtr GetNamesOfAttributes;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ACBindingsTest.Internal.IKeystoneDocument*, int> SetDocument; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ACBindingsTest.Internal.IKeystoneWindow*, int> SetWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ACBindingsTest.Internal.IKeystoneWindow*> GetWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ACBindingsTest.Internal.IKeystoneResourceFont*> GetFont; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneControl*, ushort*> GetDirectory; // function pointer
        public System.IntPtr CleanUpAttributeNameStruct;

        // Methods
    }

    // Methods
}

