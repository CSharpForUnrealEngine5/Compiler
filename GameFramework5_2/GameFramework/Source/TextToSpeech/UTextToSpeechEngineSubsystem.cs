#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextToSpeechEngineSubsystem.h")]
///<summary>Subsystem for interacting with the text to speech system via blueprints.</summary>
public partial class UTextToSpeechEngineSubsystem : UEngineSubsystem {
// TextToSpeechEngineSubsystem
	public void SpeakOnChannel(sbyte InChannelId,sbyte InStringToSpeak) {}
	public void StopSpeakingOnChannel(sbyte InChannelId) {}
	public void StopSpeakingOnAllChannels() {}
	public bool IsSpeakingOnChannel(sbyte InChannelId,bool ReturnValue) { return default; }
	public float GetVolumeOnChannel(sbyte InChannelId,float ReturnValue) { return default; }
	public void SetVolumeOnChannel(sbyte InChannelId,float InVolume) {}
	public float GetRateOnChannel(sbyte InChannelId,float ReturnValue) { return default; }
	public void SetRateOnChannel(sbyte InChannelId,float InRate) {}
	public void MuteChannel(sbyte InChannelId) {}
	public void UnmuteChannel(sbyte InChannelId) {}
	public bool IsChannelMuted(sbyte InChannelId,bool ReturnValue) { return default; }
	public void ActivateChannel(sbyte InChannelId) {}
	public void ActivateAllChannels() {}
	public void DeactivateChannel(sbyte InChannelId) {}
	public void DeactivateAllChannels() {}
	public bool IsChannelActive(sbyte InChannelId,bool ReturnValue) { return default; }
	public void AddDefaultChannel(sbyte InNewChannelId) {}
	public void AddCustomChannel(sbyte InNewChannelId) {}
	public void RemoveChannel(sbyte InChannelId) {}
	public void RemoveAllChannels() {}
	public bool DoesChannelExist(sbyte InChannelId,bool ReturnValue) { return default; }
	public int GetNumChannels(int ReturnValue) { return default; }
}
