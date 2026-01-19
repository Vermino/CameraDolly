namespace ACBindingsTest.Internal;


/// <summary>Represents a collection of rectangles forming a region, maintaining pointers to its bounding rectangle, the first rectangle in the sequence, the current number of rectangles, and the allocated capacity for efficient spatial management.</summary>
public unsafe struct Region
{
    // Members
    public ACBindingsTest.Internal.tagRECT* m_lpBoundingERect;
    public ACBindingsTest.Internal.tagRECT* m_lpFirstERect;
    public int m_iNumRects;
    public int m_iNumAllocatedRects;

    // Methods
}

