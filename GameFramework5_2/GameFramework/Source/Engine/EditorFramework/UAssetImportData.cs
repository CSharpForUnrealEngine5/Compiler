#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorFramework/AssetImportData.h")]
///<summary>todo: Make this class better suited to multiple import paths - maybe have FAssetImportInfo use a map rather than array?</summary>
public partial class UAssetImportData : UObject {
// AssetImportData
	public void ScriptedAddFilename(sbyte InPath,int Index,sbyte SourceFileLabel) {}
	public sbyte SourceFilePath_DEPRECATED;
	public sbyte SourceFileTimestamp_DEPRECATED;
	public FAssetImportInfo SourceData;
	public sbyte K2_GetFirstFilename(sbyte ReturnValue) { return default; }
	public TArray<sbyte> K2_ExtractFilenames(TArray<sbyte> ReturnValue) { return default; }
}
