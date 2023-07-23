#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingByte.h")]
public partial class UMovieSceneScriptingByteChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingByteChannel
	public UObject AddKey(FFrameNumber InTime,byte NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,EMovieSceneKeyInterpolation InInterpolation=EMovieSceneKeyInterpolation,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public void SetDefault(byte InDefaultValue) {}
	public byte GetDefault(byte ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
