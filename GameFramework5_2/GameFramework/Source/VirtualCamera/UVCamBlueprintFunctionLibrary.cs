#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamBlueprintFunctionLibrary.h")]
public partial class UVCamBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// VCamBlueprintFunctionLibrary
	public bool IsGameRunning(bool ReturnValue) { return default; }
	public UObject GetUserSettings(UObject ReturnValue) { return default; }
	public UObject GetCurrentLevelSequence(UObject ReturnValue) { return default; }
	public UObject GetPendingTakeLevelSequence(UObject ReturnValue) { return default; }
	public void PlayCurrentLevelSequence() {}
	public void PauseCurrentLevelSequence() {}
	public void SetCurrentLevelSequenceCurrentFrame(int NewFrame) {}
	public int GetCurrentLevelSequenceCurrentFrame(int ReturnValue) { return default; }
	public int GetLevelSequenceLengthInFrames(UObject LevelSequence,int ReturnValue) { return default; }
	public FTimecode GetLevelSequenceFrameAsTimecode(UObject LevelSequence,int InFrame,FTimecode ReturnValue) { return default; }
	public FTimecode GetLevelSequenceFrameAsTimecodeWithoutObject(FFrameRate DisplayRate,int InFrame,FTimecode ReturnValue) { return default; }
	public bool IsCurrentLevelSequencePlaying(bool ReturnValue) { return default; }
	public UObject ImportSnapshotTexture(sbyte FileName,sbyte SubFolderName,sbyte AbsolutePathPackage,UObject ReturnValue) { return default; }
	public bool ModifyLevelSequenceMetadataForSelects(UObject LevelSequenceMetaData,bool bIsSelected,bool ReturnValue) { return default; }
	public bool ModifyLevelSequenceMetadata(UObject LevelSequenceMetaData,bool ReturnValue) { return default; }
	public bool EditorSaveAsset(sbyte AssetPath,bool ReturnValue) { return default; }
	public UObject EditorLoadAsset(sbyte AssetPath,UObject ReturnValue) { return default; }
	public void ModifyObjectMetadataTags(UObject InObject,sbyte InTag,sbyte InValue) {}
	public TMap<sbyte,sbyte> GetObjectMetadataTags(UObject InObject,TMap<sbyte,sbyte> ReturnValue) { return default; }
	public TArray<FAssetData> SortAssetsByTimecodeAssetData(TArray<FAssetData> LevelSequenceAssets,TArray<FAssetData> ReturnValue) { return default; }
	public void PilotActor(UObject SelectedActor) {}
	public bool UpdatePostProcessSettingsForCapture(UObject CaptureComponent,float DepthOfField,float FStopValue,bool ReturnValue) { return default; }
	public FFrameRate GetDisplayRate(UObject LevelSequence,FFrameRate ReturnValue) { return default; }
	public FFrameRate ConvertStringToFrameRate(sbyte InFrameRateString,FFrameRate ReturnValue) { return default; }
	public bool CallFunctionByName(UObject ObjPtr,sbyte FunctionName,bool ReturnValue) { return default; }
	public void EditorSetGameView(bool bIsToggled) {}
	public float CalculateAutoFocusDistance(FVector2D ReticlePosition,UObject CineCamera,float ReturnValue) { return default; }
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID CameraBindingID,TArray<UObject> ReturnValue) { return default; }
	public void EnableDebugFocusPlane(UObject CineCamera,bool bEnabled) {}
	public int TimecodeToFrameAmount(FTimecode Timecode,FFrameRate InFrameRate,int ReturnValue) { return default; }
	public sbyte GetNextUndoDescription(sbyte ReturnValue) { return default; }
	public bool CopyToCineCameraActor(UObject SourceCameraComponent,UObject TargetCameraActor,bool ReturnValue) { return default; }
	public void SetActorLabel(UObject Actor,sbyte NewActorLabel) {}
	public bool IsTakeRecorderPanelOpen(bool ReturnValue) { return default; }
	public bool TryOpenTakeRecorderPanel(bool ReturnValue) { return default; }
	public bool IsRecording(bool ReturnValue) { return default; }
	public void FOnTakeRecorderSlateChanged_VCam(sbyte Slate) {}
	public void SetOnTakeRecorderSlateChanged(FOnTakeRecorderSlateChanged_VCam OnTakeRecorderSlateChanged) {}
}
