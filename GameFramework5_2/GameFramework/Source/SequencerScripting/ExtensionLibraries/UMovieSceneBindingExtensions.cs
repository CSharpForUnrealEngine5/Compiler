#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneBindingExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto FMovieSceneBindingProxies for scripting</summary>
public partial class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary {
// MovieSceneBindingExtensions
	public bool IsValid(FMovieSceneBindingProxy InBinding,bool ReturnValue) { return default; }
	public FGuid GetId(FMovieSceneBindingProxy InBinding,FGuid ReturnValue) { return default; }
	public sbyte GetDisplayName(FMovieSceneBindingProxy InBinding,sbyte ReturnValue) { return default; }
	public void SetDisplayName(FMovieSceneBindingProxy InBinding,sbyte InDisplayName) {}
	public sbyte GetName(FMovieSceneBindingProxy InBinding,sbyte ReturnValue) { return default; }
	public void SetName(FMovieSceneBindingProxy InBinding,sbyte InName) {}
	public int GetSortingOrder(FMovieSceneBindingProxy InBinding,int ReturnValue) { return default; }
	public void SetSortingOrder(FMovieSceneBindingProxy InBinding,int SortingOrder) {}
	public TArray<UObject> GetTracks(FMovieSceneBindingProxy InBinding,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindTracksByType(FMovieSceneBindingProxy InBinding,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> FindTracksByExactType(FMovieSceneBindingProxy InBinding,UClass TrackType,TArray<UObject> ReturnValue) { return default; }
	public void RemoveTrack(FMovieSceneBindingProxy InBinding,UObject TrackToRemove) {}
	public void Remove(FMovieSceneBindingProxy InBinding) {}
	public UObject AddTrack(FMovieSceneBindingProxy InBinding,UClass TrackType,UObject ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetChildPossessables(FMovieSceneBindingProxy InBinding,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public UObject GetObjectTemplate(FMovieSceneBindingProxy InBinding,UObject ReturnValue) { return default; }
	public UClass GetPossessedObjectClass(FMovieSceneBindingProxy InBinding,UClass ReturnValue) { return default; }
	public FMovieSceneBindingProxy GetParent(FMovieSceneBindingProxy InBinding,FMovieSceneBindingProxy ReturnValue) { return default; }
	public void SetParent(FMovieSceneBindingProxy InBinding,FMovieSceneBindingProxy InParentBinding) {}
	public void MoveBindingContents(FMovieSceneBindingProxy SourceBindingId,FMovieSceneBindingProxy DestinationBindingId) {}
	public void SetSpawnableBindingID(FMovieSceneBindingProxy InBinding,FMovieSceneObjectBindingID SpawnableBindingID) {}
}
