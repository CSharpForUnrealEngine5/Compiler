#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARPlaneGeometry : UARTrackedGeometry {
// ARPlaneGeometry
	public FVector GetCenter(FVector ReturnValue) { return default; }
	public FVector GetExtent(FVector ReturnValue) { return default; }
	public TArray<FVector> GetBoundaryPolygonInLocalSpace(TArray<FVector> ReturnValue) { return default; }
	public UObject GetSubsumedBy(UObject ReturnValue) { return default; }
	public EARPlaneOrientation GetOrientation(EARPlaneOrientation ReturnValue) { return default; }
	public EARPlaneOrientation Orientation;
	public FVector Center;
	public FVector Extent;
	public TArray<FVector> BoundaryPolygon;
	public UARPlaneGeometry SubsumedBy;
}
