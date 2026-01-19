namespace ACBindingsTest.Internal;


/// <summary>Manages block entries by storing them in an ordered list and providing hash‑based lookup, enabling efficient loading and retrieval of block data.</summary>
/// <remarks>Includes a virtual function table pointer to support polymorphism.</remarks>
public unsafe struct BlockListLoader
{
    // Child Types
    public unsafe struct BlockListLoader_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BlockListLoader*, void> BlockListLoader_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BlockListLoader*, sbyte*, int> Reload; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BlockListLoader*, uint, int> fEntryInBlockList; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindingsTest.Internal.NIList___BlockListEntry blockList_;
    public ACBindingsTest.Internal.LongNIHash___BlockListEntry blockHash_;

    // Methods
}

