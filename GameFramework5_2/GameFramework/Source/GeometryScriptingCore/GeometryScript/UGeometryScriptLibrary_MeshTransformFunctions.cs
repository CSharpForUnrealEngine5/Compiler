#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshTransformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshTransformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshTransformFunctions
	public UObject TransformMesh(UObject TargetMesh,FTransform Transform,bool bFixOrientationForNegativeScale=true,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject TranslateMesh(UObject TargetMesh,FVector Translation,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject RotateMesh(UObject TargetMesh,FRotator Rotation,FVector RotationOrigin=FVector,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ScaleMesh(UObject TargetMesh,FVector Scale=FVector,FVector ScaleOrigin=FVector,bool bFixOrientationForNegativeScale=true,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject TransformMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FTransform Transform,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject TranslateMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector Translation,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject RotateMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FRotator Rotation,FVector RotationOrigin=FVector,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ScaleMeshSelection(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FVector Scale=FVector,FVector ScaleOrigin=FVector,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject TranslatePivotToLocation(UObject TargetMesh,FVector PivotLocation,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
