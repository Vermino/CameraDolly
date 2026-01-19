namespace ACBindingsTest.Internal;


/// <summary>Represents radar display data for an in‑game entity, linking it to its underlying object and defining how it appears visually.</summary>
public unsafe struct RadarInfo
{
    // Members
    public ACBindingsTest.Internal.ACCWeenieObject* object_;
    public ACBindingsTest.Internal.RGBAColor color;
    public ACBindingsTest.Internal.RadarBlipShape shape;

    // Generated Constructor
    public RadarInfo(ACBindingsTest.Internal.ACCWeenieObject* obj) {
        _ConstructorInternal(obj);
    }
    public RadarInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a RadarInfo instance by assigning the supplied object and resetting its color and shape to default values.
    /// <code>Offset: 0x004D8190
    /// void __thiscall RadarInfo::RadarInfo(RadarInfo*,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="obj">The ACCWeenieObject to be represented on the radar.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.ACCWeenieObject* obj) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RadarInfo, ACBindingsTest.Internal.ACCWeenieObject*, void>)0x004D8190)(ref this, obj);

    /// <summary>Initializes a new RadarInfo instance with default values: clears the associated object, sets the blip color to null, and marks the shape as undefined.
    /// <code>Offset: 0x004D81D0
    /// void __thiscall RadarInfo::RadarInfo(RadarInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.RadarInfo, void>)0x004D81D0)(ref this);
}

