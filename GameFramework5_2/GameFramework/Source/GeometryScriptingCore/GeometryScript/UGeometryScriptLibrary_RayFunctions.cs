#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/ShapeFunctions.h")]
public partial class UGeometryScriptLibrary_RayFunctions : UBlueprintFunctionLibrary {
// GeometryScriptLibrary_RayFunctions
	public FRay MakeRayFromPoints(FVector A,FVector B,FRay ReturnValue) { return default; }
	public FRay MakeRayFromPointDirection(FVector Origin,FVector Direction,bool bDirectionIsNormalized=true,FRay ReturnValue) { return default; }
	public FRay GetTransformedRay(FRay Ray,FTransform Transform,bool bInvert=false,FRay ReturnValue) { return default; }
	public FVector GetRayPoint(FRay Ray,double Distance,FVector ReturnValue) { return default; }
	public void GetRayStartEnd(FRay Ray,double StartDistance,double EndDistance,FVector StartPoint,FVector EndPoint) {}
	public double GetRayParameter(FRay Ray,FVector Point,double ReturnValue) { return default; }
	public double GetRayPointDistance(FRay Ray,FVector Point,double ReturnValue) { return default; }
	public FVector GetRayClosestPoint(FRay Ray,FVector Point,FVector ReturnValue) { return default; }
	public bool GetRaySphereIntersection(FRay Ray,FVector SphereCenter,double SphereRadius,double Distance1,double Distance2,bool ReturnValue) { return default; }
	public bool GetRayBoxIntersection(FRay Ray,FBox Box,double HitDistance,bool ReturnValue) { return default; }
	public bool GetRayPlaneIntersection(FRay Ray,FPlane Plane,double HitDistance,bool ReturnValue) { return default; }
	public double GetRayLineClosestPoint(FRay Ray,FVector LineOrigin,FVector LineDirection,double RayParameter,FVector RayPoint,double LineParameter,FVector LinePoint,double ReturnValue) { return default; }
	public double GetRaySegmentClosestPoint(FRay Ray,FVector SegStartPoint,FVector SegEndPoint,double RayParameter,FVector RayPoint,FVector SegPoint,double ReturnValue) { return default; }
}
