namespace ACBindingsTest.Internal;


/// <summary>Holds an array of four preprocessor header strings stored as PStringBase&lt;char&gt; objects.</summary>
public unsafe struct PreprocHeader
{
    // Members
    public fixed byte header_data_Raw[16];
    public ACBindingsTest.Internal.PStringBase__sbyte* header_data => (ACBindingsTest.Internal.PStringBase__sbyte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref header_data_Raw[0]);

    // Methods
}

