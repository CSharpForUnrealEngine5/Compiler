#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimExecutionContextLibrary.h")]
///<summary>Exposes operations to be performed on anim node contexts</summary>
public partial class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary {
// AnimExecutionContextLibrary
	public void Prototype_ThreadSafeAnimNodeCall(FAnimExecutionContext Context,FAnimNodeReference Node) {}
	public void Prototype_ThreadSafeAnimUpdateCall(FAnimUpdateContext Context,FAnimNodeReference Node) {}
	public UObject GetAnimInstance(FAnimExecutionContext Context,UObject ReturnValue) { return default; }
	public FAnimNodeReference GetAnimNodeReference(UObject Instance,int Index,FAnimNodeReference ReturnValue) { return default; }
	public FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result,FAnimInitializationContext ReturnValue) { return default; }
	public FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result,FAnimUpdateContext ReturnValue) { return default; }
	public float GetDeltaTime(FAnimUpdateContext Context,float ReturnValue) { return default; }
	public float GetCurrentWeight(FAnimUpdateContext Context,float ReturnValue) { return default; }
	public FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result,FAnimPoseContext ReturnValue) { return default; }
	public FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context,EAnimExecutionContextConversionResult Result,FAnimComponentSpacePoseContext ReturnValue) { return default; }
}
