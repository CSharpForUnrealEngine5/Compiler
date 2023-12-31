#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EndMatchCallbackProxy.h")]
public partial class UEndMatchCallbackProxy : UOnlineBlueprintCallProxyBase {
// EndMatchCallbackProxy
	public FEmptyOnlineDelegate OnSuccess;
	public FEmptyOnlineDelegate OnFailure;
	public UObject EndMatch(UObject WorldContextObject,UObject PlayerController,object /*MatchActor*/ MatchActor,string MatchID,EMPMatchOutcome LocalPlayerOutcome,EMPMatchOutcome OtherPlayersOutcome) { return default; }
}
