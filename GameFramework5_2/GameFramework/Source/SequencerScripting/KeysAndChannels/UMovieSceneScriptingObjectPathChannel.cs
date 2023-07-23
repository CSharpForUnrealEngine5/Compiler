#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingObjectPath.h")]
public partial class UMovieSceneScriptingObjectPathChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingObjectPathChannel
	public UObject AddKey(FFrameNumber InTime,UObject NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public void SetDefault(UObject InDefaultValue) {}
	public UObject GetDefault(UObject ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
