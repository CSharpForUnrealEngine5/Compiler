#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoAxisSource : UInterface {
// GizmoAxisSource
	public FVector GetOrigin(FVector ReturnValue) { return default; }
	public FVector GetDirection(FVector ReturnValue) { return default; }
	public bool HasTangentVectors(bool ReturnValue) { return default; }
	public void GetTangentVectors(FVector TangentXOut,FVector TangentYOut) {}
}
