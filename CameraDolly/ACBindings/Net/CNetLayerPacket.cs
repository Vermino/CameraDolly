namespace ACBindingsTest.Internal;


/// <summary>
/// Encapsulates a network‑layer packet comprising a NetPacket payload, protocol header, and raw data buffer for transmission or reception.
/// Manages addressing, iteration over fragments, and recipient metadata, enabling efficient handling of fragmented messages across the network stack.
/// </summary>
public unsafe struct CNetLayerPacket
{
    // Base Classes
    public ACBindingsTest.Internal.NetPacket BaseClass_NetPacket; // ACBindingsTest.Internal.NetPacket

    // Child Types
    public unsafe struct CNetLayerPacket_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CNetLayerPacket*, void> CNetLayerPacket_dtor_0; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.ProtoHeader m_Hdr;
    public fixed byte m_Data[65484];
    public int m_Addr;
    public ACBindingsTest.Internal.CBufferIterator m_Iter;
    public byte m_bValid;
    public ACBindingsTest.Internal.ReceiverData* m_pRecv;
    public ACBindingsTest.Internal.RecipientData* m_pRecip;
    public uint m_CryptoKey;

    // Methods

    /// <summary>Creates a new CNetLayerPacket instance and initializes all internal fields for network use.
    /// <code>Offset: 0x005AB6A0
    /// CNetLayerPacket* __cdecl CNetLayerPacket::Create()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated packet, or null if memory allocation fails.</returns>
    public static ACBindingsTest.Internal.CNetLayerPacket* Create() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.CNetLayerPacket*>)0x005AB6A0)();

    /// <summary>Resets the packet to its default, empty state by decrementing reference counts on special fragments and blob fragments, clearing pointers, and zeroing all associated fields.
    /// <code>Offset: 0x005AB6C0
    /// void __thiscall CNetLayerPacket::Clear(CNetLayerPacket*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CNetLayerPacket, void>)0x005AB6C0)(ref this);
}

