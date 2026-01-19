namespace ACBindingsTest.Internal;


/// <summary>Represents a cryptographic hash instance that holds the algorithm identifier, native hash handle, and reference‑counted provider, enabling creation and management of hash operations.</summary>
public unsafe struct CryptoHash
{
    // Base Classes
    public ACBindingsTest.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindingsTest.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct CryptoHash_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoHash*, void> CryptoHash_dtor_0; // function pointer

        // Methods
    }

    // Members
    public uint m_algID;
    public uint m_hHash;
    public ACBindingsTest.Internal.IntrusiveSmartPointer___CryptoProvider m_spProv;

    // Methods
}

