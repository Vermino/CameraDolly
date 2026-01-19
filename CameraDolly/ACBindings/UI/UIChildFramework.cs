namespace ACBindingsTest.Internal;


/// <summary>Child element in a UI framework hierarchy that aggregates core framework behavior and holds a reference to its parent.</summary>
public unsafe struct UIChildFramework
{
    // Base Classes
    public ACBindingsTest.Internal.UIFramework BaseClass_UIFramework; // ACBindingsTest.Internal.UIFramework

    // Child Types
    public unsafe struct UIChildFramework_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, void> UIFramework_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, uint, uint, ACBindingsTest.Internal.UIElement*> CreateAndAddRootElement; // function pointer
        public System.IntPtr CreateAndAddRootElementByDataID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, ACBindingsTest.Internal.UIElement**, void> RemoveRootElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, byte, void> Show; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, byte> Shown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, byte, void> ForceHidden; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, ACBindingsTest.Internal.UIChildFramework*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, ACBindingsTest.Internal.UIChildFramework*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIFramework*, ACBindingsTest.Internal.UIChildFramework*, int> FindChild; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIFramework* m_parent;

    // Methods
}

