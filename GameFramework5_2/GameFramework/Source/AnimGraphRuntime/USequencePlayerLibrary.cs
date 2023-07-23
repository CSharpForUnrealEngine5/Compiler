#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencePlayerLibrary.h")]
///<summary>Exposes operations to be performed on a sequence player anim node</summary>
public partial class USequencePlayerLibrary : UBlueprintFunctionLibrary {
// SequencePlayerLibrary
	public FSequencePlayerReference ConvertToSequencePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result,FSequencePlayerReference ReturnValue) { return default; }
	public void ConvertToSequencePlayerPure(FAnimNodeReference Node,FSequencePlayerReference SequencePlayer,bool Result) {}
	public FSequencePlayerReference SetAccumulatedTime(FSequencePlayerReference SequencePlayer,float Time,FSequencePlayerReference ReturnValue) { return default; }
	public FSequencePlayerReference SetStartPosition(FSequencePlayerReference SequencePlayer,float StartPosition,FSequencePlayerReference ReturnValue) { return default; }
	public FSequencePlayerReference SetPlayRate(FSequencePlayerReference SequencePlayer,float PlayRate,FSequencePlayerReference ReturnValue) { return default; }
	public FSequencePlayerReference SetSequence(FSequencePlayerReference SequencePlayer,UObject Sequence,FSequencePlayerReference ReturnValue) { return default; }
	public FSequencePlayerReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext,FSequencePlayerReference SequencePlayer,UObject Sequence,float BlendTime=0.2f,FSequencePlayerReference ReturnValue) { return default; }
	public FSequencePlayerReference GetSequence(FSequencePlayerReference SequencePlayer,UObject SequenceBase,FSequencePlayerReference ReturnValue) { return default; }
	public UObject GetSequencePure(FSequencePlayerReference SequencePlayer,UObject ReturnValue) { return default; }
	public float GetAccumulatedTime(FSequencePlayerReference SequencePlayer,float ReturnValue) { return default; }
	public float GetStartPosition(FSequencePlayerReference SequencePlayer,float ReturnValue) { return default; }
	public float GetPlayRate(FSequencePlayerReference SequencePlayer,float ReturnValue) { return default; }
	public bool GetLoopAnimation(FSequencePlayerReference SequencePlayer,bool ReturnValue) { return default; }
	public float ComputePlayRateFromDuration(FSequencePlayerReference SequencePlayer,float Duration=1.f,float ReturnValue) { return default; }
}
