namespace ACBindingsTest.Internal;


/// <summary>Facilitates the registration and management of link status plugins within the system.</summary>
public unsafe struct CLinkStatusPlugin
{
    // Base Classes
    public ACBindingsTest.Internal.CPluginPrototype BaseClass_CPluginPrototype; // ACBindingsTest.Internal.CPluginPrototype

    // Child Types
    public unsafe struct CLinkStatusPlugin_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CLinkStatusPlugin*, void> CLinkStatusPlugin_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CLinkStatusPlugin*, ACBindingsTest.Internal.CPluginManager*, void> OnPluggedIn; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CLinkStatusPlugin*, ACBindingsTest.Internal.CLinkStatusAverages*, void> OnHeartbeat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CLinkStatusPlugin*, ACBindingsTest.Internal.NetStatus, int, int, void> OnNetStatusChange; // function pointer

        // Methods
    }

    // Methods
}

