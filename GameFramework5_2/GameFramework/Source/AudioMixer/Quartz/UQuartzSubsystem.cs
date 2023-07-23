#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Quartz/QuartzSubsystem.h")]
public partial class UQuartzSubsystem : UTickableWorldSubsystem {
// QuartzSubsystem
	public bool IsQuartzEnabled(bool ReturnValue) { return default; }
	public UObject CreateNewClock(UObject WorldContextObject,sbyte ClockName,FQuartzClockSettings InSettings,bool bOverrideSettingsIfClockExists=false,bool bUseAudioEngineClockManager=true,UObject ReturnValue) { return default; }
	public void DeleteClockByName(UObject WorldContextObject,sbyte ClockName) {}
	public void DeleteClockByHandle(UObject WorldContextObject,UObject InClockHandle) {}
	public UObject GetHandleForClock(UObject WorldContextObject,sbyte ClockName,UObject ReturnValue) { return default; }
	public bool DoesClockExist(UObject WorldContextObject,sbyte ClockName,bool ReturnValue) { return default; }
	public bool IsClockRunning(UObject WorldContextObject,sbyte ClockName,bool ReturnValue) { return default; }
	public float GetDurationOfQuantizationTypeInSeconds(UObject WorldContextObject,sbyte ClockName,EQuartzCommandQuantization QuantizationType,float Multiplier=1.0f,float ReturnValue) { return default; }
	public FQuartzTransportTimeStamp GetCurrentClockTimestamp(UObject WorldContextObject,sbyte InClockName,FQuartzTransportTimeStamp ReturnValue) { return default; }
	public float GetEstimatedClockRunTime(UObject WorldContextObject,sbyte InClockName,float ReturnValue) { return default; }
	public float GetGameThreadToAudioRenderThreadAverageLatency(UObject WorldContextObject,float ReturnValue) { return default; }
	public float GetGameThreadToAudioRenderThreadMinLatency(UObject WorldContextObject,float ReturnValue) { return default; }
	public float GetGameThreadToAudioRenderThreadMaxLatency(UObject WorldContextObject,float ReturnValue) { return default; }
	public float GetAudioRenderThreadToGameThreadAverageLatency(float ReturnValue) { return default; }
	public float GetAudioRenderThreadToGameThreadMinLatency(float ReturnValue) { return default; }
	public float GetAudioRenderThreadToGameThreadMaxLatency(float ReturnValue) { return default; }
	public float GetRoundTripAverageLatency(UObject WorldContextObject,float ReturnValue) { return default; }
	public float GetRoundTripMinLatency(UObject WorldContextObject,float ReturnValue) { return default; }
	public float GetRoundTripMaxLatency(UObject WorldContextObject,float ReturnValue) { return default; }
}
