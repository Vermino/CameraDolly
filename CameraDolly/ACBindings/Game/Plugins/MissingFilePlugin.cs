namespace ACBindingsTest.Internal;


/// <summary>Represents a plugin prototype for handling missing files within the application’s plugin architecture, enabling registration with a plugin manager and integration into the file management workflow.</summary>
public unsafe struct MissingFilePlugin
{
    // Base Classes
    public ACBindingsTest.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindingsTest.Internal.CPluginPrototype

    // Child Types
    public unsafe struct MissingFilePlugin_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.MissingFilePlugin*, void> MissingFilePlugin_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.MissingFilePlugin*, ACBindingsTest.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public System.IntPtr ReportMissingFile;
        public System.IntPtr ReportUnallocatedFile;

        // Methods
    }

    // Methods
}

