namespace ACBindingsTest.Internal;


/// <summary>Holds client networking settings including logging callbacks, preferred interface, port assignment, and an option for automatic unique port generation.</summary>
public unsafe struct ClientNetConfiguration
{
    // Base Classes
    public ACBindingsTest.Internal.LoggingFunctions BaseClass_LoggingFunctions; // ACBindingsTest.Internal.LoggingFunctions

    // Members
    public ACBindingsTest.Internal.AC1Legacy.PStringBase__sbyte DesiredInterface;
    public uint dwPort;
    public int bAutoGenerateUniquePort;

    // Methods
}

