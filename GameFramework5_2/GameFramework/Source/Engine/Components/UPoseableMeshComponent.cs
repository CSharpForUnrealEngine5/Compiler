#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PoseableMeshComponent.h")]
///<summary>UPoseableMeshComponent that allows bone transforms to be driven by blueprint.</summary>
public partial class UPoseableMeshComponent : USkinnedMeshComponent {
// PoseableMeshComponent
	public void SetBoneTransformByName(sbyte BoneName,FTransform InTransform,EBoneSpaces BoneSpace) {}
	public void SetBoneLocationByName(sbyte BoneName,FVector InLocation,EBoneSpaces BoneSpace) {}
	public void SetBoneRotationByName(sbyte BoneName,FRotator InRotation,EBoneSpaces BoneSpace) {}
	public void SetBoneScaleByName(sbyte BoneName,FVector InScale3D,EBoneSpaces BoneSpace) {}
	public FTransform GetBoneTransformByName(sbyte BoneName,EBoneSpaces BoneSpace,FTransform ReturnValue) { return default; }
	public FVector GetBoneLocationByName(sbyte BoneName,EBoneSpaces BoneSpace,FVector ReturnValue) { return default; }
	public FRotator GetBoneRotationByName(sbyte BoneName,EBoneSpaces BoneSpace,FRotator ReturnValue) { return default; }
	public FVector GetBoneScaleByName(sbyte BoneName,EBoneSpaces BoneSpace,FVector ReturnValue) { return default; }
	public void ResetBoneTransformByName(sbyte BoneName) {}
	public void CopyPoseFromSkeletalComponent(UObject InComponentToCopy) {}
}
