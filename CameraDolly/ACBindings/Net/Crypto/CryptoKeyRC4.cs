namespace ACBindingsTest.Internal;


/// <summary>Represents an RC4 cryptographic key derived from the base CryptoKey structure.</summary>
/// <remarks>Contains only the underlying CryptoKey; no additional RC4‑specific state is defined within this struct.</remarks>
public unsafe struct CryptoKeyRC4
{
    // Base Classes
    public ACBindingsTest.Internal.CryptoKey BaseClass_CryptoKey; // ACBindingsTest.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKeyRC4_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKeyRC4*, void> CryptoKeyRC4_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKeyRC4*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKeyRC4*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKeyRC4*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKeyRC4*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

