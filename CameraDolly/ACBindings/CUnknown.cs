namespace ACBindingsTest.Internal;


/// <summary>Provides a reference‑counted base object that exposes an IUnknown interface, enabling COM‑style lifetime management with thread‑safe AddRef and Release operations.</summary>
public unsafe struct CUnknown
{
    // Base Classes
    public ACBindingsTest.Internal.INonDelegatingUnknown BaseClass_INonDelegatingUnknown; // ACBindingsTest.Internal.INonDelegatingUnknown

    // Child Types
    public unsafe struct CUnknown_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.CUnknown*, ACBindingsTest.Internal._GUID*, void**, int> NonDelegatingQueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.CUnknown*, uint> NonDelegatingAddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.CUnknown*, uint> NonDelegatingRelease; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CUnknown*, void> CUnknown_dtor_c; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.IUnknown* m_pUnknown;
    public int m_cRef;

    // Generated Constructor
    public CUnknown(sbyte* pName, ACBindingsTest.Internal.IUnknown* pUnk) {
        _ConstructorInternal(pName, pUnk);
    }

    // Methods

    /// <summary>Creates a CUnknown instance, optionally exposing an IUnknown interface and initializing its reference count.
    /// <code>Offset: 0x006C1EB0
    /// void __thiscall CUnknown::CUnknown(CUnknown*,const char*,IUnknown*)</code>
    /// </summary>
    /// <param name="pName">Ignored by this constructor; may serve as a debug or descriptive label.</param>
    /// <param name="pUnk">Interface pointer to expose; if null the object itself is used.</param>
    public void _ConstructorInternal(sbyte* pName, ACBindingsTest.Internal.IUnknown* pUnk) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CUnknown, sbyte*, ACBindingsTest.Internal.IUnknown*, void>)0x006C1EB0)(ref this, pName, pUnk);

    /// <summary>Atomically increases the object's reference count and returns the updated count, guaranteeing a minimum of one.
    /// <code>Offset: 0x006C1F30
    /// unsigned int __stdcall CUnknown::NonDelegatingAddRef(CUnknown*)</code>
    /// </summary>
    /// <returns>The current reference count after incrementing, never less than one.</returns>
    public static uint NonDelegatingAddRef(ACBindingsTest.Internal.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.CUnknown*, uint>)0x006C1F30)(this_);

    /// <summary>Decrements the object's reference count atomically and indicates whether the object remains alive.
    /// <code>Offset: 0x006C1F50
    /// unsigned int __stdcall CUnknown::NonDelegatingRelease(CUnknown*)</code>
    /// </summary>
    /// <returns>The updated reference count; returns 0 when the last reference is released.</returns>
    public static uint NonDelegatingRelease(ACBindingsTest.Internal.CUnknown* this_) => ((delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.CUnknown*, uint>)0x006C1F50)(this_);
}

