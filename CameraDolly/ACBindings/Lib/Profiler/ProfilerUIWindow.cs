namespace ACBindingsTest.Internal;


/// <summary>Defines a UI window used by the profiler engine, storing the native window handle, auto-positioning flag, category type, and related quick window reference.</summary>
public unsafe struct ProfilerUIWindow
{
    // Members
    public uint m_WindowHandle;
    public byte m_AutoPositionWindow;
    public ACBindingsTest.Internal.ProfilerTypes.CategoryType m_Category;
    public ACBindingsTest.Internal.QuickWindow* m_pQuickWindow;

    // Methods
}

