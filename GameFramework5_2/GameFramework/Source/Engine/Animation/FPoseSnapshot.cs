#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/PoseSnapshot.h")]
///<summary>A pose for a skeletal mesh</summary>
public partial struct FPoseSnapshot {
// PoseSnapshot
	public TArray<FTransform> LocalTransforms;
	public TArray<sbyte> BoneNames;
	public sbyte SkeletalMeshName;
	public sbyte SnapshotName;
	public bool bIsValid;
}
