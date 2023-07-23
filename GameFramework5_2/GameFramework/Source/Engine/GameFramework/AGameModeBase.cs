#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/GameModeBase.h")]
///<summary>The GameModeBase defines the game being played. It governs the game rules, scoring, what actors</summary>
public partial class AGameModeBase : AInfo {
// GameModeBase
	public sbyte OptionsString;
	public UClass GetDefaultPawnClassForController(UObject InController,UClass ReturnValue) { return default; }
	public UClass GameSessionClass;
	public UClass GameStateClass;
	public UClass PlayerControllerClass;
	public UClass PlayerStateClass;
	public UClass HUDClass;
	public UClass DefaultPawnClass;
	public UClass SpectatorClass;
	public UClass ReplaySpectatorPlayerControllerClass;
	public UClass ServerStatReplicatorClass;
	public AGameSession GameSession;
	public AGameStateBase GameState;
	public AServerStatReplicator ServerStatReplicator;
	public int GetNumPlayers(int ReturnValue) { return default; }
	public int GetNumSpectators(int ReturnValue) { return default; }
	public void StartPlay() {}
	public bool HasMatchStarted(bool ReturnValue) { return default; }
	public bool HasMatchEnded(bool ReturnValue) { return default; }
	public bool ShouldReset(UObject ActorToReset,bool ReturnValue) { return default; }
	public void ResetLevel() {}
	public void ReturnToMainMenuHost() {}
	public void K2_PostLogin(UObject NewPlayer) {}
	public void K2_OnLogout(UObject ExitingController) {}
	public void HandleStartingNewPlayer(UObject NewPlayer) {}
	public bool MustSpectate(UObject NewPlayerController,bool ReturnValue) { return default; }
	public bool CanSpectate(UObject Viewer,UObject ViewTarget,bool ReturnValue) { return default; }
	public sbyte DefaultPlayerName;
	public void ChangeName(UObject Controller,sbyte NewName,bool bNameChange) {}
	public void K2_OnChangeName(UObject Other,sbyte NewName,bool bNameChange) {}
	public UObject ChoosePlayerStart(UObject Player,UObject ReturnValue) { return default; }
	public UObject FindPlayerStart(UObject Player,sbyte IncomingName,UObject ReturnValue) { return default; }
	public UObject K2_FindPlayerStart(UObject Player,sbyte IncomingName=TEXT,UObject ReturnValue) { return default; }
	public bool PlayerCanRestart(UObject Player,bool ReturnValue) { return default; }
	public void RestartPlayer(UObject NewPlayer) {}
	public void RestartPlayerAtPlayerStart(UObject NewPlayer,UObject StartSpot) {}
	public void RestartPlayerAtTransform(UObject NewPlayer,FTransform SpawnTransform) {}
	public UObject SpawnDefaultPawnFor(UObject NewPlayer,UObject StartSpot,UObject ReturnValue) { return default; }
	public UObject SpawnDefaultPawnAtTransform(UObject NewPlayer,FTransform SpawnTransform,UObject ReturnValue) { return default; }
	public void InitStartSpot(UObject StartSpot,UObject NewPlayer) {}
	public void K2_OnRestartPlayer(UObject NewPlayer) {}
	public void InitializeHUDForPlayer(UObject NewPlayer) {}
	public void K2_OnSwapPlayerControllers(UObject OldPC,UObject NewPC) {}
	public bool bUseSeamlessTravel;
	public bool bStartPlayersAsSpectators;
	public bool bPauseable;
}
