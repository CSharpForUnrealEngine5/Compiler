#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGSpatialData.h")]
///<summary>"Concrete" data base class for PCG generation</summary>
public partial class UPCGSpatialData : UPCGData {
// PCGSpatialData
	public int GetDimension(int ReturnValue) { return default; }
	public FBox GetBounds(FBox ReturnValue) { return default; }
	public FBox GetStrictBounds(FBox ReturnValue) { return default; }
	public FVector GetNormal(FVector ReturnValue) { return default; }
	public float GetDensityAtPosition(FVector InPosition,float ReturnValue) { return default; }
	public UObject ToPointData(UObject ReturnValue) { return default; }
	public UObject ToPointDataWithContext(FPCGContext Context,UObject ReturnValue) { return default; }
	public bool SamplePoint(FTransform Transform,FBox Bounds,FPCGPoint OutPoint,UObject OutMetadata,bool ReturnValue) { return default; }
	public bool ProjectPoint(FTransform InTransform,FBox InBounds,FPCGProjectionParams InParams,FPCGPoint OutPoint,UObject OutMetadata,bool ReturnValue) { return default; }
	public bool HasNonTrivialTransform(bool ReturnValue) { return default; }
	public UObject IntersectWith(UObject InOther,UObject ReturnValue) { return default; }
	public UObject ProjectOn(UObject InOther,FPCGProjectionParams InParams=FPCGProjectionParams,UObject ReturnValue) { return default; }
	public UObject UnionWith(UObject InOther,UObject ReturnValue) { return default; }
	public UObject Subtract(UObject InOther,UObject ReturnValue) { return default; }
	public UObject ConstMetadata(UObject ReturnValue) { return default; }
	public UObject MutableMetadata(UObject ReturnValue) { return default; }
	public UObject CreateEmptyMetadata(UObject ReturnValue) { return default; }
	public void InitializeFromData(UObject InSource,UObject InMetadataParentOverride=nullptr,bool bInheritMetadata=true,bool bInheritAttributes=true) {}
	public TWeakObjectPtr<AActor> TargetActor;
	public bool bKeepZeroDensityPoints;
	public UPCGMetadata Metadata;
}
