namespace ACBindingsTest.Internal;


/// <summary>
/// Facilitates negotiation of RPC syntax between client and server, enabling compatible communication over COM interfaces.
/// </summary>
public unsafe struct IRpcSyntaxNegotiate
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct IRpcSyntaxNegotiate_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IRpcSyntaxNegotiate*, System.IntPtr, int> NegotiateSyntax; // function pointer

        // Methods
    }

    // Methods
}

