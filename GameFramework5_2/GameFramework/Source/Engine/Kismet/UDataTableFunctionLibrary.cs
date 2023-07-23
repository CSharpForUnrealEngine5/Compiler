#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/DataTableFunctionLibrary.h")]
public partial class UDataTableFunctionLibrary : UBlueprintFunctionLibrary {
// DataTableFunctionLibrary
	public void EvaluateCurveTableRow(UObject CurveTable,sbyte RowName,float InXY,byte OutResult,float OutXY,sbyte ContextString) {}
	public bool DoesDataTableRowExist(UObject Table,sbyte RowName,bool ReturnValue) { return default; }
	public void GetDataTableRowNames(UObject Table,TArray<sbyte> OutRowNames) {}
	public TArray<sbyte> GetDataTableColumnAsString(UObject DataTable,sbyte PropertyName,TArray<sbyte> ReturnValue) { return default; }
	public bool GetDataTableRowFromName(UObject Table,sbyte RowName,FTableRowBase OutRow,bool ReturnValue) { return default; }
	public bool FillDataTableFromCSVString(UObject DataTable,sbyte CSVString,bool ReturnValue) { return default; }
	public bool FillDataTableFromCSVFile(UObject DataTable,sbyte CSVFilePath,bool ReturnValue) { return default; }
	public bool FillDataTableFromJSONString(UObject DataTable,sbyte JSONString,bool ReturnValue) { return default; }
	public bool FillDataTableFromJSONFile(UObject DataTable,sbyte JSONFilePath,UObject ImportRowStruct=nullptr,bool ReturnValue) { return default; }
}
