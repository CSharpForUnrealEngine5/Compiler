#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/PolyPathFunctions.h")]
public partial class UGeometryScriptLibrary_PolyPathFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_PolyPathFunctions
	public int GetPolyPathNumVertices(FGeometryScriptPolyPath PolyPath,int ReturnValue) { return default; }
	public int GetPolyPathLastIndex(FGeometryScriptPolyPath PolyPath,int ReturnValue) { return default; }
	public FVector GetPolyPathVertex(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex,FVector ReturnValue) { return default; }
	public FVector GetPolyPathTangent(FGeometryScriptPolyPath PolyPath,int Index,bool bIsValidIndex,FVector ReturnValue) { return default; }
	public double GetPolyPathArcLength(FGeometryScriptPolyPath PolyPath,double ReturnValue) { return default; }
	public int GetNearestVertexIndex(FGeometryScriptPolyPath PolyPath,FVector Point,int ReturnValue) { return default; }
	public FGeometryScriptPolyPath FlattenTo2DOnAxis(FGeometryScriptPolyPath PolyPath,EGeometryScriptAxis DropAxis=EGeometryScriptAxis,FGeometryScriptPolyPath ReturnValue) { return default; }
	public FGeometryScriptPolyPath CreateCirclePath3D(FTransform Transform,float Radius=10,int NumPoints=10,FGeometryScriptPolyPath ReturnValue) { return default; }
	public FGeometryScriptPolyPath CreateArcPath3D(FTransform Transform,float Radius=10,int NumPoints=10,float StartAngle=0,float EndAngle=90,FGeometryScriptPolyPath ReturnValue) { return default; }
	public FGeometryScriptPolyPath CreateCirclePath2D(FVector2D Center=FVector2D,float Radius=10,int NumPoints=10,FGeometryScriptPolyPath ReturnValue) { return default; }
	public FGeometryScriptPolyPath CreateArcPath2D(FVector2D Center=FVector2D,float Radius=10,int NumPoints=10,float StartAngle=0,float EndAngle=90,FGeometryScriptPolyPath ReturnValue) { return default; }
	public void ConvertSplineToPolyPath(UObject Spline,FGeometryScriptPolyPath PolyPath,FGeometryScriptSplineSamplingOptions SamplingOptions) {}
	public void SampleSplineToTransforms(UObject Spline,TArray<FTransform> Frames,TArray<double> FrameTimes,FGeometryScriptSplineSamplingOptions SamplingOptions,FTransform RelativeTransform,bool bIncludeScale=true) {}
	public void ConvertPolyPathToArray(FGeometryScriptPolyPath PolyPath,TArray<FVector> VertexArray) {}
	public void ConvertArrayToPolyPath(TArray<FVector> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public void ConvertPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath,TArray<FVector2D> VertexArray) {}
	public void ConvertArrayOfVector2DToPolyPath(TArray<FVector2D> VertexArray,FGeometryScriptPolyPath PolyPath) {}
	public TArray<FVector> Conv_GeometryScriptPolyPathToArray(FGeometryScriptPolyPath PolyPath,TArray<FVector> ReturnValue) { return default; }
	public TArray<FVector2D> Conv_GeometryScriptPolyPathToArrayOfVector2D(FGeometryScriptPolyPath PolyPath,TArray<FVector2D> ReturnValue) { return default; }
	public FGeometryScriptPolyPath Conv_ArrayToGeometryScriptPolyPath(TArray<FVector> PathVertices,FGeometryScriptPolyPath ReturnValue) { return default; }
	public FGeometryScriptPolyPath Conv_ArrayOfVector2DToGeometryScriptPolyPath(TArray<FVector2D> PathVertices,FGeometryScriptPolyPath ReturnValue) { return default; }
}
