namespace ACBindingsTest.Internal;


/// <summary>Maintains global profiler statistics and five category-specific frame metrics, enabling detailed performance analysis across various execution segments.</summary>
public unsafe struct ProfilerStats
{
    // Members
    public ACBindingsTest.Internal.ProfilerTypes.GlobalStatsType Global;
    public fixed byte Categories_Raw[680];
    public ACBindingsTest.Internal.ProfilerTypes.FrameStatsType* Categories => (ACBindingsTest.Internal.ProfilerTypes.FrameStatsType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Categories_Raw[0]);

    // Methods
}

