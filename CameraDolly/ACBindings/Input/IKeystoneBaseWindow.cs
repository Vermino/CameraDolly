namespace ACBindingsTest.Internal;


/// <summary>Represents a foundational window structure that embeds a resource notification component.</summary>
public unsafe struct IKeystoneBaseWindow
{
    // Base Classes
    public ACBindingsTest.Internal.IResourceNotify BaseClass_IResourceNotify; // ACBindingsTest.Internal.IResourceNotify

    // Child Types
    public unsafe struct IKeystoneBaseWindow_vtbl
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

        // Methods
    }

    // Methods
}

