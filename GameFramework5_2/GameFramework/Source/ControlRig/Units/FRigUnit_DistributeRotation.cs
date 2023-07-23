#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_DistributeRotation.h")]
///<summary>Distributes rotations provided along a chain.</summary>
public partial struct FRigUnit_DistributeRotation {
// RigUnit_DistributeRotation
	public sbyte StartBone;
	public sbyte EndBone;
	public TArray<FRigUnit_DistributeRotation_Rotation> Rotations;
	public ERigVMAnimEasingType RotationEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_DistributeRotation_WorkData WorkData;
}
