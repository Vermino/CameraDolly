namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a Fellowship instance, providing direct access to its data.</summary>
public unsafe struct CFellowship
{
    // Base Classes
    public ACBindingsTest.Internal.Fellowship BaseClass_Fellowship; // ACBindingsTest.Internal.Fellowship

    // Child Types
    public unsafe struct CFellowship_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CFellowship*, void> CFellowship_dtor_0; // function pointer
        public fixed byte gap4[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CFellowship*, uint> GetPackSize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CFellowship*, void**, uint, uint> Pack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CFellowship*, void**, uint, int> UnPack; // function pointer

        // Methods
    }

    // Generated Constructor
    public CFellowship() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a CFellowship instance by constructing its Fellowship base subobject and assigning the appropriate virtual table.
    /// <code>Offset: 0x0059B570
    /// void __thiscall CFellowship::CFellowship(CFellowship*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CFellowship, void>)0x0059B570)(ref this);
}

