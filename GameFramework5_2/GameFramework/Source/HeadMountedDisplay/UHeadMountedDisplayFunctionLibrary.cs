#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayFunctionLibrary.h")]
public partial class UHeadMountedDisplayFunctionLibrary : UBlueprintFunctionLibrary {
// HeadMountedDisplayFunctionLibrary
	public bool IsHeadMountedDisplayEnabled(bool ReturnValue) { return default; }
	public bool IsHeadMountedDisplayConnected(bool ReturnValue) { return default; }
	public bool EnableHMD(bool bEnable,bool ReturnValue) { return default; }
	public sbyte GetHMDDeviceName(sbyte ReturnValue) { return default; }
	public int GetXRSystemFlags(int ReturnValue) { return default; }
	public sbyte GetVersionString(sbyte ReturnValue) { return default; }
	public EHMDWornState GetHMDWornState(EHMDWornState ReturnValue) { return default; }
	public void GetOrientationAndPosition(FRotator DeviceRotation,FVector DevicePosition) {}
	public bool HasValidTrackingPosition(bool ReturnValue) { return default; }
	public int GetNumOfTrackingSensors(int ReturnValue) { return default; }
	public void GetTrackingSensorParameters(FVector Origin,FRotator Rotation,float LeftFOV,float RightFOV,float TopFOV,float BottomFOV,float Distance,float NearPlane,float FarPlane,bool IsActive,int Index=0) {}
	public void GetPositionalTrackingCameraParameters(FVector CameraOrigin,FRotator CameraRotation,float HFOV,float VFOV,float CameraDistance,float NearPlane,float FarPlane) {}
	public bool IsInLowPersistenceMode(bool ReturnValue) { return default; }
	public void EnableLowPersistenceMode(bool bEnable) {}
	public void ResetOrientationAndPosition(float Yaw=0.f,EOrientPositionSelector Options=EOrientPositionSelector) {}
	public void SetClippingPlanes(float Near,float Far) {}
	public float GetPixelDensity(float ReturnValue) { return default; }
	public void SetWorldToMetersScale(UObject WorldContext,float NewScale=100.f) {}
	public float GetWorldToMetersScale(UObject WorldContext,float ReturnValue) { return default; }
	public void SetTrackingOrigin(byte Origin) {}
	public byte GetTrackingOrigin(byte ReturnValue) { return default; }
	public FTransform GetTrackingToWorldTransform(UObject WorldContext,FTransform ReturnValue) { return default; }
	public void CalibrateExternalTrackingToHMD(FTransform ExternalTrackingTransform) {}
	public void UpdateExternalTrackingHMDPosition(FTransform ExternalTrackingTransform) {}
	public void GetVRFocusState(bool bUseFocus,bool bHasFocus) {}
	public bool IsSpectatorScreenModeControllable(bool ReturnValue) { return default; }
	public void SetSpectatorScreenMode(ESpectatorScreenMode Mode) {}
	public void SetSpectatorScreenTexture(UObject InTexture) {}
	public void SetSpectatorScreenModeTexturePlusEyeLayout(FVector2D EyeRectMin,FVector2D EyeRectMax,FVector2D TextureRectMin,FVector2D TextureRectMax,bool bDrawEyeFirst=true,bool bClearBlack=false,bool bUseAlpha=false) {}
	public TArray<FXRDeviceId> EnumerateTrackedDevices(sbyte SystemId=NAME_None,EXRTrackedDeviceType DeviceType=EXRTrackedDeviceType,TArray<FXRDeviceId> ReturnValue) { return default; }
	public void GetDevicePose(FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public void GetDeviceWorldPose(UObject WorldContext,FXRDeviceId XRDeviceId,bool bIsTracked,FRotator Orientation,bool bHasPositionalTracking,FVector Position) {}
	public bool IsDeviceTracking(FXRDeviceId XRDeviceId,bool ReturnValue) { return default; }
	public void GetHMDData(UObject WorldContext,FXRHMDData HMDData) {}
	public void GetMotionControllerData(UObject WorldContext,EControllerHand Hand,FXRMotionControllerData MotionControllerData) {}
	public bool ConfigureGestures(FXRGestureConfig GestureConfig,bool ReturnValue) { return default; }
	public bool GetCurrentInteractionProfile(EControllerHand Hand,sbyte InteractionProfile,bool ReturnValue) { return default; }
	public EXRDeviceConnectionResult ConnectRemoteXRDevice(sbyte IpAddress,int BitRate,EXRDeviceConnectionResult ReturnValue) { return default; }
	public void DisconnectRemoteXRDevice() {}
	public void SetXRDisconnectDelegate(FXRDeviceOnDisconnectDelegate InDisconnectedDelegate) {}
	public void SetXRTimedInputActionDelegate(sbyte ActionName,FXRTimedInputActionDelegate InDelegate) {}
	public void ClearXRTimedInputActionDelegate(sbyte ActionPath) {}
	public bool GetControllerTransformForTime(UObject WorldContext,int ControllerIndex,sbyte MotionSource,FTimespan Time,bool bTimeWasUsed,FRotator Orientation,FVector Position,bool bProvidedLinearVelocity,FVector LinearVelocity,bool bProvidedAngularVelocity,FVector AngularVelocityRadPerSec,bool bProvidedLinearAcceleration,FVector LinearAcceleration,bool ReturnValue) { return default; }
	public FVector2D GetPlayAreaBounds(byte Origin=EHMDTrackingOrigin,FVector2D ReturnValue) { return default; }
	public bool GetTrackingOriginTransform(byte Origin,FTransform OutTransform,bool ReturnValue) { return default; }
	public bool GetPlayAreaRect(FTransform OutTransform,FVector2D OutRect,bool ReturnValue) { return default; }
	public void BreakKey(FKey InKey,sbyte InteractionProfile,EControllerHand Hand,sbyte MotionSource,sbyte Indentifier,sbyte Component) {}
}
