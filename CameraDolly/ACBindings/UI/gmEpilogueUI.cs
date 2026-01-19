namespace ACBindingsTest.Internal;


/// <summary>Represents the epilogue UI framework that appears after game completion, listening for element and global messages to trigger Device::Done and log off active players.</summary>
public unsafe struct gmEpilogueUI
{
    // Base Classes
    public ACBindingsTest.Internal.gmUIMainFramework BaseClass_gmUIMainFramework; // ACBindingsTest.Internal.gmUIMainFramework
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct gmEpilogueUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, void> gmEpilogueUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, uint, uint, ACBindingsTest.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, ACBindingsTest.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmEpilogueUI*, void> Update; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement* m_epilogueField;

    // Methods

    /// <summary>Creates a UIMainFramework instance for the epilogue UI, registers element and global messages, adds a root UI element, and logs off any active player session.
    /// <code>Offset: 0x004EA820
    /// UIMainFramework* __cdecl gmEpilogueUI::Create()</code>
    /// </summary>
    /// <returns>Pointer to the newly constructed UIMainFramework, or nullptr if allocation fails.</returns>
    public static ACBindingsTest.Internal.UIMainFramework* Create() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.UIMainFramework*>)0x004EA820)();

    /// <summary>Registers the epilogue UI framework with the global UI flow system in the specified mode.
    /// <code>Offset: 0x004EA8A0
    /// void __cdecl gmEpilogueUI::Register(unsigned int)</code>
    /// </summary>
    /// <param name="mode">Specifies how the UI should be registered, such as its priority or visibility characteristics within the flow.</param>
    public static void Register(uint mode) => ((delegate* unmanaged[Cdecl]<uint, void>)0x004EA8A0)(mode);

    /// <summary>Handles global messages for the epilogue UI; triggers Device::Done() when message ID equals 1.
    /// <code>Offset: 0x004EA8C0
    /// void __thiscall gmEpilogueUI::ListenToGlobalMessage(gmEpilogueUI*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_messageID">The identifier of the received global message.</param>
    /// <param name="i_data_int">Integer data supplied with the message (unused in this implementation).</param>
    public void ListenToGlobalMessage(uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmEpilogueUI, uint, int, void>)0x004EA8C0)(ref this, i_messageID, i_data_int);

    /// <summary>Responds to element messages for the epilogue UI, invoking Device::Done when the specific end‑epilogue message arrives.
    /// <code>Offset: 0x004EA8D0
    /// UIElementMessageListenResult __thiscall gmEpilogueUI::ListenToElementMessage(gmEpilogueUI*,unsigned int,UIElement*,unsigned int,int)</code>
    /// </summary>
    /// <param name="i_elementID">Identifier of the UI element that generated the message.</param>
    /// <param name="i_element">Pointer to the UI element instance sending the message.</param>
    /// <param name="i_messageID">Numeric code identifying the type of message received.</param>
    /// <param name="i_data_int">Additional integer data accompanying the message.</param>
    /// <returns>Result code indicating message handling outcome; always zero in this implementation.</returns>
    public ACBindingsTest.Internal.UIElementMessageListenResult ListenToElementMessage(uint i_elementID, ACBindingsTest.Internal.UIElement* i_element, uint i_messageID, int i_data_int) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.gmEpilogueUI, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult>)0x004EA8D0)(ref this, i_elementID, i_element, i_messageID, i_data_int);
}

