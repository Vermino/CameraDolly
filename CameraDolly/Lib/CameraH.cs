using System;
using System.Numerics;
using AcClient;
using CameraDolly.Lib;
using UtilityBelt.Service.Lib.ACClientModule;
using Box2D = ACBindingsTest.Internal.Box2D;
using Frame = ACBindingsTest.Internal.Frame;
using Plane = System.Numerics.Plane;
using Position = ACBindingsTest.Internal.Position;
using Render = ACBindingsTest.Internal.Render;
using RenderDevice = ACBindingsTest.Internal.RenderDevice;
using SmartBox = ACBindingsTest.Internal.SmartBox;
using UIElement = ACBindingsTest.Internal.UIElement;
using UIElementManager = ACBindingsTest.Internal.UIElementManager;
using Vector2 = System.Numerics.Vector2;
using Vector3 = System.Numerics.Vector3;

namespace CameraDolly
{
    public unsafe class CameraH
    {
        // Native function addresses from PDB symbols
        private const int ADDR_FRAME_GLOBALTOLOCAL = 0x004526C0;
        private const int ADDR_GET_CHILD_RECURSIVE = 0x00464A00;

        public Matrix4x4 ViewTransform { get; private set; } = Matrix4x4.Identity;
        public Matrix4x4 Projection { get; private set; } = Matrix4x4.Identity;
        public Matrix4x4 ViewProj { get; private set; } = Matrix4x4.Identity;
        public Box2D ViewPortSize { get; private set; } = new Box2D();
        public Plane[] FrustumPlanes { get; private set; } = new Plane[6];
        public Coordinates Coordinates { get; private set; } = new Coordinates(0, 0, 0);

        public CameraH()
        {
        }

        public void Update()
        {
            try
            {
                Coordinates = new Coordinates(
                    SmartBox.smartbox[0]->viewer.objcell_id,
                    SmartBox.smartbox[0]->viewer.frame.m_fOrigin.BaseClass_Vector3.x,
                    SmartBox.smartbox[0]->viewer.frame.m_fOrigin.BaseClass_Vector3.y,
                    SmartBox.smartbox[0]->viewer.frame.m_fOrigin.BaseClass_Vector3.z);
                ViewTransform = GetViewTransform();
                Projection = GetProjection();
                ViewProj = ViewTransform * Projection;

                if (UIElementManager.s_pInstance != null)
                {
                    var rootEl = ((UIElementManager*)*UIElementManager.s_pInstance)->m_pRootElement;
                    var viewport = rootEl->GetChildRecursive(0x1000049Au);
                    if (viewport != null)
                    {
                        ViewPortSize = viewport->BaseClass_UIRegion.m_box;
                    }
                }

                UpdateFrustumPlanes();
            }
            catch (Exception ex)
            {
                UtilityBelt.Service.UBService.LogException(ex);
            }
        }

        public bool ToScreen(Coordinates coords, out Vector2 screenPos)
        {
            var a = new Vector3(coords.LocalX, coords.LocalY, coords.LocalZ);

            return ToScreen(a, out screenPos);
        }

        public bool ToScreen(Position pos, Vector3 a, out Vector2 screenPos)
        {
            var at = Vector3.Transform(a, pos.ToMatrix());

            return ToScreen(at, out screenPos);
        }

        public bool ToScreen(Vector3 a, out Vector2 screenPos)
        {
            var isOnScreen = true;
            var matrix_screen_pos = Matrix4x4.CreateTranslation(a) * ViewProj;
            var l = 1f / matrix_screen_pos.M44;

            var vx = matrix_screen_pos.M41 * l;
            var vy = matrix_screen_pos.M42 * l;
            var vz = matrix_screen_pos.M43 * l;

            if (Math.Abs(vx) > 1 || Math.Abs(vy) > 1 || vz > 1.00002)
            {
                isOnScreen = false;
            }

            var x = (float)Math.Floor(((vx + 1f) * 0.5f) * (ViewPortSize.m_x1 + ViewPortSize.m_x0));
            var y = (float)Math.Floor(((1f - vy) * 0.5f) * (ViewPortSize.m_y1 + ViewPortSize.m_y0));

            screenPos = new Vector2(ViewPortSize.m_x0 + x, ViewPortSize.m_y0 + y);

            return isOnScreen;
        }

