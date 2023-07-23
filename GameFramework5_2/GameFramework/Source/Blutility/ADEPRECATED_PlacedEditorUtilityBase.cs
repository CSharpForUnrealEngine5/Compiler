#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlacedEditorUtilityBase.h")]
public partial class ADEPRECATED_PlacedEditorUtilityBase : AActor {
// PlacedEditorUtilityBase
	public sbyte HelpText;
	public TArray<UObject> GetSelectionSet(TArray<UObject> ReturnValue) { return default; }
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation,bool ReturnValue) { return default; }
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
}
