#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MRMeshComponent.h")]
public partial class UMRMeshComponent : UPrimitiveComponent {
// MRMeshComponent
	public bool IsConnected(bool ReturnValue) { return default; }
	public void ForceNavMeshUpdate() {}
	public void RequestNavMeshUpdate() {}
	public void Clear() {}
	public void SetWireframeMaterial(UObject InMaterial) {}
	public void SetEnableMeshOcclusion(bool bEnable) {}
	public bool GetEnableMeshOcclusion(bool ReturnValue) { return default; }
	public void SetUseWireframe(bool bUseWireframe) {}
	public bool GetUseWireframe(bool ReturnValue) { return default; }
	public void SetWireframeColor(FLinearColor InColor) {}
	public FLinearColor GetWireframeColor(FLinearColor ReturnValue) { return default; }
	public UMaterialInterface Material;
	public UMaterialInterface WireframeMaterial;
	public bool bCreateMeshProxySections;
	public bool bUpdateNavMeshOnMeshUpdate;
	public bool bNeverCreateCollisionMesh;
	public TArray<UMRMeshBodyHolder> BodyHolders;
}
