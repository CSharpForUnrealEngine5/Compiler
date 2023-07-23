#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimPose.h")]
///<summary>Script exposed functionality for populating, retrieving data from and setting data on FAnimPose</summary>
public partial class UAnimPoseExtensions : UBlueprintFunctionLibrary {
// AnimPoseExtensions
	public bool IsValid(FAnimPose Pose,bool ReturnValue) { return default; }
	public void GetBoneNames(FAnimPose Pose,TArray<sbyte> Bones) {}
	public FTransform GetBonePose(FAnimPose Pose,sbyte BoneName,EAnimPoseSpaces Space=EAnimPoseSpaces,FTransform ReturnValue) { return default; }
	public void SetBonePose(FAnimPose Pose,FTransform Transform,sbyte BoneName,EAnimPoseSpaces Space=EAnimPoseSpaces) {}
	public FTransform GetRefBonePose(FAnimPose Pose,sbyte BoneName,EAnimPoseSpaces Space=EAnimPoseSpaces,FTransform ReturnValue) { return default; }
	public FTransform GetRelativeTransform(FAnimPose Pose,sbyte FromBoneName,sbyte ToBoneName,EAnimPoseSpaces Space=EAnimPoseSpaces,FTransform ReturnValue) { return default; }
	public FTransform GetRelativeToRefPoseTransform(FAnimPose Pose,sbyte BoneName,EAnimPoseSpaces Space=EAnimPoseSpaces,FTransform ReturnValue) { return default; }
	public FTransform GetRefPoseRelativeTransform(FAnimPose Pose,sbyte FromBoneName,sbyte ToBoneName,EAnimPoseSpaces Space=EAnimPoseSpaces,FTransform ReturnValue) { return default; }
	public void GetAnimPoseAtTime(UObject AnimationSequenceBase,double Time,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public void GetAnimPoseAtFrame(UObject AnimationSequenceBase,int FrameIndex,FAnimPoseEvaluationOptions EvaluationOptions,FAnimPose Pose) {}
	public void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose,UObject TargetSkeletalMesh,UObject AnimationBlueprint,FAnimPose OutPose) {}
	public void GetReferencePose(UObject Skeleton,FAnimPose OutPose) {}
	public void GetCurveNames(FAnimPose Pose,TArray<sbyte> Curves) {}
	public float GetCurveWeight(FAnimPose Pose,sbyte CurveName,float ReturnValue) { return default; }
}
