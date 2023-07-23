#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceSubsystem.h")]
///<summary>The input device subsystem provides an interface to allow users to set Input Device Properties</summary>
public partial class UInputDeviceSubsystem : UEngineSubsystem {
// InputDeviceSubsystem
	public FInputDevicePropertyHandle ActivateDevicePropertyOfClass(UClass PropertyClass,FActivateDevicePropertyParams Params,FInputDevicePropertyHandle ReturnValue) { return default; }
	public UObject GetActiveDeviceProperty(FInputDevicePropertyHandle Handle,UObject ReturnValue) { return default; }
	public bool IsPropertyActive(FInputDevicePropertyHandle Handle,bool ReturnValue) { return default; }
	public void RemoveDevicePropertyByHandle(FInputDevicePropertyHandle HandleToRemove) {}
	public void RemoveDevicePropertyHandles(TSet<FInputDevicePropertyHandle> HandlesToRemove) {}
	public void RemoveAllDeviceProperties() {}
	public FHardwareDeviceIdentifier GetMostRecentlyUsedHardwareDevice(FPlatformUserId InUserId,FHardwareDeviceIdentifier ReturnValue) { return default; }
	public FHardwareDeviceIdentifier GetInputDeviceHardwareIdentifier(FInputDeviceId InputDevice,FHardwareDeviceIdentifier ReturnValue) { return default; }
	public FHardwareInputDeviceChanged OnInputHardwareDeviceChanged;
	public TSet<FActiveDeviceProperty> ActiveProperties;
	public TSet<FInputDevicePropertyHandle> PropertiesPendingRemoval;
}
