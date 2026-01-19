using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using Decal.Adapter;
using Decal.Adapter.Wrappers;

namespace CameraDolly
{
    /// <summary>
    /// Handles D3D visualization of camera paths.
    /// </summary>
    public class PathRenderer : IDisposable
    {
        private readonly List<D3DObj> _d3dShapes = new List<D3DObj>();

        /// <summary>
        /// Clears all rendered D3D shapes.
        /// </summary>
        public void Clear()
        {
            if (_d3dShapes.Count == 0) return;

            foreach (var s in _d3dShapes)
            {
                try
                {
                    s.Dispose();
                }
                catch
                {
                    // D3D disposal errors are non-critical
                }
            }

            _d3dShapes.Clear();
        }

        /// <summary>
        /// Renders the camera path with keyframe markers and spline visualization.
        /// </summary>
        public void DrawPath(CameraPath currentPath)
        {
            Clear();

            if (currentPath.Items.Count < 1) return;

            // Draw timeline items (green boxes for keyframes)
            foreach (var item in currentPath.Items)
            {
                if (item is PathKeyframe kf)
                {
                    Vector3 globalPos = kf.GetGlobalPosition();
                    DrawPoint(globalPos, Color.Lime);
                }
            }

            // Draw Spline
            if (currentPath.Items.Count >= 2)
            {
                DrawSpline(currentPath);
            }

            // Draw Command Frames (Blue Spheres)
            foreach (var cmd in currentPath.CommandFrames)
            {
                var pos = SplineUtility.GetGlobalPositionAtTime(currentPath.Items, cmd.Time);
                DrawCommandMarker(pos, Color.Blue);
            }
        }

        /// <summary>
        /// Draws the spline path with direction rays.
        /// </summary>
        private void DrawSpline(CameraPath currentPath)
        {
            int stepsPerSegment = 35;

            for (int i = 0; i < currentPath.Items.Count - 1; i++)
            {
                var kf1 = currentPath.Items[i] as PathKeyframe;
                var kf2 = currentPath.Items[i + 1] as PathKeyframe;
                if (kf1 == null || kf2 == null) continue;

                // Get LOCAL positions (offset within landblock)
                Vector3 localP1 = kf1.LocalPos.Offset;
                Vector3 localP2 = kf2.LocalPos.Offset;

                // For spline, get adjacent local positions
                Vector3 localP0 = i > 0 && currentPath.Items[i - 1] is PathKeyframe kf0
                    ? kf0.LocalPos.Offset
                    : localP1;
                Vector3 localP3 = i < currentPath.Items.Count - 2 && currentPath.Items[i + 2] is PathKeyframe kf3
                    ? kf3.LocalPos.Offset
                    : localP2;

                // Get rotations
                Quaternion r1 = kf1.Rotation;
                Quaternion r2 = kf2.Rotation;

                // Use landblock from first keyframe for conversion
                uint landblock = kf1.LocalPos.LandblockId;

                Vector3 lastLocalPos = localP1;

                for (int s = 1; s <= stepsPerSegment; s++)
                {
                    float t = s / (float)stepsPerSegment;

                    // Interpolate in LOCAL space
                    Vector3 localPos = SplineUtility.CatmullRom(localP0, localP1, localP2, localP3, t);

                    // Convert to global for drawing the yellow path line
                    Vector3 globalPos = LocalToGlobal(landblock, localPos);
                    Vector3 globalLastPos = LocalToGlobal(landblock, lastLocalPos);
                    DrawLine(globalLastPos, globalPos, Color.Yellow);

                    // Draw ray at every 4th step
                    if (s % 4 == 0)
                    {
                        Quaternion rot = Quaternion.Slerp(r1, r2, t);
                        Vector3 forward = Vector3.Transform(Vector3.UnitY, rot);
                        forward = Vector3.Normalize(forward);
                        DrawRayLocal(landblock, localPos, forward, 2.0f, Color.Teal);
                    }

                    lastLocalPos = localPos;
                }
            }
        }

