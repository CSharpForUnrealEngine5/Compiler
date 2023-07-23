#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioComponentGroup.h")]
///<summary>* Automatic Handler for voices and parameters across any number of AudioComponents</summary>
public partial class UAudioComponentGroup : USceneComponent {
// AudioComponentGroup
	public UObject StaticGetOrCreateComponentGroup(UObject Actor,UObject ReturnValue) { return default; }
	public void StopSound(UObject Sound,float FadeTime=0.f) {}
	public bool IsPlayingAny(bool ReturnValue) { return default; }
	public bool IsVirtualized(bool ReturnValue) { return default; }
	public void BroadcastStopAll() {}
	public void BroadcastKill() {}
	public void BroadcastEvent(sbyte EventName) {}
	public void AddExternalComponent(UObject ComponentToAdd) {}
	public void EnableVirtualization() {}
	public void DisableVirtualization() {}
	public void SetVolumeMultiplier(float InVolume) {}
	public void SetPitchMultiplier(float InPitch) {}
	public void SetLowPassFilter(float InFrequency) {}
	public void AddExtension(object /*NewExtension*/ NewExtension) {}
	public void RemoveExtension(object /*NewExtension*/ NewExtension) {}
	public float GetFloatParamValue(sbyte ParamName,float ReturnValue) { return default; }
	public bool GetBoolParamValue(sbyte ParamName,bool ReturnValue) { return default; }
	public sbyte GetStringParamValue(sbyte ParamName,sbyte ReturnValue) { return default; }
	public FSoundGroupChanged OnStopped;
	public FSoundGroupChanged OnKilled;
	public FSoundGroupChanged OnVirtualized;
	public FSoundGroupChanged OnUnvirtualized;
	public TArray<UAudioComponent> Components;
	public TArray<FAudioParameter> ParamsToSet;
	public TArray<FAudioParameter> PersistentParams;
	public TArray<object /*Extensions*/> Extensions;
}
