#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/BaseDynamicMeshComponent.h")]
///<summary>UBaseDynamicMeshComponent is a base interface for a UMeshComponent based on a UDynamicMesh.</summary>
public partial class UBaseDynamicMeshComponent : UMeshComponent {
// BaseDynamicMeshComponent
	public UObject GetDynamicMesh(UObject ReturnValue) { return default; }
	public bool bExplicitShowWireframe;
	public void SetEnableWireframeRenderPass(bool bEnable) {}
	public bool GetEnableWireframeRenderPass(bool ReturnValue) { return default; }
	public FLinearColor WireframeColor;
	public EDynamicMeshComponentColorOverrideMode ColorMode;
	public void SetColorOverrideMode(EDynamicMeshComponentColorOverrideMode NewMode) {}
	public EDynamicMeshComponentColorOverrideMode GetColorOverrideMode(EDynamicMeshComponentColorOverrideMode ReturnValue) { return default; }
	public FColor ConstantColor;
	public void SetConstantOverrideColor(FColor NewColor) {}
	public FColor GetConstantOverrideColor(FColor ReturnValue) { return default; }
	public bool bEnableFlatShading;
	public void SetEnableFlatShading(bool bEnable) {}
	public bool GetFlatShadingEnabled(bool ReturnValue) { return default; }
	public void SetShadowsEnabled(bool bEnabled) {}
	public bool GetShadowsEnabled(bool ReturnValue) { return default; }
	public void SetViewModeOverridesEnabled(bool bEnabled) {}
	public bool GetViewModeOverridesEnabled(bool ReturnValue) { return default; }
	public bool bEnableViewModeOverrides;
	public void SetOverrideRenderMaterial(UObject Material) {}
	public void ClearOverrideRenderMaterial() {}
	public bool HasOverrideRenderMaterial(int k,bool ReturnValue) { return default; }
	public UObject GetOverrideRenderMaterial(int MaterialIndex,UObject ReturnValue) { return default; }
	public UMaterialInterface OverrideRenderMaterial;
	public void SetSecondaryRenderMaterial(UObject Material) {}
	public void ClearSecondaryRenderMaterial() {}
	public UObject GetSecondaryRenderMaterial(UObject ReturnValue) { return default; }
	public void SetSecondaryBuffersVisibility(bool bSetVisible) {}
	public bool GetSecondaryBuffersVisibility(bool ReturnValue) { return default; }
	public UMaterialInterface SecondaryRenderMaterial;
	public bool bEnableRaytracing;
	public void SetEnableRaytracing(bool bSetEnabled) {}
	public bool GetEnableRaytracing(bool ReturnValue) { return default; }
	public TArray<UMaterialInterface> BaseMaterials;
}
