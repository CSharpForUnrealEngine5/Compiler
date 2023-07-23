#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequenceEvaluatorLibrary.h")]
///<summary>Exposes operations to be performed on a sequence evaluator anim node</summary>
public partial class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary {
// SequenceEvaluatorLibrary
	public FSequenceEvaluatorReference ConvertToSequenceEvaluator(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result,FSequenceEvaluatorReference ReturnValue) { return default; }
	public void ConvertToSequenceEvaluatorPure(FAnimNodeReference Node,FSequenceEvaluatorReference SequenceEvaluator,bool Result) {}
	public FSequenceEvaluatorReference SetExplicitTime(FSequenceEvaluatorReference SequenceEvaluator,float Time,FSequenceEvaluatorReference ReturnValue) { return default; }
	public FSequenceEvaluatorReference AdvanceTime(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,float PlayRate=1.0f,FSequenceEvaluatorReference ReturnValue) { return default; }
	public FSequenceEvaluatorReference SetSequence(FSequenceEvaluatorReference SequenceEvaluator,UObject Sequence,FSequenceEvaluatorReference ReturnValue) { return default; }
	public FSequenceEvaluatorReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequenceEvaluatorReference SequenceEvaluator,UObject Sequence,float BlendTime=0.2f,FSequenceEvaluatorReference ReturnValue) { return default; }
	public float GetAccumulatedTime(FSequenceEvaluatorReference SequenceEvaluator,float ReturnValue) { return default; }
	public UObject GetSequence(FSequenceEvaluatorReference SequenceEvaluator,UObject ReturnValue) { return default; }
}
