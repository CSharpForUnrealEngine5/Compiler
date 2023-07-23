#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingInteger.h")]
///<summary>Exposes a Sequencer integer type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingIntegerKey : UMovieSceneScriptingKey {
// MovieSceneScriptingIntegerKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public int GetValue(int ReturnValue) { return default; }
	public void SetValue(int InNewValue) {}
}
