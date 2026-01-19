namespace ACBindingsTest.Internal;


/// <summary>Encapsulates a player’s core qualities and interfaces, enabling attribute queries and system registration.</summary>
public unsafe struct PlayerDesc
{
    // Base Classes
    public ACBindingsTest.Internal.CACQualities BaseClass_CACQualities; // ACBindingsTest.Internal.CACQualities

    // Child Types
    public unsafe struct PlayerDesc_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, ACBindingsTest.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.DBObj*, byte> ReloadFromDisk; // function pointer
        public System.IntPtr InqPluralNameString;

        // Methods
    }

    // Generated Constructor
    public PlayerDesc() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Checks whether the player has the qualifying flags to be considered a PSR lead by querying two boolean quality attributes.
    /// <code>Offset: 0x00593DE0
    /// bool __thiscall PlayerDesc::PlayerIsPSRLead(PlayerDesc*)</code>
    /// </summary>
    /// <returns>True if either of the relevant qualities is set; otherwise false.</returns>
    public byte PlayerIsPSRLead() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PlayerDesc, byte>)0x00593DE0)(ref this);

    /// <summary>Determines whether the player is a PSR lead or carries the PSR attribute.
    /// <code>Offset: 0x00593E30
    /// bool __thiscall PlayerDesc::PlayerIsPSR(PlayerDesc*)</code>
    /// </summary>
    /// <returns>True if the player is a PSR lead or has the PSR flag set; otherwise, false.</returns>
    public byte PlayerIsPSR() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PlayerDesc, byte>)0x00593E30)(ref this);

    /// <summary>Retrieves the requested interface from a PlayerDesc instance if supported, returning status via result and interface pointer through o_ppvInterface.
    /// <code>Offset: 0x00593F20
    /// TResult* __thiscall PlayerDesc::QueryInterface(PlayerDesc*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">The PlayerDesc object to query.</param>
    /// <param name="result">Structure receiving operation status; set to 0 on success or an error code otherwise.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppvInterface">Receives a pointer to the requested interface when available.</param>
    /// <returns>The same TResult pointer passed in result, containing operation status.</returns>
    public ACBindingsTest.Internal.TResult* QueryInterface(ACBindingsTest.Internal.TResult* result, ACBindingsTest.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PlayerDesc, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*>)0x00593F20)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Initializes a new PlayerDesc instance, configuring its underlying quality interfaces and registering it with the global InterfaceSystem to enable interface queries and system integration.
    /// <code>Offset: 0x00594620
    /// void __thiscall PlayerDesc::PlayerDesc(PlayerDesc*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PlayerDesc, void>)0x00594620)(ref this);

    /// <summary>Releases resources associated with a PlayerDesc by unregistering its interface from the InterfaceSystem and releasing any retained references.
    /// <code>Offset: 0x00594710
    /// void __thiscall PlayerDesc::Cleanup(PlayerDesc*)</code>
    /// </summary>
    public void Cleanup() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PlayerDesc, void>)0x00594710)(ref this);
}

