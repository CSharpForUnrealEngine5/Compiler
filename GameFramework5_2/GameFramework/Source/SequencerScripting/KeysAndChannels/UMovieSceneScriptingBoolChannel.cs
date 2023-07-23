#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingBool.h")]
public partial class UMovieSceneScriptingBoolChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingBoolChannel
	public UObject AddKey(FFrameNumber InTime,bool NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public int GetNumKeys(int ReturnValue) { return default; }
	public TArray<bool> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate,TArray<bool> ReturnValue) { return default; }
	public FSequencerScriptingRange ComputeEffectiveRange(FSequencerScriptingRange ReturnValue) { return default; }
	public void SetDefault(bool InDefaultValue) {}
	public bool GetDefault(bool ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
