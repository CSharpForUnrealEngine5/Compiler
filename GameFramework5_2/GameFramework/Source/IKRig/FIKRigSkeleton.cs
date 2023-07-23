#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigSkeleton.h")]
public partial struct FIKRigSkeleton {
// IKRigSkeleton
	public TArray<sbyte> BoneNames;
	public TArray<int> ParentIndices;
	public TArray<sbyte> ExcludedBones;
	public TArray<FTransform> CurrentPoseGlobal;
	public TArray<FTransform> CurrentPoseLocal;
	public TArray<FTransform> RefPoseGlobal;
}
