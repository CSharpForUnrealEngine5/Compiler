#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargeterController.h")]
///<summary>A stateless singleton (1-per-asset) class used to make modifications to a UIKRetargeter asset.</summary>
public partial class UIKRetargeterController : UObject {
// IKRetargeterController
	public UObject GetController(UObject InRetargeterAsset,UObject ReturnValue) { return default; }
	public void SetIKRig(ERetargetSourceOrTarget SourceOrTarget,UObject IKRig) {}
	public UObject GetIKRig(ERetargetSourceOrTarget SourceOrTarget,UObject ReturnValue) { return default; }
	public void SetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget,UObject InPreviewMesh) {}
	public UObject GetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget,UObject ReturnValue) { return default; }
	public FTargetRootSettings GetRootSettings(FTargetRootSettings ReturnValue) { return default; }
	public void SetRootSettings(FTargetRootSettings RootSettings) {}
	public FRetargetGlobalSettings GetGlobalSettings(FRetargetGlobalSettings ReturnValue) { return default; }
	public void SetGlobalSettings(FRetargetGlobalSettings GlobalSettings) {}
	public FTargetChainSettings GetRetargetChainSettings(sbyte TargetChainName,FTargetChainSettings ReturnValue) { return default; }
	public bool SetRetargetChainSettings(sbyte TargetChainName,FTargetChainSettings Settings,bool ReturnValue) { return default; }
	public void AutoMapChains(EAutoMapChainType AutoMapType,bool bForceRemap) {}
	public bool SetSourceChain(sbyte SourceChainName,sbyte TargetChainName,bool ReturnValue) { return default; }
	public sbyte GetSourceChain(sbyte TargetChainName,sbyte ReturnValue) { return default; }
	public TArray<UObject> GetAllChainSettings(TArray<UObject> ReturnValue) { return default; }
	public sbyte CreateRetargetPose(sbyte NewPoseName,ERetargetSourceOrTarget SourceOrTarget,sbyte ReturnValue) { return default; }
	public bool RemoveRetargetPose(sbyte PoseToRemove,ERetargetSourceOrTarget SourceOrTarget,bool ReturnValue) { return default; }
	public sbyte DuplicateRetargetPose(sbyte PoseToDuplicate,sbyte NewName,ERetargetSourceOrTarget SourceOrTarget,sbyte ReturnValue) { return default; }
	public bool RenameRetargetPose(sbyte OldPoseName,sbyte NewPoseName,ERetargetSourceOrTarget SourceOrTarget,bool ReturnValue) { return default; }
	public bool SetCurrentRetargetPose(sbyte CurrentPose,ERetargetSourceOrTarget SourceOrTarget,bool ReturnValue) { return default; }
	public sbyte GetCurrentRetargetPoseName(ERetargetSourceOrTarget SourceOrTarget,sbyte ReturnValue) { return default; }
	public TMap<sbyte,FIKRetargetPose> GetRetargetPoses(ERetargetSourceOrTarget SourceOrTarget,TMap<sbyte,FIKRetargetPose> ReturnValue) { return default; }
	public FIKRetargetPose GetCurrentRetargetPose(ERetargetSourceOrTarget SourceOrTarget,FIKRetargetPose ReturnValue) { return default; }
	public void ResetRetargetPose(sbyte PoseToReset,TArray<sbyte> BonesToReset,ERetargetSourceOrTarget SourceOrTarget) {}
	public void SetRotationOffsetForRetargetPoseBone(sbyte BoneName,FQuat RotationOffset,ERetargetSourceOrTarget SkeletonMode) {}
	public FQuat GetRotationOffsetForRetargetPoseBone(sbyte BoneName,ERetargetSourceOrTarget SourceOrTarget,FQuat ReturnValue) { return default; }
	public void SetRootOffsetInRetargetPose(FVector TranslationOffset,ERetargetSourceOrTarget SourceOrTarget) {}
	public FVector GetRootOffsetInRetargetPose(ERetargetSourceOrTarget SourceOrTarget,FVector ReturnValue) { return default; }
}
