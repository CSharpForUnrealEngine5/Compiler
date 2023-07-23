#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WindowsTargetSettings.h")]
///<summary>Implements the settings for the Windows target platform. The first instance of this class is initialized in</summary>
public partial class UWindowsTargetSettings : UObject {
// WindowsTargetSettings
	public EDefaultGraphicsRHI DefaultGraphicsRHI;
	public TArray<sbyte> TargetedRHIs_DEPRECATED;
	public TArray<sbyte> D3D12TargetedShaderFormats;
	public TArray<sbyte> D3D11TargetedShaderFormats;
	public TArray<sbyte> VulkanTargetedShaderFormats;
	public ECompilerVersion Compiler;
	public int AudioSampleRate;
	public int AudioCallbackBufferFrameSize;
	public int AudioNumBuffersToEnqueue;
	public int AudioMaxChannels;
	public int AudioNumSourceWorkers;
	public sbyte SpatializationPlugin;
	public sbyte SourceDataOverridePlugin;
	public sbyte ReverbPlugin;
	public sbyte OcclusionPlugin;
	public FPlatformRuntimeAudioCompressionOverrides CompressionOverrides;
	public int CacheSizeKB;
	public int MaxChunkSizeOverrideKB;
	public bool bResampleForDevice;
	public float MaxSampleRate;
	public float HighSampleRate;
	public float MedSampleRate;
	public float LowSampleRate;
	public float MinSampleRate;
	public float CompressionQualityModifier;
	public float AutoStreamingThreshold;
	public int SoundCueCookQualityIndex;
}
