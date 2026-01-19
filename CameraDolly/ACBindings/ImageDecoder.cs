namespace ACBindingsTest.Internal;


/// <summary>Decodes raw image data from a source into a destination buffer, handling palette mapping, pixel format conversion, and exposing image dimensions and format information.</summary>
public unsafe struct ImageDecoder
{
    // Child Types
    public unsafe struct ImageDecoder_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ImageDecoder*, int*, int*, ACBindingsTest.Internal.PixelFormatID*, int> ReadHeader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ImageDecoder*, int> Decode; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindingsTest.Internal.RGBAUnion* m_pPal;
    public ACBindingsTest.Internal.DataSource* m_pDataSrc;
    public int m_width;
    public int m_height;
    public int m_pitch;
    public int m_bpp;
    public byte* m_pDataDst;
    public ACBindingsTest.Internal.PixelFormatDesc m_dstPFD;
    public ACBindingsTest.Internal.PixelFormatDesc m_argbPFD;

    // Methods
}

