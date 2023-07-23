#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeProviderWatchdog.h")]
///<summary>Stage event to notify of TimecodeProvider state change</summary>
public partial struct FTimecodeProviderStateEvent {
// TimecodeProviderStateEvent
	public sbyte ProviderName;
	public sbyte ProviderType;
	public FFrameRate FrameRate;
	public ETimecodeProviderSynchronizationState NewState;
}
