namespace ACBindingsTest.Internal;


/// <summary>Handles command interpretation for the client, mapping input actions to motion commands while maintaining an emote‑to‑command lookup table.</summary>
public unsafe struct ACCmdInterp : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.CommandInterpreter BaseClass_CommandInterpreter; // ACBindingsTest.Internal.CommandInterpreter
    public ACBindingsTest.Internal.gmNoticeHandler BaseClass_gmNoticeHandler; // ACBindingsTest.Internal.gmNoticeHandler

    // Child Types
    public unsafe struct ACCmdInterp_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> ACCmdInterp_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.InputEvent*, byte> OnAction; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, uint, uint, ACBindingsTest.Internal.CallbackLoseFocusResult> OnLoseFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, ACBindingsTest.Internal.CommandList*> WhichList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, float, int, int, void> AddCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint*, int*, float*, int*, int*, int> NukeCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint*, int*, float*, int*, int*, int> BookkeepCommandAndModifyIfNecessary; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> ApplyCurrentMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, void> SetHoldRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, void> SetHoldSidestep; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> ClearAllCommands; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.CommandList*, void> ApplyListHeadMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.CommandList*, void> StopListHeadMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint*, float*, void> ApplyHoldKeysToCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, int, float, ACBindingsTest.Internal.HoldKey, void> MovePlayer_NonAutonomous; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> UITogglesRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> CommenceJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, byte, void> DoJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> HandleNewForwardMovement; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> SendMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> FinishJump; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, System.IntPtr, System.IntPtr, void> SetUI; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> SendPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.SmartBox*, void> SetSmartBox; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> UsePositionFromServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> LoseControlToServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> TakeControlFromServer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, void> NewPlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> LoseKeyboardFocus; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> PlayerTeleported; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> PlayerIsDead; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> HandleExhaustion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> UpdateToggleRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> Disable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> Enable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> IsEnabled; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> IsActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> HandleLogOff; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.CmdStruct*, void> HandleKeyboardCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.CmdStruct*, void> HandleMouseMovementCommand; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, int, float, int, int, void> MovePlayer; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> StopDrift; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> ShouldSendPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, int> SetAutonomyLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint> GetAutonomyLevel; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> IsStandingStill; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> StopCompletely; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> MaybeStopCompletely; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, float, int, int> TurnToHeading; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, void> ToggleAutoRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, int, void> SetAutoRun; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, void> SetMouseLookActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> GetMouseLookActive; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, int> HandleSelectLeft; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int, void> SetMouseLeftDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, int> GetMouseLeftDown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, int> SendAutonomyLevelEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, float, ACBindingsTest.Internal.HoldKey, int> SendDoMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, uint, ACBindingsTest.Internal.HoldKey, int> SendStopMovementEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.MoveToStatePack*, int> SendMoveToStateEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.AutonomousPositionPack*, int> SendAutonomousPositionEvent; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ACCmdInterp*, ACBindingsTest.Internal.TurnToEventPack*, int> SendTurnToEvent; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.HashTable__uint__uint m_hashEmoteInputActionsToCommands;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases server control over this command interpreter, aborts any ongoing automatic combat actions if a combat system is active, then delegates to the base class implementation.
    /// <code>Offset: 0x0058BF90
    /// void __thiscall ACCmdInterp::TakeControlFromServer(ACCmdInterp*)</code>
    /// </summary>
    public void TakeControlFromServer() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058BF90)(ref this);

    /// <summary>Toggles the player's running state via the player system.
    /// <code>Offset: 0x0058BFB0
    /// int __thiscall ACCmdInterp::UITogglesRun(ACCmdInterp*)</code>
    /// </summary>
    /// <returns>Non‑zero if the run state was successfully toggled; zero on failure or when no player system is available.</returns>
    public int UITogglesRun() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, int>)0x0058BFB0)(ref this);

    /// <summary>Triggers a jump action for the player and processes any queued spell selection notice.
    /// <code>Offset: 0x0058BFD0
    /// void __thiscall ACCmdInterp::CommenceJump(ACCmdInterp*)</code>
    /// </summary>
    public void CommenceJump() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058BFD0)(ref this);

    /// <summary>Initiates a jump by delegating to the client combat system, optionally executing an autonomous jump.
    /// <code>Offset: 0x0058BFF0
    /// void __thiscall ACCmdInterp::DoJump(ACCmdInterp*,bool)</code>
    /// </summary>
    /// <param name="autonomous">True to perform an automated (autonomous) jump; false for a player‑initiated jump.</param>
    public void DoJump(byte autonomous) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, byte, void>)0x0058BFF0)(ref this, autonomous);

    /// <summary>Completes a jump operation by informing the client combat system and updating the notice handler with this interpreter’s state.
    /// <code>Offset: 0x0058C000
    /// void __thiscall ACCmdInterp::FinishJump(ACCmdInterp*)</code>
    /// </summary>
    public void FinishJump() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058C000)(ref this);

    /// <summary>Handles forward movement input by aborting any automatic attacks and delegating processing to the base command interpreter.
    /// <code>Offset: 0x0058C020
    /// void __thiscall ACCmdInterp::HandleNewForwardMovement(ACCmdInterp*)</code>
    /// </summary>
    public void HandleNewForwardMovement() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058C020)(ref this);

    /// <summary>Sends an autonomy level change event to the movement system.
    /// <code>Offset: 0x0058C040
    /// int __thiscall ACCmdInterp::SendAutonomyLevelEvent(ACCmdInterp*,unsigned int)</code>
    /// </summary>
    /// <param name="level">The new autonomy level to be reported.</param>
    /// <returns>Result from CM_Movement::Event_AutonomyLevel indicating success or failure.</returns>
    public int SendAutonomyLevelEvent(uint level) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, uint, int>)0x0058C040)(ref this, level);

    /// <summary>Sends a do‑movement event using the specified motion identifier, target speed and hold‑key state.
    /// <code>Offset: 0x0058C060
    /// int __thiscall ACCmdInterp::SendDoMovementEvent(ACCmdInterp*,unsigned int,float,HoldKey)</code>
    /// </summary>
    /// <param name="motion">Motion code identifying the movement action to perform.</param>
    /// <param name="speed">Desired speed for the movement command in units per second.</param>
    /// <param name="hold_key">State indicating whether a movement key should be held during execution.</param>
    /// <returns>Status code returned by CM_Movement::Event_DoMovementCommand; zero indicates success.</returns>
    public int SendDoMovementEvent(uint motion, float speed, ACBindingsTest.Internal.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, uint, float, ACBindingsTest.Internal.HoldKey, int>)0x0058C060)(ref this, motion, speed, hold_key);

    /// <summary>Sends a stop movement command for the given motion type and optional hold key.
    /// <code>Offset: 0x0058C080
    /// int __thiscall ACCmdInterp::SendStopMovementEvent(ACCmdInterp*,unsigned int,HoldKey)</code>
    /// </summary>
    /// <param name="motion">The identifier of the motion to stop.</param>
    /// <param name="hold_key">Specifies whether a key should remain held after stopping.</param>
    /// <returns>An integer status code indicating success or failure of the event dispatch.</returns>
    public int SendStopMovementEvent(uint motion, ACBindingsTest.Internal.HoldKey hold_key) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, uint, ACBindingsTest.Internal.HoldKey, int>)0x0058C080)(ref this, motion, hold_key);

    /// <summary>Sends a move‑to‑state command to the movement subsystem based on supplied MoveToStatePack data and returns the status code.
    /// <code>Offset: 0x0058C0A0
    /// int __thiscall ACCmdInterp::SendMoveToStateEvent(ACCmdInterp*,MoveToStatePack*)</code>
    /// </summary>
    /// <param name="mtsp">Package containing target motion state, position, timestamps, and related parameters for the transition.</param>
    /// <returns>Integer status code returned by CM_Movement::Event_MoveToState.</returns>
    public int SendMoveToStateEvent(ACBindingsTest.Internal.MoveToStatePack* mtsp) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, ACBindingsTest.Internal.MoveToStatePack*, int>)0x0058C0A0)(ref this, mtsp);

    /// <summary>Transmits an autonomous position event based on the supplied AutonomousPositionPack.
    /// <code>Offset: 0x0058C0C0
    /// int __thiscall ACCmdInterp::SendAutonomousPositionEvent(ACCmdInterp*,AutonomousPositionPack*)</code>
    /// </summary>
    /// <param name="app">The AutonomousPositionPack containing position, contact, and timestamp data to be sent.</param>
    /// <returns>An integer status code returned by CM_Movement::Event_AutonomousPosition.</returns>
    public int SendAutonomousPositionEvent(ACBindingsTest.Internal.AutonomousPositionPack* app) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, ACBindingsTest.Internal.AutonomousPositionPack*, int>)0x0058C0C0)(ref this, app);

    /// <summary>Sends a turn-to event to the movement system using the supplied event packet.
    /// <code>Offset: 0x0058C0E0
    /// int __thiscall ACCmdInterp::SendTurnToEvent(ACCmdInterp*,TurnToEventPack*)</code>
    /// </summary>
    /// <param name="tep">The packet containing target direction and other parameters for turning.</param>
    /// <returns>Result of CM_Movement::Event_TurnToEvent, typically indicating success or failure.</returns>
    public int SendTurnToEvent(ACBindingsTest.Internal.TurnToEventPack* tep) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, ACBindingsTest.Internal.TurnToEventPack*, int>)0x0058C0E0)(ref this, tep);

    /// <summary>Handles player option change notices, toggling the run mode when ToggleRun is selected and updating the character’s motion interpreter accordingly.
    /// <code>Offset: 0x0058C100
    /// void __thiscall ACCmdInterp::RecvNotice_PlayerOptionChanged(ACCmdInterp*,PlayerOption)</code>
    /// </summary>
    /// <param name="i_eOption">The player option that triggered the notice.</param>
    public void RecvNotice_PlayerOptionChanged(ACBindingsTest.Internal.PlayerOption i_eOption) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, ACBindingsTest.Internal.PlayerOption, void>)0x0058C100)(ref this, i_eOption);

    /// <summary>Activates or deactivates a specified motion type for the player controlled by this interpreter.
    /// <code>Offset: 0x0058C140
    /// void __thiscall ACCmdInterp::SetMotion(ACCmdInterp*,unsigned int,bool)</code>
    /// </summary>
    /// <param name="motion">The identifier of the motion to modify.</param>
    /// <param name="fOn">True to enable the motion; false to disable it.</param>
    public void SetMotion(uint motion, byte fOn) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, uint, byte, void>)0x0058C140)(ref this, motion, fOn);

    /// <summary>Processes an input event, mapping specific actions to motion commands, handling focus changes, and looking up emote commands via a hash table. Returns true if the event was handled, otherwise false.
    /// <code>Offset: 0x0058C1A0
    /// bool __thiscall ACCmdInterp::OnAction(ACCmdInterp*,const InputEvent*)</code>
    /// </summary>
    /// <param name="i_evt">The input event containing action data to process.</param>
    /// <returns>True if the event triggered a motion command or state change; false if no matching action was found.</returns>
    public byte OnAction(ACBindingsTest.Internal.InputEvent* i_evt) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, ACBindingsTest.Internal.InputEvent*, byte>)0x0058C1A0)(ref this, i_evt);

    /// <summary>Initializes the hash table that maps emote input actions to command identifiers, adding an entry for every supported emotive command.
    /// <code>Offset: 0x0058C340
    /// void __thiscall ACCmdInterp::InitializeEmoteInputActionHash(ACCmdInterp*)</code>
    /// </summary>
    public void InitializeEmoteInputActionHash() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058C340)(ref this);

    /// <summary>Destroys an ACCmdInterp instance, unregistering it from global event handlers, clearing its emote input‑action hash table, invoking base class destructors to release resources, and notifying a global CIDM manager when present.
    /// <code>Offset: 0x0058CA10
    /// void __thiscall ACCmdInterp::~ACCmdInterp(ACCmdInterp*)</code>
    /// </summary>
    /// <param name="this">Pointer to the instance being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ACCmdInterp, void>)0x0058CA10)(ref this);
}

