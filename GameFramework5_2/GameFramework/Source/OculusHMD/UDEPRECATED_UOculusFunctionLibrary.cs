#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial class UDEPRECATED_UOculusFunctionLibrary : UBlueprintFunctionLibrary {
// UOculusFunctionLibrary
	public void GetPose(FRotator DeviceRotation,FVector DevicePosition,FVector NeckPosition,bool bUseOrienationForPlayerCamera=false,bool bUsePositionForPlayerCamera=false,FVector PositionScale=FVector) {}
	public void GetRawSensorData(FVector AngularAcceleration,FVector LinearAcceleration,FVector AngularVelocity,FVector LinearVelocity,float TimeInSeconds,ETrackedDeviceType DeviceType=ETrackedDeviceType) {}
	public bool IsDeviceTracked(ETrackedDeviceType DeviceType,bool ReturnValue) { return default; }
	public void SetCPUAndGPULevels(int CPULevel,int GPULevel) {}
	public bool GetUserProfile(FHmdUserProfile Profile,bool ReturnValue) { return default; }
	public void SetBaseRotationAndBaseOffsetInMeters(FRotator Rotation,FVector BaseOffsetInMeters,EOrientPositionSelector Options) {}
	public void GetBaseRotationAndBaseOffsetInMeters(FRotator OutRotation,FVector OutBaseOffsetInMeters) {}
	public void SetPositionScale3D(FVector PosScale3D) {}
	public void SetBaseRotationAndPositionOffset(FRotator BaseRot,FVector PosOffset,EOrientPositionSelector Options) {}
	public void GetBaseRotationAndPositionOffset(FRotator OutRot,FVector OutPosOffset) {}
	public void AddLoadingSplashScreen(UObject Texture,FVector TranslationInMeters,FRotator Rotation,FVector2D SizeInMeters=FVector2D,FRotator DeltaRotation=FRotator,bool bClearBeforeAdd=false) {}
	public void ClearLoadingSplashScreens() {}
	public bool HasInputFocus(bool ReturnValue) { return default; }
	public bool HasSystemOverlayPresent(bool ReturnValue) { return default; }
	public void GetGPUUtilization(bool IsGPUAvailable,float GPUUtilization) {}
	public float GetGPUFrameTime(float ReturnValue) { return default; }
	public EFixedFoveatedRenderingLevel GetFixedFoveatedRenderingLevel(EFixedFoveatedRenderingLevel ReturnValue) { return default; }
	public void SetFixedFoveatedRenderingLevel(EFixedFoveatedRenderingLevel level,bool isDynamic) {}
	public sbyte GetDeviceName(sbyte ReturnValue) { return default; }
	public EOculusDeviceType GetDeviceType(EOculusDeviceType ReturnValue) { return default; }
	public TArray<float> GetAvailableDisplayFrequencies(TArray<float> ReturnValue) { return default; }
	public float GetCurrentDisplayFrequency(float ReturnValue) { return default; }
	public void SetDisplayFrequency(float RequestedFrequency) {}
	public void EnablePositionTracking(bool bPositionTracking) {}
	public void EnableOrientationTracking(bool bOrientationTracking) {}
	public void SetColorScaleAndOffset(FLinearColor ColorScale,FLinearColor ColorOffset,bool bApplyToAllLayers=false) {}
	public bool GetSystemHmd3DofModeEnabled(bool ReturnValue) { return default; }
	public EOculusColorSpace GetHmdColorDesc(EOculusColorSpace ReturnValue) { return default; }
	public void SetClientColorDesc(EOculusColorSpace ColorSpace) {}
	public bool IsGuardianDisplayed(bool ReturnValue) { return default; }
	public bool IsGuardianConfigured(bool ReturnValue) { return default; }
	public TArray<FVector> GetGuardianPoints(EBoundaryType BoundaryType,bool UsePawnSpace=false,TArray<FVector> ReturnValue) { return default; }
	public FVector GetGuardianDimensions(EBoundaryType BoundaryType,FVector ReturnValue) { return default; }
	public FTransform GetPlayAreaTransform(FTransform ReturnValue) { return default; }
	public FGuardianTestResult GetPointGuardianIntersection(FVector Point,EBoundaryType BoundaryType,FGuardianTestResult ReturnValue) { return default; }
	public FGuardianTestResult GetNodeGuardianIntersection(ETrackedDeviceType DeviceType,EBoundaryType BoundaryType,FGuardianTestResult ReturnValue) { return default; }
	public void SetGuardianVisibility(bool GuardianVisible) {}
}
