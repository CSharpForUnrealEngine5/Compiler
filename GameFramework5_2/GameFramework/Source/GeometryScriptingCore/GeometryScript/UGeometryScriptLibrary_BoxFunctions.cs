#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_BoxFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_BoxFunctions
	public FBox MakeBoxFromCenterSize(FVector Center,FVector Dimensions,FBox ReturnValue) { return default; }
	public FBox MakeBoxFromCenterExtents(FVector Center,FVector Extents,FBox ReturnValue) { return default; }
	public void GetBoxCenterSize(FBox Box,FVector Center,FVector Dimensions) {}
	public FVector GetBoxCorner(FBox Box,int CornerIndex,FVector ReturnValue) { return default; }
	public FVector GetBoxFaceCenter(FBox Box,int FaceIndex,FVector FaceNormal,FVector ReturnValue) { return default; }
	public void GetBoxVolumeArea(FBox Box,double Volume,double SurfaceArea) {}
	public FBox GetExpandedBox(FBox Box,FVector ExpandBy,FBox ReturnValue) { return default; }
	public FBox GetTransformedBox(FBox Box,FTransform Transform,FBox ReturnValue) { return default; }
	public bool TestBoxBoxIntersection(FBox Box1,FBox Box2,bool ReturnValue) { return default; }
	public FBox FindBoxBoxIntersection(FBox Box1,FBox Box2,bool bIsIntersecting,FBox ReturnValue) { return default; }
	public double GetBoxBoxDistance(FBox Box1,FBox Box2,double ReturnValue) { return default; }
	public bool TestPointInsideBox(FBox Box,FVector Point,bool bConsiderOnBoxAsInside=true,bool ReturnValue) { return default; }
	public FVector FindClosestPointOnBox(FBox Box,FVector Point,bool bIsInside,FVector ReturnValue) { return default; }
	public double GetBoxPointDistance(FBox Box,FVector Point,double ReturnValue) { return default; }
	public bool TestBoxSphereIntersection(FBox Box,FVector SphereCenter,double SphereRadius,bool ReturnValue) { return default; }
}
