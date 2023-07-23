#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAssetImportData.h")]
public partial class UInterchangeAssetImportData : UAssetImportData {
// InterchangeAssetImportData
	public sbyte ScriptGetFirstFilename(sbyte ReturnValue) { return default; }
	public TArray<sbyte> ScriptExtractFilenames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> ScriptExtractDisplayLabels(TArray<sbyte> ReturnValue) { return default; }
	public UInterchangeBaseNodeContainer NodeContainer;
	public sbyte NodeUniqueID;
	public TArray<UObject> Pipelines;
}
