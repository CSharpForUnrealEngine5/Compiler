#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PoseCorrectivesAsset.h")]
///<summary>* Pose Correctives Asset</summary>
public partial class UPoseCorrectivesAsset : UObject {
// PoseCorrectivesAsset
	public TMap<sbyte,FPoseCorrective> PoseCorrectives;
	public TMap<sbyte,FPoseGroupDefinition> GroupDefinitions;
	public USkeletalMesh TargetMesh;
	public USkeletalMesh SourcePreviewMesh;
	public UObject ControlRigBlueprint;
	public FVector SourceMeshOffset;
	public float SourceMeshScale;
	public FRBFParams RBFParams;
}
