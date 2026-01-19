namespace ACBindingsTest.Internal;


/// <summary>Provides the primary user interface framework for the application, encapsulating a UIMainFramework instance that manages root UI elements and global UI state.</summary>
public unsafe struct gmUIMainFramework
{
    // Base Classes
    public ACBindingsTest.Internal.UIMainFramework BaseClass_UIMainFramework; // ACBindingsTest.Internal.UIMainFramework

    // Child Types
    public unsafe struct gmUIMainFramework_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, void> gmUIMainFramework_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, uint, uint, ACBindingsTest.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.UIChildFramework*, int> FindChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, ACBindingsTest.Internal.StringInfo*, void> SetErrorMsg; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.gmUIMainFramework*, void> Update; // function pointer

        // Methods
    }

    // Methods
}

