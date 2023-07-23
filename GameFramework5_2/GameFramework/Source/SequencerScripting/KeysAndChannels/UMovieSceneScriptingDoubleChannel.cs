#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingDouble.h")]
public partial class UMovieSceneScriptingDoubleChannel : UMovieSceneScriptingChannel {
// MovieSceneScriptingDoubleChannel
	public UObject AddKey(FFrameNumber InTime,double NewValue,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,EMovieSceneKeyInterpolation InInterpolation=EMovieSceneKeyInterpolation,UObject ReturnValue) { return default; }
	public void RemoveKey(UObject Key) {}
	public TArray<UObject> GetKeys(TArray<UObject> ReturnValue) { return default; }
	public int GetNumKeys(int ReturnValue) { return default; }
	public TArray<double> EvaluateKeys(FSequencerScriptingRange Range,FFrameRate FrameRate,TArray<double> ReturnValue) { return default; }
	public FSequencerScriptingRange ComputeEffectiveRange(FSequencerScriptingRange ReturnValue) { return default; }
	public ERichCurveExtrapolation GetPreInfinityExtrapolation(ERichCurveExtrapolation ReturnValue) { return default; }
	public void SetPreInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public ERichCurveExtrapolation GetPostInfinityExtrapolation(ERichCurveExtrapolation ReturnValue) { return default; }
	public void SetPostInfinityExtrapolation(ERichCurveExtrapolation InExtrapolation) {}
	public void SetDefault(double InDefaultValue) {}
	public double GetDefault(double ReturnValue) { return default; }
	public void RemoveDefault() {}
	public bool HasDefault(bool ReturnValue) { return default; }
}
