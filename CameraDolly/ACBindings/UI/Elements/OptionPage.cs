namespace ACBindingsTest.Internal;


/// <summary>Represents a user interface page that holds configurable options, managing the collection of UIOption objects and coordinating option state changes, defaults, and persistence.</summary>
/// <remarks>Provides methods for registering options, restoring values, saving current selections, and notifying listeners when the page’s options change.</remarks>
public unsafe struct OptionPage : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.UIElement BaseClass_UIElement; // ACBindingsTest.Internal.UIElement
    public ACBindingsTest.Internal.IOptionChangeHandler BaseClass_IOptionChangeHandler; // ACBindingsTest.Internal.IOptionChangeHandler

    // Child Types
    public unsafe struct OptionPage_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, void> UIListener_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public fixed byte gapC[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, ACBindingsTest.Internal.UIElement*, uint, int, ACBindingsTest.Internal.UIElementMessageListenResult> ListenToElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIListener*, uint, int, void> ListenToGlobalMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetShouldBlockClicks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> SetShouldEraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, void> SetClampGameViewEdge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte> CheckOverOverride; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> MoveTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> ResizeTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.Box2D*> GetSurfaceBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, int> CompareZLevel; // function pointer
        public System.IntPtr DrawHere;
        public System.IntPtr EraseSelf;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> SetParent; // function pointer
        public fixed byte gap48[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, void> MouseMove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> MouseOver; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte, void> MouseOverTop; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, int, int, byte> MouseHover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> MouseUnhover; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, byte> HasCursor; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> AddChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.UIRegion*, void> RemoveChild; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> DrawStart; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> EraseBackground; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> PreBlit; // function pointer
        public System.IntPtr DrawSelf;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, ACBindingsTest.Internal.Box2D*, ACBindingsTest.Internal.UISurface*, void> PostBlit; // function pointer
        public System.IntPtr DrawChildren;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, void> DrawDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIRegion*, uint, uint, uint, void> MouseTap; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.UIElement*> DynamicCast; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint> GetUIElementType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> SetState; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*> GetParent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.UIElement*> GetAncestorByID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> KeyUp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, float, byte> KeyDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, int, byte> RegisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> UnregisterInputMaps; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.InputEvent*, byte> OnChildAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> Initialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> PostInit; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.AvailablePropertySet*, byte> InqAvailableProperties; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.BaseProperty*, void> OnSetAttribute; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, byte> ContainsProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, uint, ACBindingsTest.Internal.BaseProperty*, byte> InqProperty; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.BaseProperty*, byte> SetProperty; // function pointer
        public fixed byte gapD8[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement.FunctionSignatureChanged> CatchDroppedItem; // function pointer
        public fixed byte gapE0[4];
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, byte, ACBindingsTest.Internal.UIElement.FunctionSignatureChanged> DragAndDropComplete; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement**, byte> DragItem; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*> GetDragAndDropCatcher; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, void> MatchElement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, void> UpdateForChildSizeChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> UpdateForParentVisibilityChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> Activate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> Deactivate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> TakeFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> RelinquishFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> GetActivatable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> SetMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, void> UpdateForScreenPositionChange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIObject*, byte> SetUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIObject**, byte> MakeUIObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement*, byte, void> OnChildActivationChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte> GetShouldBeMouseVisible; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElementMessageInfo*, ACBindingsTest.Internal.UIElementMessageListenResult, ACBindingsTest.Internal.UIElementMessageListenResult> ForwardElementMessage; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElementMessageInfo*, byte> DefElementMessageHandler; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, byte, void> OnVisibilityChanged; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.UIElement*, ACBindingsTest.Internal.UIElement.Intialized_Has_Been_Replaced_With_PostInit> Initialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> SaveCurrentValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> RestoreDefaultValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, byte> RestoreSavedValues; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.OptionPage*, void> InitOptions; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.SmartArray___UIOption_ptr m_UIOptionArray;

    // Generated Constructor
    public OptionPage(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) {
        _ConstructorInternal(layout, full_desc);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Persists current values of all UIOptions in the page and notifies the change handler afterwards.
    /// <code>Offset: 0x004F38C0
    /// bool __thiscall OptionPage::SaveCurrentValues(OptionPage*)</code>
    /// </summary>
    /// <returns>True if every option reported a successful save; otherwise false.</returns>
    public byte SaveCurrentValues() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, byte>)0x004F38C0)(ref this);

    /// <summary>Restores the default values for every option in the page, then notifies the option change handler about the update.
    /// <code>Offset: 0x004F3910
    /// bool __thiscall OptionPage::RestoreDefaultValues(OptionPage*)</code>
    /// </summary>
    /// <returns>True if all options restored defaults successfully; false if any restoration failed.</returns>
    public byte RestoreDefaultValues() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, byte>)0x004F3910)(ref this);

    /// <summary>Restores the selected values for all options in this page, validates each option, and notifies that options have changed.
    /// <code>Offset: 0x004F3960
    /// bool __thiscall OptionPage::RestoreSavedValues(OptionPage*)</code>
    /// </summary>
    /// <returns>True if every restored option reports no character errors; otherwise false.</returns>
    public byte RestoreSavedValues() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, byte>)0x004F3960)(ref this);

    /// <summary>Checks whether the page contains at least one UI option whose selected item has changed.
    /// <code>Offset: 0x004F39C0
    /// bool __thiscall OptionPage::Changed(OptionPage*)</code>
    /// </summary>
    /// <returns>True if any option reports a change; otherwise, false.</returns>
    public byte Changed() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, byte>)0x004F39C0)(ref this);

    /// <summary>Constructs an option page UI element using the provided layout and element descriptors, initializing internal option storage and setting virtual function tables for input handling and option change notifications.
    /// <code>Offset: 0x004F3A00
    /// void __thiscall OptionPage::OptionPage(OptionPage*,const LayoutDesc*,const ElementDesc*)</code>
    /// </summary>
    /// <param name="layout">Layout configuration used to position and size the option page.</param>
    /// <param name="full_desc">Element descriptor defining visual and behavioral properties of the page.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.LayoutDesc* layout, ACBindingsTest.Internal.ElementDesc* full_desc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, ACBindingsTest.Internal.LayoutDesc*, ACBindingsTest.Internal.ElementDesc*, void>)0x004F3A00)(ref this, layout, full_desc);

    /// <summary>Destroys an OptionPage instance, freeing owned UI options and invoking base class destructors.
    /// <code>Offset: 0x004F3A50
    /// void __thiscall OptionPage::~OptionPage(OptionPage*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, void>)0x004F3A50)(ref this);

    /// <summary>Adds a UIOption to this page’s options array, expanding storage as necessary and notifying the option of its new parent context.
    /// <code>Offset: 0x004F3AF0
    /// void __thiscall OptionPage::RegisterOption(OptionPage*,UIOption*)</code>
    /// </summary>
    /// <param name="option">The UIOption instance to associate with this page; if null the call has no effect.</param>
    public void RegisterOption(ACBindingsTest.Internal.UIOption* option) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.OptionPage, ACBindingsTest.Internal.UIOption*, void>)0x004F3AF0)(ref this, option);
}

