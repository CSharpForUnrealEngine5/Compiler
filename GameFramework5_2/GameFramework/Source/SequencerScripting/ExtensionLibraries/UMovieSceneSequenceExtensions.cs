#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneSequenceExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneSequences for scripting purposes</summary>
public partial class UMovieSceneSequenceExtensions : UBlueprintFunctionLibrary {
// MovieSceneSequenceExtensions
	public UObject GetMovieScene(UObject Sequence,UObject ReturnValue) { return default; }
	public TArray<UObject> GetTracks(UObject Sequence,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetMasterTracks(UObject Sequence,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindTracksByType(UObject Sequence,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindMasterTracksByType(UObject Sequence,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindTracksByExactType(UObject Sequence,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindMasterTracksByExactType(UObject Sequence,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public UObject AddTrack(UObject Sequence,UClass TrackType,UObject ReturnValue) { return default; }
	public UObject AddMasterTrack(UObject Sequence,UClass TrackType,UObject ReturnValue) { return default; }
	public bool RemoveTrack(UObject Sequence,UObject Track,bool ReturnValue) { return default; }
	public bool RemoveMasterTrack(UObject Sequence,UObject Track,bool ReturnValue) { return default; }
	public FFrameRate GetDisplayRate(UObject Sequence,FFrameRate ReturnValue) { return default; }
	public void SetDisplayRate(UObject Sequence,FFrameRate DisplayRate) {}
	public FFrameRate GetTickResolution(UObject Sequence,FFrameRate ReturnValue) { return default; }
	public void SetTickResolution(UObject Sequence,FFrameRate TickResolution) {}
	public void SetTickResolutionDirectly(UObject Sequence,FFrameRate TickResolution) {}
	public FSequencerScriptingRange MakeRange(UObject Sequence,int StartFrame,int Duration,FSequencerScriptingRange ReturnValue) { return default; }
	public FSequencerScriptingRange MakeRangeSeconds(UObject Sequence,float StartTime,float Duration,FSequencerScriptingRange ReturnValue) { return default; }
	public FSequencerScriptingRange GetPlaybackRange(UObject Sequence,FSequencerScriptingRange ReturnValue) { return default; }
	public int GetPlaybackStart(UObject Sequence,int ReturnValue) { return default; }
	public float GetPlaybackStartSeconds(UObject Sequence,float ReturnValue) { return default; }
	public int GetPlaybackEnd(UObject Sequence,int ReturnValue) { return default; }
	public float GetPlaybackEndSeconds(UObject Sequence,float ReturnValue) { return default; }
	public void SetPlaybackStart(UObject Sequence,int StartFrame) {}
	public void SetPlaybackStartSeconds(UObject Sequence,float StartTime) {}
	public void SetPlaybackEnd(UObject Sequence,int EndFrame) {}
	public void SetPlaybackEndSeconds(UObject Sequence,float EndTime) {}
	public void SetViewRangeStart(UObject InSequence,float StartTimeInSeconds) {}
	public float GetViewRangeStart(UObject InSequence,float ReturnValue) { return default; }
	public void SetViewRangeEnd(UObject InSequence,float EndTimeInSeconds) {}
	public float GetViewRangeEnd(UObject InSequence,float ReturnValue) { return default; }
	public void SetWorkRangeStart(UObject InSequence,float StartTimeInSeconds) {}
	public float GetWorkRangeStart(UObject InSequence,float ReturnValue) { return default; }
	public void SetWorkRangeEnd(UObject InSequence,float EndTimeInSeconds) {}
	public float GetWorkRangeEnd(UObject InSequence,float ReturnValue) { return default; }
	public void SetEvaluationType(UObject InSequence,EMovieSceneEvaluationType InEvaluationType) {}
	public EMovieSceneEvaluationType GetEvaluationType(UObject InSequence,EMovieSceneEvaluationType ReturnValue) { return default; }
	public void SetClockSource(UObject InSequence,EUpdateClockSource InClockSource) {}
	public EUpdateClockSource GetClockSource(UObject InSequence,EUpdateClockSource ReturnValue) { return default; }
	public FTimecode GetTimecodeSource(UObject Sequence,FTimecode ReturnValue) { return default; }
	public FMovieSceneBindingProxy FindBindingByName(UObject Sequence,sbyte Name,FMovieSceneBindingProxy ReturnValue) { return default; }
	public FMovieSceneBindingProxy FindBindingById(UObject Sequence,FGuid BindingId,FMovieSceneBindingProxy ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetBindings(UObject Sequence,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetSpawnables(UObject Sequence,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetPossessables(UObject Sequence,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public FMovieSceneBindingProxy AddPossessable(UObject Sequence,UObject ObjectToPossess,FMovieSceneBindingProxy ReturnValue) { return default; }
	public FMovieSceneBindingProxy AddSpawnableFromInstance(UObject Sequence,UObject ObjectToSpawn,FMovieSceneBindingProxy ReturnValue) { return default; }
	public FMovieSceneBindingProxy AddSpawnableFromClass(UObject Sequence,UClass ClassToSpawn,FMovieSceneBindingProxy ReturnValue) { return default; }
	public TArray<UObject> LocateBoundObjects(UObject Sequence,FMovieSceneBindingProxy InBinding,UObject Context,TArray<UObject> ReturnValue) { return default; }
	public FMovieSceneObjectBindingID MakeBindingID(UObject Sequence,FMovieSceneBindingProxy InBinding,EMovieSceneObjectBindingSpace Space=EMovieSceneObjectBindingSpace,FMovieSceneObjectBindingID ReturnValue) { return default; }
	public FMovieSceneObjectBindingID GetBindingID(FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID ReturnValue) { return default; }
	public FMovieSceneObjectBindingID GetPortableBindingID(UObject RootSequence,UObject DestinationSequence,FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID ReturnValue) { return default; }
	public FMovieSceneBindingProxy ResolveBindingID(UObject RootSequence,FMovieSceneObjectBindingID InObjectBindingID,FMovieSceneBindingProxy ReturnValue) { return default; }
	public TArray<UObject> GetRootFoldersInSequence(UObject Sequence,TArray<UObject> ReturnValue) { return default; }
	public UObject AddRootFolderToSequence(UObject Sequence,sbyte NewFolderName,UObject ReturnValue) { return default; }
	public void RemoveRootFolderFromSequence(UObject Sequence,UObject Folder) {}
	public TArray<FMovieSceneMarkedFrame> GetMarkedFrames(UObject Sequence,TArray<FMovieSceneMarkedFrame> ReturnValue) { return default; }
	public int AddMarkedFrame(UObject Sequence,FMovieSceneMarkedFrame InMarkedFrame,int ReturnValue) { return default; }
	public void SetMarkedFrame(UObject Sequence,int InMarkIndex,FFrameNumber InFrameNumber) {}
	public void DeleteMarkedFrame(UObject Sequence,int DeleteIndex) {}
	public void DeleteMarkedFrames(UObject Sequence) {}
	public void SortMarkedFrames(UObject Sequence) {}
	public int FindMarkedFrameByLabel(UObject Sequence,sbyte InLabel,int ReturnValue) { return default; }
	public int FindMarkedFrameByFrameNumber(UObject Sequence,FFrameNumber InFrameNumber,int ReturnValue) { return default; }
	public int FindNextMarkedFrame(UObject Sequence,FFrameNumber InFrameNumber,bool bForward,int ReturnValue) { return default; }
	public void SetReadOnly(UObject Sequence,bool bInReadOnly) {}
	public bool IsReadOnly(UObject Sequence,bool ReturnValue) { return default; }
}
