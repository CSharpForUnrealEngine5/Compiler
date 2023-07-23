#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/InputDeviceLibrary.h")]
///<summary>A static BP library that exposes Input Device data to blueprints</summary>
public partial class UInputDeviceLibrary : UBlueprintFunctionLibrary {
// InputDeviceLibrary
	public UObject GetPlayerControllerFromPlatformUser(FPlatformUserId UserId,UObject ReturnValue) { return default; }
	public UObject GetPlayerControllerFromInputDevice(FInputDeviceId DeviceId,UObject ReturnValue) { return default; }
	public bool IsDevicePropertyHandleValid(FInputDevicePropertyHandle InHandle,bool ReturnValue) { return default; }
	public int GetAllInputDevicesForUser(FPlatformUserId UserId,TArray<FInputDeviceId> OutInputDevices,int ReturnValue) { return default; }
	public int GetAllInputDevices(TArray<FInputDeviceId> OutInputDevices,int ReturnValue) { return default; }
	public int GetAllConnectedInputDevices(TArray<FInputDeviceId> OutInputDevices,int ReturnValue) { return default; }
	public int GetAllActiveUsers(TArray<FPlatformUserId> OutUsers,int ReturnValue) { return default; }
	public FPlatformUserId GetUserForUnpairedInputDevices(FPlatformUserId ReturnValue) { return default; }
	public FPlatformUserId GetPrimaryPlatformUser(FPlatformUserId ReturnValue) { return default; }
	public bool IsUnpairedUserId(FPlatformUserId PlatformId,bool ReturnValue) { return default; }
	public bool IsInputDeviceMappedToUnpairedUser(FInputDeviceId InputDevice,bool ReturnValue) { return default; }
	public FInputDeviceId GetDefaultInputDevice(FInputDeviceId ReturnValue) { return default; }
	public FPlatformUserId GetUserForInputDevice(FInputDeviceId DeviceId,FPlatformUserId ReturnValue) { return default; }
	public FInputDeviceId GetPrimaryInputDeviceForUser(FPlatformUserId UserId,FInputDeviceId ReturnValue) { return default; }
	public EInputDeviceConnectionState GetInputDeviceConnectionState(FInputDeviceId DeviceId,EInputDeviceConnectionState ReturnValue) { return default; }
	public bool IsValidInputDevice(FInputDeviceId DeviceId,bool ReturnValue) { return default; }
	public bool IsValidPlatformId(FPlatformUserId UserId,bool ReturnValue) { return default; }
	public FPlatformUserId PlatformUserId_None(FPlatformUserId ReturnValue) { return default; }
	public FInputDeviceId InputDeviceId_None(FInputDeviceId ReturnValue) { return default; }
	public bool EqualEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B,bool ReturnValue) { return default; }
	public bool NotEqual_PlatformUserId(FPlatformUserId A,FPlatformUserId B,bool ReturnValue) { return default; }
	public bool EqualEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B,bool ReturnValue) { return default; }
	public bool NotEqual_InputDeviceId(FInputDeviceId A,FInputDeviceId B,bool ReturnValue) { return default; }
}
