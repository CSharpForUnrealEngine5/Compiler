#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPScoutingSubsystem.h")]
///<summary>* Subsystem used for VR Scouting</summary>
public partial class UVPScoutingSubsystem : UEditorSubsystem {
// VPScoutingSubsystem
	public UVPScoutingSubsystemHelpersBase VPSubsystemHelpers;
	public UVPScoutingSubsystemGestureManagerBase GestureManager;
	public bool IsSettingsMenuOpen;
	public float GripNavSpeedCoeff;
	public void ToggleVRScoutingUI(FVREditorFloatingUICreationContext CreationContext) {}
	public void HideInfoDisplayPanel() {}
	public bool IsVRScoutingUIOpen(sbyte PanelID,bool ReturnValue) { return default; }
	public UObject GetPanelActor(sbyte PanelID,UObject ReturnValue) { return default; }
	public UObject GetPanelWidget(sbyte PanelID,UObject ReturnValue) { return default; }
	public TArray<UObject> GetActiveEditorVRControllers(TArray<UObject> ReturnValue) { return default; }
	public sbyte GetVProdPanelID(EVProdPanelIDs Panel,sbyte ReturnValue) { return default; }
	public sbyte GetDirectorName(sbyte ReturnValue) { return default; }
	public sbyte GetShowName(sbyte ReturnValue) { return default; }
	public bool IsUsingMetricSystem(bool ReturnValue) { return default; }
	public void SetIsUsingMetricSystem(bool bInUseMetricSystem) {}
	public bool IsUsingTransformGizmo(bool ReturnValue) { return default; }
	public void SetIsUsingTransformGizmo(bool bInIsUsingTransformGizmo) {}
	public void SetShowTransformGizmoCVar(bool bInShowTransformGizmoCVar) {}
	public float GetFlightSpeed(float ReturnValue) { return default; }
	public void SetFlightSpeed(float InFlightSpeed) {}
	public float GetGripNavSpeed(float ReturnValue) { return default; }
	public void SetGripNavSpeed(float InGripNavSpeed) {}
	public bool IsUsingInertiaDamping(bool ReturnValue) { return default; }
	public void SetIsUsingInertiaDamping(bool bInIsUsingInertiaDamping) {}
	public void SetInertiaDampingCVar(float InInertiaDamping) {}
	public bool IsHelperSystemEnabled(bool ReturnValue) { return default; }
	public void SetIsHelperSystemEnabled(bool bInIsHelperSystemEnabled) {}
	public UObject GetVREditorMode(UObject ReturnValue) { return default; }
	public bool EnterVRMode(bool ReturnValue) { return default; }
	public void ExitVRMode() {}
	public bool IsLocationGridSnappingEnabled(bool ReturnValue) { return default; }
	public void ToggleLocationGridSnapping() {}
	public bool IsRotationGridSnappingEnabled(bool ReturnValue) { return default; }
	public void ToggleRotationGridSnapping() {}
}
