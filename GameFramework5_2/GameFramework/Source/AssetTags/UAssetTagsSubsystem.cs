#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetTagsSubsystem.h")]
public partial class UAssetTagsSubsystem : UEngineSubsystem {
// AssetTagsSubsystem
	public bool CreateCollection(sbyte Name,ECollectionScriptingShareType ShareType,bool ReturnValue) { return default; }
	public bool DestroyCollection(sbyte Name,bool ReturnValue) { return default; }
	public bool RenameCollection(sbyte Name,sbyte NewName,bool ReturnValue) { return default; }
	public bool ReparentCollection(sbyte Name,sbyte NewParentName,bool ReturnValue) { return default; }
	public bool EmptyCollection(sbyte Name,bool ReturnValue) { return default; }
	public bool K2_AddAssetToCollection(sbyte Name,FSoftObjectPath AssetPath,bool ReturnValue) { return default; }
	public bool AddAssetToCollection(sbyte Name,sbyte AssetPathName,bool ReturnValue) { return default; }
	public bool AddAssetDataToCollection(sbyte Name,FAssetData AssetData,bool ReturnValue) { return default; }
	public bool AddAssetPtrToCollection(sbyte Name,UObject AssetPtr,bool ReturnValue) { return default; }
	public bool K2_AddAssetsToCollection(sbyte Name,TArray<FSoftObjectPath> AssetPaths,bool ReturnValue) { return default; }
	public bool AddAssetsToCollection(sbyte Name,TArray<sbyte> AssetPathNames,bool ReturnValue) { return default; }
	public bool AddAssetDatasToCollection(sbyte Name,TArray<FAssetData> AssetDatas,bool ReturnValue) { return default; }
	public bool AddAssetPtrsToCollection(sbyte Name,TArray<UObject> AssetPtrs,bool ReturnValue) { return default; }
	public bool K2_RemoveAssetFromCollection(sbyte Name,FSoftObjectPath AssetPath,bool ReturnValue) { return default; }
	public bool RemoveAssetFromCollection(sbyte Name,sbyte AssetPathName,bool ReturnValue) { return default; }
	public bool RemoveAssetDataFromCollection(sbyte Name,FAssetData AssetData,bool ReturnValue) { return default; }
	public bool RemoveAssetPtrFromCollection(sbyte Name,UObject AssetPtr,bool ReturnValue) { return default; }
	public bool K2_RemoveAssetsFromCollection(sbyte Name,TArray<FSoftObjectPath> AssetPaths,bool ReturnValue) { return default; }
	public bool RemoveAssetsFromCollection(sbyte Name,TArray<sbyte> AssetPathNames,bool ReturnValue) { return default; }
	public bool RemoveAssetDatasFromCollection(sbyte Name,TArray<FAssetData> AssetDatas,bool ReturnValue) { return default; }
	public bool RemoveAssetPtrsFromCollection(sbyte Name,TArray<UObject> AssetPtrs,bool ReturnValue) { return default; }
	public bool CollectionExists(sbyte Name,bool ReturnValue) { return default; }
	public TArray<sbyte> GetCollections(TArray<sbyte> ReturnValue) { return default; }
	public TArray<FAssetData> GetAssetsInCollection(sbyte Name,TArray<FAssetData> ReturnValue) { return default; }
	public TArray<sbyte> K2_GetCollectionsContainingAsset(FSoftObjectPath AssetPath,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetCollectionsContainingAsset(sbyte AssetPathName,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetCollectionsContainingAssetData(FAssetData AssetData,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetCollectionsContainingAssetPtr(UObject AssetPtr,TArray<sbyte> ReturnValue) { return default; }
}
