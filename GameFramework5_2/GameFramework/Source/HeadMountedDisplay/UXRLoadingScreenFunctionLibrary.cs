#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRLoadingScreenFunctionLibrary.h")]
///<summary>XR Loading Screen Function Library</summary>
public partial class UXRLoadingScreenFunctionLibrary : UBlueprintFunctionLibrary {
// XRLoadingScreenFunctionLibrary
	public void SetLoadingScreen(UObject Texture,FVector2D Scale=FVector2D,FVector Offset=FVector,bool bShowLoadingMovie=false,bool bShowOnSet=false) {}
	public void ClearLoadingScreenSplashes() {}
	public void AddLoadingScreenSplash(UObject Texture,FVector Translation,FRotator Rotation,FVector2D Size=FVector2D,FRotator DeltaRotation=FRotator,bool bClearBeforeAdd=false) {}
	public void ShowLoadingScreen() {}
	public void HideLoadingScreen() {}
}
