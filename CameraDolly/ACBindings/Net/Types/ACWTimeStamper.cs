namespace ACBindingsTest.Internal;


/// <summary>Wraps a WTimeStamper instance, initializing its state and assigning a custom virtual function table to provide specialized timestamp handling in the system.</summary>
public unsafe struct ACWTimeStamper
{
    // Base Classes
    public ACBindingsTest.Internal.WTimeStamper BaseClass_WTimeStamper; // ACBindingsTest.Internal.WTimeStamper

    // Child Types
    public unsafe struct ACWTimeStamper_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACWTimeStamper*, void> ACWTimeStamper_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACWTimeStamper*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACWTimeStamper*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACWTimeStamper*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public ACWTimeStamper() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new ACWTimeStamper instance by constructing its WTimeStamper base part and assigning the correct virtual function table.
    /// <code>Offset: 0x005BE470
    /// void __thiscall ACWTimeStamper::ACWTimeStamper(ACWTimeStamper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACWTimeStamper, void>)0x005BE470)(ref this);
}

