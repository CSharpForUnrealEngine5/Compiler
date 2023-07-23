#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilityLibrary.h")]
///<summary>Expose editor utility functions to Blutilities</summary>
public partial class UEditorUtilityLibrary : UBlueprintFunctionLibrary {
// EditorUtilityLibrary
	public TArray<UObject> GetSelectionSet(TArray<UObject> ReturnValue) { return default; }
	public void GetSelectionBounds(FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public TArray<UObject> GetSelectedAssets(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetSelectedAssetsOfClass(UClass AssetClass,TArray<UObject> ReturnValue) { return default; }
	public TArray<UClass> GetSelectedBlueprintClasses(TArray<UClass> ReturnValue) { return default; }
	public TArray<FAssetData> GetSelectedAssetData(TArray<FAssetData> ReturnValue) { return default; }
	public void RenameAsset(UObject Asset,sbyte NewName) {}
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
	public bool GetCurrentContentBrowserPath(sbyte OutPath,bool ReturnValue) { return default; }
	public TArray<sbyte> GetSelectedFolderPaths(TArray<sbyte> ReturnValue) { return default; }
	public void SyncBrowserToFolders(TArray<sbyte> FolderList) {}
}