        private static AC1Legacy.Vector3*
            Frame_globaltolocal(ref Frame This, AC1Legacy.Vector3* res, AC1Legacy.Vector3* _in) =>
            ((delegate* unmanaged[Thiscall]<ref Frame, AC1Legacy.Vector3*, AC1Legacy.Vector3*, AC1Legacy.Vector3*>)
                ADDR_FRAME_GLOBALTOLOCAL)(ref This, res, _in);
        //.text:004526C0 ; float *__thiscall Frame::globaltolocal(float *this, float *, float *)

        private unsafe static int GetChildRecursive(ref UIElement This, uint _ID)
        {
            return ((delegate* unmanaged[Thiscall]<ref UIElement, uint, int>)ADDR_GET_CHILD_RECURSIVE)(ref This, _ID);
        }

        private Matrix4x4 GetProjection()
        {
            var aspectRatio = RenderDevice.render_device[0]->m_ViewportAspectRatio;
            var fov = SmartBox.smartbox[0]->m_fGameFOV / (aspectRatio - 0.1f);

            return Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, *Render.znear, *Render.zfar);
        }

        private Matrix4x4 GetViewTransform()
        {
            var smartbox = SmartBox.smartbox[0];
            var viewerPos = smartbox->viewer;
            var m_fl2gv = viewerPos.frame.m_fl2gv;

            var _in = new AC1Legacy.Vector3();
            var p = new AC1Legacy.Vector3();
            Frame_globaltolocal(ref viewerPos.frame, &p, &_in);

            var xAxis = new Vector3(m_fl2gv[0], m_fl2gv[1], m_fl2gv[2]);
            // Negate Y-axis for right-handed system
            var yAxis = -new Vector3(m_fl2gv[3], m_fl2gv[4], m_fl2gv[5]);
            var zAxis = new Vector3(m_fl2gv[6], m_fl2gv[7], m_fl2gv[8]);

            var res = Matrix4x4.Identity;

            res.M11 = xAxis.X;
            res.M12 = zAxis.X;
            res.M13 = yAxis.X;
            res.M14 = 0;

            res.M21 = xAxis.Y;
            res.M22 = zAxis.Y;
            res.M23 = yAxis.Y;
            res.M24 = 0;

            res.M31 = xAxis.Z;
            res.M32 = zAxis.Z;
            res.M33 = yAxis.Z;
            res.M34 = 0;

            res.M41 = p.a0.x;
            res.M42 = p.a0.z;
            res.M43 = -p.a0.y; // Negate Z-axis for right-handed system
            res.M44 = 1;

            // Right-handed coordinate system adjustment
            var rhBasis = new Matrix4x4(
                1, 0, 0, 0,
                0, 1, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);

            res = Matrix4x4.Multiply(rhBasis, res);

            return res;
        }

