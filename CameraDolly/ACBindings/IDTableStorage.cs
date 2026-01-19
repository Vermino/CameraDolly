namespace ACBindingsTest.Internal;


/// <summary>Contains a CPluginPrototype instance for use within the application’s plugin framework.</summary>
public unsafe struct IDTableStorage
{
    // Base Classes
    public ACBindingsTest.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindingsTest.Internal.CPluginPrototype

    // Child Types
    public unsafe struct IDTableStorage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, void> IDTableStorage_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, ACBindingsTest.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public System.IntPtr InitFromFilename;
        public System.IntPtr TestForExistance;
        public System.IntPtr OnDone;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, byte> RequestClearAll; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, ACBindingsTest.Internal.IDTableStorageCallback*, byte> RequestAllTypeData; // function pointer
        public System.IntPtr RequestTypeNumber;
        public System.IntPtr SetTypeData;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, ACBindingsTest.Internal.IDTableStorageCallback*, byte> RequestAllMappings; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IDTableStorage*, ACBindingsTest.Internal.IDTableStorageCallback*, uint, byte> RequestMappings; // function pointer
        public System.IntPtr RequestMapping;
        public System.IntPtr SetMapping;
        public System.IntPtr SetDescriptionString;
        public System.IntPtr GetDescriptionString;

        // Methods
    }

    // Methods
}