        /// <summary>
        /// Converts a local position (landblock offset) to global coordinates.
        /// </summary>
        private Vector3 LocalToGlobal(uint landblock, Vector3 localPos)
        {
            float ew = LandblockCoordinates.LandblockToEW(landblock, localPos.X);
            float ns = LandblockCoordinates.LandblockToNS(landblock, localPos.Y);
            return new Vector3(ew, ns, localPos.Z);
        }

        /// <summary>
        /// Draws a ray in local space, converting to global for rendering.
        /// </summary>
        private void DrawRayLocal(uint landblock, Vector3 localStart, Vector3 direction, float lengthLocal, Color color)
        {
            if (lengthLocal <= 0) return;

            try
            {
                Vector3 localEnd = localStart + direction * lengthLocal;
                Vector3 globalStart = LocalToGlobal(landblock, localStart);
                Vector3 globalEnd = LocalToGlobal(landblock, localEnd);

                var obj = CoreManager.Current.D3DService.NewD3DObj();
                obj.Visible = false;
                obj.Color = color.ToArgb();
                obj.SetShape(D3DShape.Cube);

                Vector3 globalMid = (globalStart + globalEnd) / 2;
                obj.Anchor(globalMid.Y, globalMid.X, globalMid.Z + 0.05f);
                obj.OrientToCoords(globalEnd.Y, globalEnd.X, globalEnd.Z + 0.05f, true);

                obj.ScaleX = 0.02f;
                obj.ScaleZ = 0.02f;
                obj.ScaleY = lengthLocal;

                obj.Visible = true;
                _d3dShapes.Add(obj);
            }
            catch
            {
                // D3D creation errors are non-critical
            }
        }

        /// <summary>
        /// Draws a point marker at a global position.
        /// </summary>
        private void DrawPoint(Vector3 globalPos, Color color)
        {
            try
            {
                var obj = CoreManager.Current.D3DService.NewD3DObj();
                obj.Visible = false;
                obj.Color = color.ToArgb();
                obj.SetShape(D3DShape.Cube);

                obj.Anchor(globalPos.Y, globalPos.X, globalPos.Z + 0.05f);
                obj.OrientToCoords(globalPos.Y, globalPos.X, globalPos.Z + 0.05f, true);
                obj.Scale(0.2f);
                obj.Visible = true;

                _d3dShapes.Add(obj);
            }
            catch
            {
                // D3D creation errors are non-critical
            }
        }

        /// <summary>
        /// Draws a line between two global positions.
        /// </summary>
        private void DrawLine(Vector3 start, Vector3 end, Color color)
        {
            var d = Vector3.Distance(start, end);
            if (d <= 0) return;

            try
            {
                var obj = CoreManager.Current.D3DService.NewD3DObj();
                obj.Visible = false;
                obj.Color = color.ToArgb();
                obj.SetShape(D3DShape.Cube);

                var mid = (start + end) / 2;
                obj.Anchor(mid.Y, mid.X, mid.Z + 0.05f);
                obj.OrientToCoords(end.Y, end.X, end.Z + 0.05f, true);

                obj.ScaleX = 0.05f;
                obj.ScaleZ = 0.05f;
                obj.ScaleY = d;

                obj.Visible = true;
                _d3dShapes.Add(obj);
            }
            catch
            {
                // D3D creation errors are non-critical
            }
        }

        private void DrawCommandMarker(Vector3 globalPos, Color color)
        {
            try
            {
                var obj = CoreManager.Current.D3DService.NewD3DObj();
                obj.Visible = false;
                obj.Color = color.ToArgb();
                obj.SetShape(D3DShape.Sphere);

                obj.Anchor(globalPos.Y, globalPos.X, globalPos.Z + 0.05f);
                obj.OrientToCoords(globalPos.Y, globalPos.X, globalPos.Z + 0.05f, true);
                obj.Scale(0.15f);
                obj.Visible = true;

                _d3dShapes.Add(obj);
            }
            catch
            {
            }
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
