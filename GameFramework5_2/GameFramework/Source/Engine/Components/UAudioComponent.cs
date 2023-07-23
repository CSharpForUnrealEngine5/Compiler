#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/AudioComponent.h")]
///<summary>AudioComponent is used to play a Sound</summary>
public partial class UAudioComponent : USceneComponent {
// AudioComponent
	public USoundBase Sound;
	public TArray<FAudioParameter> DefaultParameters;
	public TArray<FAudioParameter> InstanceParameters;
	public USoundClass SoundClassOverride;
	public bool bAutoDestroy;
	public bool bStopWhenOwnerDestroyed;
	public bool bShouldRemainActiveIfDropped;
	public bool bAllowSpatialization;
	public bool bOverrideAttenuation;
	public bool bOverrideSubtitlePriority;
	public bool bIsUISound;
	public bool bEnableLowPassFilter;
	public bool bOverridePriority;
	public bool bSuppressSubtitles;
	public bool bCanPlayMultipleInstances;
	public bool bDisableParameterUpdatesWhilePlaying;
	public bool bAutoManageAttachment;
	public sbyte AudioComponentUserID;
	public float PitchModulationMin;
	public float PitchModulationMax;
	public float VolumeModulationMin;
	public float VolumeModulationMax;
	public float VolumeMultiplier;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public float Priority;
	public float SubtitlePriority;
	public USoundEffectSourcePresetChain SourceEffectChain;
	public float VolumeWeightedPriorityScale_DEPRECATED;
	public float HighFrequencyGainMultiplier_DEPRECATED;
	public float PitchMultiplier;
	public float LowPassFilterFrequency;
	public USoundAttenuation AttenuationSettings;
	public FSoundAttenuationSettings AttenuationOverrides;
	public USoundConcurrency ConcurrencySettings_DEPRECATED;
	public TSet<USoundConcurrency> ConcurrencySet;
	public EAttachmentRule AutoAttachLocationRule;
	public EAttachmentRule AutoAttachRotationRule;
	public EAttachmentRule AutoAttachScaleRule;
	public FSoundModulationDefaultRoutingSettings ModulationRouting;
	public FOnAudioPlayStateChanged OnAudioPlayStateChanged;
	public FOnAudioVirtualizationChanged OnAudioVirtualizationChanged;
	public FOnAudioFinished OnAudioFinished;
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent;
	public FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue;
	public FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue;
	public FOnQueueSubtitles OnQueueSubtitles;
	public void SetSound(UObject NewSound) {}
	public void FadeIn(float FadeInDuration,float FadeVolumeLevel=1.0f,float StartTime=0.0f,EAudioFaderCurve FadeCurve=EAudioFaderCurve) {}
	public void FadeOut(float FadeOutDuration,float FadeVolumeLevel,EAudioFaderCurve FadeCurve=EAudioFaderCurve) {}
	public void Play(float StartTime=0.0f) {}
	public void PlayQuantized(UObject WorldContextObject,UObject InClockHandle,FQuartzQuantizationBoundary InQuantizationBoundary,FOnQuartzCommandEventBP InDelegate,float InStartTime=0.f,float InFadeInDuration=0.f,float InFadeVolumeLevel=1.f,EAudioFaderCurve InFadeCurve=EAudioFaderCurve) {}
	public void SetBoolParameter(sbyte InName,bool InBool) {}
	public void SetIntParameter(sbyte InName,int InInt) {}
	public void SetFloatParameter(sbyte InName,float InFloat) {}
	public void Stop() {}
	public void StopDelayed(float DelayTime) {}
	public void SetPaused(bool bPause) {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public bool IsVirtualized(bool ReturnValue) { return default; }
	public EAudioComponentPlayState GetPlayState(EAudioComponentPlayState ReturnValue) { return default; }
	public void AdjustVolume(float AdjustVolumeDuration,float AdjustVolumeLevel,EAudioFaderCurve FadeCurve=EAudioFaderCurve) {}
	public void SetWaveParameter(sbyte InName,UObject InWave) {}
	public void SetVolumeMultiplier(float NewVolumeMultiplier) {}
	public void SetPitchMultiplier(float NewPitchMultiplier) {}
	public void SetUISound(bool bInUISound) {}
	public void AdjustAttenuation(FSoundAttenuationSettings InAttenuationSettings) {}
	public void SetSubmixSend(UObject Submix,float SendLevel) {}
	public void SetSourceBusSendPreEffect(UObject SoundSourceBus,float SourceBusSendLevel) {}
	public void SetSourceBusSendPostEffect(UObject SoundSourceBus,float SourceBusSendLevel) {}
	public void SetAudioBusSendPreEffect(UObject AudioBus,float AudioBusSendLevel) {}
	public void SetAudioBusSendPostEffect(UObject AudioBus,float AudioBusSendLevel) {}
	public void SetLowPassFilterEnabled(bool InLowPassFilterEnabled) {}
	public void SetLowPassFilterFrequency(float InLowPassFilterFrequency) {}
	public void SetOutputToBusOnly(bool bInOutputToBusOnly) {}
	public bool HasCookedFFTData(bool ReturnValue) { return default; }
	public bool HasCookedAmplitudeEnvelopeData(bool ReturnValue) { return default; }
	public bool GetCookedFFTData(TArray<float> FrequenciesToGet,TArray<FSoundWaveSpectralData> OutSoundWaveSpectralData,bool ReturnValue) { return default; }
	public bool GetCookedFFTDataForAllPlayingSounds(TArray<FSoundWaveSpectralDataPerSound> OutSoundWaveSpectralData,bool ReturnValue) { return default; }
	public bool GetCookedEnvelopeData(float OutEnvelopeData,bool ReturnValue) { return default; }
	public bool GetCookedEnvelopeDataForAllPlayingSounds(TArray<FSoundWaveEnvelopeDataPerSound> OutEnvelopeData,bool ReturnValue) { return default; }
	public void SetModulationRouting(TSet<UObject> Modulators,EModulationDestination Destination,EModulationRouting RoutingMethod=EModulationRouting) {}
	public TSet<UObject> GetModulators(EModulationDestination Destination,TSet<UObject> ReturnValue) { return default; }
	public bool BP_GetAttenuationSettingsToApply(FSoundAttenuationSettings OutAttenuationSettings,bool ReturnValue) { return default; }
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	public sbyte AutoAttachSocketName;
}
