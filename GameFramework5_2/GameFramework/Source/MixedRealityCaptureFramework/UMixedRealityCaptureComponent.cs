#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MixedRealityCaptureComponent.h")]
public partial class UMixedRealityCaptureComponent : USceneCaptureComponent2D {
// MixedRealityCaptureComponent
	public UMediaPlayer MediaSource;
	public UMaterialInterface VideoProcessingMaterial;
	public FMrcVideoProcessingParams VideoProcessingParams;
	public FMrcVideoCaptureFeedIndex CaptureFeedRef;
	public FOpenCVLensDistortionParameters LensDistortionParameters;
	public sbyte TrackingSourceName;
	public UTextureRenderTarget2D GarbageMatteCaptureTextureTarget;
	public int TrackingLatency;
	public bool bAutoLoadConfiguration;
	public float ProjectionDepthOffset;
	public bool bProjectionDepthTracking;
	public bool SaveAsDefaultConfiguration_K2(bool ReturnValue) { return default; }
	public bool SaveConfiguration_K2(sbyte SlotName,int UserIndex,bool ReturnValue) { return default; }
	public bool LoadDefaultConfiguration(bool ReturnValue) { return default; }
	public bool LoadConfiguration(sbyte SlotName,int UserIndex,bool ReturnValue) { return default; }
	public UObject ConstructCalibrationData(UObject ReturnValue) { return default; }
	public void FillOutCalibrationData(UObject Dst) {}
	public void ApplyCalibrationData(UObject ConfigData) {}
	public bool SetGarbageMatteActor(UObject Actor,bool ReturnValue) { return default; }
	public void SetVidProjectionMat(UObject NewMaterial) {}
	public void SetVidProcessingParams(FMrcVideoProcessingParams NewVidProcessingParams) {}
	public void SetDeviceAttachment(sbyte SourceName) {}
	public void DetatchFromDevice() {}
	public bool IsTracked(bool ReturnValue) { return default; }
	public void SetCaptureDevice(FMrcVideoCaptureFeedIndex FeedRef) {}
	public void SetLensDistortionParameters(FOpenCVLensDistortionParameters ModelRef) {}
	public int GetTrackingDelay(int ReturnValue) { return default; }
	public void SetTrackingDelay(int DelayMS) {}
	public void SetProjectionDepthOffset(float DepthOffset) {}
	public UObject GetProjectionActor_K2(UObject ReturnValue) { return default; }
	public void FMRCaptureFeedOpenedDelegate(FMrcVideoCaptureFeedIndex FeedRef) {}
	public FMRCaptureFeedOpenedDelegate OnCaptureSourceOpened;
	public void SetEnableProjectionDepthTracking(bool bEnable=true) {}
	public void OnVideoFeedOpened(FMrcVideoCaptureFeedIndex FeedRef) {}
	public UStaticMesh ProxyMesh;
	public UStaticMeshComponent ProxyMeshComponent;
	public UChildActorComponent ProjectionActor;
	public UMotionControllerComponent PairedTracker;
	public USceneComponent TrackingOriginOffset;
	public UMrcGarbageMatteCaptureComponent GarbageMatteCaptureComponent;
	public UTexture2D DistortionDisplacementMap;
}
