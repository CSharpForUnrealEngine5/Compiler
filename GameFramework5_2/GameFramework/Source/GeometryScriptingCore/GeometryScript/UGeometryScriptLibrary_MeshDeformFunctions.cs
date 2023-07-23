#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshDeformFunctions.h")]
public partial class UGeometryScriptLibrary_MeshDeformFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_MeshDeformFunctions
	public UObject ApplyBendWarpToMesh(UObject TargetMesh,FGeometryScriptBendWarpOptions Options,FTransform BendOrientation,float BendAngle=45,float BendExtent=50,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyTwistWarpToMesh(UObject TargetMesh,FGeometryScriptTwistWarpOptions Options,FTransform TwistOrientation,float TwistAngle=45,float TwistExtent=50,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyFlareWarpToMesh(UObject TargetMesh,FGeometryScriptFlareWarpOptions Options,FTransform FlareOrientation,float FlarePercentX=0,float FlarePercentY=0,float FlareExtent=50,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyMathWarpToMesh(UObject TargetMesh,FTransform WarpOrientation,EGeometryScriptMathWarpType WarpType,FGeometryScriptMathWarpOptions Options,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyPerlinNoiseToMesh(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptPerlinNoiseOptions Options,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyIterativeSmoothingToMesh(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptIterativeMeshSmoothingOptions Options,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyDisplaceFromTextureMap(UObject TargetMesh,UObject Texture,FGeometryScriptMeshSelection Selection,FGeometryScriptDisplaceFromTextureOptions Options,int UVLayer=0,UObject Debug=nullptr,UObject ReturnValue) { return default; }
	public UObject ApplyDisplaceFromPerVertexVectors(UObject TargetMesh,FGeometryScriptMeshSelection Selection,FGeometryScriptVectorList VectorList,float Magnitude=5.0,UObject Debug=nullptr,UObject ReturnValue) { return default; }
}
