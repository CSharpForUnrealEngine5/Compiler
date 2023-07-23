#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Component for applying a post-process lens distortion effect to a CineCameraComponent on the same actor</summary>
public partial class ULensComponent : UActorComponent {
// LensComponent
	public FLensFilePicker GetLensFilePicker(FLensFilePicker ReturnValue) { return default; }
	public UObject GetLensFile(UObject ReturnValue) { return default; }
	public void SetLensFilePicker(FLensFilePicker LensFile) {}
	public void SetLensFile(UObject LensFile) {}
	public EFIZEvaluationMode GetFIZEvaluationMode(EFIZEvaluationMode ReturnValue) { return default; }
	public void SetFIZEvaluationMode(EFIZEvaluationMode Mode) {}
	public float GetOverscanMultiplier(float ReturnValue) { return default; }
	public void SetOverscanMultiplier(float Multiplier) {}
	public EFilmbackOverrideSource GetFilmbackOverrideSetting(EFilmbackOverrideSource ReturnValue) { return default; }
	public void SetFilmbackOverrideSetting(EFilmbackOverrideSource Setting) {}
	public FCameraFilmbackSettings GetCroppedFilmback(FCameraFilmbackSettings ReturnValue) { return default; }
	public void SetCroppedFilmback(FCameraFilmbackSettings Filmback) {}
	public bool ShouldApplyNodalOffsetOnTick(bool ReturnValue) { return default; }
	public void SetApplyNodalOffsetOnTick(bool bApplyNodalOffset) {}
	public EDistortionSource GetDistortionSource(EDistortionSource ReturnValue) { return default; }
	public void SetDistortionSource(EDistortionSource Source) {}
	public bool ShouldApplyDistortion(bool ReturnValue) { return default; }
	public void SetApplyDistortion(bool bApply) {}
	public UClass GetLensModel(UClass ReturnValue) { return default; }
	public void SetLensModel(UClass Model) {}
	public FLensDistortionState GetDistortionState(FLensDistortionState ReturnValue) { return default; }
	public void SetDistortionState(FLensDistortionState State) {}
	public void ClearDistortionState() {}
	public float GetOriginalFocalLength(float ReturnValue) { return default; }
	public FLensFileEvaluationInputs GetLensFileEvaluationInputs(FLensFileEvaluationInputs ReturnValue) { return default; }
	public bool WasNodalOffsetAppliedThisTick(bool ReturnValue) { return default; }
	public bool WasDistortionEvaluated(bool ReturnValue) { return default; }
	public void ApplyNodalOffset(UObject ComponentToOffset,bool bUseManualInputs=false,float ManualFocusInput=0.0f,float ManualZoomInput=0.0f) {}
	public FLensFilePicker LensFilePicker;
	public EFIZEvaluationMode EvaluationMode;
	public FComponentReference TargetCameraComponent;
	public FLensFileEvaluationInputs EvalInputs;
	public EDistortionSource DistortionStateSource;
	public bool bApplyDistortion;
	public UClass LensModel;
	public FLensDistortionState DistortionState;
	public bool bScaleOverscan;
	public float OverscanMultiplier;
	public EFilmbackOverrideSource FilmbackOverride;
	public FCameraFilmbackSettings CroppedFilmback;
	public bool bApplyNodalOffsetOnTick;
	public FTransform OriginalTrackedComponentTransform;
	public bool bIsDistortionSetup;
	public float OriginalFocalLength;
	public UMaterialInstanceDynamic LastDistortionMID;
	public UCineCameraComponent LastCameraComponent;
	public TMap<UClass,ULensDistortionModelHandlerBase> LensDistortionHandlerMap;
	public TWeakObjectPtr<USceneComponent> TrackedComponent;
	public sbyte TrackedComponentName;
	public FRotator OriginalCameraRotation_DEPRECATED;
	public FVector OriginalCameraLocation_DEPRECATED;
	public bool bEvaluateLensFileForDistortion_DEPRECATED;
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	public FGuid DistortionProducerID_DEPRECATED;
	public FDistortionHandlerPicker DistortionSource_DEPRECATED;
}
