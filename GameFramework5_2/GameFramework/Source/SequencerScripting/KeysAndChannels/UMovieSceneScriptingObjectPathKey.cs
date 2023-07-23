#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingObjectPath.h")]
///<summary>Exposes a Sequencer Object Path type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingObjectPathKey : UMovieSceneScriptingKey {
// MovieSceneScriptingObjectPathKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public UObject GetValue(UObject ReturnValue) { return default; }
	public void SetValue(UObject InNewValue) {}
}
