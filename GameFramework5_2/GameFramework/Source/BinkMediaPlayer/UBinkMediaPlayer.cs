#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BinkMediaPlayer.h")]
///<summary>Implements a media player asset that can play movies and other media.</summary>
public partial class UBinkMediaPlayer : UObject {
// BinkMediaPlayer
	public bool CanPause(bool ReturnValue) { return default; }
	public bool CanPlay(bool ReturnValue) { return default; }
	public FTimespan GetDuration(FTimespan ReturnValue) { return default; }
	public float GetRate(float ReturnValue) { return default; }
	public FTimespan GetTime(FTimespan ReturnValue) { return default; }
	public sbyte GetUrl(sbyte ReturnValue) { return default; }
	public bool IsLooping(bool ReturnValue) { return default; }
	public bool IsPaused(bool ReturnValue) { return default; }
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsStopped(bool ReturnValue) { return default; }
	public bool OpenUrl(sbyte NewUrl,bool ReturnValue) { return default; }
	public void CloseUrl() {}
	public bool Pause(bool ReturnValue) { return default; }
	public bool Play(bool ReturnValue) { return default; }
	public bool Rewind(bool ReturnValue) { return default; }
	public bool Seek(FTimespan InTime,bool ReturnValue) { return default; }
	public bool SetLooping(bool InLooping,bool ReturnValue) { return default; }
	public bool SetRate(float Rate,bool ReturnValue) { return default; }
	public void SetVolume(float Rate) {}
	public void Stop() {}
	public bool SupportsRate(float Rate,bool Unthinned,bool ReturnValue) { return default; }
	public bool SupportsScrubbing(bool ReturnValue) { return default; }
	public bool SupportsSeeking(bool ReturnValue) { return default; }
	public bool IsInitialized(bool ReturnValue) { return default; }
	public void Draw(UObject texture,bool tonemap=false,int out_nits=10000,float alpha=1,bool srgb_decode=false,bool hdr=false) {}
	public FOnBinkMediaPlayerMediaClosed OnMediaClosed;
	public FOnBinkMediaPlayerMediaOpened OnMediaOpened;
	public FOnBinkMediaPlayerMediaReachedEnd OnMediaReachedEnd;
	public FOnBinkMediaPlayerMediaEvent OnPlaybackSuspended;
	public bool Looping;
	public bool StartImmediately;
	public bool DelayedOpen;
	public FVector2D BinkDestinationUpperLeft;
	public FVector2D BinkDestinationLowerRight;
	public sbyte URL;
	public byte BinkBufferMode;
	public byte BinkSoundTrack;
	public int BinkSoundTrackStart;
	public byte BinkDrawStyle;
	public int BinkLayerDepth;
}
