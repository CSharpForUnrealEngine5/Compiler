#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_SetBoneInitialTransform.h")]
///<summary>SetBoneInitialTransform is used to perform a change in the hierarchy by setting a single bone's transform.</summary>
public partial struct FRigUnit_SetBoneInitialTransform {
// RigUnit_SetBoneInitialTransform
	public string Bone;
	public FTransform Transform;
	public FTransform Result;
	public ERigVMTransformSpace Space;
	public bool bPropagateToChildren;
	public FCachedRigElement CachedBone;
}
