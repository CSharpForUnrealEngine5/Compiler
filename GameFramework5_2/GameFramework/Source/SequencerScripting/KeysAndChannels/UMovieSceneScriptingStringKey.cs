#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingString.h")]
///<summary>Exposes a Sequencer string type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingStringKey : UMovieSceneScriptingKey {
// MovieSceneScriptingStringKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public sbyte GetValue(sbyte ReturnValue) { return default; }
	public void SetValue(sbyte InNewValue) {}
}
