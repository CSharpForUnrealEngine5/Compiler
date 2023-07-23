#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayer.h")]
///<summary>Implements a media player asset that can play movies and other media sources.</summary>
public partial class UMediaPlayer : UObject {
// MediaPlayer
	public bool CanPause(bool ReturnValue) { return default; }
	public bool CanPlaySource(UObject MediaSource,bool ReturnValue) { return default; }
	public bool CanPlayUrl(sbyte Url,bool ReturnValue) { return default; }
	public void Close() {}
	public int GetAudioTrackChannels(int TrackIndex,int FormatIndex,int ReturnValue) { return default; }
	public int GetAudioTrackSampleRate(int TrackIndex,int FormatIndex,int ReturnValue) { return default; }
	public sbyte GetAudioTrackType(int TrackIndex,int FormatIndex,sbyte ReturnValue) { return default; }
	public sbyte GetDesiredPlayerName(sbyte ReturnValue) { return default; }
	public FTimespan GetDuration(FTimespan ReturnValue) { return default; }
	public float GetHorizontalFieldOfView(float ReturnValue) { return default; }
	public sbyte GetMediaName(sbyte ReturnValue) { return default; }
	public int GetNumTracks(EMediaPlayerTrack TrackType,int ReturnValue) { return default; }
	public int GetNumTrackFormats(EMediaPlayerTrack TrackType,int TrackIndex,int ReturnValue) { return default; }
	public sbyte GetPlayerName(sbyte ReturnValue) { return default; }
	public UObject GetPlaylist(UObject ReturnValue) { return default; }
	public int GetPlaylistIndex(int ReturnValue) { return default; }
	public float GetRate(float ReturnValue) { return default; }
	public int GetSelectedTrack(EMediaPlayerTrack TrackType,int ReturnValue) { return default; }
	public void GetSupportedRates(TArray<FFloatRange> OutRates,bool Unthinned) {}
	public FTimespan GetTime(FTimespan ReturnValue) { return default; }
	public UObject GetTimeStamp(UObject ReturnValue) { return default; }
	public sbyte GetTrackDisplayName(EMediaPlayerTrack TrackType,int TrackIndex,sbyte ReturnValue) { return default; }
	public int GetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex,int ReturnValue) { return default; }
	public sbyte GetTrackLanguage(EMediaPlayerTrack TrackType,int TrackIndex,sbyte ReturnValue) { return default; }
	public sbyte GetUrl(sbyte ReturnValue) { return default; }
	public float GetVerticalFieldOfView(float ReturnValue) { return default; }
	public float GetVideoTrackAspectRatio(int TrackIndex,int FormatIndex,float ReturnValue) { return default; }
	public FIntPoint GetVideoTrackDimensions(int TrackIndex,int FormatIndex,FIntPoint ReturnValue) { return default; }
	public float GetVideoTrackFrameRate(int TrackIndex,int FormatIndex,float ReturnValue) { return default; }
	public FFloatRange GetVideoTrackFrameRates(int TrackIndex,int FormatIndex,FFloatRange ReturnValue) { return default; }
	public sbyte GetVideoTrackType(int TrackIndex,int FormatIndex,sbyte ReturnValue) { return default; }
	public FRotator GetViewRotation(FRotator ReturnValue) { return default; }
	public FTimespan GetTimeDelay(FTimespan ReturnValue) { return default; }
	public bool HasError(bool ReturnValue) { return default; }
	public bool IsBuffering(bool ReturnValue) { return default; }
	public bool IsConnecting(bool ReturnValue) { return default; }
	public bool IsLooping(bool ReturnValue) { return default; }
	public bool IsPaused(bool ReturnValue) { return default; }
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsPreparing(bool ReturnValue) { return default; }
	public bool IsClosed(bool ReturnValue) { return default; }
	public bool IsReady(bool ReturnValue) { return default; }
	public bool Next(bool ReturnValue) { return default; }
	public bool OpenFile(sbyte FilePath,bool ReturnValue) { return default; }
	public bool OpenPlaylist(UObject InPlaylist,bool ReturnValue) { return default; }
	public bool OpenPlaylistIndex(UObject InPlaylist,int Index,bool ReturnValue) { return default; }
	public bool OpenSource(UObject MediaSource,bool ReturnValue) { return default; }
	public bool OpenSourceWithOptions(UObject MediaSource,FMediaPlayerOptions Options,bool ReturnValue) { return default; }
	public void OpenSourceLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,UObject MediaSource,FMediaPlayerOptions Options,bool bSuccess) {}
	public bool OpenUrl(sbyte Url,bool ReturnValue) { return default; }
	public bool Pause(bool ReturnValue) { return default; }
	public bool Play(bool ReturnValue) { return default; }
	public void PlayAndSeek() {}
	public bool Previous(bool ReturnValue) { return default; }
	public bool Reopen(bool ReturnValue) { return default; }
	public bool Rewind(bool ReturnValue) { return default; }
	public bool Seek(FTimespan Time,bool ReturnValue) { return default; }
	public bool SelectTrack(EMediaPlayerTrack TrackType,int TrackIndex,bool ReturnValue) { return default; }
	public void SetBlockOnTime(FTimespan Time) {}
	public void SetDesiredPlayerName(sbyte PlayerName) {}
	public bool SetLooping(bool Looping,bool ReturnValue) { return default; }
	public void SetMediaOptions(UObject Options) {}
	public bool SetRate(float Rate,bool ReturnValue) { return default; }
	public bool SetNativeVolume(float Volume,bool ReturnValue) { return default; }
	public bool SetTrackFormat(EMediaPlayerTrack TrackType,int TrackIndex,int FormatIndex,bool ReturnValue) { return default; }
	public bool SetVideoTrackFrameRate(int TrackIndex,int FormatIndex,float FrameRate,bool ReturnValue) { return default; }
	public bool SetViewField(float Horizontal,float Vertical,bool Absolute,bool ReturnValue) { return default; }
	public bool SetViewRotation(FRotator Rotation,bool Absolute,bool ReturnValue) { return default; }
	public void SetTimeDelay(FTimespan TimeDelay) {}
	public bool SupportsRate(float Rate,bool Unthinned,bool ReturnValue) { return default; }
	public bool SupportsScrubbing(bool ReturnValue) { return default; }
	public bool SupportsSeeking(bool ReturnValue) { return default; }
	public FOnMediaPlayerMediaEvent OnEndReached;
	public FOnMediaPlayerMediaEvent OnMediaClosed;
	public FOnMediaPlayerMediaOpened OnMediaOpened;
	public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed;
	public FOnMediaPlayerMediaEvent OnPlaybackResumed;
	public FOnMediaPlayerMediaEvent OnPlaybackSuspended;
	public FOnMediaPlayerMediaEvent OnSeekCompleted;
	public FOnMediaPlayerMediaEvent OnTracksChanged;
	public FOnMediaPlayerMediaEvent OnMetadataChanged;
	public FTimespan CacheAhead;
	public FTimespan CacheBehind;
	public FTimespan CacheBehindGame;
	public bool NativeAudioOut;
	public bool PlayOnOpen;
	public bool Shuffle;
	public bool Loop;
	public UMediaPlaylist Playlist;
	public int PlaylistIndex;
	public FTimespan TimeDelay;
	public float HorizontalFieldOfView;
	public float VerticalFieldOfView;
	public FRotator ViewRotation;
	public FGuid PlayerGuid;
	public bool AffectedByPIEHandling;
}
