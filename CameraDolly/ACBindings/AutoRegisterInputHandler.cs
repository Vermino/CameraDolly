namespace ACBindingsTest.Internal;


/// <summary>Automates registration of input handlers by extending CInputHandler and maintaining a count of registered types.</summary>
public unsafe struct AutoRegisterInputHandler
{
    // Base Classes
    public ACBindingsTest.Internal.CInputHandler BaseClass_CInputHandler; // ACBindingsTest.Internal.CInputHandler

    // Child Types
    public unsafe struct AutoRegisterInputHandler_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, ACBindingsTest.Internal.InputEvent*, void> ActionHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, int, int, void> MouseMoveHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, int, int, void> MouseLookHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, byte, int, void> FocusSwitchHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, System.Char, void> CharacterHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AutoRegisterInputHandler*, ACBindingsTest.Internal.QualifiedControl*, uint*, byte> KeyHitHandler; // function pointer

        // Methods
    }

    // Members
    public uint m_RegisteredTypes;

    // Methods
}

