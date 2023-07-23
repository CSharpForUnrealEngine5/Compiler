#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DynamicMeshComponent.h")]
///<summary>UDynamicMeshComponent is a mesh component similar to UProceduralMeshComponent,</summary>
public partial class UDynamicMeshComponent : UBaseDynamicMeshComponent {
// DynamicMeshComponent
	public void SetDynamicMesh(UObject NewMesh) {}
	public UDynamicMesh MeshObject;
	public void ConfigureMaterialSet(TArray<UObject> NewMaterialSet) {}
	public bool ValidateMaterialSlots(bool bCreateIfMissing=true,bool bDeleteExtraSlots=true,bool ReturnValue) { return default; }
	public void SetTangentsType(EDynamicMeshComponentTangentsMode NewTangentsType) {}
	public EDynamicMeshComponentTangentsMode GetTangentsType(EDynamicMeshComponentTangentsMode ReturnValue) { return default; }
	public EDynamicMeshComponentTangentsMode TangentsType;
	public void EnableComplexAsSimpleCollision() {}
	public void SetComplexAsSimpleCollisionEnabled(bool bEnabled,bool bImmediateUpdate=true) {}
	public void SetDeferredCollisionUpdatesEnabled(bool bEnabled,bool bImmediateUpdate=true) {}
	public void UpdateCollision(bool bOnlyIfPending=true) {}
	public byte CollisionType;
	public bool bUseAsyncCooking;
	public bool bEnableComplexCollision;
	public bool bDeferCollisionUpdates;
	public UBodySetup MeshBodySetup;
	public FKAggregateGeom AggGeom;
	public TArray<UBodySetup> AsyncBodySetupQueue;
}
