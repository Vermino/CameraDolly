namespace ACBindingsTest.Internal;


/// <summary>Represents a single budget statistic item, storing its descriptive information, current value, and status as reported by the profiler.</summary>
public unsafe struct BudgetStatItem
{
    // Members
    public ACBindingsTest.Internal.BudgetStatInfo sInfo;
    public uint nValue;
    public ACBindingsTest.Internal.ProfilerBudget.Status nStatus;

    // Methods
}

