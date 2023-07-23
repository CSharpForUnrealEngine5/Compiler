#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/Factory.h")]
///<summary>Base class for all factories</summary>
public partial class UFactory : UObject {
// Factory
	public bool ScriptFactoryCanImport(sbyte Filename,bool ReturnValue) { return default; }
	public bool ScriptFactoryCreateFile(UObject InTask,bool ReturnValue) { return default; }
	public bool bCreateNew;
	public UClass SupportedClass;
	public UClass ContextClass;
	public TArray<sbyte> Formats;
	public bool bEditAfterNew;
	public bool bEditorImport;
	public bool bText;
	public int ImportPriority;
	public UAutomatedAssetImportData AutomatedImportData;
	public UAssetImportTask AssetImportTask;
	public int OverwriteYesOrNoToAllState;
}
