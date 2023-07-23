#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MeshComponent.h")]
///<summary>MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles.</summary>
public partial class UMeshComponent : UPrimitiveComponent {
// MeshComponent
	public TArray<UMaterialInterface> OverrideMaterials;
	public TArray<UObject> GetMaterials(TArray<UObject> ReturnValue) { return default; }
	public int GetMaterialIndex(sbyte MaterialSlotName,int ReturnValue) { return default; }
	public TArray<sbyte> GetMaterialSlotNames(TArray<sbyte> ReturnValue) { return default; }
	public bool IsMaterialSlotNameValid(sbyte MaterialSlotName,bool ReturnValue) { return default; }
	public UMaterialInterface OverlayMaterial;
	public float OverlayMaterialMaxDrawDistance;
	public UObject GetOverlayMaterial(UObject ReturnValue) { return default; }
	public void SetOverlayMaterial(UObject NewOverlayMaterial) {}
	public void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance) {}
	public void PrestreamTextures(float Seconds,bool bPrioritizeCharacterTextures,int CinematicTextureGroups=0) {}
	public void SetScalarParameterValueOnMaterials(sbyte ParameterName,float ParameterValue) {}
	public void SetVectorParameterValueOnMaterials(sbyte ParameterName,FVector ParameterValue) {}
	public bool bEnableMaterialParameterCaching;
}
