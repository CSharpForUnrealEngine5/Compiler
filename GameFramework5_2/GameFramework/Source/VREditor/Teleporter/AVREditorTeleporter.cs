#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Teleporter/VREditorTeleporter.h")]
///<summary>VR Editor teleport manager and the visual representation of the teleport</summary>
public partial class AVREditorTeleporter : AActor {
// VREditorTeleporter
	public void Init(UObject InMode) {}
	public void Shutdown() {}
	public bool IsAiming(bool ReturnValue) { return default; }
	public bool IsTeleporting(bool ReturnValue) { return default; }
	public UObject GetVRMode(UObject ReturnValue) { return default; }
	public void StartTeleport() {}
	public void TeleportDone() {}
	public void SetVisibility(bool bVisible) {}
	public void SetColor(FLinearColor Color) {}
	public float GetSlideDelta(UObject Interactor,bool Axis,float ReturnValue) { return default; }
	public void StartAiming(UObject Interactor) {}
	public void StopAiming() {}
	public void DoTeleport() {}
	public UObject GetInteractorTryingTeleport(UObject ReturnValue) { return default; }
	public UVREditorMode VRMode;
	public UStaticMeshComponent TeleportDirectionMeshComponent;
	public UStaticMeshComponent HMDMeshComponent;
	public UStaticMeshComponent LeftMotionControllerMeshComponent;
	public UStaticMeshComponent RightMotionControllerMeshComponent;
	public UMaterialInstanceDynamic TeleportMID;
	public UViewportInteractor InteractorTryingTeleport;
}
