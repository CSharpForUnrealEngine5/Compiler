#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseBPLibrary.h")]
public partial class UWaveFunctionCollapseBPLibrary : UBlueprintFunctionLibrary {
// WaveFunctionCollapseBPLibrary
	public float CalculateShannonEntropy(TArray<FWaveFunctionCollapseOption> Options,UObject WFCModel,float ReturnValue) { return default; }
	public int PositionAsIndex(FIntVector Position,FIntVector Resolution,int ReturnValue) { return default; }
	public FIntVector IndexAsPosition(int Index,FIntVector Resolution,FIntVector ReturnValue) { return default; }
	public FWaveFunctionCollapseTile BuildInitialTile(UObject WFCModel,FWaveFunctionCollapseTile ReturnValue) { return default; }
	public TMap<int,EWaveFunctionCollapseAdjacency> GetAdjacentIndices(int Index,FIntVector Resolution,TMap<int,EWaveFunctionCollapseAdjacency> ReturnValue) { return default; }
	public TMap<FIntVector,EWaveFunctionCollapseAdjacency> GetAdjacentPositions(FIntVector Position,FIntVector Resolution,TMap<FIntVector,EWaveFunctionCollapseAdjacency> ReturnValue) { return default; }
	public bool IsOptionContained(FWaveFunctionCollapseOption Option,TArray<FWaveFunctionCollapseOption> Options,bool ReturnValue) { return default; }
	public EWaveFunctionCollapseAdjacency GetOppositeAdjacency(EWaveFunctionCollapseAdjacency Adjacency,EWaveFunctionCollapseAdjacency ReturnValue) { return default; }
	public EWaveFunctionCollapseAdjacency GetNextZAxisClockwiseAdjacency(EWaveFunctionCollapseAdjacency Adjacency,EWaveFunctionCollapseAdjacency ReturnValue) { return default; }
	public void AddToAdjacencyToOptionsMap(FWaveFunctionCollapseAdjacencyToOptionsMap AdjacencyToOptionsMap,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption Option) {}
	public bool IsSoftObjPathEqual(FSoftObjectPath SoftObjectPathA,FSoftObjectPath SoftObjectPathB,bool ReturnValue) { return default; }
	public FRotator SanitizeRotator(FRotator Rotator,FRotator ReturnValue) { return default; }
	public void DeriveModelFromActors(TArray<UObject> Actors,UObject WFCModel,float TileSize,bool bIsBorderEmptyOption,bool bIsMinZFloorOption,bool bUseUniformWeightDistribution,bool bAutoDeriveZAxisRotationConstraints,TArray<FSoftObjectPath> SpawnExclusionAssets,TArray<FSoftObjectPath> IgnoreRotationAssets) {}
	public bool GetPositionToOptionMapFromActor(UObject Actor,float TileSize,TMap<FIntVector,FWaveFunctionCollapseOption> PositionToOptionMap,bool ReturnValue) { return default; }
	public FWaveFunctionCollapseOption MakeEmptyOption(FWaveFunctionCollapseOption ReturnValue) { return default; }
	public FWaveFunctionCollapseOption MakeBorderOption(FWaveFunctionCollapseOption ReturnValue) { return default; }
	public FWaveFunctionCollapseOption MakeVoidOption(FWaveFunctionCollapseOption ReturnValue) { return default; }
}
