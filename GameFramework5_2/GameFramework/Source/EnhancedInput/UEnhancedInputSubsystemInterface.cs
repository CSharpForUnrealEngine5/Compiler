#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputSubsystemInterface.h")]
public partial class UEnhancedInputSubsystemInterface : UInterface {
// EnhancedInputSubsystemInterface
	public void InjectInputForAction(UObject Action,FInputActionValue RawValue,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public void InjectInputVectorForAction(UObject Action,FVector Value,TArray<UObject> Modifiers,TArray<UObject> Triggers) {}
	public void ClearAllMappings() {}
	public void AddMappingContext(UObject MappingContext,int Priority,FModifyContextOptions Options=FModifyContextOptions) {}
	public void RemoveMappingContext(UObject MappingContext,FModifyContextOptions Options=FModifyContextOptions) {}
	public void RequestRebuildControlMappings(FModifyContextOptions Options=FModifyContextOptions,EInputMappingRebuildType RebuildType=EInputMappingRebuildType) {}
	public EMappingQueryResult QueryMapKeyInActiveContextSet(UObject InputContext,UObject Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues,EMappingQueryResult ReturnValue) { return default; }
	public EMappingQueryResult QueryMapKeyInContextSet(TArray<UObject> PrioritizedActiveContexts,UObject InputContext,UObject Action,FKey Key,TArray<FMappingQueryIssue> OutIssues,EMappingQueryIssue BlockingIssues,EMappingQueryResult ReturnValue) { return default; }
	public bool HasMappingContext(UObject MappingContext,int OutFoundPriority,bool ReturnValue) { return default; }
	public TArray<FKey> QueryKeysMappedToAction(UObject Action,TArray<FKey> ReturnValue) { return default; }
	public TArray<FEnhancedActionKeyMapping> GetAllPlayerMappableActionKeyMappings(TArray<FEnhancedActionKeyMapping> ReturnValue) { return default; }
	public int K2_AddPlayerMappedKeyInSlot(sbyte MappingName,FKey NewKey,FPlayerMappableKeySlot KeySlot=FPlayerMappableKeySlot,FModifyContextOptions Options=FModifyContextOptions,int ReturnValue) { return default; }
	public int K2_RemovePlayerMappedKeyInSlot(sbyte MappingName,FPlayerMappableKeySlot KeySlot=FPlayerMappableKeySlot,FModifyContextOptions Options=FModifyContextOptions,int ReturnValue) { return default; }
	public int RemoveAllPlayerMappedKeysForMapping(sbyte MappingName,FModifyContextOptions Options=FModifyContextOptions,int ReturnValue) { return default; }
	public FKey K2_GetPlayerMappedKeyInSlot(sbyte MappingName,FPlayerMappableKeySlot KeySlot=FPlayerMappableKeySlot,FKey ReturnValue) { return default; }
	public TArray<FKey> GetAllPlayerMappedKeys(sbyte MappingName,TArray<FKey> ReturnValue) { return default; }
	public void RemoveAllPlayerMappedKeys(FModifyContextOptions Options=FModifyContextOptions) {}
	public void AddPlayerMappableConfig(UObject Config,FModifyContextOptions Options=FModifyContextOptions) {}
	public void RemovePlayerMappableConfig(UObject Config,FModifyContextOptions Options=FModifyContextOptions) {}
}
