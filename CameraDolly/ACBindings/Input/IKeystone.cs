namespace ACBindingsTest.Internal;


/// <summary>Serves as a COM interface for interacting with Keystone modules in the application.</summary>
public unsafe struct IKeystone
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IKeystone_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, int> KsCreateMessageBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, ushort*, uint, ACBindingsTest.Internal.tagRECT*, float, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int> KsCreateWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, ACBindingsTest.Internal.IKeystoneWindow*> KsGetWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, System.IntPtr> KsGetDevice; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneResourceImage*, ACBindingsTest.Internal.tagPOINT*, int> KsSetCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, int> KsUpdate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, uint, uint, int, int*, ACBindingsTest.Internal.IKeystoneWindow*> KsDispatchMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneWindow*, int> KsSetFocusWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneWindow*> KsGetFocusWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.KSWNDCLASS*, int> KsRegisterClass; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, int> KsUnregisterClass; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, ACBindingsTest.Internal.KSWNDCLASS**, int> KsGetClassInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*, ushort*, ACBindingsTest.Internal.tagRECT*, uint, int> KsSetWindowPos; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneWindow*, uint, int> KsTrackMouseEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneWindow*, uint, int> KsUnTrackMouseEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, int> KsGetLastError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, System.IntPtr, int> KsEnumerateControlTags; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneWindow*, int> KsDestroyWindow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, int, int> KsSetLastError; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ushort*> KsGetWorkingDirectory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, uint, System.IntPtr, void**, int> KsChangeSetting; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.tagPOINT*, ACBindingsTest.Internal.IKeystoneWindow*> KsWindowFromPoint; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneControl*, uint, uint, int> KsSetTimer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, ACBindingsTest.Internal.IKeystoneControl*, uint, int> KsKillTimer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystone*, int*, int*, System.IntPtr, int> KsTranslateAccelerator; // function pointer

        // Methods
    }

    // Methods
}

