using System.Numerics;

namespace CameraDolly
{
    /// <summary>
    /// Base class for all timeline items (keyframes).
    /// </summary>
    public abstract class TimelineItem
    {
        /// <summary>
        /// Speed to travel to this item (units per second).
        /// </summary>
        public float Speed { get; set; } = 0.1f;

        /// <summary>
        /// Gets the target global position for this timeline item.
        /// </summary>
        public abstract Vector3 GetGlobalPosition();

        /// <summary>
        /// Gets the target rotation for this timeline item.
        /// </summary>
        public abstract Quaternion GetTargetRotation();
    }
}
