#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceActor.h")]
///<summary>Actor responsible for controlling a specific level sequence in the world.</summary>
public partial class ALevelSequenceActor : AActor {
// LevelSequenceActor
	public void FOnLevelSequenceLoaded() {}
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;
	public ULevelSequencePlayer SequencePlayer;
	public ULevelSequence LevelSequenceAsset;
	public FSoftObjectPath LevelSequence_DEPRECATED;
	public FLevelSequenceCameraSettings CameraSettings;
	public ULevelSequenceBurnInOptions BurnInOptions;
	public UMovieSceneBindingOverrides BindingOverrides;
	public bool bAutoPlay_DEPRECATED;
	public bool bOverrideInstanceData;
	public bool bReplicatePlayback;
	public UObject DefaultInstanceData;
	public UObject GetSequence(UObject ReturnValue) { return default; }
	public UObject LoadSequence(UObject ReturnValue) { return default; }
	public void SetSequence(UObject InSequence) {}
	public void SetReplicatePlayback(bool ReplicatePlayback) {}
	public UObject GetSequencePlayer(UObject ReturnValue) { return default; }
	public void HideBurnin() {}
	public void ShowBurnin() {}
	public void SetBinding(FMovieSceneObjectBindingID Binding,TArray<UObject> Actors,bool bAllowBindingsFromAsset=false) {}
	public void SetBindingByTag(sbyte BindingTag,TArray<UObject> Actors,bool bAllowBindingsFromAsset=false) {}
	public void AddBinding(FMovieSceneObjectBindingID Binding,UObject Actor,bool bAllowBindingsFromAsset=false) {}
	public void AddBindingByTag(sbyte BindingTag,UObject Actor,bool bAllowBindingsFromAsset=false) {}
	public void RemoveBinding(FMovieSceneObjectBindingID Binding,UObject Actor) {}
	public void RemoveBindingByTag(sbyte Tag,UObject Actor) {}
	public void ResetBinding(FMovieSceneObjectBindingID Binding) {}
	public void ResetBindings() {}
	public FMovieSceneObjectBindingID FindNamedBinding(sbyte Tag,FMovieSceneObjectBindingID ReturnValue) { return default; }
	public TArray<FMovieSceneObjectBindingID> FindNamedBindings(sbyte Tag,TArray<FMovieSceneObjectBindingID> ReturnValue) { return default; }
	public ULevelSequenceBurnIn BurnInInstance;
	public bool bShowBurnin;
}
