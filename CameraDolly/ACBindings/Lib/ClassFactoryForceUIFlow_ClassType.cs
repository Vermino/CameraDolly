namespace ACBindingsTest.Internal;


/// <summary>Provides object creation services for UI flow components, maintaining reference counts through Turbine_RefCount. Supports interface queries and aggregation via IObjectFactory.</summary>
public unsafe struct ClassFactoryForceUIFlow_ClassType
{
    // Base Classes
    public ACBindingsTest.Internal.IObjectFactory BaseClass_IObjectFactory; // ACBindingsTest.Internal.IObjectFactory

    // Child Types
    public unsafe struct ClassFactoryForceUIFlow_ClassType_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.IObjectFactory*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> CreateInstance; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClassFactoryForceUIFlow_ClassType*, ACBindingsTest.Internal.ClassFactoryForceUIFlow_ClassType.Enum20> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClassFactoryForceUIFlow_ClassType::Enum20
    public enum Enum20 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum21
    public enum Enum21 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum5
    public enum Enum5 : uint
    {
    }
    // ClassFactoryForceUIFlow_ClassType::Enum7
    public enum Enum7 : uint
    {
    }

    // Members
    public ACBindingsTest.Internal.Turbine_RefCount m_cTurbineRefCount;

    // Methods

    /// <summary>Retrieves an interface implementation from a ClassFactoryForceUIFlow instance if it supports the requested interface GUID, returning status via a TResult structure and outputting the interface pointer.
    /// <code>Offset: 0x0047AE30
    /// TResult* __thiscall ClassFactoryForceUIFlow_ClassType::QueryInterface(ClassFactoryForceUIFlow_ClassType*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Status holder for the operation; receives 0 on success or an error code on failure.</param>
    /// <param name="rInterfaceType">GUID specifying the desired interface type.</param>
    /// <param name="ppOutInterface">Receives the requested interface pointer upon successful query.</param>
    /// <returns>Pointer to the result structure used to indicate success or failure.</returns>
    public ACBindingsTest.Internal.TResult* QueryInterface(ACBindingsTest.Internal.TResult* result, ACBindingsTest.Internal.Turbine_GUID* rInterfaceType, void** ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClassFactoryForceUIFlow_ClassType, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*>)0x0047AE30)(ref this, result, rInterfaceType, ppOutInterface);

    /// <summary>
    /// Creates a new gmUIFlow instance, queries it for the requested interface type, and returns the resulting object via ppvObject.
    /// If an outer interface is supplied or creation fails, records an error code in result instead of creating the object.
    /// 
    /// <code>Offset: 0x0047AEC0
    /// TResult* __thiscall ClassFactoryForceUIFlow_ClassType::CreateInstance(ClassFactoryForceUIFlow_ClassType*,TResult*,Interface*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Structure where status and returned pointer are stored.</param>
    /// <param name="pOuterInterface">Optional outer interface for aggregation; must be null.</param>
    /// <param name="rInterfaceType">GUID specifying the desired interface to query on the created object.</param>
    /// <param name="ppvObject">Output parameter that receives a pointer to the created object.</param>
    /// <returns>Pointer to the result structure containing status and value.</returns>
    public ACBindingsTest.Internal.TResult* CreateInstance(ACBindingsTest.Internal.TResult* result, ACBindingsTest.Internal.Interface* pOuterInterface, ACBindingsTest.Internal.Turbine_GUID* rInterfaceType, void** ppvObject) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClassFactoryForceUIFlow_ClassType, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*>)0x0047AEC0)(ref this, result, pOuterInterface, rInterfaceType, ppvObject);
}

