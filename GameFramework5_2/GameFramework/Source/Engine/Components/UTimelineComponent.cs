#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
///<summary>TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes.</summary>
public partial class UTimelineComponent : UActorComponent {
// TimelineComponent
	public FTimeline TheTimeline;
	public bool bIgnoreTimeDilation;
	public void Play() {}
	public void PlayFromStart() {}
	public void Reverse() {}
	public void ReverseFromEnd() {}
	public void Stop() {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsReversing(bool ReturnValue) { return default; }
	public void SetPlaybackPosition(float NewPosition,bool bFireEvents,bool bFireUpdate=true) {}
	public float GetPlaybackPosition(float ReturnValue) { return default; }
	public void SetLooping(bool bNewLooping) {}
	public bool IsLooping(bool ReturnValue) { return default; }
	public void SetPlayRate(float NewRate) {}
	public float GetPlayRate(float ReturnValue) { return default; }
	public void SetNewTime(float NewTime) {}
	public float GetTimelineLength(float ReturnValue) { return default; }
	public float GetScaledTimelineLength(float ReturnValue) { return default; }
	public void SetTimelineLength(float NewLength) {}
	public void SetTimelineLengthMode(ETimelineLengthMode NewLengthMode) {}
	public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation) {}
	public bool GetIgnoreTimeDilation(bool ReturnValue) { return default; }
	public void SetFloatCurve(UObject NewFloatCurve,sbyte FloatTrackName) {}
	public void SetVectorCurve(UObject NewVectorCurve,sbyte VectorTrackName) {}
	public void SetLinearColorCurve(UObject NewLinearColorCurve,sbyte LinearColorTrackName) {}
	public void OnRep_Timeline(FTimeline OldTimeline) {}
}
