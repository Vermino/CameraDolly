namespace ACBindingsTest.Internal;


/// <summary>Handles always‑loaded block management, coordinating timer updates and touch‑mode transitions to maintain continuous operation of critical blocks within the system.</summary>
public unsafe struct AlwaysLoaded
{
    // Base Classes
    public ACBindingsTest.Internal.BlockListLoader BaseClass_BlockListLoader; // ACBindingsTest.Internal.BlockListLoader

    // Child Types
    public unsafe struct AlwaysLoaded_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AlwaysLoaded*, void> AlwaysLoaded_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AlwaysLoaded*, sbyte*, int> Reload; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AlwaysLoaded*, uint, int> fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.CQuickTimer m_timerDoUseTime;
    public int fEnableDontTouch_;
    public double lastDontTouchMode_;
    public int fInDontTouchMode_;
    public double timeStartedNotTouchingCurrentBlock_;

    // Methods
}

