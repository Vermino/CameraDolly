namespace ACBindingsTest.Internal;


/// <summary>Combines position offset, scale, and rotation for transforming objects in 3D space.</summary>
public unsafe struct TransformBase
{
    // Members
    public ACBindingsTest.Internal.Vector3 offset;
    public float scale;
    public ACBindingsTest.Internal.Quaternion qt;

    // Methods
}

