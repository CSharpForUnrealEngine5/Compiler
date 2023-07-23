#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneAudioSection.h")]
///<summary>Audio section, for use in the audio track, or by attached audio objects</summary>
public partial class UMovieSceneAudioSection : UMovieSceneSection {
// MovieSceneAudioSection
	public void SetSound(UObject InSound) {}
	public UObject GetSound(UObject ReturnValue) { return default; }
	public void SetStartOffset(FFrameNumber InStartOffset) {}
	public FFrameNumber GetStartOffset(FFrameNumber ReturnValue) { return default; }
	public USoundBase Sound;
	public FFrameNumber StartFrameOffset;
	public float StartOffset_DEPRECATED;
	public float AudioStartTime_DEPRECATED;
	public float AudioDilationFactor_DEPRECATED;
	public float AudioVolume_DEPRECATED;
	public FMovieSceneFloatChannel SoundVolume;
	public FMovieSceneFloatChannel PitchMultiplier;
	public TMap<sbyte,FMovieSceneFloatChannel> Inputs_Float;
	public TMap<sbyte,FMovieSceneStringChannel> Inputs_String;
	public TMap<sbyte,FMovieSceneBoolChannel> Inputs_Bool;
	public TMap<sbyte,FMovieSceneIntegerChannel> Inputs_Int;
	public TMap<sbyte,FMovieSceneAudioTriggerChannel> Inputs_Trigger;
	public FMovieSceneActorReferenceData AttachActorData;
	public bool bLooping;
	public bool bSuppressSubtitles;
	public bool bOverrideAttenuation;
	public USoundAttenuation AttenuationSettings;
	public FOnQueueSubtitles OnQueueSubtitles;
	public FOnAudioFinished OnAudioFinished;
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent;
}
