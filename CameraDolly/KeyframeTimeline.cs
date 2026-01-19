using System;
using System.Collections.Generic;
using System.Numerics;
using ImGuiNET;

namespace CameraDolly
{
    /// <summary>
    /// A timeline widget showing timeline items and command frames as draggable shapes.
    /// Keyframes are squares, command frames are diamonds.
    /// </summary>
    public static class KeyframeTimeline
    {
        private static int _draggingItem = -1;
        private static int _draggingCommand = -1;
        private static float _dragStartX;
        private static float _dragStartTime;
        private static bool _scrubbingPlayhead;
        private static float _cachedTotalDuration;

        // Shared state between sub-methods for current frame
        private static ImGuiIOPtr _io;
        private static ImDrawListPtr _drawList;
        private static float _totalDuration;
        private static float _padding;
        private static float _usableWidth;
        private static float _playheadX;
        private static List<float> _itemTimes;

        /// <summary>
        /// Draws the timeline with scrubbing and handles interaction for both keyframes and command frames.
        /// </summary>
        public static bool Draw(List<TimelineItem> items, List<CommandFrame> commandFrames,
            ref int selectedItem, ref int selectedCommand, ref float currentTime,
            float timelineWidth = 500)
        {
            if (items == null || items.Count == 0)
            {
                ImGui.Text("No items - Record some points first");
                return false;
            }

            // Initialize shared state
            _io = ImGui.GetIO();
            _drawList = ImGui.GetWindowDrawList();
            _totalDuration = SplineUtility.CalculateTotalDuration(items);
            if (_totalDuration <= 0) _totalDuration = 1f;
            currentTime = Math.Max(0, Math.Min(_totalDuration, currentTime));

            _padding = 10f;
            _usableWidth = timelineWidth - _padding * 2;

            // Calculate item times once
            _itemTimes = CalculateItemTimes(items);

            // Draw the three rows
            bool scrubbed = DrawScrubRow(timelineWidth, ref currentTime);
            DrawKeyframeRow(items, timelineWidth, ref selectedItem, ref selectedCommand);
            DrawCommandRow(commandFrames, timelineWidth, ref selectedItem, ref selectedCommand);

            return scrubbed;
        }

        /// <summary>
        /// Calculates the accumulated time for each item in the timeline.
        /// </summary>
        private static List<float> CalculateItemTimes(List<TimelineItem> items)
        {
            var itemTimes = new List<float>();
            float accumulatedTime = 0;
            for (int i = 0; i < items.Count; i++)
            {
                itemTimes.Add(accumulatedTime);
                if (i < items.Count - 1)
                {
                    float segmentLength = SplineUtility.GetSegmentLength(items, i, 10);
                    float speed = items[i].Speed;
                    if (speed <= 0.001f) speed = 0.001f;
                    accumulatedTime += segmentLength / speed;
                }
            }

            return itemTimes;
        }

        /// <summary>
        /// Draws the scrub row with playhead and time markers.
        /// </summary>
        private static bool DrawScrubRow(float timelineWidth, ref float currentTime)
        {
            bool scrubbed = false;

            float scrubRowHeight = 24f;
            var scrubCursorPos = ImGui.GetCursorScreenPos();

            ImGui.InvisibleButton("##scrubRow", new Vector2(timelineWidth, scrubRowHeight));
            bool scrubRowHovered = ImGui.IsItemHovered();

            // Draw background
            var scrubBgMin = scrubCursorPos;
            var scrubBgMax = new Vector2(scrubCursorPos.X + timelineWidth, scrubCursorPos.Y + scrubRowHeight);
            _drawList.AddRectFilled(scrubBgMin, scrubBgMax, 0xFF1A1A1A, 4);

            // Draw time markers
            int numMarkers = 5;
            for (int i = 0; i <= numMarkers; i++)
            {
                float t = i / (float)numMarkers;
                float x = scrubCursorPos.X + _padding + t * _usableWidth;
                _drawList.AddLine(new Vector2(x, scrubCursorPos.Y + scrubRowHeight - 6),
                    new Vector2(x, scrubCursorPos.Y + scrubRowHeight), 0xFF555555, 1);

                string label = $"{t * _totalDuration:F1}s";
                var textSize = ImGui.CalcTextSize(label);
                _drawList.AddText(new Vector2(x - textSize.X / 2, scrubCursorPos.Y + 2), 0xFF888888, label);
            }

            // Handle scrubbing
            if (scrubRowHovered && _io.MouseClicked[0])
            {
                _scrubbingPlayhead = true;
            }

            if (_scrubbingPlayhead)
            {
                if (_io.MouseDown[0])
                {
                    float relX = _io.MousePos.X - scrubCursorPos.X - _padding;
                    float t = Math.Max(0, Math.Min(1, relX / _usableWidth));
                    currentTime = t * _totalDuration;
                    scrubbed = true;
                }
                else
                {
                    _scrubbingPlayhead = false;
                }
            }

            // Draw playhead triangle
            float playheadT = _totalDuration > 0 ? currentTime / _totalDuration : 0;
            _playheadX = scrubCursorPos.X + _padding + playheadT * _usableWidth;

            _drawList.AddTriangleFilled(
                new Vector2(_playheadX, scrubCursorPos.Y + scrubRowHeight - 3),
                new Vector2(_playheadX - 6, scrubCursorPos.Y + scrubRowHeight + 3),
                new Vector2(_playheadX + 6, scrubCursorPos.Y + scrubRowHeight + 3),
                0xFF00AAFF);

            return scrubbed;
        }

