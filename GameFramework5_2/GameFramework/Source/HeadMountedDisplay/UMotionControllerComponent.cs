#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionControllerComponent.h")]
public partial class UMotionControllerComponent : UPrimitiveComponent {
// MotionControllerComponent
	public int PlayerIndex;
	public EControllerHand Hand_DEPRECATED;
	public sbyte MotionSource;
	public bool bDisableLowLatencyUpdate;
	public ETrackingStatus CurrentTrackingStatus;
	public bool bDisplayDeviceModel;
	public sbyte DisplayModelSource;
	public UStaticMesh CustomDisplayMesh;
	public TArray<UMaterialInterface> DisplayMeshMaterialOverrides;
	public void SetShowDeviceModel(bool bShowControllerModel) {}
	public void SetDisplayModelSource(sbyte NewDisplayModelSource) {}
	public void SetCustomDisplayMesh(UObject NewDisplayMesh) {}
	public bool IsTracked(bool ReturnValue) { return default; }
	public void SetTrackingSource(EControllerHand NewSource) {}
	public EControllerHand GetTrackingSource(EControllerHand ReturnValue) { return default; }
	public void SetTrackingMotionSource(sbyte NewSource) {}
	public void SetAssociatedPlayerIndex(int NewPlayer) {}
	public UPrimitiveComponent DisplayComponent;
	public void OnMotionControllerUpdated() {}
	public float GetParameterValue(sbyte InName,bool bValueFound,float ReturnValue) { return default; }
	public FVector GetHandJointPosition(int jointIndex,bool bValueFound,FVector ReturnValue) { return default; }
}
