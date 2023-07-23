#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingString.h")]
public partial class UMovieSceneScriptingStringChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingStringChannel
	public UObject AddKey(FFrameNumber InTime,sbyte NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public void SetDefault(sbyte InDefaultValue) {}
	public sbyte GetDefault(sbyte ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
