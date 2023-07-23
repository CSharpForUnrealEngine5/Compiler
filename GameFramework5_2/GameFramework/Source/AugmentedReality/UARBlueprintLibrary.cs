#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARBlueprintLibrary.h")]
public partial class UARBlueprintLibrary : UBlueprintFunctionLibrary {
// ARBlueprintLibrary
	public bool IsARSupported(bool ReturnValue) { return default; }
	public void StartARSession(UObject SessionConfig) {}
	public void PauseARSession() {}
	public void StopARSession() {}
	public FARSessionStatus GetARSessionStatus(FARSessionStatus ReturnValue) { return default; }
	public UObject GetSessionConfig(UObject ReturnValue) { return default; }
	public bool ToggleARCapture(bool bOnOff,EARCaptureType CaptureType,bool ReturnValue) { return default; }
	public void SetEnabledXRCamera(bool bOnOff) {}
	public FIntPoint ResizeXRCamera(FIntPoint InSize,FIntPoint ReturnValue) { return default; }
	public void SetAlignmentTransform(FTransform InAlignmentTransform) {}
	public TArray<FARTraceResult> LineTraceTrackedObjects(FVector2D ScreenCoord,bool bTestFeaturePoints=true,bool bTestGroundPlane=true,bool bTestPlaneExtents=true,bool bTestPlaneBoundaryPolygon=true,TArray<FARTraceResult> ReturnValue) { return default; }
	public TArray<FARTraceResult> LineTraceTrackedObjects3D(FVector Start,FVector End,bool bTestFeaturePoints=true,bool bTestGroundPlane=true,bool bTestPlaneExtents=true,bool bTestPlaneBoundaryPolygon=true,TArray<FARTraceResult> ReturnValue) { return default; }
	public EARTrackingQuality GetTrackingQuality(EARTrackingQuality ReturnValue) { return default; }
	public EARTrackingQualityReason GetTrackingQualityReason(EARTrackingQualityReason ReturnValue) { return default; }
	public TArray<UObject> GetAllGeometries(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllGeometriesByClass(UClass GeometryClass,TArray<UObject> ReturnValue) { return default; }
	public UObject GetCameraImage(UObject ReturnValue) { return default; }
	public UObject GetCameraDepth(UObject ReturnValue) { return default; }
	public UObject GetARTexture(EARTextureType TextureType,UObject ReturnValue) { return default; }
	public bool IsSessionTypeSupported(EARSessionType SessionType,bool ReturnValue) { return default; }
	public void DebugDrawTrackedGeometry(UObject TrackedGeometry,UObject WorldContextObject,FLinearColor Color=FLinearColor,float OutlineThickness=5.0f,float PersistForSeconds=0.0f) {}
	public void DebugDrawPin(UObject ARPin,UObject WorldContextObject,FLinearColor Color=FLinearColor,float Scale=5.0f,float PersistForSeconds=0.0f) {}
	public UObject GetCurrentLightEstimate(UObject ReturnValue) { return default; }
	public UObject PinComponent(UObject ComponentToPin,FTransform PinToWorldTransform,UObject TrackedGeometry=nullptr,sbyte DebugName=NAME_None,UObject ReturnValue) { return default; }
	public UObject PinComponentToTraceResult(UObject ComponentToPin,FARTraceResult TraceResult,sbyte DebugName=NAME_None,UObject ReturnValue) { return default; }
	public bool PinComponentToARPin(UObject ComponentToPin,UObject Pin,bool ReturnValue) { return default; }
	public void UnpinComponent(UObject ComponentToUnpin) {}
	public void RemovePin(UObject PinToRemove) {}
	public TArray<UObject> GetAllPins(TArray<UObject> ReturnValue) { return default; }
	public bool IsARPinLocalStoreSupported(bool ReturnValue) { return default; }
	public bool IsARPinLocalStoreReady(bool ReturnValue) { return default; }
	public TMap<sbyte,UObject> LoadARPinsFromLocalStore(TMap<sbyte,UObject> ReturnValue) { return default; }
	public bool SaveARPinToLocalStore(sbyte InSaveName,UObject InPin,bool ReturnValue) { return default; }
	public void RemoveARPinFromLocalStore(sbyte InSaveName) {}
	public void RemoveAllARPinsFromLocalStore() {}
	public TArray<UObject> GetAllTrackedPlanes(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllTrackedPoints(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllTrackedImages(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllTrackedEnvironmentCaptureProbes(TArray<UObject> ReturnValue) { return default; }
	public bool AddManualEnvironmentCaptureProbe(FVector Location,FVector Extent,bool ReturnValue) { return default; }
	public EARWorldMappingState GetWorldMappingStatus(EARWorldMappingState ReturnValue) { return default; }
	public TArray<FVector> GetPointCloud(TArray<FVector> ReturnValue) { return default; }
	public TArray<FARVideoFormat> GetSupportedVideoFormats(EARSessionType SessionType,TArray<FARVideoFormat> ReturnValue) { return default; }
	public UObject AddRuntimeCandidateImage(UObject SessionConfig,UObject CandidateTexture,sbyte FriendlyName,float PhysicalWidth,UObject ReturnValue) { return default; }
	public bool IsSessionTrackingFeatureSupported(EARSessionType SessionType,EARSessionTrackingFeature SessionTrackingFeature,bool ReturnValue) { return default; }
	public bool IsSceneReconstructionSupported(EARSessionType SessionType,EARSceneReconstruction SceneReconstructionMethod,bool ReturnValue) { return default; }
	public TArray<FARPose2D> GetAllTracked2DPoses(TArray<FARPose2D> ReturnValue) { return default; }
	public TArray<UObject> GetAllTrackedPoses(TArray<UObject> ReturnValue) { return default; }
	public UObject GetPersonSegmentationImage(UObject ReturnValue) { return default; }
	public UObject GetPersonSegmentationDepthImage(UObject ReturnValue) { return default; }
	public bool GetObjectClassificationAtLocation(FVector InWorldLocation,EARObjectClassification OutClassification,FVector OutClassificationLocation,float MaxLocationDiff=10.f,bool ReturnValue) { return default; }
	public void SetARWorldOriginLocationAndRotation(FVector OriginLocation,FRotator OriginRotation,bool bIsTransformInWorldSpace=true,bool bMaintainUpDirection=true) {}
	public void SetARWorldScale(float InWorldScale) {}
	public float GetARWorldScale(float ReturnValue) { return default; }
	public FTransform GetAlignmentTransform(FTransform ReturnValue) { return default; }
	public bool AddTrackedPointWithName(FTransform WorldTransform,sbyte PointName,bool bDeletePointsWithSameName=true,bool ReturnValue) { return default; }
	public TArray<UObject> FindTrackedPointsByName(sbyte PointName,TArray<UObject> ReturnValue) { return default; }
	public void CalculateClosestIntersection(TArray<FVector> StartPoints,TArray<FVector> EndPoints,FVector ClosestIntersection) {}
	public void CalculateAlignmentTransform(FTransform TransformInFirstCoordinateSystem,FTransform TransformInSecondCoordinateSystem,FTransform AlignmentTransform) {}
	public int GetNumberOfTrackedFacesSupported(int ReturnValue) { return default; }
	public bool GetCameraIntrinsics(FARCameraIntrinsics OutCameraIntrinsics,bool ReturnValue) { return default; }
}
