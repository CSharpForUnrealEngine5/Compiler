#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>An Unreal Data Asset that defines what features are used in the AR session.</summary>
public partial class UARSessionConfig : UDataAsset {
// ARSessionConfig
	public EARWorldAlignment GetWorldAlignment(EARWorldAlignment ReturnValue) { return default; }
	public EARSessionType GetSessionType(EARSessionType ReturnValue) { return default; }
	public EARPlaneDetectionMode GetPlaneDetectionMode(EARPlaneDetectionMode ReturnValue) { return default; }
	public EARLightEstimationMode GetLightEstimationMode(EARLightEstimationMode ReturnValue) { return default; }
	public EARFrameSyncMode GetFrameSyncMode(EARFrameSyncMode ReturnValue) { return default; }
	public bool ShouldRenderCameraOverlay(bool ReturnValue) { return default; }
	public bool ShouldEnableCameraTracking(bool ReturnValue) { return default; }
	public bool ShouldEnableAutoFocus(bool ReturnValue) { return default; }
	public void SetEnableAutoFocus(bool bNewValue) {}
	public bool ShouldResetCameraTracking(bool ReturnValue) { return default; }
	public void SetResetCameraTracking(bool bNewValue) {}
	public bool ShouldResetTrackedObjects(bool ReturnValue) { return default; }
	public void SetResetTrackedObjects(bool bNewValue) {}
	public TArray<UObject> GetCandidateImageList(TArray<UObject> ReturnValue) { return default; }
	public void AddCandidateImage(UObject NewCandidateImage) {}
	public int GetMaxNumSimultaneousImagesTracked(int ReturnValue) { return default; }
	public EAREnvironmentCaptureProbeType GetEnvironmentCaptureProbeType(EAREnvironmentCaptureProbeType ReturnValue) { return default; }
	public TArray<byte> GetWorldMapData(TArray<byte> ReturnValue) { return default; }
	public void SetWorldMapData(TArray<byte> WorldMapData) {}
	public TArray<UObject> GetCandidateObjectList(TArray<UObject> ReturnValue) { return default; }
	public void SetCandidateObjectList(TArray<UObject> InCandidateObjects) {}
	public void AddCandidateObject(UObject CandidateObject) {}
	public FARVideoFormat GetDesiredVideoFormat(FARVideoFormat ReturnValue) { return default; }
	public void SetDesiredVideoFormat(FARVideoFormat NewFormat) {}
	public EARFaceTrackingDirection GetFaceTrackingDirection(EARFaceTrackingDirection ReturnValue) { return default; }
	public void SetFaceTrackingDirection(EARFaceTrackingDirection InDirection) {}
	public EARFaceTrackingUpdate GetFaceTrackingUpdate(EARFaceTrackingUpdate ReturnValue) { return default; }
	public void SetFaceTrackingUpdate(EARFaceTrackingUpdate InUpdate) {}
	public EARSessionTrackingFeature GetEnabledSessionTrackingFeature(EARSessionTrackingFeature ReturnValue) { return default; }
	public EARSceneReconstruction GetSceneReconstructionMethod(EARSceneReconstruction ReturnValue) { return default; }
	public void SetSessionTrackingFeatureToEnable(EARSessionTrackingFeature InSessionTrackingFeature) {}
	public void SetSceneReconstructionMethod(EARSceneReconstruction InSceneReconstructionMethod) {}
	public bool bGenerateMeshDataFromTrackedGeometry;
	public bool bGenerateCollisionForMeshData;
	public bool bGenerateNavMeshForMeshData;
	public bool bUseMeshDataForOcclusion;
	public bool bRenderMeshDataInWireframe;
	public bool bTrackSceneObjects;
	public bool bUsePersonSegmentationForOcclusion;
	public bool bUseSceneDepthForOcclusion;
	public bool bUseAutomaticImageScaleEstimation;
	public bool bUseStandardOnboardingUX;
	public EARWorldAlignment WorldAlignment;
	public EARSessionType SessionType;
	public EARPlaneDetectionMode PlaneDetectionMode_DEPRECATED;
	public bool bHorizontalPlaneDetection;
	public bool bVerticalPlaneDetection;
	public bool bEnableAutoFocus;
	public EARLightEstimationMode LightEstimationMode;
	public EARFrameSyncMode FrameSyncMode;
	public bool bEnableAutomaticCameraOverlay;
	public bool bEnableAutomaticCameraTracking;
	public bool bResetCameraTracking;
	public bool bResetTrackedObjects;
	public TArray<UARCandidateImage> CandidateImages;
	public int MaxNumSimultaneousImagesTracked;
	public EAREnvironmentCaptureProbeType EnvironmentCaptureProbeType;
	public TArray<byte> WorldMapData;
	public TArray<UARCandidateObject> CandidateObjects;
	public FARVideoFormat DesiredVideoFormat;
	public bool bUseOptimalVideoFormat;
	public EARFaceTrackingDirection FaceTrackingDirection;
	public EARFaceTrackingUpdate FaceTrackingUpdate;
	public int MaxNumberOfTrackedFaces;
	public TArray<byte> SerializedARCandidateImageDatabase;
	public EARSessionTrackingFeature EnabledSessionTrackingFeature;
	public EARSceneReconstruction SceneReconstructionMethod;
	public UClass PlaneComponentClass;
	public UClass PointComponentClass;
	public UClass FaceComponentClass;
	public UClass ImageComponentClass;
	public UClass QRCodeComponentClass;
	public UClass PoseComponentClass;
	public UClass EnvironmentProbeComponentClass;
	public UClass ObjectComponentClass;
	public UClass MeshComponentClass;
	public UClass GeoAnchorComponentClass;
	public UMaterialInterface DefaultMeshMaterial;
	public UMaterialInterface DefaultWireframeMeshMaterial;
}
