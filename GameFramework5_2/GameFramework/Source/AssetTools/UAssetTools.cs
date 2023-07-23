#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAssetTools.h")]
public partial class UAssetTools : UInterface {
// AssetTools
	public UObject CreateAsset(sbyte AssetName,sbyte PackagePath,UClass AssetClass,UObject Factory,sbyte CallingContext=NAME_None,UObject ReturnValue) { return default; }
	public UObject CreateAssetWithDialog(sbyte AssetName,sbyte PackagePath,UClass AssetClass,UObject Factory,sbyte CallingContext=NAME_None,bool bCallConfigureProperties=true,UObject ReturnValue) { return default; }
	public UObject DuplicateAssetWithDialog(sbyte AssetName,sbyte PackagePath,UObject OriginalObject,UObject ReturnValue) { return default; }
	public UObject DuplicateAssetWithDialogAndTitle(sbyte AssetName,sbyte PackagePath,UObject OriginalObject,sbyte DialogTitle,UObject ReturnValue) { return default; }
	public UObject DuplicateAsset(sbyte AssetName,sbyte PackagePath,UObject OriginalObject,UObject ReturnValue) { return default; }
	public bool RenameAssets(TArray<FAssetRenameData> AssetsAndNames,bool ReturnValue) { return default; }
	public EAssetRenameResult RenameAssetsWithDialog(TArray<FAssetRenameData> AssetsAndNames,bool bAutoCheckout=false,EAssetRenameResult ReturnValue) { return default; }
	public void FindSoftReferencesToObject(FSoftObjectPath TargetObject,TArray<UObject> ReferencingObjects) {}
	public void RenameReferencingSoftObjectPaths(TArray<UObject> PackagesToCheck,TMap<FSoftObjectPath,FSoftObjectPath> AssetRedirectorMap) {}
	public TArray<UObject> ImportAssetsWithDialog(sbyte DestinationPath,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> ImportAssetsAutomated(UObject ImportData,TArray<UObject> ReturnValue) { return default; }
	public void ImportAssetTasks(TArray<UObject> ImportTasks) {}
	public void ExportAssets(TArray<sbyte> AssetsToExport,sbyte ExportPath) {}
	public void ExportAssetsWithDialog(TArray<sbyte> AssetsToExport,bool bPromptForIndividualFilenames) {}
	public void CreateUniqueAssetName(sbyte InBasePackageName,sbyte InSuffix,sbyte OutPackageName,sbyte OutAssetName) {}
	public void DiffAgainstDepot(UObject InObject,sbyte InPackagePath,sbyte InPackageName) {}
	public void DiffAssets(UObject OldAsset,UObject NewAsset,FRevisionInfo OldRevision,FRevisionInfo NewRevision) {}
	public void MigratePackages(TArray<sbyte> PackageNamesToMigrate,sbyte DestinationPath,FMigrationOptions Options=FMigrationOptions) {}
	public void BeginAdvancedCopyPackages(TArray<sbyte> InputNamesToCopy,sbyte TargetPath,FAdvancedCopyCompletedEvent OnCopyComplete) {}
	public void OpenEditorForAssets(TArray<UObject> Assets) {}
}
