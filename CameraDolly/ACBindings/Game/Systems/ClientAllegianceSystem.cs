namespace ACBindingsTest.Internal;


/// <summary>Manages the player's allegiance data on the client side, handling updates, login notifications, and synchronization with the server. Provides access to the global allegiance system instance and serves as a notice handler for alliance events.</summary>
public unsafe struct ClientAllegianceSystem : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.ClientSystem BaseClass_ClientSystem; // ACBindingsTest.Internal.ClientSystem

    // Statics
    public static ACBindingsTest.Internal.ClientAllegianceSystem** s_pAllegianceSystem = (ACBindingsTest.Internal.ClientAllegianceSystem**)0x008715BC;

    // Child Types
    public unsafe struct ClientAllegianceSystem_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindingsTest.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientSystem*, void> OnStartup; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientSystem*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientSystem*, void> OnBeginCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientSystem*, void> OnEndCharacterSession; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientSystem*, void> OnShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ClientAllegianceSystem*, ACBindingsTest.Internal.ClientAllegianceSystem.Enum8> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer

        // Methods
    }
    // ClientAllegianceSystem::Enum10
    public enum Enum10 : uint
    {
    }
    // ClientAllegianceSystem::Enum11
    public enum Enum11 : uint
    {
    }
    // ClientAllegianceSystem::Enum7
    public enum Enum7 : uint
    {
    }
    // ClientAllegianceSystem::Enum8
    public enum Enum8 : uint
    {
    }
    // ClientAllegianceSystem::Enum9
    public enum Enum9 : uint
    {
    }

    // Members
    public ACBindingsTest.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindingsTest.Internal.CAllegianceProfile m_allegianceProfile;

    // Generated Constructor
    public ClientAllegianceSystem() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Accesses the global instance of the allegiance system.
    /// <code>Offset: 0x0056AD30
    /// ClientAllegianceSystem* __cdecl ClientAllegianceSystem::GetAllegianceSystem()</code>
    /// </summary>
    /// <returns>The singleton ClientAllegianceSystem instance, or nullptr if uninitialized.</returns>
    public static ACBindingsTest.Internal.ClientAllegianceSystem* GetAllegianceSystem() => ((delegate* unmanaged[Cdecl]<ACBindingsTest.Internal.ClientAllegianceSystem*>)0x0056AD30)();

    /// <summary>Clears the alliance data for a character session by resetting member and vassal counts to zero and clearing the allegiance hierarchy.
    /// <code>Offset: 0x0056AD40
    /// void __thiscall ClientAllegianceSystem::OnEndCharacterSession(ClientAllegianceSystem*)</code>
    /// </summary>
    public void OnEndCharacterSession() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, void>)0x0056AD40)(ref this);

    /// <summary>Shuts down the client allegiance system, releasing resources and clearing the global instance reference.
    /// <code>Offset: 0x0056AD50
    /// void __thiscall ClientAllegianceSystem::OnShutdown(ClientAllegianceSystem*)</code>
    /// </summary>
    public void OnShutdown() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, void>)0x0056AD50)(ref this);

    /// <summary>Handles an allegiance update abort notification by forwarding the event to the CM_Allegiance system.
    /// <code>Offset: 0x0056AD70
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdateAborted(ClientAllegianceSystem*,const unsigned int)</code>
    /// </summary>
    /// <param name="etype">The type identifier for the aborted alliance update event.</param>
    /// <returns>Always returns 0, indicating successful handling with no additional action required.</returns>
    public uint Handle_Allegiance__AllegianceUpdateAborted(uint etype) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, uint, uint>)0x0056AD70)(ref this, etype);

    /// <summary>Sends an allegiance login notification for the specified member, indicating whether they are currently logged in.
    /// <code>Offset: 0x0056AD90
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceLoginNotificationEvent(ClientAllegianceSystem*,unsigned int,int)</code>
    /// </summary>
    /// <param name="member">Identifier of the member whose login status is being reported.</param>
    /// <param name="bNowLoggedIn">Nonzero if the member has just logged in; zero otherwise.</param>
    /// <returns>Zero to indicate success.</returns>
    public uint Handle_Allegiance__AllegianceLoginNotificationEvent(uint member, int bNowLoggedIn) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, uint, int, uint>)0x0056AD90)(ref this, member, bNowLoggedIn);

    /// <summary>Destroys a ClientAllegianceSystem instance, releasing its reference count, allegiance profile, and notice handler resources.
    /// <code>Offset: 0x0056ADB0
    /// void __thiscall ClientAllegianceSystem::~ClientAllegianceSystem(ClientAllegianceSystem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, void>)0x0056ADB0)(ref this);

    /// <summary>Retrieves an interface from ClientAllegianceSystem identified by a GUID, storing the status in result and optionally returning a pointer to the requested interface.
    /// <code>Offset: 0x0056ADF0
    /// TResult* __thiscall ClientAllegianceSystem::QueryInterface(ClientAllegianceSystem*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="this">ClientAllegianceSystem instance.</param>
    /// <param name="result">Receives the operation status; m_val set to 0 on success or an error code such as E_NOINTERFACE.</param>
    /// <param name="i_rcInterface">GUID identifying the requested interface.</param>
    /// <param name="o_ppvInterface">Out parameter receiving a pointer to the requested interface if found.</param>
    /// <returns>Pointer to the TResult passed in.</returns>
    public ACBindingsTest.Internal.TResult* QueryInterface(ACBindingsTest.Internal.TResult* result, ACBindingsTest.Internal.Turbine_GUID* i_rcInterface, void** o_ppvInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, ACBindingsTest.Internal.TResult*, ACBindingsTest.Internal.Turbine_GUID*, void**, ACBindingsTest.Internal.TResult*>)0x0056ADF0)(ref this, result, i_rcInterface, o_ppvInterface);

    /// <summary>Synchronizes the client’s allegiance profile with new data and broadcasts an update notice.
    /// <code>Offset: 0x0056AEC0
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceUpdate(ClientAllegianceSystem*,const CAllegianceProfile*,unsigned int)</code>
    /// </summary>
    /// <param name="prof">The updated allegiance profile to copy into the local system state.</param>
    /// <param name="rank">The rank of the player within the allegiance, used in the broadcast notice.</param>
    /// <returns>A status code indicating completion; currently always 0 for success.</returns>
    public uint Handle_Allegiance__AllegianceUpdate(ACBindingsTest.Internal.CAllegianceProfile* prof, uint rank) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, ACBindingsTest.Internal.CAllegianceProfile*, uint, uint>)0x0056AEC0)(ref this, prof, rank);

    /// <summary>Constructs the client allegiance system, initializing interface vtables, reference counter, and internal allegiance profile.
    /// <code>Offset: 0x0056AEF0
    /// void __thiscall ClientAllegianceSystem::ClientAllegianceSystem(ClientAllegianceSystem*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, void>)0x0056AEF0)(ref this);

    /// <summary>Decrements the object's reference count; destroys and frees the object when the count reaches zero.
    /// <code>Offset: 0x0056AF40
    /// unsigned int __thiscall ClientAllegianceSystem::Release(ClientAllegianceSystem*)</code>
    /// </summary>
    /// <returns>The updated reference count after the release operation.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, uint>)0x0056AF40)(ref this);

    /// <summary>Processes an allegiance information response and presents formatted details—including name, patron, and vassals—in the client’s scroll interface.
    /// <code>Offset: 0x0056AF70
    /// unsigned int __thiscall ClientAllegianceSystem::Handle_Allegiance__AllegianceInfoResponseEvent(ClientAllegianceSystem*,unsigned int,const CAllegianceProfile*)</code>
    /// </summary>
    /// <param name="target">The identifier of the target allegiance to display.</param>
    /// <param name="prof">Pointer to the allegiance profile providing context for the operation.</param>
    /// <returns>Zero, indicating successful handling of the event.</returns>
    public uint Handle_Allegiance__AllegianceInfoResponseEvent(uint target, ACBindingsTest.Internal.CAllegianceProfile* prof) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ClientAllegianceSystem, uint, ACBindingsTest.Internal.CAllegianceProfile*, uint>)0x0056AF70)(ref this, target, prof);
}

