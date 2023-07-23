#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingInteger.h")]
public partial class UMovieSceneScriptingIntegerChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingIntegerChannel
	public UObject AddKey(FFrameNumber InTime,int NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public void SetDefault(int InDefaultValue) {}
	public int GetDefault(int ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
