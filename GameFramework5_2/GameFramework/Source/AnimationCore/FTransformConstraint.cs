#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Constraint.h")]
public partial struct FTransformConstraint {
// TransformConstraint
	public FConstraintDescription Operator;
	public sbyte SourceNode;
	public sbyte TargetNode;
	public float Weight;
	public bool bMaintainOffset;
}
