using System.Collections.Generic;
using System.Numerics;

namespace CameraDolly
{
    /// <summary>
    /// Shared utility methods for spline interpolation and path calculations.
    /// </summary>
    public static class SplineUtility
    {
        /// <summary>
        /// Catmull-Rom spline interpolation between four control points.
        /// </summary>
        /// <param name="p0">First control point (before start)</param>
        /// <param name="p1">Start point</param>
        /// <param name="p2">End point</param>
        /// <param name="p3">Last control point (after end)</param>
        /// <param name="t">Interpolation parameter [0, 1]</param>
        /// <returns>Interpolated position</returns>
        public static Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
        {
            float t2 = t * t;
            float t3 = t2 * t;

            return 0.5f * (
                (2.0f * p1) +
                (p2 - p0) * t +
                (2.0f * p0 - 5.0f * p1 + 4.0f * p2 - p3) * t2 +
                (3.0f * p1 - 3.0f * p2 + p3 - p0) * t3);
        }

        /// <summary>
        /// Calculates the arc length of a spline segment using numerical integration.
        /// </summary>
        /// <param name="items">Timeline items list</param>
        /// <param name="segmentIndex">Index of the segment (0-based)</param>
        /// <param name="steps">Number of integration steps (higher = more accurate)</param>
        /// <returns>Approximate arc length of the segment</returns>
        public static float GetSegmentLength(IList<TimelineItem> items, int segmentIndex, int steps = 20)
        {
            if (segmentIndex < 0 || segmentIndex >= items.Count - 1) return 0;

            Vector3 p0 = segmentIndex > 0
                ? items[segmentIndex - 1].GetGlobalPosition()
                : items[segmentIndex].GetGlobalPosition();
            Vector3 p1 = items[segmentIndex].GetGlobalPosition();
            Vector3 p2 = items[segmentIndex + 1].GetGlobalPosition();
            Vector3 p3 = segmentIndex < items.Count - 2
                ? items[segmentIndex + 2].GetGlobalPosition()
                : p2;

            float length = 0;
            Vector3 lastPos = p1;

            for (int s = 1; s <= steps; s++)
            {
                float t = s / (float)steps;
                Vector3 currentPos = CatmullRom(p0, p1, p2, p3, t);
                length += Vector3.Distance(lastPos, currentPos);
                lastPos = currentPos;
            }

            return length;
        }

        /// <summary>
        /// Calculates the total duration of all segments in the path.
        /// Duration = distance / speed for each segment.
        /// </summary>
        /// <param name="items">Timeline items list</param>
        /// <param name="steps">Integration steps per segment</param>
        /// <returns>Total duration in seconds</returns>
        public static float CalculateTotalDuration(IList<TimelineItem> items, int steps = 20)
        {
            if (items.Count < 2) return 0;

            float total = 0;
            for (int i = 0; i < items.Count - 1; i++)
            {
                float dist = GetSegmentLength(items, i, steps);
                float speed = items[i].Speed;
                if (speed <= 0.001f) speed = 0.001f;
                total += dist / speed;
            }

            return total;
        }

        public static Vector3 GetGlobalPositionAtTime(IList<TimelineItem> items, float time)
        {
            if (items.Count < 2) return Vector3.Zero;

            float t = time;
            for (int i = 0; i < items.Count - 1; i++)
            {
                float dist = GetSegmentLength(items, i);
                float speed = items[i].Speed;
                if (speed <= 0.001f) speed = 0.001f;
                float duration = dist / speed;

                if (t <= duration)
                {
                    float segT = t / duration;
                    if (segT < 0) segT = 0;
                    if (segT > 1) segT = 1;

                    Vector3 p0 = i > 0
                        ? items[i - 1].GetGlobalPosition()
                        : items[i].GetGlobalPosition();
                    Vector3 p1 = items[i].GetGlobalPosition();
                    Vector3 p2 = items[i + 1].GetGlobalPosition();
                    Vector3 p3 = i < items.Count - 2 ? items[i + 2].GetGlobalPosition() : p2;

                    return CatmullRom(p0, p1, p2, p3, segT);
                }

                t -= duration;
            }

            // Fallback to end
            return items[items.Count - 1].GetGlobalPosition();
        }
    }
}
