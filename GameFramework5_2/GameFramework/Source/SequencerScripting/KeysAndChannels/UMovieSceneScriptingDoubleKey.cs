#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KeysAndChannels/MovieSceneScriptingDouble.h")]
///<summary>Exposes a Sequencer double type key to Python/Blueprints.</summary>
public partial class UMovieSceneScriptingDoubleKey : UMovieSceneScriptingKey {
// MovieSceneScriptingDoubleKey
	public FFrameTime GetTime(ESequenceTimeUnit TimeUnit=ESequenceTimeUnit,FFrameTime ReturnValue) { return default; }
	public void SetTime(FFrameNumber NewFrameNumber,float SubFrame=0.f,ESequenceTimeUnit TimeUnit=ESequenceTimeUnit) {}
	public double GetValue(double ReturnValue) { return default; }
	public void SetValue(double InNewValue) {}
	public ERichCurveInterpMode GetInterpolationMode(ERichCurveInterpMode ReturnValue) { return default; }
	public void SetInterpolationMode(ERichCurveInterpMode InNewValue) {}
	public ERichCurveTangentMode GetTangentMode(ERichCurveTangentMode ReturnValue) { return default; }
	public void SetTangentMode(ERichCurveTangentMode InNewValue) {}
	public float GetArriveTangent(float ReturnValue) { return default; }
	public void SetArriveTangent(float InNewValue) {}
	public float GetLeaveTangent(float ReturnValue) { return default; }
	public void SetLeaveTangent(float InNewValue) {}
	public ERichCurveTangentWeightMode GetTangentWeightMode(ERichCurveTangentWeightMode ReturnValue) { return default; }
	public void SetTangentWeightMode(ERichCurveTangentWeightMode InNewValue) {}
	public float GetArriveTangentWeight(float ReturnValue) { return default; }
	public void SetArriveTangentWeight(float InNewValue) {}
	public float GetLeaveTangentWeight(float ReturnValue) { return default; }
	public void SetLeaveTangentWeight(float InNewValue) {}
}
