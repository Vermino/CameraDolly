namespace ACBindingsTest.Internal;


/// <summary>Initializes the gameplay UI, building the core framework and presenting the primary SmartBox interface.</summary>
public unsafe struct GamePlayUI
{
    // Base Classes
    public ACBindingsTest.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindingsTest.Internal.UIMainFramework

    // Child Types
    public unsafe struct GamePlayUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, void> GamePlayUI_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, uint, uint, ACBindingsTest.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, ACBindingsTest.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.GamePlayUI*, void> Update; // function pointer

        // Methods
    }

    // Generated Constructor
    public GamePlayUI() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the gameplay user interface by constructing its base framework components and displaying the main smartbox window.
    /// <code>Offset: 0x006A1BC0
    /// void __thiscall GamePlayUI::GamePlayUI(GamePlayUI*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.GamePlayUI, void>)0x006A1BC0)(ref this);
}

