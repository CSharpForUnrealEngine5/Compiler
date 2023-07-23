#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingBool.h")]
///<summary>Exposes a Sequencer bool type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingBoolKey : UMovieSceneScriptingKey {
// MovieSceneScriptingBoolKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public bool GetValue(bool ReturnValue) { return default; }
	public void SetValue(bool InNewValue) {}
}
