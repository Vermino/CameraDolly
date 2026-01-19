namespace ACBindingsTest.Internal;


/// <summary>
/// Represents a node in an interpolation sequence, storing positional data, orientation quaternion, type classification, and extent for motion or animation calculations. Links to adjacent nodes via a singly linked list for efficient traversal during interpolation.
/// </summary>
public unsafe struct InterpolationNode
{
    // Base Classes
    public ACBindingsTest.Internal.LListData BaseClass_LListData; // ACBindingsTest.Internal.LListData

    // Members
    public uint type;
    public ACBindingsTest.Internal.Position p;
    public ACBindingsTest.Internal.AC1Legacy.Vector3 v;
    public float extent;

    // Generated Constructor
    public InterpolationNode() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes an InterpolationNode instance with default values, setting up its linked list pointer, type, position data, and frame quaternion for a stationary identity transform. Also caches the frame for future use.
    /// <code>Offset: 0x00556670
    /// void __thiscall InterpolationNode::InterpolationNode(InterpolationNode*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.InterpolationNode, void>)0x00556670)(ref this);
}

