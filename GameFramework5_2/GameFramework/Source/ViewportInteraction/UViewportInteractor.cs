#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportInteractor.h")]
///<summary>Represents the interactor in the world</summary>
public partial class UViewportInteractor : UObject {
// ViewportInteractor
	public UObject GetWorldInteraction(UObject ReturnValue) { return default; }
	public UObject GetOtherInteractor(UObject ReturnValue) { return default; }
	public void Shutdown() {}
	public void Tick(float DeltaTime) {}
	public FTransform GetTransform(FTransform ReturnValue) { return default; }
	public FTransform GetRoomSpaceTransform(FTransform ReturnValue) { return default; }
	public FTransform GetLastTransform(FTransform ReturnValue) { return default; }
	public FTransform GetLastRoomSpaceTransform(FTransform ReturnValue) { return default; }
	public EViewportInteractionDraggingMode GetDraggingMode(EViewportInteractionDraggingMode ReturnValue) { return default; }
	public bool GetLaserPointer(FVector LaserPointerStart,FVector LaserPointerEnd,bool bEvenIfBlocked=false,float LaserLengthOverride=0.0f,bool ReturnValue) { return default; }
	public bool GetTransformAndForwardVector(FTransform OutHandTransform,FVector OutForwardVector,bool ReturnValue) { return default; }
	public FVector GetHoverLocation(FVector ReturnValue) { return default; }
	public bool IsHoveringOverGizmo(bool ReturnValue) { return default; }
	public void SetDraggingMode(EViewportInteractionDraggingMode NewDraggingMode) {}
	public void SetHitResultGizmoFilterMode(EHitResultGizmoFilterMode newFilter) {}
	public EHitResultGizmoFilterMode GetHitResultGizmoFilterMode(EHitResultGizmoFilterMode ReturnValue) { return default; }
	public void SetCanCarry(bool bInCanCarry) {}
	public bool CanCarry(bool ReturnValue) { return default; }
	public void HandleInputKey_BP(FViewportActionKeyInput Action,FKey Key,EInputEvent Event,bool bOutWasHandled) {}
	public void HandleInputAxis_BP(FViewportActionKeyInput Action,FKey Key,float Delta,float DeltaTime,bool bOutWasHandled) {}
	public TMap<FKey,FViewportActionKeyInput> KeyToActionMap;
	public UViewportWorldInteraction WorldInteraction;
	public UViewportInteractor OtherInteractor;
}
