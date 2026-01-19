namespace ACBindingsTest.Internal;


/// <summary>Serves as the base interface for string table generation logic, exposing a virtual function table that derived classes implement to create and manage string resources within the application.</summary>
public unsafe struct StringTableGen
{
    // Child Types
    public unsafe struct StringTableGen_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.StringTableGen*, void> StringTableGen_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.StringTableGen*, void> Reset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.StringTableGen*, byte> Save; // function pointer
        public System.IntPtr AddString;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.StringTableGen*, void> Report; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

