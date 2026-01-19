namespace ACBindingsTest.Internal;


/// <summary>Provides an interface to create, configure, and render TrueType fonts within Direct3D applications.</summary>
/// <remarks>Inherits from IUnknown and is used by D3DXCreateFont to obtain a font resource that can be drawn on the screen.</remarks>
public unsafe struct ID3DXFont
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXFont_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, System.IntPtr, int> GetDevice; // function pointer
        public System.IntPtr GetDescA;
        public System.IntPtr GetDescW;
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, System.IntPtr, int> GetTextMetricsA; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, System.IntPtr, int> GetTextMetricsW; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, System.IntPtr> GetDC; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, uint, System.IntPtr, ACBindingsTest.Internal.tagRECT*, ACBindingsTest.Internal.tagPOINT*, int> GetGlyphData; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, uint, uint, int> PreloadCharacters; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, uint, uint, int> PreloadGlyphs; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, sbyte*, int, int> PreloadTextA; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, ushort*, int, int> PreloadTextW; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, ACBindingsTest.Internal.ID3DXSprite*, sbyte*, int, ACBindingsTest.Internal.tagRECT*, uint, uint, int> DrawTextA; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, ACBindingsTest.Internal.ID3DXSprite*, ushort*, int, ACBindingsTest.Internal.tagRECT*, uint, uint, int> DrawTextW; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, int> OnLostDevice; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXFont*, int> OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

