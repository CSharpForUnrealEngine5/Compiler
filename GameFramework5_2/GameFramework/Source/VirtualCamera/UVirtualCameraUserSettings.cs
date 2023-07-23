#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraUserSettings.h")]
///<summary>Virtual Camera User Settings</summary>
public partial class UVirtualCameraUserSettings : UObject {
// VirtualCameraUserSettings
	public float FocusInterpSpeed;
	public float JoysticksSpeed;
	public float MaxJoysticksSpeed;
	public bool bIsMapGrayscale;
	public bool bOverrideCameraSettingsOnTeleportToScreenshot;
	public sbyte VirtualCameraFilmback;
	public bool bDisplayFilmLeader;
	public bool bTeleportOnStart;
	public TSoftObjectPtr<UClass> DefaultVCamClass;
	public TArray<FInputAxisKeyMapping> AxisMappings;
	public TArray<FInputActionKeyMapping> ActionMappings;
	public float GetFocusInterpSpeed(float ReturnValue) { return default; }
	public void SetFocusInterpSpeed(float InFocusInterpSpeed) {}
	public float GetJoysticksSpeed(float ReturnValue) { return default; }
	public void SetJoysticksSpeed(float InJoysticksSpeed) {}
	public float GetMaxJoysticksSpeed(float ReturnValue) { return default; }
	public void SetMaxJoysticksSpeed(float InMaxJoysticksSpeed) {}
	public bool IsMapGrayscle(bool ReturnValue) { return default; }
	public void SetIsMapGrayscle(bool bInIsMapGrayscle) {}
	public bool GetShouldOverrideCameraSettingsOnTeleport(bool ReturnValue) { return default; }
	public void SetShouldOverrideCameraSettingsOnTeleport(bool bInOverrideCameraSettings) {}
	public sbyte GetSavedVirtualCameraFilmbackPresetName(sbyte ReturnValue) { return default; }
	public void SetSavedVirtualCameraFilmbackPresetName(sbyte InFilmback) {}
	public bool GetShouldDisplayFilmLeader(bool ReturnValue) { return default; }
	public void SetShouldDisplayFilmLeader(bool bInDisplayFilmLeader) {}
	public bool GetTeleportOnStart(bool ReturnValue) { return default; }
	public void SetTeleportOnStart(bool bInTeleportOnStart) {}
	public void InjectGamepadKeybinds() {}
	public void GetActionMappingsByName(sbyte InActionName,TArray<FInputActionKeyMapping> OutMappings) {}
	public void GetAxisMappingsByName(sbyte InAxisName,TArray<FInputAxisKeyMapping> OutMappings) {}
}
