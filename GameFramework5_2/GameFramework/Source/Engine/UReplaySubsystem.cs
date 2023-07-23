#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReplaySubsystem.h")]
public partial class UReplaySubsystem : UGameInstanceSubsystem {
// ReplaySubsystem
	public sbyte GetActiveReplayName(sbyte ReturnValue) { return default; }
	public float GetReplayCurrentTime(float ReturnValue) { return default; }
	public bool IsRecording(bool ReturnValue) { return default; }
	public bool IsPlaying(bool ReturnValue) { return default; }
	public void RequestCheckpoint() {}
	public bool bLoadDefaultMapOnStop;
}