        /// <summary>
        /// Draws the keyframe row with draggable keyframe shapes.
        /// </summary>
        private static void DrawKeyframeRow(List<TimelineItem> items, float timelineWidth,
            ref int selectedItem, ref int selectedCommand)
        {
            float itemRowHeight = 36f;
            var kfCursorPos = ImGui.GetCursorScreenPos();

            ImGui.InvisibleButton("##itemRow", new Vector2(timelineWidth, itemRowHeight));

            // Draw background
            var kfBgMin = kfCursorPos;
            var kfBgMax = new Vector2(kfCursorPos.X + timelineWidth, kfCursorPos.Y + itemRowHeight);
            _drawList.AddRectFilled(kfBgMin, kfBgMax, 0xFF2D2D2D, 4);
            _drawList.AddRect(kfBgMin, kfBgMax, 0xFF4A4A4A, 4);

            // Draw label and track
            _drawList.AddText(new Vector2(kfCursorPos.X + 2, kfCursorPos.Y + 2), 0xFF666666, "KF");
            float trackY = kfCursorPos.Y + itemRowHeight / 2;
            float trackHeight = 4;
            _drawList.AddRectFilled(
                new Vector2(kfCursorPos.X + _padding, trackY - trackHeight / 2),
                new Vector2(kfCursorPos.X + timelineWidth - _padding, trackY + trackHeight / 2),
                0xFF505050, 2);

            // Draw keyframe shapes
            float shapeSize = 16;
            for (int i = 0; i < items.Count; i++)
            {
                float t = _totalDuration > 0 ? _itemTimes[i] / _totalDuration : 0;
                float x = kfCursorPos.X + _padding + t * _usableWidth;
                float y = trackY;

                bool isSelected = (i == selectedItem && selectedCommand == -1);
                var shapeMin = new Vector2(x - shapeSize / 2, y - shapeSize / 2);
                var shapeMax = new Vector2(x + shapeSize / 2, y + shapeSize / 2);

                bool isHovered = _io.MousePos.X >= shapeMin.X && _io.MousePos.X <= shapeMax.X &&
                                 _io.MousePos.Y >= shapeMin.Y && _io.MousePos.Y <= shapeMax.Y;
                bool isDragging = (_draggingItem == i);

                uint fillColor = GetKeyframeColor(isSelected, isDragging, isHovered);
                uint borderColor = isSelected ? 0xFFFFFFFF : 0xFF888888;

                _drawList.AddRectFilled(shapeMin, shapeMax, fillColor, 3);
                _drawList.AddRect(shapeMin, shapeMax, borderColor, 3, ImDrawFlags.None, 2);

                string label = i.ToString();
                var textSize = ImGui.CalcTextSize(label);
                _drawList.AddText(new Vector2(x - textSize.X / 2, y - textSize.Y / 2), 0xFF000000, label);

                if (isHovered)
                {
                    ImGui.BeginTooltip();
                    ImGui.Text($"Keyframe #{i}");
                    ImGui.EndTooltip();
                }

                if (isHovered && _io.MouseClicked[0] && _draggingItem == -1 && _draggingCommand == -1 &&
                    !_scrubbingPlayhead)
                {
                    selectedItem = i;
                    selectedCommand = -1;
                    if (i > 0)
                    {
                        _draggingItem = i;
                        _dragStartX = _io.MousePos.X;
                        _dragStartTime = _itemTimes[i];
                        _cachedTotalDuration = _totalDuration;
                    }
                }
            }

            // Handle keyframe dragging
            HandleKeyframeDragging(items);

            // Draw playhead line
            _drawList.AddLine(
                new Vector2(_playheadX, kfCursorPos.Y),
                new Vector2(_playheadX, kfCursorPos.Y + itemRowHeight),
                0xCC00AAFF, 2);
        }

