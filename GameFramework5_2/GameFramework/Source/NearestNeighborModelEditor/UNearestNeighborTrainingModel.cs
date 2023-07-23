#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborTrainingModel.h")]
public partial class UNearestNeighborTrainingModel : UMLDeformerTrainingModel {
// NearestNeighborTrainingModel
	public int Train(int ReturnValue) { return default; }
	public int UpdateNearestNeighborData(int ReturnValue) { return default; }
	public int KmeansClusterPoses(int PartId,int ReturnValue) { return default; }
	public TArray<float> PartSampleDeltas;
	public TArray<int> KmeansResults;
	public UObject GetNearestNeighborModel(UObject ReturnValue) { return default; }
	public TArray<int> GetPartVertexMap(int PartId,TArray<int> ReturnValue) { return default; }
	public int SamplePart(int PartId,int Index,int ReturnValue) { return default; }
	public int SetSamplerPartData(int PartId,int ReturnValue) { return default; }
	public int GetPartNumNeighbors(int PartId,int ReturnValue) { return default; }
	public bool SampleKmeansAnim(int SkeletonId,bool ReturnValue) { return default; }
	public bool SampleKmeansFrame(int Frame,bool ReturnValue) { return default; }
	public int GetKmeansNumAnims(int ReturnValue) { return default; }
	public int GetKmeansAnimNumFrames(int SkeletonId,int ReturnValue) { return default; }
	public int GetKmeansNumClusters(int ReturnValue) { return default; }
	public TArray<float> GetUnskinnedVertexPositions(TArray<float> ReturnValue) { return default; }
	public TArray<int> GetMeshIndexBuffer(TArray<int> ReturnValue) { return default; }
}
