#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneFolderExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneFolders for scripting</summary>
public partial class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary {
// MovieSceneFolderExtensions
	public sbyte GetFolderName(UObject Folder,sbyte ReturnValue) { return default; }
	public bool SetFolderName(UObject Folder,sbyte InFolderName,bool ReturnValue) { return default; }
	public FColor GetFolderColor(UObject Folder,FColor ReturnValue) { return default; }
	public bool SetFolderColor(UObject Folder,FColor InFolderColor,bool ReturnValue) { return default; }
	public TArray<UObject> GetChildFolders(UObject Folder,TArray<UObject> ReturnValue) { return default; }
	public bool AddChildFolder(UObject TargetFolder,UObject FolderToAdd,bool ReturnValue) { return default; }
	public bool RemoveChildFolder(UObject TargetFolder,UObject FolderToRemove,bool ReturnValue) { return default; }
	public TArray<UObject> GetChildTracks(UObject Folder,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetChildMasterTracks(UObject Folder,TArray<UObject> ReturnValue) { return default; }
	public bool AddChildTrack(UObject Folder,UObject InTrack,bool ReturnValue) { return default; }
	public bool AddChildMasterTrack(UObject Folder,UObject InTrack,bool ReturnValue) { return default; }
	public bool RemoveChildTrack(UObject Folder,UObject InTrack,bool ReturnValue) { return default; }
	public bool RemoveChildMasterTrack(UObject Folder,UObject InTrack,bool ReturnValue) { return default; }
	public TArray<FMovieSceneBindingProxy> GetChildObjectBindings(UObject Folder,TArray<FMovieSceneBindingProxy> ReturnValue) { return default; }
	public bool AddChildObjectBinding(UObject Folder,FMovieSceneBindingProxy InObjectBinding,bool ReturnValue) { return default; }
	public bool RemoveChildObjectBinding(UObject Folder,FMovieSceneBindingProxy InObjectBinding,bool ReturnValue) { return default; }
}
