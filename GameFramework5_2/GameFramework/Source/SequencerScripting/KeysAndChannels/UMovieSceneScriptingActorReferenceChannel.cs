#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
public partial class UMovieSceneScriptingActorReferenceChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingActorReferenceChannel
	public UObject AddKey(FFrameNumber InTime,FMovieSceneObjectBindingID NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public void SetDefault(FMovieSceneObjectBindingID InDefaultValue) {}
	public FMovieSceneObjectBindingID GetDefault(FMovieSceneObjectBindingID ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
