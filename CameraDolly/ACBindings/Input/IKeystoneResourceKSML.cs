namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a Keystone resource tailored for KSML usage, extending the base IKeystoneResource with 4‑byte alignment optimizations.</summary>
public unsafe struct IKeystoneResourceKSML
{
    // Base Classes
    public ACBindingsTest.Internal.IKeystoneResource BaseClass_IKeystoneResource; // ACBindingsTest.Internal.IKeystoneResource

    // Child Types
    public unsafe struct IKeystoneResourceKSML_vtbl
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
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IKeystoneResourceKSML*, ushort*> GetData; // function pointer

        // Methods
    }

    // Methods
}

