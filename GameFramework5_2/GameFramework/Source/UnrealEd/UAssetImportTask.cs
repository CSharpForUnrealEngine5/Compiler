#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetImportTask.h")]
///<summary>Contains data for a group of assets to import</summary>
public partial class UAssetImportTask : UObject {
// AssetImportTask
	public sbyte Filename;
	public sbyte DestinationPath;
	public sbyte DestinationName;
	public bool bReplaceExisting;
	public bool bReplaceExistingSettings;
	public bool bAutomated;
	public bool bSave;
	public bool bAsync;
	public UFactory Factory;
	public UObject Options;
	public TArray<UObject> GetObjects(TArray<UObject> ReturnValue) { return default; }
	public bool IsAsyncImportComplete(bool ReturnValue) { return default; }
	public TArray<sbyte> ImportedObjectPaths;
	public TArray<UObject> Result;
}
