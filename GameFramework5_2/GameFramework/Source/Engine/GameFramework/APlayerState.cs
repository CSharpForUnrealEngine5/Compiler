#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerState.h")]
///<summary>A PlayerState is created for every player on a server (or in a standalone game).</summary>
public partial class APlayerState : AInfo {
// PlayerState
	public float Score;
	public int PlayerId;
	public byte CompressedPing;
	public bool bShouldUpdateReplicatedPing;
	public bool bIsSpectator;
	public bool bOnlySpectator;
	public bool bIsABot;
	public bool bIsInactive;
	public bool bFromPreviousLevel;
	public int StartTime;
	public UClass EngineMessageClass;
	public sbyte SavedNetworkAddress;
	public FUniqueNetIdRepl UniqueId;
	public FOnPlayerStatePawnSet OnPawnSet;
	public APawn PawnPrivate;
	public void OnPawnPrivateDestroyed(UObject InActor) {}
	public sbyte PlayerNamePrivate;
	public void OnRep_Score() {}
	public void OnRep_PlayerName() {}
	public void OnRep_bIsInactive() {}
	public void OnRep_PlayerId() {}
	public void OnRep_UniqueId() {}
	public UObject GetPawn(UObject ReturnValue) { return default; }
	public UObject GetPlayerController(UObject ReturnValue) { return default; }
	public sbyte GetPlayerName(sbyte ReturnValue) { return default; }
	public void ReceiveOverrideWith(UObject OldPlayerState) {}
	public void ReceiveCopyProperties(UObject NewPlayerState) {}
	public float GetScore(float ReturnValue) { return default; }
	public int GetPlayerId(int ReturnValue) { return default; }
	public byte GetCompressedPing(byte ReturnValue) { return default; }
	public float GetPingInMilliseconds(float ReturnValue) { return default; }
	public bool IsSpectator(bool ReturnValue) { return default; }
	public bool IsOnlyASpectator(bool ReturnValue) { return default; }
	public bool IsABot(bool ReturnValue) { return default; }
	public FUniqueNetIdRepl BP_GetUniqueId(FUniqueNetIdRepl ReturnValue) { return default; }
}
