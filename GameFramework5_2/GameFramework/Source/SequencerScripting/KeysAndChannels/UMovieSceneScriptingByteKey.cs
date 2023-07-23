#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingByte.h")]
///<summary>Exposes a Sequencer byte/enum type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingByteKey : UMovieSceneScriptingKey {
// MovieSceneScriptingByteKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public byte GetValue(byte ReturnValue) { return default; }
	public void SetValue(byte InNewValue) {}
}
