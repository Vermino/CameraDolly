namespace ACBindingsTest.Internal;


/// <summary>Represents a 3DES cryptographic key, extending the generic CryptoKey functionality to support triple-length DES operations within the application.</summary>
public unsafe struct CryptoKey3DES
{
    // Base Classes
    public ACBindingsTest.Internal.CryptoKey BaseClass_CryptoKey; // ACBindingsTest.Internal.CryptoKey

    // Child Types
    public unsafe struct CryptoKey3DES_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKey3DES*, void> CryptoKey3DES_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKey3DES*, byte> GenerateNewKey; // function pointer
        public System.IntPtr StreamEncrypt;
        public System.IntPtr StreamDecrypt;
        public System.IntPtr Encrypt;
        public System.IntPtr Decrypt;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKey3DES*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKey3DES*, byte> ShouldSerializeWithExchangeKey; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CryptoKey3DES*, uint> GetBlobType; // function pointer

        // Methods
    }

    // Methods
}

