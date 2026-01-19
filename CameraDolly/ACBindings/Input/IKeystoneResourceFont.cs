namespace ACBindingsTest.Internal;


/// <summary>Represents a font resource within the Keystone framework, wrapping core resource functionality.</summary>
/// <remarks>Contains an IKeystoneResource instance that provides generic resource handling capabilities for font assets.</remarks>
public unsafe struct IKeystoneResourceFont
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneResource BaseClass_IKeystoneResource; // ACBindingsTest.Internal.IKeystoneResource

    // Child Types
    public unsafe struct IKeystoneResourceFont_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IResourceNotify*, ACBindingsTest.Internal.IResourceNotify*, ACBindingsTest.Internal.KS_STATUS, int> NotifyResourceStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IResourceNotify*, ushort*> GetName; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, ushort*> GetType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, System.IntPtr, int> DecodeData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, ACBindingsTest.Internal.IResourceNotify*, int> AddOwner; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, ACBindingsTest.Internal.IResourceNotify*, int> RemoveOwner; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, ACBindingsTest.Internal.KS_STATUS, int> SetStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResource*, ACBindingsTest.Internal.KS_STATUS> GetStatus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceFont*, ACBindingsTest.Internal.IKeystoneWindow*, System.IntPtr, ACBindingsTest.Internal.tagRECT*, float, ACBindingsTest.Internal.tagRECT*, uint, ushort*, ACBindingsTest.Internal.IKeystoneControl*, int> DrawTextA; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceFont*, ushort*, ACBindingsTest.Internal.tagRECT*, ACBindingsTest.Internal.IKeystoneControl*, int> GetTextExtent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceFont*, ACBindingsTest.Internal.IKeystoneControl*, int> ReleaseCharacterMemory; // function pointer

        // Methods
    }

    // Methods
}

