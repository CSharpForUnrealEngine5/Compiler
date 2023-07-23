#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Light.h")]
public partial class ALight : AActor {
// Light
	public ULightComponent LightComponent;
	public bool bEnabled;
	public void OnRep_bEnabled() {}
	public void SetEnabled(bool bSetEnabled) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public void ToggleEnabled() {}
	public void SetBrightness(float NewBrightness) {}
	public float GetBrightness(float ReturnValue) { return default; }
	public void SetLightColor(FLinearColor NewLightColor) {}
	public FLinearColor GetLightColor(FLinearColor ReturnValue) { return default; }
	public void SetLightFunctionMaterial(UObject NewLightFunctionMaterial) {}
	public void SetLightFunctionScale(FVector NewLightFunctionScale) {}
	public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance) {}
	public void SetCastShadows(bool bNewValue) {}
	public void SetAffectTranslucentLighting(bool bNewValue) {}
}
