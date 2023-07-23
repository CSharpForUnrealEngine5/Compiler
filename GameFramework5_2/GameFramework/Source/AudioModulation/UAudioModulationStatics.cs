#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioModulationStatics.h")]
///<summary>namespace AudioModulation</summary>
public partial class UAudioModulationStatics : UBlueprintFunctionLibrary {
// AudioModulationStatics
	public void ActivateBus(UObject WorldContextObject,UObject Bus) {}
	public void ActivateBusMix(UObject WorldContextObject,UObject Mix) {}
	public void ActivateGenerator(UObject WorldContextObject,UObject Generator) {}
	public UObject CreateBus(UObject WorldContextObject,sbyte Name,UObject Parameter,bool Activate=true,UObject ReturnValue) { return default; }
	public FSoundControlBusMixStage CreateBusMixStage(UObject WorldContextObject,UObject Bus,float Value,float AttackTime=0.1f,float ReleaseTime=0.1f,FSoundControlBusMixStage ReturnValue) { return default; }
	public UObject CreateBusMix(UObject WorldContextObject,sbyte Name,TArray<FSoundControlBusMixStage> Stages,bool Activate,UObject ReturnValue) { return default; }
	public UObject CreateModulationParameter(UObject WorldContextObject,sbyte Name,UClass ParamClass,float DefaultValue,UObject ReturnValue) { return default; }
	public UObject CreateEnvelopeFollowerGenerator(UObject WorldContextObject,sbyte Name,FEnvelopeFollowerGeneratorParams Params,UObject ReturnValue) { return default; }
	public UObject CreateLFOGenerator(UObject WorldContextObject,sbyte Name,FSoundModulationLFOParams Params,UObject ReturnValue) { return default; }
	public void DeactivateBus(UObject WorldContextObject,UObject Bus) {}
	public void DeactivateBusMix(UObject WorldContextObject,UObject Mix) {}
	public void DeactivateGenerator(UObject WorldContextObject,UObject Generator) {}
	public void SaveMixToProfile(UObject WorldContextObject,UObject Mix,int ProfileIndex=0) {}
	public TArray<FSoundControlBusMixStage> LoadMixFromProfile(UObject WorldContextObject,UObject Mix,bool bActivate=true,int ProfileIndex=0,TArray<FSoundControlBusMixStage> ReturnValue) { return default; }
	public void UpdateMix(UObject WorldContextObject,UObject Mix,TArray<FSoundControlBusMixStage> Stages,float FadeTime=-1.0f) {}
	public void SetGlobalBusMixValue(UObject WorldContextObject,UObject Bus,float Value,float FadeTime=-1.0f) {}
	public void ClearGlobalBusMixValue(UObject WorldContextObject,UObject Bus,float FadeTime=-1.0f) {}
	public void ClearAllGlobalBusMixValues(UObject WorldContextObject,float FadeTime=-1.0f) {}
	public void UpdateMixByFilter(UObject WorldContextObject,UObject Mix,sbyte AddressFilter,UClass ParamClassFilter,UObject ParamFilter,float Value=1.0f,float FadeTime=-1.0f) {}
	public void UpdateMixFromObject(UObject WorldContextObject,UObject Mix,float FadeTime=-1.0f) {}
	public void UpdateModulator(UObject WorldContextObject,UObject Modulator) {}
	public float GetModulatorValue(UObject WorldContextObject,UObject Modulator,float ReturnValue) { return default; }
	public TSet<UObject> GetModulatorsFromDestination(FSoundModulationDestinationSettings Destination,TSet<UObject> ReturnValue) { return default; }
}
