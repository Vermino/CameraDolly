namespace ACBindingsTest.Internal;


/// <summary>Represents a pending message patch, encapsulating serialized data through a FakeMessageData member and the line position where the patch should be applied.</summary>
/// <remarks>Uses composition to include FakeMessageData rather than inheriting from it.</remarks>
public unsafe struct DDD_PatchPendingMessage
{
    // Base Classes
    public ACBindingsTest.Internal.FakeMessageData BaseClass_FakeMessageData; // ACBindingsTest.Internal.FakeMessageData

    // Child Types
    public unsafe struct DDD_PatchPendingMessage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DDD_PatchPendingMessage*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer

        // Methods
    }

    // Members
    public uint m_nLinePosition;

    // Methods
}

