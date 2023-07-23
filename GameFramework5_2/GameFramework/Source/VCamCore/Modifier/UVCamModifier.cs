#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/VCamModifier.h")]
public partial class UVCamModifier : UObject {
// VCamModifier
	public UObject GetOwningVCamComponent(UObject ReturnValue) { return default; }
	public void GetCurrentLiveLinkDataFromOwningComponent(FLiveLinkCameraBlueprintData LiveLinkData) {}
	public void SetEnabled(bool bNewEnabled) {}
	public bool IsEnabled(bool ReturnValue) { return default; }
	public bool SetStackEntryName(sbyte NewName,bool ReturnValue) { return default; }
	public sbyte GetStackEntryName(sbyte ReturnValue) { return default; }
	public UInputMappingContext InputMappingContext;
	public int InputContextPriority;
	public TMap<sbyte,FVCamModifierConnectionPoint> ConnectionPoints;
	public bool bIsInitialized;
}
