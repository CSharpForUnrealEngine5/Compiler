#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigSpaceHierarchy.h")]
public partial struct FRigSpace {
// RigSpace
	public ERigSpaceType SpaceType;
	public sbyte ParentName;
	public int ParentIndex;
	public FTransform InitialTransform;
	public FTransform LocalTransform;
}
