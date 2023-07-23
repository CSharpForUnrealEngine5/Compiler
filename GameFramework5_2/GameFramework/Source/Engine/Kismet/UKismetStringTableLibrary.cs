#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetStringTableLibrary.h")]
public partial class UKismetStringTableLibrary : UBlueprintFunctionLibrary {
// KismetStringTableLibrary
	public bool IsRegisteredTableId(sbyte TableId,bool ReturnValue) { return default; }
	public bool IsRegisteredTableEntry(sbyte TableId,sbyte Key,bool ReturnValue) { return default; }
	public sbyte GetTableNamespace(sbyte TableId,sbyte ReturnValue) { return default; }
	public sbyte GetTableEntrySourceString(sbyte TableId,sbyte Key,sbyte ReturnValue) { return default; }
	public sbyte GetTableEntryMetaData(sbyte TableId,sbyte Key,sbyte MetaDataId,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetRegisteredStringTables(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetKeysFromStringTable(sbyte TableId,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetMetaDataIdsFromStringTableEntry(sbyte TableId,sbyte Key,TArray<sbyte> ReturnValue) { return default; }
}
