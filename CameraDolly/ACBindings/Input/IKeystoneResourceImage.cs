namespace ACBindingsTest.Internal;


/// <summary>Represents an image resource within the Keystone framework, extending base resource functionality to manage image-specific data.</summary>
public unsafe struct IKeystoneResourceImage
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneResource BaseClass_IKeystoneResource; // ACBindingsTest.Internal.IKeystoneResource

    // Child Types
    public unsafe struct IKeystoneResourceImage_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, ACBindingsTest.Internal.IKeystoneControl*, System.IntPtr> GetData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint> GetImageWidth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint> GetImageHeight; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint, int> SetImageWidth; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint, int> SetImageHeight; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, int> IsAnimation; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint> GetUpdateTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceImage*, uint, ACBindingsTest.Internal.IKeystoneControl*, void> UpdateCounter; // function pointer

        // Methods
    }

    // Methods
}

