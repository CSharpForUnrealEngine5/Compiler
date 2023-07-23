#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraPlayerControllerBase.h")]
public partial class AVirtualCameraPlayerControllerBase : APlayerController {
// VirtualCameraPlayerControllerBase
	public ETrackerInputSource InputSource;
	public sbyte LiveLinkTargetName;
	public FTrackingOffset TrackerPreOffset;
	public FTrackingOffset TrackerPostOffset;
	public UClass TargetCameraActorClass;
	public TArray<sbyte> RequiredSequencerRecorderCameraSettings;
	public FVirtualCameraResetOffsetsDelegate OnOffsetReset;
	public AVPRootActor RootActor;
	public void GetCustomTrackerLocationAndRotation(FVector OutTrackerLocation,FRotator OutTrackerRotation) {}
	public void UpdateFocusReticle(FVector NewReticleLocation) {}
	public void OnRecordEnabledStateChanged(bool bIsRecordEnabled) {}
	public void OnStopped() {}
	public void InitializeAutoFocusPoint() {}
	public UObject GetTargetCamera(UObject ReturnValue) { return default; }
	public void SetInputSource(ETrackerInputSource InInputSource) {}
	public void FocusMethodChanged(EVirtualCameraFocusMethod NewFocusMethod) {}
	public sbyte GetDistanceInDesiredUnits(float InputDistance,EUnit ConversionUnit,sbyte ReturnValue) { return default; }
	public ULevelSequencePlaybackController LevelSequencePlaybackController;
	public ACineCameraActor TargetCameraActor;
	public bool bCachedIsVirtualCameraControlledByRemoteSession;
	public bool bCachedShouldUpdateTargetCameraTransform;
	public void BroadcastOffsetReset() {}
	public bool IsVirtualCameraControlledByRemoteSession(bool ReturnValue) { return default; }
	public bool ShouldUpdateTargetCameraTransform(bool ReturnValue) { return default; }
	public void AddBlendableToCamera(object /*BlendableToAdd*/ BlendableToAdd,float Weight) {}
	public float ChangeAperturePreset(bool bShiftUp,float ReturnValue) { return default; }
	public float ChangeFocalLengthPreset(bool bShiftUp,float ReturnValue) { return default; }
	public void ClearActiveLevelSequence() {}
	public int DeletePreset(sbyte PresetName,int ReturnValue) { return default; }
	public int DeleteScreenshot(sbyte ScreenshotName,int ReturnValue) { return default; }
	public int DeleteWaypoint(sbyte WaypointName,int ReturnValue) { return default; }
	public sbyte GetActiveLevelSequenceName(sbyte ReturnValue) { return default; }
	public UObject GetActiveLevelSequence(UObject ReturnValue) { return default; }
	public float GetAxisStabilizationScale(EVirtualCameraAxis AxisToRetrieve,float ReturnValue) { return default; }
	public float GetAxisMovementScale(EVirtualCameraAxis AxisToRetrieve,float ReturnValue) { return default; }
	public float GetCurrentAperture(float ReturnValue) { return default; }
	public sbyte GetCurrentFilmbackName(sbyte ReturnValue) { return default; }
	public float GetCurrentFocalLength(float ReturnValue) { return default; }
	public float GetCurrentFocusDistance(float ReturnValue) { return default; }
	public EVirtualCameraFocusMethod GetCurrentFocusMethod(EVirtualCameraFocusMethod ReturnValue) { return default; }
	public FFrameNumber GetCurrentSequencePlaybackEnd(FFrameNumber ReturnValue) { return default; }
	public FFrameNumber GetCurrentSequencePlaybackStart(FFrameNumber ReturnValue) { return default; }
	public bool IsSequencerLockedToCameraCut(bool ReturnValue) { return default; }
	public void SetSequencerLockedToCameraCut(bool bLockView) {}
	public FFrameRate GetCurrentSequenceFrameRate(FFrameRate ReturnValue) { return default; }
	public EUnit GetDesiredDistanceUnits(EUnit ReturnValue) { return default; }
	public FColor GetFocusPlaneColor(FColor ReturnValue) { return default; }
	public bool GetFilmbackPresetOptions(TArray<sbyte> OutFilmbackPresetsArray,bool ReturnValue) { return default; }
	public FFrameNumber GetLevelSequenceLength(FFrameNumber ReturnValue) { return default; }
	public void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	public float GetMatteAspectRatio(float ReturnValue) { return default; }
	public float GetMatteOpacity(float ReturnValue) { return default; }
	public void GetMatteValues(TArray<float> OutMatteValues) {}
	public FFrameTime GetPlaybackPosition(FFrameTime ReturnValue) { return default; }
	public FTimecode GetPlaybackTimecode(FTimecode ReturnValue) { return default; }
	public void GetScreenshotInfo(sbyte ScreenshotName,FVirtualCameraScreenshot OutScreenshotInfo) {}
	public void GetScreenshotNames(TArray<sbyte> OutArray) {}
	public TMap<sbyte,FVirtualCameraSettingsPreset> GetSettingsPresets(TMap<sbyte,FVirtualCameraSettingsPreset> ReturnValue) { return default; }
	public ETouchInputState GetTouchInputState(ETouchInputState ReturnValue) { return default; }
	public void GetWaypointInfo(sbyte WaypointName,FVirtualCameraWaypoint OutWaypointInfo) {}
	public void GetWaypointNames(TArray<sbyte> OutArray) {}
	public bool IsAxisLocked(EVirtualCameraAxis AxisToCheck,bool ReturnValue) { return default; }
	public bool IsFocusVisualizationAllowed(bool ReturnValue) { return default; }
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsTouchInputInFocusMode(bool ReturnValue) { return default; }
	public bool IsUsingGlobalBoom(bool ReturnValue) { return default; }
	public void JumpToLevelSequenceEnd() {}
	public void JumpToLevelSequenceStart() {}
	public void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	public bool LoadPreset(sbyte PresetName,bool ReturnValue) { return default; }
	public bool LoadScreenshotView(sbyte ScreenshotName,bool ReturnValue) { return default; }
	public void PauseLevelSequence() {}
	public void PlayLevelSequence() {}
	public void PlayLevelSequenceInReverse() {}
	public void ResetCameraOffsetsToTracker() {}
	public void ResumeLevelSequencePlay() {}
	public void SaveHomeWaypoint(sbyte NewHomeWaypointName) {}
	public sbyte SavePreset(bool bSaveCameraSettings,bool bSaveStabilization,bool bSaveAxisLocking,bool bSaveMotionScale,sbyte ReturnValue) { return default; }
	public sbyte SaveWaypoint(sbyte ReturnValue) { return default; }
	public bool SetActiveLevelSequence(UObject InNewLevelSequence,bool ReturnValue) { return default; }
	public void SetAllowFocusPlaneVisualization(bool bShouldAllowFocusVisualization) {}
	public float SetAxisStabilizationScale(EVirtualCameraAxis AxisToAdjust,float NewStabilizationAmount,float ReturnValue) { return default; }
	public void SetCurrentAperture(float NewAperture) {}
	public void SetCurrentFocalLength(float NewFocalLength) {}
	public void SetCurrentFocusDistance(float NewFocusDistance) {}
	public void SetDesiredDistanceUnits(EUnit DesiredUnits) {}
	public bool SetFilmbackPresetOption(sbyte NewFilmbackPreset,bool ReturnValue) { return default; }
	public void SetFocusMethod(EVirtualCameraFocusMethod NewFocusMethod) {}
	public void SetFocusPlaneColor(FColor NewFocusPlaneColor) {}
	public void SetFocusVisualization(bool bShowFocusVisualization) {}
	public bool IsFocusVisualizationActivated(bool ReturnValue) { return default; }
	public bool SetMatteAspectRatio(float NewMatteAspectRatio,bool ReturnValue) { return default; }
	public void SetMatteOpacity(float NewMatteOpacity) {}
	public void SetMovementScale(EVirtualCameraAxis AxisToAdjust,float NewMovementScale) {}
	public void SetPresetFavoriteStatus(sbyte PresetName,bool bIsFavorite) {}
	public void SetSaveSettingsWhenClosing(bool bShouldSettingsSave) {}
	public void SetScreenshotFavoriteStatus(sbyte ScreenshotName,bool bIsFavorite) {}
	public void SetTouchInputState(ETouchInputState NewInputState) {}
	public void SetUseGlobalBoom(bool bShouldUseGlobalBoom) {}
	public void SetWaypointFavoriteStatus(sbyte WaypointName,bool bIsFavorite) {}
	public void SetZeroDutchOnLock(bool bInValue) {}
	public bool ShouldSaveSettingsWhenClosing(bool ReturnValue) { return default; }
	public void StopLevelSequencePlay() {}
	public sbyte TakeScreenshot(sbyte ReturnValue) { return default; }
	public void TeleportToHomeWaypoint() {}
	public bool TeleportToWaypoint(sbyte WaypointIndex,bool ReturnValue) { return default; }
	public bool ToggleAxisFreeze(EVirtualCameraAxis AxisToToggle,bool ReturnValue) { return default; }
	public bool ToggleAxisLock(EVirtualCameraAxis AxisToToggle,bool ReturnValue) { return default; }
	public void ActivateGameViewport() {}
}
