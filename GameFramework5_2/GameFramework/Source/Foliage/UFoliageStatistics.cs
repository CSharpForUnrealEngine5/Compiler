#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FoliageStatistics.h")]
public partial class UFoliageStatistics : UBlueprintFunctionLibrary {
// FoliageStatistics
	public int FoliageOverlappingSphereCount(UObject WorldContextObject,UObject StaticMesh,FVector CenterPosition,float Radius,int ReturnValue) { return default; }
	public int FoliageOverlappingBoxCount(UObject WorldContextObject,UObject StaticMesh,FBox Box,int ReturnValue) { return default; }
	public void FoliageOverlappingBoxTransforms(UObject WorldContextObject,UObject StaticMesh,FBox Box,TArray<FTransform> OutTransforms) {}
}
