namespace ACBindingsTest.Internal;


/// <summary>Tracks high‑resolution timestamps to calculate elapsed intervals, using m_startTime as the starting point.</summary>
/// <remarks>Holds a virtual function table pointer for polymorphic behavior within the application.</remarks>
public unsafe struct CStopWatch
{
    // Child Types
    public unsafe struct CStopWatch_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CStopWatch*, void> CStopWatch_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CStopWatch*, void> Start; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CStopWatch*, double> Stop; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public double m_startTime;

    // Methods
}

