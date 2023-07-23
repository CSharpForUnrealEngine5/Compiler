#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborModel.h")]
///<summary>The nearest neighbor model.</summary>
public partial class UNearestNeighborModel : UMLDeformerMorphModel {
// NearestNeighborModel
	public int GetNumParts(int ReturnValue) { return default; }
	public int GetPartNumVerts(int PartId,int ReturnValue) { return default; }
	public int GetPCACoeffStart(int PartId,int ReturnValue) { return default; }
	public int GetPCACoeffNum(int PartId,int ReturnValue) { return default; }
	public int GetNumNeighbors(int PartId,int ReturnValue) { return default; }
	public TArray<float> PCABasis(int PartId,TArray<float> ReturnValue) { return default; }
	public void SetPCABasis(int PartId,TArray<float> PCABasis) {}
	public TArray<float> VertexMean(int PartId,TArray<float> ReturnValue) { return default; }
	public void SetVertexMean(int PartId,TArray<float> VertexMean) {}
	public void SetNumNeighbors(int PartId,int InNumNeighbors) {}
	public TArray<float> NeighborCoeffs(int PartId,TArray<float> ReturnValue) { return default; }
	public void SetNeighborCoeffs(int PartId,TArray<float> NeighborCoeffs) {}
	public TArray<float> NeighborOffsets(int PartId,TArray<float> ReturnValue) { return default; }
	public void SetNeighborOffsets(int PartId,TArray<float> NeighborOffsets) {}
	public TArray<float> ClipInputs(TArray<float> Input,TArray<float> ReturnValue) { return default; }
	public int GetInputDim(int ReturnValue) { return default; }
	public TArray<int> GetHiddenLayerDims(TArray<int> ReturnValue) { return default; }
	public int GetOutputDim(int ReturnValue) { return default; }
	public int GetNumEpochs(int ReturnValue) { return default; }
	public int GetBatchSize(int ReturnValue) { return default; }
	public float GetLearningRate(float ReturnValue) { return default; }
	public TArray<FClothPartEditorData> GetClothPartEditorData(TArray<FClothPartEditorData> ReturnValue) { return default; }
	public TArray<FSkeletonCachePair> GetNearestNeighborData(TArray<FSkeletonCachePair> ReturnValue) { return default; }
	public sbyte GetModelDir(sbyte ReturnValue) { return default; }
	public int InputDim;
	public TArray<int> HiddenLayerDims;
	public int OutputDim;
	public int NumEpochs;
	public int BatchSize;
	public float LearningRate;
	public bool bClothPartDataValid;
	public TArray<FClothPartEditorData> ClothPartEditorData;
	public int BasisSmoothIter;
	public bool bUseDualQuaternionDeltas;
	public bool bNearestNeighborDataValid;
	public bool bMorphTargetDataValid;
	public bool bUsePartOnlyMesh;
	public TArray<FSkeletonCachePair> NearestNeighborData;
	public float SavedNetworkSize;
	public float MorphDataSize;
	public bool bUseFileCache;
	public sbyte FileCacheDirectory;
	public bool bRecomputeDeltas;
	public bool bRecomputePCA;
	public TArray<UAnimSequence> SourceAnims;
	public int NumClusters;
	public int KMeansPartId;
	public bool bUseInputMultipliers;
	public TArray<FVector3f> InputMultipliers;
	public TArray<FClothPartData> ClothPartData;
	public TArray<float> InputsMin;
	public TArray<float> InputsMax;
	public float DecayFactor;
	public float NearestNeighborOffsetWeight;
	public UNearestNeighborOptimizedNetwork OptimizedNetwork;
	public UNeuralNetwork NNINetwork;
	public bool bDoesMeetOptimizedNetworkPrerequisites;
	public bool bUseOptimizedNetwork;
}
