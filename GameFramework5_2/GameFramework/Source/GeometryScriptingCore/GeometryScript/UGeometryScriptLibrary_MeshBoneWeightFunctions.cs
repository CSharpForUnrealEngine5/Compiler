#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBoneWeightFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBoneWeightFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBoneWeightFunctions
	public UObject MeshHasBoneWeights(UObject TargetMesh,bool bHasBoneWeights,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject MeshCreateBoneWeights(UObject TargetMesh,bool bProfileExisted,bool bReplaceExistingProfile=false,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject GetMaxBoneWeightIndex(UObject TargetMesh,bool bHasBoneWeights,int MaxBoneIndex,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject GetVertexBoneWeights(UObject TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject GetLargestVertexBoneWeight(UObject TargetMesh,int VertexID,FGeometryScriptBoneWeight BoneWeight,bool bHasValidBoneWeights,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject SetVertexBoneWeights(UObject TargetMesh,int VertexID,TArray<FGeometryScriptBoneWeight> BoneWeights,bool bIsValidVertexID,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject SetAllVertexBoneWeights(UObject TargetMesh,TArray<FGeometryScriptBoneWeight> BoneWeights,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject ReturnValue) { return default; }
	public UObject ComputeSmoothBoneWeights(UObject TargetMesh,UObject Skeleton,FGeometryScriptSmoothBoneWeightsOptions Options,FGeometryScriptBoneWeightProfile Profile=FGeometryScriptBoneWeightProfile,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
