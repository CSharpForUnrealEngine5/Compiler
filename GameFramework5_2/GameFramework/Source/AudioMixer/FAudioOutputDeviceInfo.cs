#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
///<summary>Platform audio output device info, in a Blueprint-readable format</summary>
public partial struct FAudioOutputDeviceInfo {
// AudioOutputDeviceInfo
	public sbyte Name;
	public sbyte DeviceId;
	public int NumChannels;
	public int SampleRate;
	public EAudioMixerStreamDataFormatType Format;
	public TArray<EAudioMixerChannelType> OutputChannelArray;
	public bool bIsSystemDefault;
	public bool bIsCurrentDevice;
}
