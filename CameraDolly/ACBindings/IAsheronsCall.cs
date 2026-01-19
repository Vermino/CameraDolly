namespace ACBindingsTest.Internal;


/// <summary>Holds a COM interface pointer to the Asheron's Call service, enabling interaction with game functionality through standard COM methods.</summary>
public unsafe struct IAsheronsCall
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IAsheronsCall_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, ushort*, ACBindingsTest.Internal.eChatTypes, int> WriteToChat; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, ushort*, int, int> IssueChatBarCommand; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SelectItem; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SetSelectedObjectID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SetPreviousSelectedItemID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetSelectedItemID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetPreviousSelectedItemID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> ExamineObject; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> UseObject; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, uint, int> UseObjectOn; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, uint, int> UseEquippedItem; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, ACBindingsTest.Internal.eCombatMode, int> ChangeCombatMode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, ACBindingsTest.Internal.eCombatMode*, int> GetCombatMode; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, uint, int, int> MoveItemExternal; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, uint, int, int, int> MoveItemInternal; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, uint, int> CastSpell; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int> GetBusyCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> IncrementBusyCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> DecrementBusyCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int> IsStandingStill; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> StopCompletely; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, float, int> TurnToHeading; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int, int> SetAutoRun; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int> GetIsOutdoors; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, double*, double*, int> GetCurCoords; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, float*, float*, float*, float*, int> GetCurLoc; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetPlayerID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetVendorID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetGroundContainerID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> GetSelectedStackCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SetSelectedStackCount; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int> TradeWindow_IsOpen; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint*, int> TradeWindow_GetPartnerID; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> TradeWindow_AddItem; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> TradeWindow_Clear; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> TradeWindow_Accept; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> TradeWindow_Close; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SalvagePanel_Open; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SalvagePanel_Add; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> SalvagePanel_Remove; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> SalvagePanel_Close; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> SalvagePanel_Clear; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> SalvagePanel_Salvage; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int> EndCharacterSession; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int> BeginCharacterSession; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int> GetChatState; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, int*, int*, int> GetScreenDimensions; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, int*, int> ItemIsKnown; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IAsheronsCall*, uint, ushort**, int> GetItemName; // function pointer

        // Methods
    }

    // Methods
}

