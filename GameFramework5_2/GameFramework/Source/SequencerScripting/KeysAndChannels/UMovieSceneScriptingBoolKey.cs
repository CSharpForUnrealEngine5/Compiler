#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingBool.h")]
///<summary>Exposes a Sequencer bool type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingBoolKey : UMovieSceneScriptingKey {
// MovieSceneScriptingBoolKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame/*=0.0f*/,ESequenceTimeUnit TimeUnit/*=ESequenceTimeUnit.DisplayRate*/) {}
	public bool GetValue() { return default; }
	public void SetValue(bool InNewValue) {}
}
