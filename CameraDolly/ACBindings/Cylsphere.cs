namespace ACBindingsTest.Internal;


/// <summary>Cylindrical shape defined by a base point, height, and radius; used to represent vertical cylinders in 3‑D space for spatial calculations such as bounding volumes or collision detection.</summary>
public unsafe struct Cylsphere
{
    // Members
    public ACBindingsTest.Internal.Vector3 low_pt;
    public float height;
    public float radius;

    // Methods
}

