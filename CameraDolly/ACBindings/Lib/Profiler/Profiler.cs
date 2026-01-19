namespace ACBindingsTest.Internal;


/// <summary>Collects per‑frame performance metrics, organizing data into categories and resetting statistics at the start of each frame.</summary>
public unsafe struct Profiler
{
    // Statics
    public static ACBindingsTest.Internal.ProfilerTypes.CategoryType** ActiveCategories = (ACBindingsTest.Internal.ProfilerTypes.CategoryType**)0x008F20D0;
    public static ACBindingsTest.Internal.ProfilerStats* Stats = (ACBindingsTest.Internal.ProfilerStats*)0x008F20E8;
    public static ACBindingsTest.Internal.ProfilerStats* CapturedStats = (ACBindingsTest.Internal.ProfilerStats*)0x008F23F0;

    // Methods

    /// <summary>Resets all profiling statistics for a new frame, clearing category counters and initializing the active category count.
    /// <code>Offset: 0x005DE390
    /// void __cdecl Profiler::ResetFrameStats()</code>
    /// </summary>
    public static void ResetFrameStats() => ((delegate* unmanaged[Cdecl]<void>)0x005DE390)();
}

