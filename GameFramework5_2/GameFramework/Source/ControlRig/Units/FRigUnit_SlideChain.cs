#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_SlideChain.h")]
///<summary>Slides an existing chain along itself with control over extrapolation.</summary>
public partial struct FRigUnit_SlideChain {
// RigUnit_SlideChain
	public sbyte StartBone;
	public sbyte EndBone;
	public float SlideAmount;
	public bool bPropagateToChildren;
	public FRigUnit_SlideChain_WorkData WorkData;
}
