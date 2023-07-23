#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBlueprintLibrary.h")]
public partial class UWorldPartitionBlueprintLibrary : UBlueprintFunctionLibrary {
// WorldPartitionBlueprintLibrary
	public FBox GetEditorWorldBounds(FBox ReturnValue) { return default; }
	public FBox GetRuntimeWorldBounds(FBox ReturnValue) { return default; }
	public void LoadActors(TArray<FGuid> InActorsToLoad) {}
	public void UnloadActors(TArray<FGuid> InActorsToUnload) {}
	public void PinActors(TArray<FGuid> InActorsToPin) {}
	public void UnpinActors(TArray<FGuid> InActorsToUnpin) {}
	public bool GetActorDescs(TArray<FActorDesc> OutActorDescs,bool ReturnValue) { return default; }
	public bool GetIntersectingActorDescs(FBox InBox,TArray<FActorDesc> OutActorDescs,bool ReturnValue) { return default; }
}
