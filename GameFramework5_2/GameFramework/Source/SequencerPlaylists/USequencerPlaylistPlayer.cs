#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerPlaylistPlayer.h")]
///<summary>Controls playback of playlist items</summary>
public partial class USequencerPlaylistPlayer : UObject {
// SequencerPlaylistPlayer
	public void SetPlaylist(UObject InPlaylist) {}
	public UObject GetPlaylist(UObject ReturnValue) { return default; }
	public UObject GetDefaultPlayer(UObject ReturnValue) { return default; }
	public FOnPlayerSequencerPlaylistSet OnPlaylistSet;
	public bool PlayItem(UObject Item,ESequencerPlaylistPlaybackDirection Direction=ESequencerPlaylistPlaybackDirection,bool ReturnValue) { return default; }
	public bool PauseItem(UObject Item,bool ReturnValue) { return default; }
	public bool StopItem(UObject Item,bool ReturnValue) { return default; }
	public bool ResetItem(UObject Item,bool ReturnValue) { return default; }
	public bool IsPlaying(UObject Item,bool ReturnValue) { return default; }
	public FSequencerPlaylistPlaybackState GetPlaybackState(UObject Item,FSequencerPlaylistPlaybackState ReturnValue) { return default; }
	public bool PlayAll(ESequencerPlaylistPlaybackDirection Direction=ESequencerPlaylistPlaybackDirection,bool ReturnValue) { return default; }
	public bool PauseAll(bool ReturnValue) { return default; }
	public bool StopAll(bool ReturnValue) { return default; }
	public bool ResetAll(bool ReturnValue) { return default; }
	public USequencerPlaylist Playlist;
}
