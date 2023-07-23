#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraController.h")]
public partial class UVirtualCameraController : UInterface {
// VirtualCameraController
	public UObject GetStreamedCameraComponent(UObject ReturnValue) { return default; }
	public UObject GetSceneCaptureComponent(UObject ReturnValue) { return default; }
	public UObject GetSequenceController(UObject ReturnValue) { return default; }
	public object /*ReturnValue*/ GetPresetContainer(object /*ReturnValue*/ ReturnValue) { return default; }
	public object /*ReturnValue*/ GetOptions(object /*ReturnValue*/ ReturnValue) { return default; }
	public FLiveLinkSubjectRepresentation GetLiveLinkRepresentation(FLiveLinkSubjectRepresentation ReturnValue) { return default; }
	public void SetLiveLinkRepresentation(FLiveLinkSubjectRepresentation InLiveLinkRepresenation) {}
	public bool IsStreaming(bool ReturnValue) { return default; }
	public bool ShouldSaveSettingsOnStopStreaming(bool ReturnValue) { return default; }
	public void SetSaveSettingsOnStopStreaming(bool bShouldSettingsSave) {}
	public FTransform GetRelativeTransform(FTransform ReturnValue) { return default; }
	public void AddBlendableToCamera(object /*InBlendableToAdd*/ InBlendableToAdd,float InWeight) {}
	public void SetTrackedActorForFocus(UObject InActorToTrack,FVector TrackingPointOffset) {}
	public void SetFocusVisualization(bool bInShowFocusVisualization) {}
	public void SetBeforeSetVirtualCameraTransformDelegate(FPreSetVirtualCameraTransform InDelegate) {}
	public void SetOnActorClickedDelegate(FOnActorClickedDelegate InDelegate) {}
	public void AddOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
	public void RemoveOnVirtualCameraUpdatedDelegate(FVirtualCameraTickDelegate InDelegate) {}
}
