namespace ACBindingsTest.Internal;


/// <summary>Describes the rendering device’s display configuration, indicating support for stencil buffers, multisampling, texture render targets, and available pixel formats for render targets, depth buffers, textures, and surfaces.</summary>
public unsafe struct RenderDeviceDisplayInfo
{
    // Members
    public byte bStencilBuffer;
    public byte bTextureRenderTargets;
    public byte bMultiSampling;
    public byte bMultiSample_2_Samples;
    public byte bMultiSample_4_Samples;
    public ACBindingsTest.Internal.PixelFormatID pfRenderTargets;
    public ACBindingsTest.Internal.PixelFormatID pfDepthBuffers;
    public ACBindingsTest.Internal.PixelFormatID pfRGBTextures;
    public ACBindingsTest.Internal.PixelFormatID pfARGBTextures;
    public ACBindingsTest.Internal.PixelFormatID pfAlphaTextures;
    public ACBindingsTest.Internal.PixelFormatID pfRGBSurfaces;
    public ACBindingsTest.Internal.PixelFormatID pfARGBSurfaces;
    public ACBindingsTest.Internal.PixelFormatID pfAlphaSurfaces;
    public ACBindingsTest.Internal.PixelFormatID pfLowRGBSurfaces;
    public ACBindingsTest.Internal.PixelFormatID pfLowARGBSurfaces;
    public ACBindingsTest.Internal.PixelFormatID pfLowAlphaSurfaces;

    // Methods
}

