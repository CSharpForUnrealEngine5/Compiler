#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LobbyBeaconClient.h")]
///<summary>A beacon client used for quality timings to a specified session</summary>
public partial class ALobbyBeaconClient : AOnlineBeaconClient {
// LobbyBeaconClient
	public ALobbyBeaconState LobbyState;
	public ALobbyBeaconPlayerState PlayerState;
	public void ClientJoinGame() {}
	public void ClientSetInviteFlags(FJoinabilitySettings Settings) {}
	public void ServerCheat(sbyte Msg) {}
	public ELobbyBeaconJoinState LobbyJoinServerState;
	public void ServerLoginPlayer(sbyte InSessionId,FUniqueNetIdRepl InUniqueId,sbyte UrlString) {}
	public void ServerDisconnectFromLobby() {}
	public void ServerNotifyJoiningServer() {}
	public void ClientAckJoiningServer() {}
	public void ServerKickPlayer(FUniqueNetIdRepl PlayerToKick,sbyte Reason) {}
	public void ServerSetPartyOwner(FUniqueNetIdRepl InUniqueId,FUniqueNetIdRepl InPartyOwnerId) {}
	public void ClientLoginComplete(FUniqueNetIdRepl InUniqueId,bool bWasSuccessful) {}
	public void ClientWasKicked(sbyte KickReason) {}
	public void ClientPlayerJoined(sbyte NewPlayerName,FUniqueNetIdRepl InUniqueId) {}
	public void ClientPlayerLeft(FUniqueNetIdRepl InUniqueId) {}
}
