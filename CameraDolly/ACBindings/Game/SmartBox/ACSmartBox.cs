namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a base SmartBox, extending it with specialized event dispatching and readiness logic for the AC subsystem.</summary>
public unsafe struct ACSmartBox
{
    // Base Classes
    public ACBindingsTest.Internal.SmartBox BaseClass_SmartBox; // ACBindingsTest.Internal.SmartBox

    // Child Types
    public unsafe struct ACSmartBox_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACSmartBox*, void> ACSmartBox_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACSmartBox*, ACBindingsTest.Internal.NetBlob*, int> IsReadyToDispatchEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACSmartBox*, ACBindingsTest.Internal.NetBlob*, ACBindingsTest.Internal.NetBlobProcessedStatus> DispatchSmartBoxEvent; // function pointer

        // Methods
    }

    // Methods

    /// <summary>Determines whether an ACSmartBox instance is prepared to process a NetBlob event. If the box has an associated player, it is always considered ready; otherwise readiness depends on the blob’s size and a specific header value.
    /// <code>Offset: 0x0055A1D0
    /// int __thiscall ACSmartBox::IsReadyToDispatchEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The network packet examined for dispatch eligibility.</param>
    /// <returns>1 if ready; 0 if not.</returns>
    public int IsReadyToDispatchEvent(ACBindingsTest.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACSmartBox, ACBindingsTest.Internal.NetBlob*, int>)0x0055A1D0)(ref this, blob);

    /// <summary>Dispatches a network blob event to the smart box, interpreting its command code and invoking appropriate handlers or queuing the blob for later processing.
    /// <code>Offset: 0x0055A210
    /// NetBlobProcessedStatus __thiscall ACSmartBox::DispatchSmartBoxEvent(ACSmartBox*,NetBlob*)</code>
    /// </summary>
    /// <param name="blob">The NetBlob containing the event data.</param>
    /// <returns>NetBlobProcessedStatus indicating whether the blob was queued, processed successfully, or failed.</returns>
    public ACBindingsTest.Internal.NetBlobProcessedStatus DispatchSmartBoxEvent(ACBindingsTest.Internal.NetBlob* blob) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACSmartBox, ACBindingsTest.Internal.NetBlob*, ACBindingsTest.Internal.NetBlobProcessedStatus>)0x0055A210)(ref this, blob);
}

