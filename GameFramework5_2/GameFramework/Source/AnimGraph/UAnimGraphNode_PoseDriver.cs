#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_PoseDriver.h")]
public partial class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler {
// AnimGraphNode_PoseDriver
	public FAnimNode_PoseDriver Node;
	public float AxisLength;
	public int ConeSubdivision;
	public bool bDrawDebugCones;
	public void CopyTargetsFromPoseAsset() {}
	public void SetSourceBones(TArray<sbyte> BoneNames) {}
	public void GetSourceBoneNames(TArray<sbyte> BoneNames) {}
	public void SetDrivingBones(TArray<sbyte> BoneNames) {}
	public void GetDrivingBoneNames(TArray<sbyte> BoneNames) {}
	public void SetRBFParameters(FRBFParams Parameters) {}
	public FRBFParams GetRBFParameters(FRBFParams ReturnValue) { return default; }
	public void SetPoseDriverSource(EPoseDriverSource DriverSource) {}
	public EPoseDriverSource GetPoseDriverSource(EPoseDriverSource ReturnValue) { return default; }
	public void SetPoseDriverOutput(EPoseDriverOutput DriverOutput) {}
	public EPoseDriverOutput GetPoseDriverOutput(EPoseDriverOutput ReturnValue) { return default; }
	public void SetOnlyDriveSelectedBones(bool bOnlyDriveSelectedBones) {}
	public bool GetOnlyDriveSelectedBones(bool ReturnValue) { return default; }
	public USkeletalMeshComponent LastPreviewComponent;
}
