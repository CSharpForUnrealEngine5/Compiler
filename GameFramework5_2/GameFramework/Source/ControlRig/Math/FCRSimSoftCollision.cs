#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Math/Simulation/CRSimSoftCollision.h")]
public partial struct FCRSimSoftCollision {
// CRSimSoftCollision
	public FTransform Transform;
	public ECRSimSoftCollisionType ShapeType;
	public float MinimumDistance;
	public float MaximumDistance;
	public ERigVMAnimEasingType FalloffType;
	public float Coefficient;
	public bool bInverted;
}
