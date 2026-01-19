namespace ACBindingsTest.Internal;


/// <summary>Axis-aligned bounding box defined by minimum and maximum corner vectors.</summary>
public unsafe struct BBox
{
    // Statics
    public static ACBindingsTest.Internal.BBox* s_cZeroAABB = (ACBindingsTest.Internal.BBox*)0x008EF180;

    // Members
    public ACBindingsTest.Internal.Vector3 m_vMin;
    public ACBindingsTest.Internal.Vector3 m_vMax;

    // Methods

    /// <summary>Updates the bounding box so that it encloses the specified point, expanding min and max coordinates as necessary.
    /// <code>Offset: 0x00534E90
    /// void __thiscall BBox::AdjustBBox(BBox*,const Vector3*)</code>
    /// </summary>
    /// <param name="vc">A vector representing a point to be included in the bounding box.</param>
    public void AdjustBBox(ACBindingsTest.Internal.Vector3* vc) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.Vector3*, void>)0x00534E90)(ref this, vc);

    /// <summary>Expands the specified bounding box to include this bounding box's extents.
    /// <code>Offset: 0x005B2E20
    /// void __thiscall BBox::BuildBoundingBox(BBox*,BBox*)</code>
    /// </summary>
    /// <param name="this">The source bounding box whose extents are used for expansion.</param>
    /// <param name="bbox">The target bounding box that will be expanded.</param>
    public void BuildBoundingBox(ACBindingsTest.Internal.BBox* bbox) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.BBox*, void>)0x005B2E20)(ref this, bbox);

    /// <summary>Initializes the bounding box to extreme values for subsequent incremental adjustments.
    /// <code>Offset: 0x005B2EA0
    /// void __thiscall BBox::InitForAdjustment(BBox*)</code>
    /// </summary>
    public void InitForAdjustment() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, void>)0x005B2EA0)(ref this);

    /// <summary>Transforms a bounding box from one coordinate space to another by converting each of its eight corners with Position::localtolocal and updating this box’s min/max bounds accordingly.
    /// <code>Offset: 0x005B2F10
    /// void __thiscall BBox::LocalToLocal(BBox*,const BBox*,const Position*,const Position*)</code>
    /// </summary>
    /// <param name="from_box">The source bounding box whose coordinates are converted.</param>
    /// <param name="from_pos">Position defining the source coordinate system for the conversion.</param>
    /// <param name="to_pos">Position defining the target coordinate system into which the box is transformed.</param>
    public void LocalToLocal(ACBindingsTest.Internal.BBox* from_box, ACBindingsTest.Internal.Position* from_pos, ACBindingsTest.Internal.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.BBox*, ACBindingsTest.Internal.Position*, ACBindingsTest.Internal.Position*, void>)0x005B2F10)(ref this, from_box, from_pos, to_pos);

    /// <summary>
    /// Transforms the bounding box from a local coordinate system into global coordinates based on two position frames, updating this BBox with the resulting extents.
    /// 
    /// <code>Offset: 0x005B31D0
    /// void __thiscall BBox::LocalToGlobal(BBox*,const BBox*,const Position*,const Position*)</code>
    /// </summary>
    /// <param name="from_box">The original bounding box defined in local space.</param>
    /// <param name="from_pos">The source Position representing the local coordinate frame.</param>
    /// <param name="to_pos">The destination Position to which the bounding box is transformed into global space.</param>
    public void LocalToGlobal(ACBindingsTest.Internal.BBox* from_box, ACBindingsTest.Internal.Position* from_pos, ACBindingsTest.Internal.Position* to_pos) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.BBox*, ACBindingsTest.Internal.Position*, ACBindingsTest.Internal.Position*, void>)0x005B31D0)(ref this, from_box, from_pos, to_pos);

    /// <summary>Translates a bounding box from local to global coordinates using the provided origin position’s transformation matrix and adjusts the bounding extents accordingly.
    /// <code>Offset: 0x005B3490
    /// void __thiscall BBox::ConvertToGlobal(BBox*,const Position*)</code>
    /// </summary>
    /// <param name="i_rcOriginPos">The Position containing the origin point and frame matrix for conversion.</param>
    public void ConvertToGlobal(ACBindingsTest.Internal.Position* i_rcOriginPos) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.Position*, void>)0x005B3490)(ref this, i_rcOriginPos);

    /// <summary>Computes the geometric center of the bounding box by averaging its minimum and maximum coordinates.
    /// <code>Offset: 0x005B3840
    /// Vector3* __thiscall BBox::GetCenter(BBox*,Vector3*)</code>
    /// </summary>
    /// <param name="result">Pointer to a Vector3 that will receive the computed center position.</param>
    /// <returns>A pointer to the supplied result vector containing the bounding box’s center.</returns>
    public ACBindingsTest.Internal.Vector3* GetCenter(ACBindingsTest.Internal.Vector3* result) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BBox, ACBindingsTest.Internal.Vector3*, ACBindingsTest.Internal.Vector3*>)0x005B3840)(ref this, result);
}

