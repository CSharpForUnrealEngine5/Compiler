#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDExporterBlueprintLibrary.h")]
///<summary>Library of functions that can be used via Python scripting to help export Unreal scenes and assets to USD</summary>
public partial class UUsdExporterBlueprintLibrary : UBlueprintFunctionLibrary {
// UsdExporterBlueprintLibrary
	public UObject GetInstancedFoliageActorForLevel(bool bCreateIfNone=false,UObject Level=nullptr,UObject ReturnValue) { return default; }
	public TArray<UObject> GetUsedFoliageTypes(UObject Actor,TArray<UObject> ReturnValue) { return default; }
	public UObject GetSource(UObject FoliageType,UObject ReturnValue) { return default; }
	public TArray<FTransform> GetInstanceTransforms(UObject Actor,UObject FoliageType,UObject InstancesLevel=nullptr,TArray<FTransform> ReturnValue) { return default; }
	public void SendAnalytics(TArray<FAnalyticsEventAttr> Attrs,sbyte EventName,bool bAutomated,double ElapsedSeconds,double NumberOfFrames,sbyte Extension) {}
}
