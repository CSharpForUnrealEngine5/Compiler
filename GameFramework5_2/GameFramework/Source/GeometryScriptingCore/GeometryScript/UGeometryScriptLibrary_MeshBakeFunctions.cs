#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBakeFunctions.h")]
public partial class UGeometryScriptLibrary_MeshBakeFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshBakeFunctions
	public FGeometryScriptBakeTypeOptions MakeBakeTypeTangentNormal(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeObjectNormal(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeFaceNormal(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeBentNormal(int OcclusionRays=16,float MaxDistance=0.0f,float SpreadAngle=180.0f,FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypePosition(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeCurvature(EGeometryScriptBakeCurvatureTypeMode CurvatureType=EGeometryScriptBakeCurvatureTypeMode,EGeometryScriptBakeCurvatureColorMode ColorMapping=EGeometryScriptBakeCurvatureColorMode,float ColorRangeMultiplier=1.0f,float MinRangeMultiplier=0.0f,EGeometryScriptBakeCurvatureClampMode Clamping=EGeometryScriptBakeCurvatureClampMode,FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeAmbientOcclusion(int OcclusionRays=16,float MaxDistance=0.0f,float SpreadAngle=180.0f,float BiasAngle=15.0f,FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeTexture(UObject SourceTexture=nullptr,int SourceUVLayer=0,FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeMultiTexture(TArray<UObject> MaterialIDSourceTextures,int SourceUVLayer=0,FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeVertexColor(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public FGeometryScriptBakeTypeOptions MakeBakeTypeMaterialID(FGeometryScriptBakeTypeOptions ReturnValue) { return default; }
	public TArray<UObject> BakeTexture(UObject TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UObject SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,TArray<FGeometryScriptBakeTypeOptions> BakeTypes,FGeometryScriptBakeTextureOptions BakeOptions,UObject Debug=nullptr,TArray<UObject> ReturnValue) { return default; }
	public UObject BakeVertex(UObject TargetMesh,FTransform TargetTransform,FGeometryScriptBakeTargetMeshOptions TargetOptions,UObject SourceMesh,FTransform SourceTransform,FGeometryScriptBakeSourceMeshOptions SourceOptions,FGeometryScriptBakeOutputType BakeTypes,FGeometryScriptBakeVertexOptions BakeOptions,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public FGeometryScriptRenderCaptureTextures BakeTextureFromRenderCaptures(UObject TargetMesh,FTransform TargetLocalToWorld,FGeometryScriptBakeTargetMeshOptions TargetOptions,TArray<UObject> SourceActors,FGeometryScriptBakeRenderCaptureOptions BakeOptions,UObject Debug=nullptr,FGeometryScriptRenderCaptureTextures ReturnValue) { return default; }
}
