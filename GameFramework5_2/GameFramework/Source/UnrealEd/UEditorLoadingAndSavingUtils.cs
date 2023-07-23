#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FileHelpers.h")]
///<summary>This class is a wrapper for editor loading and saving functionality</summary>
public partial class UEditorLoadingAndSavingUtils : UObject {
// EditorLoadingAndSavingUtils
	public UObject NewBlankMap(bool bSaveExistingMap,UObject ReturnValue) { return default; }
	public UObject NewMapFromTemplate(sbyte PathToTemplateLevel,bool bSaveExistingMap,UObject ReturnValue) { return default; }
	public UObject LoadMapWithDialog(UObject ReturnValue) { return default; }
	public UObject LoadMap(sbyte Filename,UObject ReturnValue) { return default; }
	public bool SaveMap(UObject World,sbyte AssetPath,bool ReturnValue) { return default; }
	public bool SavePackages(TArray<UObject> PackagesToSave,bool bOnlyDirty,bool ReturnValue) { return default; }
	public bool SavePackagesWithDialog(TArray<UObject> PackagesToSave,bool bOnlyDirty,bool ReturnValue) { return default; }
	public bool SaveDirtyPackages(bool bSaveMapPackages,bool bSaveContentPackages,bool ReturnValue) { return default; }
	public bool SaveDirtyPackagesWithDialog(bool bSaveMapPackages,bool bSaveContentPackages,bool ReturnValue) { return default; }
	public bool SaveCurrentLevel(bool ReturnValue) { return default; }
	public void GetDirtyMapPackages(TArray<UObject> OutDirtyPackages) {}
	public void GetDirtyContentPackages(TArray<UObject> OutDirtyPackages) {}
	public void ImportScene(sbyte Filename) {}
	public void ExportScene(bool bExportSelectedActorsOnly) {}
	public void UnloadPackages(TArray<UObject> PackagesToUnload,bool bOutAnyPackagesUnloaded,sbyte OutErrorMessage) {}
	public void ReloadPackages(TArray<UObject> PackagesToReload,bool bOutAnyPackagesReloaded,sbyte OutErrorMessage,EReloadPackagesInteractionMode InteractionMode=EReloadPackagesInteractionMode) {}
}
