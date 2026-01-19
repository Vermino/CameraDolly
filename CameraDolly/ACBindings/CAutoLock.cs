namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a pointer to CCritSec, enabling automatic lock handling in concurrent contexts.</summary>
public unsafe struct CAutoLock
{
    // Members
    public ACBindingsTest.Internal.CCritSec* m_pLock;

    // Methods
}

