#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCModulationMixingStatics.h")]
public partial class UOSCModulationMixingStatics : UBlueprintFunctionLibrary {
// OSCModulationMixingStatics
	public FOSCAddress GetMixLoadPattern(FOSCAddress ReturnValue) { return default; }
	public FOSCAddress GetProfileLoadPath(FOSCAddress ReturnValue) { return default; }
	public FOSCAddress GetProfileSavePath(FOSCAddress ReturnValue) { return default; }
	public void CopyStagesToOSCBundle(UObject WorldContextObject,FOSCAddress PathAddress,TArray<FSoundControlBusMixStage> Stages,FOSCBundle Bundle) {}
	public void CopyMixToOSCBundle(UObject WorldContextObject,UObject Mix,FOSCBundle Bundle) {}
	public EOSCModulationBundle GetOSCBundleType(FOSCBundle Bundle,EOSCModulationBundle ReturnValue) { return default; }
	public void RequestMix(UObject WorldContextObject,UObject Client,FOSCAddress MixPath) {}
	public TArray<FSoundModulationMixValue> OSCBundleToStageValues(UObject WorldContextObject,FOSCBundle Bundle,FOSCAddress MixPath,TArray<FOSCAddress> BusPaths,TArray<sbyte> BusClassNames,TArray<FSoundModulationMixValue> ReturnValue) { return default; }
}
