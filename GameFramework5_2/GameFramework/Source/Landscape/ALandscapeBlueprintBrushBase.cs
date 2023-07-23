#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeBlueprintBrushBase.h")]
public partial class ALandscapeBlueprintBrushBase : AActor {
// LandscapeBlueprintBrushBase
	public ALandscape OwningLandscape;
	public bool UpdateOnPropertyChange;
	public bool AffectHeightmap;
	public bool AffectWeightmap;
	public TArray<sbyte> AffectedWeightmapLayers;
	public bool bIsVisible;
	public UObject Render(bool InIsHeightmap,UObject InCombinedResult,sbyte InWeightmapLayerName,UObject ReturnValue) { return default; }
	public void Initialize(FTransform InLandscapeTransform,FIntPoint InLandscapeSize,FIntPoint InLandscapeRenderTargetSize) {}
	public void RequestLandscapeUpdate(bool bInUserTriggered=false) {}
	public void GetBlueprintRenderDependencies(TArray<UObject> OutStreamableAssets) {}
}