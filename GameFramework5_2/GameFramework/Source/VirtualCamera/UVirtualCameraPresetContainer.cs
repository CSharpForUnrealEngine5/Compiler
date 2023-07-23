#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVirtualCameraPresetContainer.h")]
public partial class UVirtualCameraPresetContainer : UInterface {
// VirtualCameraPresetContainer
	public sbyte SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale,sbyte ReturnValue) { return default; }
	public bool LoadPreset(sbyte PresetName,bool ReturnValue) { return default; }
	public int DeletePreset(sbyte PresetName,int ReturnValue) { return default; }
	public TMap<sbyte,FVirtualCameraSettingsPreset> GetSettingsPresets(TMap<sbyte,FVirtualCameraSettingsPreset> ReturnValue) { return default; }
}
