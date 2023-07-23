#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWave.h")]
public partial class USoundWave : USoundBase {
// SoundWave
	public int CompressionQuality;
	public int StreamingPriority;
	public ESoundwaveSampleRateSettings SampleRateQuality;
	public byte SoundGroup;
	public bool bLooping;
	public bool bStreaming;
	public ESoundAssetCompressionType SoundAssetCompressionType;
	public bool bSeekableStreaming;
	public bool bUseBinkAudio;
	public ESoundAssetCompressionType GetSoundAssetCompressionType(ESoundAssetCompressionType ReturnValue) { return default; }
	public void SetSoundAssetCompressionType(ESoundAssetCompressionType InSoundAssetCompressionType,bool bMarkDirty=true) {}
	public USoundWave OverrideSoundToUseForAnalysis;
	public bool TreatFileAsLoopingForAnalysis;
	public bool bEnableBakedFFTAnalysis;
	public bool bEnableAmplitudeEnvelopeAnalysis;
	public ESoundWaveFFTSize FFTSize;
	public int FFTAnalysisFrameSize;
	public int FFTAnalysisAttackTime;
	public int FFTAnalysisReleaseTime;
	public int EnvelopeFollowerFrameSize;
	public int EnvelopeFollowerAttackTime;
	public int EnvelopeFollowerReleaseTime;
	public FSoundModulationDefaultRoutingSettings ModulationSettings;
	public TArray<float> FrequenciesToAnalyze;
	public TArray<FSoundWaveSpectralTimeData> CookedSpectralTimeData;
	public TArray<FSoundWaveEnvelopeTimeData> CookedEnvelopeTimeData;
	public int InitialChunkSize;
	public bool bMature;
	public bool bManualWordWrap;
	public bool bSingleLine;
	public bool bVirtualizeWhenSilent_DEPRECATED;
	public bool bIsAmbisonics;
	public ESoundWaveLoadingBehavior LoadingBehavior;
	public sbyte SpokenText_DEPRECATED;
	public float SubtitlePriority;
	public float Volume;
	public float Pitch;
	public int NumChannels;
	public TArray<FSoundWaveCuePoint> CuePoints;
	public TArray<int> ChannelOffsets;
	public TArray<int> ChannelSizes;
	public int SampleRate;
	public int ImportedSampleRate;
	public TArray<FSubtitleCue> Subtitles;
	public sbyte Comment;
	public FSoundWaveTimecodeInfo TimecodeInfo;
	public sbyte SourceFilePath_DEPRECATED;
	public sbyte SourceFileTimestamp_DEPRECATED;
	public UAssetImportData AssetImportData;
	public UCurveTable Curves;
	public UCurveTable InternalCurves;
	public TArray<UWaveformTransformationBase> Transformations;
}
