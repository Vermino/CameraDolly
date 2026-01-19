namespace ACBindingsTest.Internal;


/// <summary>Represents an end‑of‑DDD message, extending FakeMessageData for use within the application’s messaging infrastructure.</summary>
public unsafe struct DDD_EndDDDMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_EndDDDMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_EndDDDMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Methods
}

