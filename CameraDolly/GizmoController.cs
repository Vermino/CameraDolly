using System;
using System.Numerics;
using ImGuiNET;
using ImGuizmoNET;

namespace CameraDolly
{
    /// <summary>
    /// Handles 3D keyframe gizmo operations including picking and manipulation.
    /// </summary>
    public class GizmoController
    {
        private readonly CameraH _cameraH;

        [Flags]
        public enum UpdateType
        {
            None = 0x00000000,
            Translation = 0x00000001,
            Rotation = 0x00000002,
            Scale = 0x00000004,
            All = Translation | Rotation | Scale
        }

        public int SelectedKeyframe { get; set; } = -1;

        public GizmoController(CameraH cameraH)
        {
            _cameraH = cameraH;
            ImGuizmo.Enable(true);
            ImGuizmo.AllowAxisFlip(false);
            ImGuizmo.SetOrthographic(false);
        }

        /// <summary>
        /// Handles picking keyframes from 3D space via mouse click.
        /// </summary>
        public void HandlePicking(Vector2 mousePos)
        {
            var mgr = CameraPathManager.Instance;
            _cameraH.GetPickRay(mousePos, out var rayStart, out var rayDir);

            float closestDist = float.MaxValue;
            int closestIdx = -1;

            for (int i = 0; i < mgr.CurrentPath.Items.Count; i++)
            {
                if (mgr.CurrentPath.Items[i] is PathKeyframe kf)
                {
                    Vector3 kfPos = kf.LocalPos.Offset;
                    Vector3 toPoint = kfPos - rayStart;
                    float t = Vector3.Dot(toPoint, rayDir);
                    if (t > 0)
                    {
                        Vector3 closestPointOnRay = rayStart + rayDir * t;
                        float distSq = Vector3.DistanceSquared(closestPointOnRay, kfPos);
                        if (distSq < 1.0f * 1.0f)
                        {
                            float distFromCam = Vector3.Distance(rayStart, kfPos);
                            if (distFromCam < closestDist)
                            {
                                closestDist = distFromCam;
                                closestIdx = i;
                            }
                        }
                    }
                }
            }

            if (closestIdx != -1)
            {
                SelectedKeyframe = closestIdx;
            }
        }

        /// <summary>
        /// Draws the gizmo for the selected keyframe and handles manipulation.
        /// </summary>
        public void DrawGizmo()
        {
            var io = ImGui.GetIO();
            var view = _cameraH.ViewTransform;
            var proj = _cameraH.Projection;
            var mgr = CameraPathManager.Instance;

            // Handle picking when left mouse clicked outside UI
            if (ImGui.IsMouseClicked(ImGuiMouseButton.Left) && !io.WantCaptureMouse)
            {
                HandlePicking(io.MousePos);
            }

            if (SelectedKeyframe < 0 || SelectedKeyframe >= mgr.CurrentPath.Items.Count) return;
            if (!(mgr.CurrentPath.Items[SelectedKeyframe] is PathKeyframe kf)) return;


            var localOffset = kf.LocalPos.Offset;
            var objMat = Matrix4x4.CreateFromQuaternion(kf.Rotation) * Matrix4x4.CreateTranslation(localOffset);

            var gizmoOperation = OPERATION.ROTATE | OPERATION.TRANSLATE;
            var gizmoMode = MODE.WORLD;
            if (ImGuizmo.Manipulate(ref view.M11, ref proj.M11, gizmoOperation, gizmoMode, ref objMat.M11))
            {
                var updateFlags = UpdateType.None;

                if (((uint)gizmoOperation & (uint)OPERATION.TRANSLATE) != 0)
                    updateFlags |= UpdateType.Translation;

                if (((uint)gizmoOperation & (uint)OPERATION.ROTATE) != 0)
                    updateFlags |= UpdateType.Rotation;

                if (updateFlags != UpdateType.None)
                {
                    ApplyUpdate(objMat, updateFlags, SelectedKeyframe);
                }
            }

            var size = new Vector2(150, 150);
            var offset = new Vector2(io.DisplaySize.X - 270, 50);
            ImGuizmo.ViewManipulate(ref view.M11, ref proj.M11, gizmoOperation, gizmoMode,
                ref objMat.M11, 0, offset, size, 0);
        }

        /// <summary>
        /// Applies gizmo manipulation to the keyframe.
        /// </summary>
        private void ApplyUpdate(Matrix4x4 objMat, UpdateType updateType, int index)
        {
            var mgr = CameraPathManager.Instance;
            if (index < 0 || index >= mgr.CurrentPath.Items.Count) return;
            if (!(mgr.CurrentPath.Items[index] is PathKeyframe kf)) return;

            Vector3 translationV = Vector3.Zero;
            Vector3 rotationV = Vector3.Zero;
            Vector3 scaleV = Vector3.Zero;

            ImGuizmo.DecomposeMatrixToComponents(ref objMat.M11, ref translationV.X, ref rotationV.X, ref scaleV.X);

            LocalPosition? newPos = null;
            Quaternion? newRot = null;

            if (updateType.HasFlag(UpdateType.Translation))
            {
                var currentLocal = kf.LocalPos;
                newPos = new LocalPosition
                {
                    LandblockId = currentLocal.LandblockId,
                    Offset = new Vector3(translationV.X, translationV.Y, translationV.Z)
                };
            }

            if (updateType.HasFlag(UpdateType.Rotation))
            {
                var q = Quaternion.CreateFromRotationMatrix(objMat);
                newRot = new Quaternion(q.X, q.Y, q.Z, q.W);
            }

            mgr.UpdateKeyframe(index, newPos, newRot);
        }
    }
}
