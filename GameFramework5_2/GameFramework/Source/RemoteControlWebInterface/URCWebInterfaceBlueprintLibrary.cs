#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCWebInterfaceLibrary.h")]
public partial class URCWebInterfaceBlueprintLibrary : UBlueprintFunctionLibrary {
// RCWebInterfaceBlueprintLibrary
	public TMap<sbyte,UObject> FindMatchingActorsToRebind(sbyte PresetId,TArray<sbyte> PropertyIds,TMap<sbyte,UObject> ReturnValue) { return default; }
	public sbyte GetOwnerActorLabel(sbyte PresetId,TArray<sbyte> PropertyIds,sbyte ReturnValue) { return default; }
	public void RebindProperties(sbyte PresetId,TArray<sbyte> PropertyIds,UObject NewOwner) {}
	public TMap<UObject,sbyte> FindAllActorsOfClass(UClass Class,TMap<UObject,sbyte> ReturnValue) { return default; }
	public UObject SpawnActor(UClass Class,UObject ReturnValue) { return default; }
	public TMap<UObject,sbyte> GetValuesOfActorsByClass(UClass Class,TMap<UObject,sbyte> ReturnValue) { return default; }
}
