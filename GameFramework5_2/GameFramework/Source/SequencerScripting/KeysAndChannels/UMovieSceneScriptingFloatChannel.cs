#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingFloat.h")]
public partial class UMovieSceneScriptingFloatChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingFloatChannel
	public UObject AddKey(FFrameNumber InTime,float NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,EMovieSceneKeyInterpolation InInterpolation=EMovieSceneKeyInterpolation,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public int GetNumKeys(int ReturnValue) { return default; }
	public TArray<float> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate,TArray<float> ReturnValue) { return default; }
	public FSequencerScriptingRange ComputeEffectiveRange(FSequencerScriptingRange ReturnValue) { return default; }
	public ERichCurveExtrapolation GetPreInfinityExtrapolation(ERichCurveExtrapolation ReturnValue) { return default; }
	public void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public ERichCurveExtrapolation GetPostInfinityExtrapolation(ERichCurveExtrapolation ReturnValue) { return default; }
	public void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public void SetDefault(float InDefaultValue) {}
	public float GetDefault(float ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
