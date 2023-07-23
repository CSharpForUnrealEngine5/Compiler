#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/UIFImageBlock.h")]
public partial class UUIFrameworkImageBlock : UUIFrameworkWidget {
// UIFrameworkImageBlock
	public void SetMaterial(TSoftObjectPtr<UMaterialInterface> Material) {}
	public TSoftObjectPtr<UObject> GeResourceObject(TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public void SetTexture(TSoftObjectPtr<UTexture2D> Texture,bool bUseTextureSize) {}
	public void SetTint(FLinearColor Tint) {}
	public FLinearColor GetTint(FLinearColor ReturnValue) { return default; }
	public void SetDesiredSize(FVector2f DesiredSize) {}
	public FVector2f GetDesiredSize(FVector2f ReturnValue) { return default; }
	public void SetTiling(ESlateBrushTileType OverflowPolicy) {}
	public ESlateBrushTileType GetTiling(ESlateBrushTileType ReturnValue) { return default; }
	public void OnRep_Data() {}
	public FUIFrameworkImageBlockData Data;
	public bool bWaitForResourceToBeLoaded;
}
