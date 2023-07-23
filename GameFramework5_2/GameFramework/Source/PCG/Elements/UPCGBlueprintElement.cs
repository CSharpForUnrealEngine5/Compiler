#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGExecuteBlueprint.h")]
public partial class UPCGBlueprintElement : UObject {
// PCGBlueprintElement
	public void ExecuteWithContext(FPCGContext InContext,FPCGDataCollection Input,FPCGDataCollection Output) {}
	public void Execute(FPCGDataCollection Input,FPCGDataCollection Output) {}
	public bool PointLoopBody(FPCGContext InContext,UObject InData,FPCGPoint InPoint,FPCGPoint OutPoint,UObject OutMetadata,bool ReturnValue) { return default; }
	public TArray<FPCGPoint> VariableLoopBody(FPCGContext InContext,UObject InData,FPCGPoint InPoint,UObject OutMetadata,TArray<FPCGPoint> ReturnValue) { return default; }
	public bool NestedLoopBody(FPCGContext InContext,UObject InOuterData,UObject InInnerData,FPCGPoint InOuterPoint,FPCGPoint InInnerPoint,FPCGPoint OutPoint,UObject OutMetadata,bool ReturnValue) { return default; }
	public bool IterationLoopBody(FPCGContext InContext,long Iteration,UObject InA,UObject InB,FPCGPoint OutPoint,UObject OutMetadata,bool ReturnValue) { return default; }
	public void PointLoop(FPCGContext InContext,UObject InData,UObject OutData,UObject OptionalOutData=nullptr) {}
	public void VariableLoop(FPCGContext InContext,UObject InData,UObject OutData,UObject OptionalOutData=nullptr) {}
	public void NestedLoop(FPCGContext InContext,UObject InOuterData,UObject InInnerData,UObject OutData,UObject OptionalOutData=nullptr) {}
	public void IterationLoop(FPCGContext InContext,long NumIterations,UObject OutData,UObject OptionalA=nullptr,UObject OptionalB=nullptr,UObject OptionalOutData=nullptr) {}
	public sbyte NodeTitleOverride(sbyte ReturnValue) { return default; }
	public FLinearColor NodeColorOverride(FLinearColor ReturnValue) { return default; }
	public EPCGSettingsType NodeTypeOverride(EPCGSettingsType ReturnValue) { return default; }
	public TSet<sbyte> InputLabels(TSet<sbyte> ReturnValue) { return default; }
	public TSet<sbyte> OutputLabels(TSet<sbyte> ReturnValue) { return default; }
	public int GetSeed(FPCGContext InContext,int ReturnValue) { return default; }
	public FRandomStream GetRandomStream(FPCGContext InContext,FRandomStream ReturnValue) { return default; }
	public bool bCreatesArtifacts;
	public bool bCacheable;
	public bool bCanBeMultithreaded;
	public TSet<sbyte> InputPinLabels_DEPRECATED;
	public TSet<sbyte> OutputPinLabels_DEPRECATED;
	public TArray<FPCGPinProperties> CustomInputPins;
	public TArray<FPCGPinProperties> CustomOutputPins;
	public bool bHasDefaultInPin;
	public bool bHasDefaultOutPin;
	public bool bExposeToLibrary;
	public sbyte Category;
	public sbyte Description;
	public int DependencyParsingDepth;
}
