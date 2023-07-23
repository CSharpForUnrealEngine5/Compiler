#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Helpers/PCGBlueprintHelpers.h")]
public partial class UPCGBlueprintHelpers : UBlueprintFunctionLibrary {
// PCGBlueprintHelpers
	public int ComputeSeedFromPosition(FVector InPosition,int ReturnValue) { return default; }
	public void SetSeedFromPosition(FPCGPoint InPoint) {}
	public FRandomStream GetRandomStream(FPCGPoint InPoint,UObject OptionalSettings=nullptr,UObject OptionalComponent=nullptr,FRandomStream ReturnValue) { return default; }
	public UObject GetSettings(FPCGContext Context,UObject ReturnValue) { return default; }
	public UObject GetActorData(FPCGContext Context,UObject ReturnValue) { return default; }
	public UObject GetInputData(FPCGContext Context,UObject ReturnValue) { return default; }
	public UObject GetComponent(FPCGContext Context,UObject ReturnValue) { return default; }
	public UObject GetOriginalComponent(FPCGContext Context,UObject ReturnValue) { return default; }
	public void SetExtents(FPCGPoint InPoint,FVector InExtents) {}
	public FVector GetExtents(FPCGPoint InPoint,FVector ReturnValue) { return default; }
	public void SetLocalCenter(FPCGPoint InPoint,FVector InLocalCenter) {}
	public FVector GetLocalCenter(FPCGPoint InPoint,FVector ReturnValue) { return default; }
	public FBox GetTransformedBounds(FPCGPoint InPoint,FBox ReturnValue) { return default; }
	public FBox GetActorBoundsPCG(UObject InActor,bool bIgnorePCGCreatedComponents=true,FBox ReturnValue) { return default; }
	public FBox GetActorLocalBoundsPCG(UObject InActor,bool bIgnorePCGCreatedComponents=true,FBox ReturnValue) { return default; }
	public UObject CreatePCGDataFromActor(UObject InActor,bool bParseActor=true,UObject ReturnValue) { return default; }
	public TArray<FPCGLandscapeLayerWeight> GetInterpolatedPCGLandscapeLayerWeights(UObject WorldContextObject,FVector Location,TArray<FPCGLandscapeLayerWeight> ReturnValue) { return default; }
	public long GetTaskId(FPCGContext Context,long ReturnValue) { return default; }
}
