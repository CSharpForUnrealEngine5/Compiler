#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/EditorAssetSubsystem.h")]
///<summary>UEditorAssetSubsystem</summary>
public partial class UEditorAssetSubsystem : UEditorSubsystem {
// EditorAssetSubsystem
	public UObject LoadAsset(sbyte AssetPath,UObject ReturnValue) { return default; }
	public UClass LoadBlueprintClass(sbyte AssetPath,UClass ReturnValue) { return default; }
	public sbyte GetPathNameForLoadedAsset(UObject LoadedAsset,sbyte ReturnValue) { return default; }
	public FAssetData FindAssetData(sbyte AssetPath,FAssetData ReturnValue) { return default; }
	public bool DoesAssetExist(sbyte AssetPath,bool ReturnValue) { return default; }
	public bool DoAssetsExist(TArray<sbyte> AssetPaths,bool ReturnValue) { return default; }
	public TArray<sbyte> FindPackageReferencersForAsset(sbyte AssetPath,bool bLoadAssetsToConfirm=false,TArray<sbyte> ReturnValue) { return default; }
	public bool ConsolidateAssets(UObject AssetToConsolidateTo,TArray<UObject> AssetsToConsolidate,bool ReturnValue) { return default; }
	public bool DeleteLoadedAsset(UObject AssetToDelete,bool ReturnValue) { return default; }
	public bool DeleteLoadedAssets(TArray<UObject> AssetsToDelete,bool ReturnValue) { return default; }
	public bool DeleteAsset(sbyte AssetPathToDelete,bool ReturnValue) { return default; }
	public bool DeleteDirectory(sbyte DirectoryPath,bool ReturnValue) { return default; }
	public UObject DuplicateLoadedAsset(UObject SourceAsset,sbyte DestinationAssetPath,UObject ReturnValue) { return default; }
	public UObject DuplicateAsset(sbyte SourceAssetPath,sbyte DestinationAssetPath,UObject ReturnValue) { return default; }
	public bool DuplicateDirectory(sbyte SourceDirectoryPath,sbyte DestinationDirectoryPath,bool ReturnValue) { return default; }
	public bool RenameLoadedAsset(UObject SourceAsset,sbyte DestinationAssetPath,bool ReturnValue) { return default; }
	public bool RenameAsset(sbyte SourceAssetPath,sbyte DestinationAssetPath,bool ReturnValue) { return default; }
	public bool RenameDirectory(sbyte SourceDirectoryPath,sbyte DestinationDirectoryPath,bool ReturnValue) { return default; }
	public bool CheckoutLoadedAsset(UObject AssetToCheckout,bool ReturnValue) { return default; }
	public bool CheckoutLoadedAssets(TArray<UObject> AssetsToCheckout,bool ReturnValue) { return default; }
	public bool CheckoutAsset(sbyte AssetToCheckout,bool ReturnValue) { return default; }
	public bool CheckoutDirectory(sbyte DirectoryPath,bool bRecursive=true,bool ReturnValue) { return default; }
	public bool SaveLoadedAsset(UObject AssetToSave,bool bOnlyIfIsDirty=true,bool ReturnValue) { return default; }
	public bool SaveLoadedAssets(TArray<UObject> AssetsToSave,bool bOnlyIfIsDirty=true,bool ReturnValue) { return default; }
	public bool SaveAsset(sbyte AssetToSave,bool bOnlyIfIsDirty=true,bool ReturnValue) { return default; }
	public bool SaveDirectory(sbyte DirectoryPath,bool bOnlyIfIsDirty=true,bool bRecursive=true,bool ReturnValue) { return default; }
	public bool DoesDirectoryExist(sbyte DirectoryPath,bool ReturnValue) { return default; }
	public bool DoesDirectoryContainAssets(sbyte DirectoryPath,bool bRecursive=true,bool ReturnValue) { return default; }
	public bool MakeDirectory(sbyte DirectoryPath,bool ReturnValue) { return default; }
	public TArray<sbyte> ListAssets(sbyte DirectoryPath,bool bRecursive=true,bool bIncludeFolder=false,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> ListAssetsByTagValue(sbyte TagName,sbyte TagValue,TArray<sbyte> ReturnValue) { return default; }
	public TMap<sbyte,sbyte> GetTagValues(sbyte AssetPath,TMap<sbyte,sbyte> ReturnValue) { return default; }
	public TMap<sbyte,sbyte> GetMetadataTagValues(UObject Object,TMap<sbyte,sbyte> ReturnValue) { return default; }
	public sbyte GetMetadataTag(UObject Object,sbyte Tag,sbyte ReturnValue) { return default; }
	public void SetMetadataTag(UObject Object,sbyte Tag,sbyte Value) {}
	public void RemoveMetadataTag(UObject Object,sbyte Tag) {}
	public void FOnExtractAssetFromFileDynamic(TArray<sbyte> Files,TArray<FAssetData> AssetDataArray) {}
	public void AddOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate) {}
	public void RemoveOnExtractAssetFromFile(FOnExtractAssetFromFileDynamic Delegate) {}
}
