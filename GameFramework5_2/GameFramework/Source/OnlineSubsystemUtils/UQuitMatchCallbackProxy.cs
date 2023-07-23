#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QuitMatchCallbackProxy.h")]
public partial class UQuitMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
// QuitMatchCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject QuitMatch(UObject WorldContextObject,UObject PlayerController,sbyte MatchID,EMPMatchOutcome Outcome,int TurnTimeoutInSeconds,UObject ReturnValue) { return default; }
}
