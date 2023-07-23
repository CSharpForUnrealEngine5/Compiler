#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsSpringComponent.h")]
///<summary>Note: this component is still work in progress. Uses raycast springs for simple vehicle forces</summary>
public partial class UPhysicsSpringComponent : USceneComponent {
// PhysicsSpringComponent
	public float SpringStiffness;
	public float SpringDamping;
	public float SpringLengthAtRest;
	public float SpringRadius;
	public byte SpringChannel;
	public bool bIgnoreSelf;
	public float SpringCompression;
	public float GetNormalizedCompressionScalar(float ReturnValue) { return default; }
	public FVector GetSpringRestingPoint(FVector ReturnValue) { return default; }
	public FVector GetSpringCurrentEndPoint(FVector ReturnValue) { return default; }
	public FVector GetSpringDirection(FVector ReturnValue) { return default; }
}
