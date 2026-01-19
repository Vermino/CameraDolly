namespace ACBindingsTest.Internal;


/// <summary>Encapsulates rendering data for a 3D view, storing total vertex count, polygon list, and vertex details.</summary>
public unsafe struct view_type
{
    // Members
    public uint vertex_count_total;
    public ACBindingsTest.Internal.DArray___view_poly poly;
    public ACBindingsTest.Internal.DArray___view_vertex vertex;

    // Methods
}

