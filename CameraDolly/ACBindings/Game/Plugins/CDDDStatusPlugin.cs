namespace ACBindingsTest.Internal;


/// <summary>Represents a status plugin prototype, enabling registration and interaction within the application’s plugin framework.</summary>
public unsafe struct CDDDStatusPlugin
{
    // Base Classes
    public ACBindingsTest.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindingsTest.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CDDDStatusPlugin_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CDDDStatusPlugin*, void> CDDDStatusPlugin_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CDDDStatusPlugin*, ACBindingsTest.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CDDDStatusPlugin*, ACBindingsTest.Internal.DDDEvent, uint, void> OnDDDEvent; // function pointer

        // Methods
    }

    // Methods
}

