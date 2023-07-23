#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDStageEditorBlueprintLibrary.h")]
///<summary>Library of functions that can be used from scripting to interact with the USD Stage Editor UI</summary>
public partial class UUsdStageEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdStageEditorBlueprintLibrary
	public bool OpenStageEditor(bool ReturnValue) { return default; }
	public bool CloseStageEditor(bool ReturnValue) { return default; }
	public UObject GetAttachedStageActor(UObject ReturnValue) { return default; }
	public bool SetAttachedStageActor(UObject NewActor,bool ReturnValue) { return default; }
	public TArray<sbyte> GetSelectedLayerIdentifiers(TArray<sbyte> ReturnValue) { return default; }
	public void SetSelectedLayerIdentifiers(TArray<sbyte> NewSelection) {}
	public TArray<sbyte> GetSelectedPrimPaths(TArray<sbyte> ReturnValue) { return default; }
	public void SetSelectedPrimPaths(TArray<sbyte> NewSelection) {}
	public TArray<sbyte> GetSelectedPropertyNames(TArray<sbyte> ReturnValue) { return default; }
	public void SetSelectedPropertyNames(TArray<sbyte> NewSelection) {}
	public void FileNew() {}
	public void FileOpen(sbyte FilePath) {}
	public void FileSave(sbyte OutputFilePathIfUnsaved) {}
	public void FileExportAllLayers(sbyte OutputDirectory) {}
	public void FileExportFlattenedStage(sbyte OutputLayer) {}
	public void FileReload() {}
	public void FileReset() {}
	public void FileClose() {}
	public void ActionsImport(sbyte OutputContentFolder,UObject Options) {}
	public void ExportSelectedLayers(sbyte OutputDirectory) {}
}
