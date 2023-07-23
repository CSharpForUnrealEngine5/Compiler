#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>Sound Submix class meant for applying an effect to the downmixed sum of multiple audio sources.</summary>
public partial class USoundSubmix : USoundSubmixWithParentBase {
// SoundSubmix
	public bool bMuteWhenBackgrounded;
	public TArray<USoundEffectSubmixPreset> SubmixEffectChain;
	public USoundfieldEncodingSettingsBase AmbisonicsPluginSettings;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public float OutputVolume;
	public float WetLevel;
	public float DryLevel;
	public FSoundModulationDestinationSettings OutputVolumeModulation;
	public FSoundModulationDestinationSettings WetLevelModulation;
	public FSoundModulationDestinationSettings DryLevelModulation;
	public bool bSendToAudioLink;
	public UAudioLinkSettingsAbstract AudioLinkSettings;
	public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone;
	public void StartRecordingOutput(UObject WorldContextObject,float ExpectedDuration) {}
	public void StopRecordingOutput(UObject WorldContextObject,EAudioRecordingExportType ExportType,sbyte Name,sbyte Path,UObject ExistingSoundWaveToOverwrite=nullptr) {}
	public void StartEnvelopeFollowing(UObject WorldContextObject) {}
	public void StopEnvelopeFollowing(UObject WorldContextObject) {}
	public void AddEnvelopeFollowerDelegate(UObject WorldContextObject,FOnSubmixEnvelopeBP OnSubmixEnvelopeBP) {}
	public void AddSpectralAnalysisDelegate(UObject WorldContextObject,TArray<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP,float UpdateRate=10.f,float DecibelNoiseFloor=-40.f,bool bDoNormalize=true,bool bDoAutoRange=false,float AutoRangeAttackTime=0.1f,float AutoRangeReleaseTime=60.f) {}
	public void RemoveSpectralAnalysisDelegate(UObject WorldContextObject,FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP) {}
	public void StartSpectralAnalysis(UObject WorldContextObject,EFFTSize FFTSize=EFFTSize,EFFTPeakInterpolationMethod InterpolationMethod=EFFTPeakInterpolationMethod,EFFTWindowType WindowType=EFFTWindowType,float HopSize=0,EAudioSpectrumType SpectrumType=EAudioSpectrumType) {}
	public void StopSpectralAnalysis(UObject WorldContextObject) {}
	public void SetSubmixOutputVolume(UObject WorldContextObject,float InOutputVolume) {}
	public void SetSubmixWetLevel(UObject WorldContextObject,float InWetLevel) {}
	public void SetSubmixDryLevel(UObject WorldContextObject,float InDryLevel) {}
}
