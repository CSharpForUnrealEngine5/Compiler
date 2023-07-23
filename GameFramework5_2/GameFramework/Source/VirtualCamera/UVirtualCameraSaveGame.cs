#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraSaveGame.h")]
public partial class UVirtualCameraSaveGame : USaveGame {
// VirtualCameraSaveGame
	public TMap<sbyte,FVirtualCameraWaypoint> Waypoints;
	public TMap<sbyte,FVirtualCameraScreenshot> Screenshots;
	public sbyte HomeWaypointName;
	public FVirtualCameraSettings CameraSettings;
	public TMap<sbyte,FVirtualCameraSettingsPreset> SettingsPresets;
	public sbyte SaveSlotName;
	public uint UserIndex;
	public int WaypointIndex;
	public int ScreenshotIndex;
	public int PresetIndex;
}
