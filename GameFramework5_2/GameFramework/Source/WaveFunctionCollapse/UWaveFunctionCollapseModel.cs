#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveFunctionCollapseModel.h")]
///<summary>A Model of WFC constraints.</summary>
public partial class UWaveFunctionCollapseModel : UDataAsset {
// WaveFunctionCollapseModel
	public float TileSize;
	public TMap<FWaveFunctionCollapseOption,FWaveFunctionCollapseAdjacencyToOptionsMap> Constraints;
	public TArray<FSoftObjectPath> SpawnExclusion;
	public void AddConstraint(FWaveFunctionCollapseOption KeyOption,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOption AdjacentOption) {}
	public FWaveFunctionCollapseOptions GetOptions(FWaveFunctionCollapseOption KeyOption,EWaveFunctionCollapseAdjacency Adjacency,FWaveFunctionCollapseOptions ReturnValue) { return default; }
	public void SetWeightsFromContributions() {}
	public void SetAllWeights(float Weight) {}
	public void SetAllContributions(int Contribution) {}
	public void SetOptionContribution(FWaveFunctionCollapseOption Option,int Contribution) {}
	public float GetOptionWeight(FWaveFunctionCollapseOption Option,float ReturnValue) { return default; }
	public int GetOptionContribution(FWaveFunctionCollapseOption Option,int ReturnValue) { return default; }
	public int GetConstraintCount(int ReturnValue) { return default; }
	public void SwapMeshes(TMap<UObject,UObject> SourceToTargetMeshMap) {}
}
