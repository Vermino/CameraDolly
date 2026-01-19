namespace ACBindingsTest.Internal;


/// <summary>Maintains a singly‑linked list of blocked objects, each entry holding a reference, a timestamp, and a link to the next node.</summary>
public unsafe struct TSBlockedEntry
{
    // Members
    public ACBindingsTest.Internal.TSBlockedEntry* m_pNext;
    public uint m_stamp;
    public System.IntPtr m_pObj;

    // Methods
}

