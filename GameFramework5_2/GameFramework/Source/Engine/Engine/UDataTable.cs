#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DataTable.h")]
///<summary>Imported spreadsheet table.</summary>
public partial class UDataTable : UObject {
// DataTable
	public UScriptStruct RowStruct;
	public bool bStripFromClientBuilds;
	public bool bIgnoreExtraFields;
	public bool bIgnoreMissingFields;
	public sbyte ImportKeyField;
	public UAssetImportData AssetImportData;
	public sbyte ImportPath_DEPRECATED;
	public sbyte RowStructName_DEPRECATED;
	public FTopLevelAssetPath RowStructPathName;
	public TArray<byte> RowsSerializedWithTags;
	public TSet<UObject> TemporarilyReferencedObjects;
}
