namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a unique identifier stamp composed of a major GUID and a minor version number, used for tracking component identity or schema evolution.</summary>
public unsafe struct DatIDStamp
{
    // Members
    public ACBindingsTest.Internal._GUID _maj_vnum;
    public uint _min_vnum;

    // Generated Constructor
    public DatIDStamp() {
        _ConstructorInternal();
    }
    public DatIDStamp(ACBindingsTest.Internal.DatIDStamp* rhs) {
        _ConstructorInternal(rhs);
    }

    // Methods

    /// <summary>Resets the DatIDStamp instance to an empty state by clearing its GUID components and setting the minor version to zero.
    /// <code>Offset: 0x00413960
    /// void __thiscall DatIDStamp::Clear(DatIDStamp*)</code>
    /// </summary>
    public void Clear() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DatIDStamp, void>)0x00413960)(ref this);

    /// <summary>Initializes the DatIDStamp instance, clearing all GUID components and setting the minor version to zero.
    /// <code>Offset: 0x00413980
    /// void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DatIDStamp, void>)0x00413980)(ref this);

    /// <summary>Creates a new DatIDStamp by copying the values of an existing instance.
    /// <code>Offset: 0x004139A0
    /// void __thiscall DatIDStamp::DatIDStamp(DatIDStamp*,const DatIDStamp*)</code>
    /// </summary>
    /// <param name="rhs">The source DatIDStamp to copy from.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.DatIDStamp* rhs) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.DatIDStamp, ACBindingsTest.Internal.DatIDStamp*, void>)0x004139A0)(ref this, rhs);
}

