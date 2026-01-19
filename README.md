# 🎥 CameraDolly

A [Decal](https://decaldev.com/) plugin for Asheron's Call that provides advanced camera tools for content creators. Features a Free Camera mode for unrestricted movement and a Camera Path system for creating smooth, cinematic cutscenes.

Built against .NET Framework 4.8 using [UtilityBelt.Service](https://gitlab.com/utilitybelt/utilitybelt.service).

## Features

- **Free Camera**: Detach the camera from your character and fly freely through the world.
  - WASD-style controls (remapped to YGHJ to avoid conflicts).
  - Vertical movement (World Z).
  - Adjustable fly speed with sprint modifier.
  - Native mouse look integration.
  - Collision bypass for free camera.
  
- **Camera Paths**: Record and play back smooth camera movements.
  - **Keyframe System**: Set keyframes to define the camera's path.
  - **Spline Interpolation**: Uses Catmull-Rom splines for smooth transitions between points.
  - **Timeline**: Visual timeline interface to scrub through the path and manage keyframes.
  - **Playback Controls**: Play, Stop, Loop, and Reverse modes.
  - **UI Hiding**: Automatically hide the UI during playback for clean recording.

- **Command Frames**: Trigger chat commands at specific points in the timeline (e.g., emotes, spell casting, or text).

## Usage

### Free Camera Controls

| Action | Key |
| :--- | :--- |
| **Move Forward/Back** | `Y` / `H` |
| **Strafe Left/Right** | `G` / `J` |
| **Move Up/Down** | `U` / `I` |
| **Look Around** | Right Mouse Button + Drag |
| **Sprint** | Hold `Shift` |

*Note: Enable Free Camera from the "Camera Paths" tab in the plugin UI.*

### Creating Cinematic Paths

1. **Enable Free Camera** and fly to your starting position.
2. Open the **Camera Paths** tab.
3. Click **Add Keyframe** to record the current position and rotation.
4. Move to the next position and add another keyframe. Repeat as needed.
5. Use the **Timeline** to scrub through your path and preview the movement.
6. **Adjust Timing**:
   - Select a keyframe on the timeline to adjust its speed.
   - Drag keyframes (visual representation coming soon) or manage them via the UI.
7. **Playback**:
   - Click **Play** to start the camera movement.
   - Toggle **Loop** for continuous playback.
   - Toggle **Hide UI** to clear the screen during playback.

### Command Frames

Trigger actions during your cinematic:
1. Scrub the timeline to the desired time.
2. Click **Add Command Frame**.
3. In the Command Frame list, add chat commands (e.g., `/say Hello`, `/e bow`).

## Developing

* The plugin code is located in the `CameraDolly` project.
* `CameraDolly.Loader` is used for hot-reloading during development.

### Setup
1. Build the solution in Visual Studio (`Ctrl+Shift+B`).
2. Add `CameraDolly.Loader.dll` to Decal (Network Filters) and `CameraDolly.dll` to Decal (Plugins).
3. **Important**: Keep `CameraDolly` disabled in the Plugins list and `CameraDolly.Loader` enabled in Network Filters to use hot-reloading.

## Releasing

1. Update the version number in the Project Properties.
2. Build the `Release` configuration.
3. Distribute the `CameraDolly.dll` and dependencies.
