namespace ACBindingsTest.Internal;


/// <summary>
/// Represents a plugin interface utilized by the application, exposing COM functionality through its embedded IUnknown reference.
/// </summary>
public unsafe struct IACPlugin
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IACPlugin_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ushort**, int> QueryPluginList; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ushort*, ushort**, ushort**, ushort**, int> QueryPluginInformation; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int> OnUIInitialized; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int> OnLoginComplete; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ushort*, ACBindingsTest.Internal.eChatTypes, int*, int> OnChatWindowText; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ushort*, int*, int> OnChatBarEnter; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, uint, int> OnDeleteObject; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, uint, uint, int> OnSelectedTargetChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ACBindingsTest.Internal.eCombatMode, ACBindingsTest.Internal.eCombatMode, int, int> OnCombatModeChange; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int, int> OnBusyCountDecremented; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int, int> OnBusyCountIncremented; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, uint, int> OnTradeWindowOpened; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ACBindingsTest.Internal.eTradeListID, uint, int> OnTradeWindowItemAdded; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int> OnTradeWindowClosed; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ACBindingsTest.Internal.eTradeListID, int> OnTradeWindowAccepted; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, ACBindingsTest.Internal.eTradeListID, int> OnTradeWindowDeclined; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int> OnTradeWindowCleared; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IACPlugin*, int> OnTradeCompleted; // function pointer

        // Methods
    }

    // Methods
}

