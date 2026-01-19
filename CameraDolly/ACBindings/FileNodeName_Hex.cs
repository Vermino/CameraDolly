namespace ACBindingsTest.Internal;


/// <summary>Derives from FileNodeName_UInt32 to represent file node names as 32‑bit hexadecimal values, offering cloning and formatted string output.</summary>
public unsafe struct FileNodeName_Hex
{
    // Base Classes
    public ACBindingsTest.Internal.FileNodeName_UInt32 BaseClass_FileNodeName_UInt32; // ACBindingsTest.Internal.FileNodeName_UInt32

    // Methods

    /// <summary>Creates a duplicate of the current FileNodeName_Hex instance as an IFileNodeName object.
    /// <code>Offset: 0x00425D50
    /// IFileNodeName* __thiscall FileNodeName_Hex::Clone(FileNodeName_Hex*)</code>
    /// </summary>
    /// <returns>A newly allocated IFileNodeName containing a copy of this hex node name, or nullptr if memory allocation fails.</returns>
    public ACBindingsTest.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.FileNodeName_Hex, ACBindingsTest.Internal.IFileNodeName*>)0x00425D50)(ref this);

    /// <summary>Converts the 32‑bit hexadecimal name stored in this object into a null‑terminated string formatted as “0xXXXXXXXX”.
    /// <code>Offset: 0x0065C280
    /// int* __thiscall FileNodeName_Hex::ToPString(_DWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the character buffer that contains the resulting hex string.</param>
    /// <returns>The same pointer value supplied in <paramref name="a2"/>, pointing to the formatted string representation of the file node name.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.FileNodeName_Hex, int*, int*>)0x0065C280)(ref this, a2);
}

