#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlendSpacePlayerLibrary.h")]
///<summary>Exposes operations to be performed on a blend space player anim node.</summary>
public partial class UBlendSpacePlayerLibrary : UBlueprintFunctionLibrary {
// BlendSpacePlayerLibrary
	public FBlendSpacePlayerReference ConvertToBlendSpacePlayer(FAnimNodeReference Node,EAnimNodeReferenceConversionResult Result,FBlendSpacePlayerReference ReturnValue) { return default; }
	public void ConvertToBlendSpacePlayerPure(FAnimNodeReference Node,FBlendSpacePlayerReference BlendSpacePlayer,bool Result) {}
	public FBlendSpacePlayerReference SetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer,UObject BlendSpace,FBlendSpacePlayerReference ReturnValue) { return default; }
	public FBlendSpacePlayerReference SetBlendSpaceWithInertialBlending(FAnimUpdateContext UpdateContext,FBlendSpacePlayerReference BlendSpacePlayer,UObject BlendSpace,float BlendTime=0.2f,FBlendSpacePlayerReference ReturnValue) { return default; }
	public FBlendSpacePlayerReference SetResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer,bool bReset,FBlendSpacePlayerReference ReturnValue) { return default; }
	public FBlendSpacePlayerReference SetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer,float PlayRate,FBlendSpacePlayerReference ReturnValue) { return default; }
	public FBlendSpacePlayerReference SetLoop(FBlendSpacePlayerReference BlendSpacePlayer,bool bLoop,FBlendSpacePlayerReference ReturnValue) { return default; }
	public UObject GetBlendSpace(FBlendSpacePlayerReference BlendSpacePlayer,UObject ReturnValue) { return default; }
	public FVector GetPosition(FBlendSpacePlayerReference BlendSpacePlayer,FVector ReturnValue) { return default; }
	public float GetStartPosition(FBlendSpacePlayerReference BlendSpacePlayer,float ReturnValue) { return default; }
	public float GetPlayRate(FBlendSpacePlayerReference BlendSpacePlayer,float ReturnValue) { return default; }
	public bool GetLoop(FBlendSpacePlayerReference BlendSpacePlayer,bool ReturnValue) { return default; }
	public bool ShouldResetPlayTimeWhenBlendSpaceChanges(FBlendSpacePlayerReference BlendSpacePlayer,bool ReturnValue) { return default; }
	public void SnapToPosition(FBlendSpacePlayerReference BlendSpacePlayer,FVector NewPosition) {}
}
