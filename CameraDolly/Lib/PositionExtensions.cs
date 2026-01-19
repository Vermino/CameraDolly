using System.Numerics;
using ACBindingsTest.Internal;

namespace CameraDolly.Lib;

public static class PositionExtensions {
    public static Matrix4x4 ToMatrix(this Position pos) {
        var frame = pos.frame;

        var q = new System.Numerics.Quaternion(frame.qx, frame.qy, frame.qz, frame.qw);

        var rotM = Matrix4x4.CreateFromQuaternion(q);
        var translateM = Matrix4x4.CreateTranslation(frame.m_fOrigin.BaseClass_Vector3.x, frame.m_fOrigin.BaseClass_Vector3.y, frame.m_fOrigin.BaseClass_Vector3.z);

        return rotM * translateM;
    }
}