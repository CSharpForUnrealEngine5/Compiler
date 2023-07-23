#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSnapshotsEditorFunctionLibrary.h")]
public partial class ULevelSnapshotsEditorFunctionLibrary : UBlueprintFunctionLibrary {
// LevelSnapshotsEditorFunctionLibrary
	public UObject TakeLevelSnapshotAndSaveToDisk(UObject WorldContextObject,sbyte FileName,sbyte FolderPath,sbyte Description,bool bShouldCreateUniqueFileName=true,UObject ReturnValue) { return default; }
	public void TakeAndSaveLevelSnapshotEditorWorld(sbyte FileName,sbyte FolderPath,sbyte Description) {}
	public void GenerateThumbnailForSnapshotAsset(UObject SnapshotPackage) {}
}
