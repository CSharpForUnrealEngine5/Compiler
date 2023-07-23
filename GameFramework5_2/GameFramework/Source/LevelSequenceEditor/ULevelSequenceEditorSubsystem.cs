#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceEditorSubsystem.h")]
///<summary>ULevelSequenceEditorSubsystem</summary>
public partial class ULevelSequenceEditorSubsystem : UEditorSubsystem {
// LevelSequenceEditorSubsystem
	public TArray<FMovieSceneBindingProxy> AddActors(TArray<UObject> Actors,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public FMovieSceneBindingProxy CreateCamera(bool bSpawnable,UObject OutActor,FMovieSceneBindingProxy ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> ConvertToSpawnable(FMovieSceneBindingProxy ObjectBinding,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public FMovieSceneBindingProxy ConvertToPossessable(FMovieSceneBindingProxy ObjectBinding,FMovieSceneBindingProxy ReturnValue) { return default; }
	public void CopyFolders(TArray<UObject> Folders,sbyte ExportedText) {}
	public bool PasteFolders(sbyte TextToImport,FMovieScenePasteFoldersParams PasteFoldersParams,TArray<UObject> OutFolders,bool ReturnValue) { return default; }
	public void CopySections(TArray<UObject> Sections,sbyte ExportedText) {}
	public bool PasteSections(sbyte TextToImport,FMovieScenePasteSectionsParams PasteSectionsParams,TArray<UObject> OutSections,bool ReturnValue) { return default; }
	public void CopyTracks(TArray<UObject> Tracks,sbyte ExportedText) {}
	public bool PasteTracks(sbyte TextToImport,FMovieScenePasteTracksParams PasteTracksParams,TArray<UObject> OutTracks,bool ReturnValue) { return default; }
	public void CopyBindings(TArray<FMovieSceneBindingProxy> Bindings,sbyte ExportedText) {}
	public bool PasteBindings(sbyte TextToImport,FMovieScenePasteBindingsParams PasteBindingsParams,TArray<FMovieSceneBindingProxy> OutObjectBindings,bool ReturnValue) { return default; }
	public void SnapSectionsToTimelineUsingSourceTimecode(TArray<UObject> Sections) {}
	public void SyncSectionsUsingSourceTimecode(TArray<UObject> Sections) {}
	public void BakeTransform(TArray<FMovieSceneBindingProxy> ObjectBindings,FFrameTime BakeInTime,FFrameTime BakeOutTime,FFrameTime BakeInterval,FMovieSceneScriptingParams Params=FMovieSceneScriptingParams) {}
	public void FixActorReferences() {}
	public void AddActorsToBinding(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void ReplaceBindingWithActors(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveActorsFromBinding(TArray<UObject> Actors,FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveAllBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public void RemoveInvalidBindings(FMovieSceneBindingProxy ObjectBinding) {}
	public void RebindComponent(TArray<FMovieSceneBindingProxy> ComponentBindings,sbyte ComponentName) {}
}
