#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneTracks for scripting</summary>
public partial class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary {
// MovieSceneTrackExtensions
	public void SetDisplayName(UObject Track,sbyte InName) {}
	public sbyte GetDisplayName(UObject Track,sbyte ReturnValue) { return default; }
	public void SetTrackRowDisplayName(UObject Track,sbyte InName,int RowIndex) {}
	public sbyte GetTrackRowDisplayName(UObject Track,int RowIndex,sbyte ReturnValue) { return default; }
	public UObject AddSection(UObject Track,UObject ReturnValue) { return default; }
	public TArray<UObject> GetSections(UObject Track,TArray<UObject> ReturnValue) { return default; }
	public void RemoveSection(UObject Track,UObject Section) {}
	public int GetSortingOrder(UObject Track,int ReturnValue) { return default; }
	public void SetSortingOrder(UObject Track,int SortingOrder) {}
	public FColor GetColorTint(UObject Track,FColor ReturnValue) { return default; }
	public void SetColorTint(UObject Track,FColor ColorTint) {}
	public UObject GetSectionToKey(UObject Track,UObject ReturnValue) { return default; }
	public void SetSectionToKey(UObject Track,UObject Section) {}
}
