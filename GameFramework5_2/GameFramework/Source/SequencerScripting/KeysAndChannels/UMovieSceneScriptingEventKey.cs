#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingEvent.h")]
///<summary>Exposes a Sequencer Event type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingEventKey : UMovieSceneScriptingKey {
// MovieSceneScriptingEventKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public FMovieSceneEvent GetValue(FMovieSceneEvent ReturnValue) { return default; }
	public void SetValue(FMovieSceneEvent InNewValue) {}
}