        private void UpdateFrustumPlanes()
        {
            FrustumPlanes[0].Normal = new Vector3(
                ViewProj.M14 - ViewProj.M11,
                ViewProj.M24 - ViewProj.M21,
                ViewProj.M34 - ViewProj.M31);
            FrustumPlanes[0].D = ViewProj.M44 - ViewProj.M41;

            FrustumPlanes[1].Normal = new Vector3(
                ViewProj.M14 + ViewProj.M11,
                ViewProj.M24 + ViewProj.M21,
                ViewProj.M34 + ViewProj.M31);
            FrustumPlanes[1].D = ViewProj.M44 + ViewProj.M41;

            FrustumPlanes[2].Normal = new Vector3(
                ViewProj.M14 - ViewProj.M12,
                ViewProj.M24 - ViewProj.M22,
                ViewProj.M34 - ViewProj.M32);
            FrustumPlanes[2].D = ViewProj.M44 - ViewProj.M42;

            FrustumPlanes[3].Normal = new Vector3(
                ViewProj.M14 + ViewProj.M12,
                ViewProj.M24 + ViewProj.M22,
                ViewProj.M34 + ViewProj.M32);
            FrustumPlanes[3].D = ViewProj.M44 + ViewProj.M42;

            FrustumPlanes[4].Normal = new Vector3(
                ViewProj.M14 - ViewProj.M13,
                ViewProj.M24 - ViewProj.M23,
                ViewProj.M34 - ViewProj.M33);
            FrustumPlanes[4].D = ViewProj.M44 - ViewProj.M43;

            FrustumPlanes[5].Normal = new Vector3(
                ViewProj.M14 + ViewProj.M13,
                ViewProj.M24 + ViewProj.M23,
                ViewProj.M34 + ViewProj.M33);
            FrustumPlanes[5].D = ViewProj.M44 + ViewProj.M43;

            for (var i = 0; i < 6; i++)
            {
                FrustumPlanes[i] = Plane.Normalize(FrustumPlanes[i]);
            }
        }

        /// <summary>
        /// Generates a picking ray from screen coordinates.
        /// </summary>
        /// <param name="mousePos">Mouse position in screen coordinates.</param>
        /// <param name="start">Output: ray origin in world space.</param>
        /// <param name="direction">Output: normalized ray direction in world space.</param>
        public void GetPickRay(Vector2 mousePos, out Vector3 start, out Vector3 direction)
        {
            var viewportSize = new Vector2(
                ViewPortSize.m_x1 - ViewPortSize.m_x0,
                ViewPortSize.m_y1 - ViewPortSize.m_y0);

            // Adjust mouse position relative to viewport
            var adjustedMouse = new Vector2(
                mousePos.X - ViewPortSize.m_x0,
                mousePos.Y - ViewPortSize.m_y0);

            Vector3 nearSource = new Vector3(adjustedMouse.X, adjustedMouse.Y, 0f);
            Vector3 farSource = new Vector3(adjustedMouse.X, adjustedMouse.Y, 1f);

            Vector3 nearPoint = Unproject(nearSource, viewportSize, *Render.znear, *Render.zfar, ViewProj);
            Vector3 farPoint = Unproject(farSource, viewportSize, *Render.znear, *Render.zfar, ViewProj);

            start = nearPoint;
            direction = Vector3.Normalize(farPoint - nearPoint);
        }

        /// <summary>
        /// Unprojects a screen-space point to world space.
        /// </summary>
        /// <param name="source">Screen-space point (X, Y in pixels, Z = 0 for near, 1 for far).</param>
        /// <param name="viewportSize">Size of the viewport.</param>
        /// <param name="minZ">Near clipping plane distance.</param>
        /// <param name="maxZ">Far clipping plane distance.</param>
        /// <param name="worldViewProjection">Combined view-projection matrix.</param>
        /// <returns>World-space position.</returns>
        public static Vector3 Unproject(Vector3 source, Vector2 viewportSize, float minZ, float maxZ,
            Matrix4x4 worldViewProjection)
        {
            Matrix4x4.Invert(worldViewProjection, out var matrix);

            // Convert to normalized device coordinates (-1 to 1)
            source.X = ((source.X / viewportSize.X) * 2f) - 1f;
            source.Y = -(((source.Y / viewportSize.Y) * 2f) - 1f);
            source.Z = (source.Z - minZ) / (maxZ - minZ);

            Vector3 vector = Vector3.Transform(source, matrix);
            float a = (((source.X * matrix.M14) + (source.Y * matrix.M24)) + (source.Z * matrix.M34)) + matrix.M44;

            if (!IsWithinEpsilon(a, 1f))
                vector = vector / a;

            return vector;
        }

        private static bool IsWithinEpsilon(float a, float b)
        {
            float num = a - b;
            return ((-float.Epsilon <= num) && (num <= float.Epsilon));
        }
    }
}
