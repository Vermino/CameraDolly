namespace ACBindingsTest.Internal;


/// <summary>Provides notification support for Keystone resources, exposing the IResourceNotify interface to handle resource events within the system.</summary>
public unsafe struct IKeystoneResource
{
    // Base Classes
    public ACBindingsTest.Internal.IResourceNotify BaseClass_IResourceNotify; // ACBindingsTest.Internal.IResourceNotify

    // Child Types
    public unsafe struct IKeystoneResource_vtbl
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

        // Methods
    }

    // Methods
}