        /// <summary>
        /// Handles dragging logic for keyframes.
        /// </summary>
        private static void HandleKeyframeDragging(List<TimelineItem> items)
        {
            if (_draggingItem > 0)
            {
                if (_io.MouseDown[0])
                {
                    float deltaX = _io.MousePos.X - _dragStartX;
                    float deltaTime = (deltaX / _usableWidth) * _cachedTotalDuration;
                    float newTime = _dragStartTime + deltaTime;

                    float prevTime = _itemTimes[_draggingItem - 1];

                    if (_draggingItem < items.Count - 1)
                    {
                        float nextTime = _itemTimes[_draggingItem + 1];
                        newTime = Math.Max(prevTime + 0.01f, Math.Min(nextTime - 0.01f, newTime));
                    }
                    else
                    {
                        newTime = Math.Max(prevTime + 0.01f, newTime);
                    }

                    float segmentLength = SplineUtility.GetSegmentLength(items, _draggingItem - 1, 10);
                    float newSegmentDuration = newTime - prevTime;
                    if (newSegmentDuration > 0.001f && segmentLength > 0.001f)
                    {
                        items[_draggingItem - 1].Speed = segmentLength / newSegmentDuration;
                    }
                }
                else
                {
                    _draggingItem = -1;
                }
            }
        }

        /// <summary>
        /// Draws the command frame row with draggable diamond shapes.
        /// </summary>
        private static void DrawCommandRow(List<CommandFrame> commandFrames, float timelineWidth,
            ref int selectedItem, ref int selectedCommand)
        {
            float cmdRowHeight = 28f;
            var cmdCursorPos = ImGui.GetCursorScreenPos();

            ImGui.InvisibleButton("##cmdRow", new Vector2(timelineWidth, cmdRowHeight));

            // Draw background
            var cmdBgMin = cmdCursorPos;
            var cmdBgMax = new Vector2(cmdCursorPos.X + timelineWidth, cmdCursorPos.Y + cmdRowHeight);
            _drawList.AddRectFilled(cmdBgMin, cmdBgMax, 0xFF252525, 4);
            _drawList.AddRect(cmdBgMin, cmdBgMax, 0xFF3A3A3A, 4);

            // Draw label and track
            _drawList.AddText(new Vector2(cmdCursorPos.X + 2, cmdCursorPos.Y + 2), 0xFF666666, "CMD");
            float cmdTrackY = cmdCursorPos.Y + cmdRowHeight / 2;
            float trackHeight = 4;
            _drawList.AddRectFilled(
                new Vector2(cmdCursorPos.X + _padding, cmdTrackY - trackHeight / 2),
                new Vector2(cmdCursorPos.X + timelineWidth - _padding, cmdTrackY + trackHeight / 2),
                0xFF404040, 2);

            // Draw command frames
            if (commandFrames != null)
            {
                DrawCommandFrames(commandFrames, cmdCursorPos, cmdTrackY, ref selectedItem, ref selectedCommand);
                HandleCommandDragging(commandFrames);
            }

            // Draw playhead line
            _drawList.AddLine(
                new Vector2(_playheadX, cmdCursorPos.Y),
                new Vector2(_playheadX, cmdCursorPos.Y + cmdRowHeight),
                0xCC00AAFF, 2);
        }

