namespace ACBindingsTest.Internal;


/// <summary>Encapsulates compiled shader resources, storing the shader version, entry‑point names, and binary blobs for both vertex and pixel stages.</summary>
public unsafe struct ShaderResourceType : System.IDisposable
{
    // Members
    public ACBindingsTest.Internal.ShaderVersionType Version;
    public ACBindingsTest.Internal.PStringBase__sbyte VertexShaderFunctionName;
    public ACBindingsTest.Internal.PStringBase__sbyte PixelShaderFunctionName;
    public ACBindingsTest.Internal.SmartBuffer BinaryVertexShaderData;
    public ACBindingsTest.Internal.SmartBuffer BinaryPixelShaderData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases the binary shader data buffers and decrements reference counts for vertex and pixel shader names, freeing associated memory when counts reach zero.
    /// <code>Offset: 0x0044A3F0
    /// void __thiscall ShaderResourceType::~ShaderResourceType(ShaderResourceType*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ShaderResourceType, void>)0x0044A3F0)(ref this);
}

