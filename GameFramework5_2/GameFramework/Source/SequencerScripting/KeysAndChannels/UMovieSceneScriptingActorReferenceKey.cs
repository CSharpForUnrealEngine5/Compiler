#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingActorReference.h")]
///<summary>Exposes a Sequencer Actor Reference type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingActorReferenceKey : UMovieSceneScriptingKey {
// MovieSceneScriptingActorReferenceKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public FMovieSceneObjectBindingID GetValue(FMovieSceneObjectBindingID ReturnValue) { return default; }
	public void SetValue(FMovieSceneObjectBindingID InNewValue) {}
}
