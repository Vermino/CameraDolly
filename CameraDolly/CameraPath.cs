using System.Collections.Generic;
using ACBindingsTest.Internal;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = System.Numerics.Vector3;

namespace CameraDolly
{
    /// <summary>
    /// Represents a position in local frame (landblock + offset).
    /// </summary>
    public struct LocalPosition
    {
        public uint LandblockId { get; set; }
        public Vector3 Offset { get; set; } // Local X, Y, Z within landblock

        /// <summary>
        /// Converts local position to global (EW, NS, Z) coordinates.
        /// </summary>
        public Vector3 ToGlobal()
        {
            float ew = LandblockCoordinates.LandblockToEW(LandblockId, Offset.X);
            float ns = LandblockCoordinates.LandblockToNS(LandblockId, Offset.Y);
            return new Vector3(ew, ns, Offset.Z);
        }

        /// <summary>
        /// Creates a LocalPosition from a Position pointer.
        /// </summary>
        public static unsafe LocalPosition FromPosition(Position* pos)
        {
            return new LocalPosition
            {
                LandblockId = pos->objcell_id,
                Offset = new Vector3(
                    pos->frame.m_fOrigin.BaseClass_Vector3.x,
                    pos->frame.m_fOrigin.BaseClass_Vector3.y,
                    pos->frame.m_fOrigin.BaseClass_Vector3.z)
            };
        }

        /// <summary>
        /// Creates a LocalPosition from global (EW, NS, Z) coordinates.
        /// </summary>
        public static LocalPosition FromGlobal(Vector3 globalPos)
        {
            uint cellId = LandblockCoordinates.GetLandblockFromCoordinates(globalPos.X, globalPos.Y);
            float offsetX = LandblockCoordinates.EWToLandblock(cellId, globalPos.X);
            float offsetY = LandblockCoordinates.NSToLandblock(cellId, globalPos.Y);
            return new LocalPosition
            {
                LandblockId = cellId,
                Offset = new Vector3(offsetX, offsetY, globalPos.Z)
            };
        }
    }

    /// <summary>
    /// A keyframe position on the camera path timeline.
    /// </summary>
    public class PathKeyframe : TimelineItem
    {
        /// <summary>
        /// The position in local frame (landblock + offset).
        /// </summary>
        public LocalPosition LocalPos { get; set; }

        public Quaternion Rotation { get; set; }
        public float Time { get; set; } = 2.0f; // Default duration to reach NEXT node
        public string Notes { get; set; } = "";

        // Target Lock Properties
        public bool LookAtTarget { get; set; }
        public int TargetId { get; set; }
        public Vector3 TargetOffset { get; set; } = new Vector3(0, 0, 0);

        // Removed GetTargetPosition to enforce global coordinate usage

        public override Quaternion GetTargetRotation() => Rotation;

        /// <summary>
        /// Gets the landblock ID for this keyframe.
        /// </summary>
        public uint GetLandblockId() => LocalPos.LandblockId;

        /// <summary>
        /// Gets the global (EW, NS, Z) position for this keyframe.
        /// Used for D3D rendering and cross-landblock interpolation.
        /// </summary>
        public override Vector3 GetGlobalPosition() => LocalPos.ToGlobal();
    }

    /// <summary>
    /// A complete camera path with timeline items (keyframes and object tracks).
    /// </summary>
    public class CameraPath
    {
        public string Name { get; set; } = "New Path";
        public bool IsLooping { get; set; }
        public bool IsReverse { get; set; }

        /// <summary>
        /// All timeline items (keyframes and object tracks).
        /// </summary>
        public List<TimelineItem> Items { get; set; } = new List<TimelineItem>();

        /// <summary>
        /// Command frames that trigger commands at specific times during playback.
        /// </summary>
        public List<CommandFrame> CommandFrames { get; set; } = new List<CommandFrame>();

        /// <summary>
        /// Legacy keyframes list for backwards compatibility.
        /// Returns only PathKeyframe items from the Items list.
        /// </summary>
        public List<PathKeyframe> Keyframes
        {
            get
            {
                var result = new List<PathKeyframe>();
                foreach (var item in Items)
                {
                    if (item is PathKeyframe kf)
                        result.Add(kf);
                }

                return result;
            }
        }
    }
}
