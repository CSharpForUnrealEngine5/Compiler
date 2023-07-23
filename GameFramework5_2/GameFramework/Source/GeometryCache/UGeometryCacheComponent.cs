#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCacheComponent.h")]
///<summary>GeometryCacheComponent, encapsulates a GeometryCache asset instance and implements functionality for rendering/and playback of GeometryCaches</summary>
public partial class UGeometryCacheComponent : UMeshComponent {
// GeometryCacheComponent
	public void Play() {}
	public void PlayFromStart() {}
	public void PlayReversed() {}
	public void PlayReversedFromEnd() {}
	public void Pause() {}
	public void Stop() {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsPlayingReversed(bool ReturnValue) { return default; }
	public bool IsLooping(bool ReturnValue) { return default; }
	public void SetLooping(bool bNewLooping) {}
	public bool IsExtrapolatingFrames(bool ReturnValue) { return default; }
	public void SetExtrapolateFrames(bool bNewExtrapolating) {}
	public float GetPlaybackSpeed(float ReturnValue) { return default; }
	public void SetPlaybackSpeed(float NewPlaybackSpeed) {}
	public float GetMotionVectorScale(float ReturnValue) { return default; }
	public void SetMotionVectorScale(float NewMotionVectorScale) {}
	public bool SetGeometryCache(UObject NewGeomCache,bool ReturnValue) { return default; }
	public float GetStartTimeOffset(float ReturnValue) { return default; }
	public void SetStartTimeOffset(float NewStartTimeOffset) {}
	public float GetAnimationTime(float ReturnValue) { return default; }
	public float GetPlaybackDirection(float ReturnValue) { return default; }
	public UGeometryCache GeometryCache;
	public float GetDuration(float ReturnValue) { return default; }
	public int GetNumberOfFrames(int ReturnValue) { return default; }
	public void SetOverrideWireframeColor(bool bOverride) {}
	public bool GetOverrideWireframeColor(bool ReturnValue) { return default; }
	public void SetWireframeOverrideColor(FLinearColor Color) {}
	public FLinearColor GetWireframeOverrideColor(FLinearColor ReturnValue) { return default; }
	public void TickAtThisTime(float Time,bool bInIsRunning,bool bInBackwards,bool bInIsLooping) {}
	public bool bRunning;
	public bool bLooping;
	public bool bExtrapolateFrames;
	public float StartTimeOffset;
	public float PlaybackSpeed;
	public float MotionVectorScale;
	public int NumTracks;
	public float ElapsedTime;
	public float Duration;
	public bool bManualTick;
	public bool bOverrideWireframeColor;
	public FLinearColor WireframeOverrideColor;
}
