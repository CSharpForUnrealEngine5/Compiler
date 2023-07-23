#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySubsystem.h")]
///<summary>Singleton manager that provides synchronous and asynchronous access to data registries</summary>
public partial class UDataRegistrySubsystem : UEngineSubsystem {
// DataRegistrySubsystem
	public bool GetCachedItemBP(FDataRegistryId ItemId,FTableRowBase OutItem,bool ReturnValue) { return default; }
	public void FindCachedItemBP(FDataRegistryId ItemId,EDataRegistrySubsystemGetItemResult OutResult,FTableRowBase OutItem) {}
	public bool GetCachedItemFromLookupBP(FDataRegistryId ItemId,FDataRegistryLookup ResolvedLookup,FTableRowBase OutItem,bool ReturnValue) { return default; }
	public bool AcquireItemBP(FDataRegistryId ItemId,FDataRegistryItemAcquiredBPCallback AcquireCallback,bool ReturnValue) { return default; }
	public void EvaluateDataRegistryCurve(FDataRegistryId ItemId,float InputValue,float DefaultValue,EDataRegistrySubsystemGetItemResult OutResult,float OutValue) {}
	public bool IsValidDataRegistryType(FDataRegistryType DataRegistryType,bool ReturnValue) { return default; }
	public sbyte Conv_DataRegistryTypeToString(FDataRegistryType DataRegistryType,sbyte ReturnValue) { return default; }
	public bool EqualEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B,bool ReturnValue) { return default; }
	public bool NotEqual_DataRegistryType(FDataRegistryType A,FDataRegistryType B,bool ReturnValue) { return default; }
	public bool IsValidDataRegistryId(FDataRegistryId DataRegistryId,bool ReturnValue) { return default; }
	public sbyte Conv_DataRegistryIdToString(FDataRegistryId DataRegistryId,sbyte ReturnValue) { return default; }
	public bool EqualEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B,bool ReturnValue) { return default; }
	public bool NotEqual_DataRegistryId(FDataRegistryId A,FDataRegistryId B,bool ReturnValue) { return default; }
}
