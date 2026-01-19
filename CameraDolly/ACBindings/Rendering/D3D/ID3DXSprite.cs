namespace ACBindingsTest.Internal;


/// <summary>Manages sprite rendering in Direct3D applications, enabling efficient drawing, clipping, and alpha blending of 2D graphics.</summary>
public unsafe struct ID3DXSprite
{
    // Base Classes
    public ACBindingsTest.Internal.IUnknown BaseClass_IUnknown; // ACBindingsTest.Internal.IUnknown

    // Child Types
    public unsafe struct ID3DXSprite_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, ACBindingsTest.Internal._GUID*, void**, int> QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.IUnknown*, uint> Release; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, System.IntPtr, int> GetDevice; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, ACBindingsTest.Internal.D3DXMATRIX*, int> GetTransform; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, ACBindingsTest.Internal.D3DXMATRIX*, int> SetTransform; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, ACBindingsTest.Internal.D3DXMATRIX*, ACBindingsTest.Internal.D3DXMATRIX*, int> SetWorldViewRH; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, ACBindingsTest.Internal.D3DXMATRIX*, ACBindingsTest.Internal.D3DXMATRIX*, int> SetWorldViewLH; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, uint, int> Begin; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, System.IntPtr, ACBindingsTest.Internal.tagRECT*, ACBindingsTest.Internal.D3DXVECTOR3*, ACBindingsTest.Internal.D3DXVECTOR3*, uint, int> Draw; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, int> Flush; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, int> End; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, int> OnLostDevice; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.ID3DXSprite*, int> OnResetDevice; // function pointer

        // Methods
    }

    // Methods
}

