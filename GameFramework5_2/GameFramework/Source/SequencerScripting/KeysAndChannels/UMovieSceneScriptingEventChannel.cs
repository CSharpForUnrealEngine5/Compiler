#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingEvent.h")]
public partial class UMovieSceneScriptingEventChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingEventChannel
	public UObject AddKey(FFrameNumber InTime,FMovieSceneEvent NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
}
