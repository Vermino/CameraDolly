namespace ACBindingsTest.Internal;


/// <summary>Represents an ambient audio instance within the game's audio subsystem, storing its playback state, volume count, descriptor reference, unique identifier, and constant‑sound flag.</summary>
/// <remarks>GetVolume currently returns a fixed 0.0 value regardless of runtime conditions.</remarks>
public unsafe struct AmbientSound
{
    // Child Types
    public unsafe struct AmbientSound_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, void> ResetCount; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, float> GetVolume; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, int> CanHear; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, int> PlayNow; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, float> GetPlayInterval; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, float, ACBindingsTest.Internal.AC1Legacy.Vector3*, ACBindingsTest.Internal.LandDefs.Direction, void> AddTo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, float, void> UpdateSound; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.AmbientSound*, ACBindingsTest.Internal.Position*, int> GetSoundPos; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public int on_queue;
    public float sound_count;
    public ACBindingsTest.Internal.AmbientSTBDesc* desc;
    public uint ambient_sound_id;
    public int constant_sound;

    // Methods

    /// <summary>Retrieves the current playback volume of an ambient sound, currently returning a constant 0.0 regardless of state.
    /// <code>Offset: 0x005518E0
    /// float __thiscall AmbientSound::GetVolume(AmbientSound*)</code>
    /// </summary>
    /// <returns>The volume level as a floating‑point value (always 0.0 in this implementation).</returns>
    public float GetVolume() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.AmbientSound, float>)0x005518E0)(ref this);
}

