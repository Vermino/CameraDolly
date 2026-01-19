namespace ACBindingsTest.Internal;


/// <summary>
/// Manages individual inventory slots for a character, holding pointers to CInvSlotInfo objects that represent equipped items across all body locations.
/// </summary>
public unsafe struct CInvSlotModule : System.IDisposable
{
    // Members
    public ACBindingsTest.Internal.CInvSlotInfo* neckSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* leftWristSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* leftRingSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* rightWristSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* rightRingSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* weaponReadySlot;
    public ACBindingsTest.Internal.CInvSlotInfo* ammoReadySlot;
    public ACBindingsTest.Internal.CInvSlotInfo* shieldReadySlot;
    public ACBindingsTest.Internal.CInvSlotInfo* clothesPantsSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* clothesShirtSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* trinketOneSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* cloakSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* sigilOneSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* sigilTwoSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* sigilThreeSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* headSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* chestSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* abdomenSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* upperArmSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* lowerArmSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* handSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* upperLegSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* lowerLegSlot;
    public ACBindingsTest.Internal.CInvSlotInfo* footSlot;

    // Generated Constructor
    public CInvSlotModule() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes an inventory slot module by allocating and configuring individual slot objects with default values for each equipment location.
    /// <code>Offset: 0x0055E680
    /// void __thiscall CInvSlotModule::CInvSlotModule(CInvSlotModule*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CInvSlotModule, void>)0x0055E680)(ref this);

    /// <summary>Resets every equipment slot in the inventory module, clearing all assigned items by setting each slot’s item ID to zero.
    /// <code>Offset: 0x0055E9C0
    /// void __thiscall CInvSlotModule::Reset(CInvSlotModule*)</code>
    /// </summary>
    public void Reset() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CInvSlotModule, void>)0x0055E9C0)(ref this);

    /// <summary>Releases all inventory slots owned by the module, deleting any allocated CInvSlotInfo objects and clearing member pointers.
    /// <code>Offset: 0x0055F240
    /// void __thiscall CInvSlotModule::~CInvSlotModule(CInvSlotModule*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CInvSlotModule, void>)0x0055F240)(ref this);
}