        /// <summary>
        /// Draws individual command frame diamonds.
        /// </summary>
        private static void DrawCommandFrames(List<CommandFrame> commandFrames, Vector2 cursorPos,
            float trackY, ref int selectedItem, ref int selectedCommand)
        {
            float cmdShapeSize = 14;
            for (int i = 0; i < commandFrames.Count; i++)
            {
                var cmd = commandFrames[i];
                float t = _totalDuration > 0 ? cmd.Time / _totalDuration : 0;
                t = Math.Max(0, Math.Min(1, t));
                float x = cursorPos.X + _padding + t * _usableWidth;
                float y = trackY;

                bool isSelected = (i == selectedCommand);
                var hitMin = new Vector2(x - cmdShapeSize / 2, y - cmdShapeSize / 2);
                var hitMax = new Vector2(x + cmdShapeSize / 2, y + cmdShapeSize / 2);

                bool isHovered = _io.MousePos.X >= hitMin.X && _io.MousePos.X <= hitMax.X &&
                                 _io.MousePos.Y >= hitMin.Y && _io.MousePos.Y <= hitMax.Y;
                bool isDragging = (_draggingCommand == i);

                uint fillColor = GetCommandColor(isSelected, isDragging, isHovered);
                uint borderColor = isSelected ? 0xFFFFFFFF : 0xFF888888;

                // Draw diamond shape
                float halfSize = cmdShapeSize / 2;
                _drawList.AddQuadFilled(
                    new Vector2(x, y - halfSize),
                    new Vector2(x + halfSize, y),
                    new Vector2(x, y + halfSize),
                    new Vector2(x - halfSize, y),
                    fillColor);
                _drawList.AddQuad(
                    new Vector2(x, y - halfSize),
                    new Vector2(x + halfSize, y),
                    new Vector2(x, y + halfSize),
                    new Vector2(x - halfSize, y),
                    borderColor, 2);

                // Draw command count
                string cmdLabel = cmd.Commands.Count.ToString();
                var textSize = ImGui.CalcTextSize(cmdLabel);
                _drawList.AddText(new Vector2(x - textSize.X / 2, y - textSize.Y / 2), 0xFF000000, cmdLabel);

                if (isHovered)
                {
                    ImGui.BeginTooltip();
                    ImGui.Text($"Command Frame #{i}");
                    ImGui.Text($"Time: {cmd.Time:F2}s");
                    ImGui.Text($"Commands: {cmd.Commands.Count}");
                    ImGui.EndTooltip();
                }

                if (isHovered && _io.MouseClicked[0] && _draggingItem == -1 && _draggingCommand == -1 &&
                    !_scrubbingPlayhead)
                {
                    selectedCommand = i;
                    selectedItem = -1;
                    _draggingCommand = i;
                    _dragStartX = _io.MousePos.X;
                    _dragStartTime = cmd.Time;
                    _cachedTotalDuration = _totalDuration;
                }
            }
        }

        /// <summary>
        /// Handles dragging logic for command frames.
        /// </summary>
        private static void HandleCommandDragging(List<CommandFrame> commandFrames)
        {
            if (_draggingCommand >= 0 && _draggingCommand < commandFrames.Count)
            {
                if (_io.MouseDown[0])
                {
                    float deltaX = _io.MousePos.X - _dragStartX;
                    float deltaTime = (deltaX / _usableWidth) * _cachedTotalDuration;
                    float newTime = _dragStartTime + deltaTime;
                    newTime = Math.Max(0, Math.Min(_totalDuration, newTime));
                    commandFrames[_draggingCommand].Time = newTime;
                }
                else
                {
                    _draggingCommand = -1;
                }
            }
        }

        private static uint GetKeyframeColor(bool isSelected, bool isDragging, bool isHovered)
        {
            if (isSelected) return 0xFF00AAFF;
            if (isDragging) return 0xFF00FF00;
            if (isHovered) return 0xFFFFAA00;
            return 0xFFCCCCCC;
        }

        private static uint GetCommandColor(bool isSelected, bool isDragging, bool isHovered)
        {
            if (isSelected) return 0xFFFF6600;
            if (isDragging) return 0xFF00FF00;
            if (isHovered) return 0xFFFFAA00;
            return 0xFFAA66FF;
        }
    }
}
