#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithBlueprintLibrary.h")]
public partial class UDatasmithSceneElement : UDatasmithSceneElementBase {
// DatasmithSceneElement
	public UObject ConstructDatasmithSceneFromFile(sbyte FilePath,UObject ReturnValue) { return default; }
	public UObject ConstructDatasmithSceneFromSourceUri(sbyte SourceUri,UObject ReturnValue) { return default; }
	public UObject ConstructDatasmithSceneFromCADFiles(TArray<sbyte> FilePaths,UObject ReturnValue) { return default; }
	public UObject GetExistingDatasmithScene(sbyte AssetPath,UObject ReturnValue) { return default; }
	public bool TranslateScene(bool ReturnValue) { return default; }
	public FDatasmithImportFactoryCreateFileResult ImportScene(sbyte DestinationFolder,FDatasmithImportFactoryCreateFileResult ReturnValue) { return default; }
	public TArray<FDatasmithImportFactoryCreateFileResult> ImportScenes(sbyte DestinationFolder,TArray<FDatasmithImportFactoryCreateFileResult> ReturnValue) { return default; }
	public FDatasmithImportFactoryCreateFileResult ReimportScene(FDatasmithImportFactoryCreateFileResult ReturnValue) { return default; }
	public UObject GetOptions(UClass OptionType=nullptr,UObject ReturnValue) { return default; }
	public TMap<UClass,UObject> GetAllOptions(TMap<UClass,UObject> ReturnValue) { return default; }
	public UObject GetImportOptions(UObject ReturnValue) { return default; }
	public void DestroyScene() {}
}
