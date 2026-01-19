using System.Collections.Generic;

namespace CameraDolly
{
    /// <summary>
    /// Represents a command frame on the timeline that triggers commands at a specific time.
    /// </summary>
    public class CommandFrame
    {
        /// <summary>
        /// The time in seconds on the timeline when this command frame triggers.
        /// </summary>
        public float Time { get; set; }

        /// <summary>
        /// List of commands to dispatch when this frame is reached during playback.
        /// </summary>
        public List<string> Commands { get; set; } = new List<string>();
    }
}
