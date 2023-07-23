#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EyeTrackerFunctionLibrary.h")]
public partial class UEyeTrackerFunctionLibrary : UBlueprintFunctionLibrary {
// EyeTrackerFunctionLibrary
	public bool IsEyeTrackerConnected(bool ReturnValue) { return default; }
	public bool IsStereoGazeDataAvailable(bool ReturnValue) { return default; }
	public bool GetGazeData(FEyeTrackerGazeData OutGazeData,bool ReturnValue) { return default; }
	public bool GetStereoGazeData(FEyeTrackerStereoGazeData OutGazeData,bool ReturnValue) { return default; }
	public void SetEyeTrackedPlayer(UObject PlayerController) {}
}
