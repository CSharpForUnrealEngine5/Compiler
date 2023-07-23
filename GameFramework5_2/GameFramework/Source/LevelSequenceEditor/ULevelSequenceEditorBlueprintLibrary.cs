#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorBlueprintLibrary.h")]
public partial class ULevelSequenceEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// LevelSequenceEditorBlueprintLibrary
	public bool OpenLevelSequence(UObject LevelSequence,bool ReturnValue) { return default; }
	public UObject GetCurrentLevelSequence(UObject ReturnValue) { return default; }
	public UObject GetFocusedLevelSequence(UObject ReturnValue) { return default; }
	public void FocusLevelSequence(UObject SubSection) {}
	public void FocusParentSequence() {}
	public TArray<UObject> GetSubSequenceHierarchy(TArray<UObject> ReturnValue) { return default; }
	public void CloseLevelSequence() {}
	public void Play() {}
	public void Pause() {}
	public void SetCurrentTime(int NewFrame) {}
	public int GetCurrentTime(int ReturnValue) { return default; }
	public void SetCurrentLocalTime(int NewFrame) {}
	public int GetCurrentLocalTime(int ReturnValue) { return default; }
	public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams) {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public TArray<UObject> GetSelectedTracks(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetSelectedSections(TArray<UObject> ReturnValue) { return default; }
	public TArray<FSequencerChannelProxy> GetSelectedChannels(TArray<FSequencerChannelProxy> ReturnValue) { return default; }
	public TArray<UObject> GetSelectedFolders(TArray<UObject> ReturnValue) { return default; }
	public TArray<FGuid> GetSelectedObjects(TArray<FGuid> ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetSelectedBindings(TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public void SelectTracks(TArray<UObject> Tracks) {}
	public void SelectSections(TArray<UObject> Sections) {}
	public void SelectChannels(TArray<FSequencerChannelProxy> Channels) {}
	public void SelectFolders(TArray<UObject> Folders) {}
	public void SelectObjects(TArray<FGuid> ObjectBinding) {}
	public void SelectBindings(TArray<FMovieSceneBindingProxy> ObjectBindings) {}
	public void EmptySelection() {}
	public void SetSelectionRangeStart(int NewFrame) {}
	public void SetSelectionRangeEnd(int NewFrame) {}
	public int GetSelectionRangeStart(int ReturnValue) { return default; }
	public int GetSelectionRangeEnd(int ReturnValue) { return default; }
	public void RefreshCurrentLevelSequence() {}
	public TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding,TArray<UObject> ReturnValue) { return default; }
	public bool IsLevelSequenceLocked(bool ReturnValue) { return default; }
	public void SetLockLevelSequence(bool bLock) {}
	public bool IsCameraCutLockedToViewport(bool ReturnValue) { return default; }
	public void SetLockCameraCutToViewport(bool bLock) {}
	public bool IsTrackFilterEnabled(sbyte TrackFilterName,bool ReturnValue) { return default; }
	public void SetTrackFilterEnabled(sbyte TrackFilterName,bool bEnabled) {}
	public TArray<sbyte> GetTrackFilterNames(TArray<sbyte> ReturnValue) { return default; }
	public bool HasCustomColorForChannel(UClass Class,sbyte Identifier,bool ReturnValue) { return default; }
	public FLinearColor GetCustomColorForChannel(UClass Class,sbyte Identifier,FLinearColor ReturnValue) { return default; }
	public void SetCustomColorForChannel(UClass Class,sbyte Identifier,FLinearColor NewColor) {}
	public void SetCustomColorForChannels(UClass Class,TArray<sbyte> Identifiers,TArray<FLinearColor> NewColors) {}
	public void SetRandomColorForChannels(UClass Class,TArray<sbyte> Identifiers) {}
	public void DeleteColorForChannels(UClass Class,sbyte Identifier) {}
}
