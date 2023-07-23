#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SlateScreenReaderEngineSubsystem.h")]
///<summary>The engine subsystem for the Slate screen reader.</summary>
public partial class USlateScreenReaderEngineSubsystem : UEngineSubsystem {
// SlateScreenReaderEngineSubsystem
	public void ActivateScreenReader() {}
	public void DeactivateScreenReader() {}
	public bool IsScreenReaderActive(bool ReturnValue) { return default; }
	public FScreenReaderReply ActivateUser(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply DeactivateUser(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply RegisterUser(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply UnregisterUser(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public bool IsUserRegistered(int InUserId,bool ReturnValue) { return default; }
	public FScreenReaderReply RequestSpeak(int InUserId,FScreenReaderAnnouncement InAnnouncement,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply RequestSpeakFocusedWidget(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply StopSpeaking(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public bool IsSpeaking(int InUserId,bool ReturnValue) { return default; }
	public float GetSpeechVolume(int InUserId,float ReturnValue) { return default; }
	public FScreenReaderReply SetSpeechVolume(int InUserId,float InVolume,FScreenReaderReply ReturnValue) { return default; }
	public float GetSpeechRate(int InUserId,float ReturnValue) { return default; }
	public FScreenReaderReply SetSpeechRate(int InUserId,float InRate,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply MuteSpeech(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public FScreenReaderReply UnmuteSpeech(int InUserId,FScreenReaderReply ReturnValue) { return default; }
	public bool IsSpeechMuted(int InUserId,bool ReturnValue) { return default; }
}
