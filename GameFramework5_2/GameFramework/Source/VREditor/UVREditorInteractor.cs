#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VREditorInteractor.h")]
///<summary>VREditor default interactor</summary>
public partial class UVREditorInteractor : UViewportInteractor {
// VREditorInteractor
	public void Init(UObject InVRMode) {}
	public void SetupComponent(UObject OwningActor) {}
	public sbyte GetHMDDeviceType(sbyte ReturnValue) { return default; }
	public UObject GetMotionControllerComponent(UObject ReturnValue) { return default; }
	public void SetControllerHandSide(sbyte InControllerHandSide) {}
	public sbyte GetControllerHandSide(sbyte ReturnValue) { return default; }
	public float GetSlideDelta(float ReturnValue) { return default; }
	public void SetForceShowLaser(bool bInForceShow) {}
	public bool IsTouchingTrackpad(bool ReturnValue) { return default; }
	public FVector2D GetTrackpadPosition(FVector2D ReturnValue) { return default; }
	public FVector2D GetLastTrackpadPosition(FVector2D ReturnValue) { return default; }
	public FVector GetLaserStart(FVector ReturnValue) { return default; }
	public FVector GetLaserEnd(FVector ReturnValue) { return default; }
	public void SetForceLaserColor(FLinearColor InColor) {}
	public UObject GetTeleportActor(UObject ReturnValue) { return default; }
	public EControllerHand GetControllerSide(EControllerHand ReturnValue) { return default; }
	public EControllerType GetControllerType(EControllerType ReturnValue) { return default; }
	public void SetControllerType(EControllerType InControllerType) {}
	public bool TryOverrideControllerType(EControllerType InControllerType,bool ReturnValue) { return default; }
	public bool IsHoveringOverUI(bool ReturnValue) { return default; }
	public bool IsClickingOnUI(bool ReturnValue) { return default; }
	public float GetSelectAndMoveTriggerValue(float ReturnValue) { return default; }
	public void ReplaceHandMeshComponent(UObject NewMesh,FVector MeshScale=FVector) {}
	public bool bIsUndoRedoSwipeEnabled;
	public UMotionControllerComponent MotionControllerComponent;
	public UMotionControllerComponent LaserMotionControllerComponent;
	public UStaticMeshComponent HandMeshComponent;
	public void UpdateHandMeshRelativeTransform() {}
	public USplineComponent LaserSplineComponent;
	public TArray<USplineMeshComponent> LaserSplineMeshComponents;
	public UMaterialInstanceDynamic LaserPointerMID;
	public UMaterialInstanceDynamic TranslucentLaserPointerMID;
	public UStaticMeshComponent HoverMeshComponent;
	public UPointLightComponent HoverPointLightComponent;
	public UMaterialInstanceDynamic HandMeshMID;
	public AActor OwningAvatar;
	public EControllerType ControllerType;
	public EControllerType OverrideControllerType;
	public sbyte ControllerMotionSource;
	public UVREditorMode VRMode;
}
