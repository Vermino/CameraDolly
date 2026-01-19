namespace ACBindingsTest.Internal;


/// <summary>Maps a device type to its unique turbine GUID, enabling identification and lookup of devices within the system.</summary>
public unsafe struct DeviceKeyMapEntry
{
    // Members
    public ACBindingsTest.Internal.DeviceType dt;
    public ACBindingsTest.Internal.Turbine_GUID guid;

    // Methods
}

