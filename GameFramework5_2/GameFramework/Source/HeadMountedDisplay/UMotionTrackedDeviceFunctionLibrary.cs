#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionTrackedDeviceFunctionLibrary.h")]
public partial class UMotionTrackedDeviceFunctionLibrary : UBlueprintFunctionLibrary {
// MotionTrackedDeviceFunctionLibrary
	public bool IsMotionTrackedDeviceCountManagementNecessary(bool ReturnValue) { return default; }
	public void SetIsControllerMotionTrackingEnabledByDefault(bool Enable) {}
	public int GetMaximumMotionTrackedControllerCount(int ReturnValue) { return default; }
	public int GetMotionTrackingEnabledControllerCount(int ReturnValue) { return default; }
	public bool IsMotionTrackingEnabledForDevice(int PlayerIndex,EControllerHand Hand,bool ReturnValue) { return default; }
	public bool IsMotionTrackingEnabledForSource(int PlayerIndex,sbyte SourceName,bool ReturnValue) { return default; }
	public bool IsMotionTrackingEnabledForComponent(UObject MotionControllerComponent,bool ReturnValue) { return default; }
	public bool EnableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand,bool ReturnValue) { return default; }
	public bool EnableMotionTrackingOfSource(int PlayerIndex,sbyte SourceName,bool ReturnValue) { return default; }
	public bool EnableMotionTrackingForComponent(UObject MotionControllerComponent,bool ReturnValue) { return default; }
	public void DisableMotionTrackingOfDevice(int PlayerIndex,EControllerHand Hand) {}
	public void DisableMotionTrackingOfSource(int PlayerIndex,sbyte SourceName) {}
	public void DisableMotionTrackingForComponent(UObject MotionControllerComponent) {}
	public void DisableMotionTrackingOfAllControllers() {}
	public void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) {}
	public TArray<sbyte> EnumerateMotionSources(TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetActiveTrackingSystemName(sbyte ReturnValue) { return default; }
	public bool IsMotionSourceTracking(int PlayerIndex,sbyte SourceName,bool ReturnValue) { return default; }
}
