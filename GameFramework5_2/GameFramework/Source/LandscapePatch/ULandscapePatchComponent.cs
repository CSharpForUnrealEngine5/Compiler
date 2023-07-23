#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapePatchComponent.h")]
///<summary>Base class for landscape patches: components that can be attached to meshes and moved around to make</summary>
public partial class ULandscapePatchComponent : USceneComponent {
// LandscapePatchComponent
	public void RequestLandscapeUpdate(bool bInUserTriggeredUpdate=false) {}
	public void SetIsEnabled(bool bEnabledIn) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public FTransform GetLandscapeHeightmapCoordsToWorld(FTransform ReturnValue) { return default; }
	public void SetLandscape(UObject NewLandscape) {}
	public void SetPatchManager(UObject NewPatchManager) {}
	public UObject GetPatchManager(UObject ReturnValue) { return default; }
	public void MoveToTop() {}
	public TSoftObjectPtr<ALandscape> Landscape;
	public TSoftObjectPtr<ALandscapePatchManager> PatchManager;
	public bool bIsEnabled;
	public bool bPropertiesCopiedIndicator;
	public TSoftObjectPtr<ALandscapePatchManager> PreviousPatchManager;
}
