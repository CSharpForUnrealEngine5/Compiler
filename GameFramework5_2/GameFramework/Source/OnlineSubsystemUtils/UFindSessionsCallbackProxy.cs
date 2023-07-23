#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FindSessionsCallbackProxy.h")]
public partial class UFindSessionsCallbackProxy : UOnlineBlueprintCallProxyBase {
// FindSessionsCallbackProxy
	public FBlueprintFindSessionsResultDelegate OnSuccess;
	public FBlueprintFindSessionsResultDelegate OnFailure;
	public UObject FindSessions(UObject WorldContextObject,UObject PlayerController,int MaxResults,bool bUseLAN,UObject ReturnValue) { return default; }
	public int GetPingInMs(FBlueprintSessionResult Result,int ReturnValue) { return default; }
	public sbyte GetServerName(FBlueprintSessionResult Result,sbyte ReturnValue) { return default; }
	public int GetCurrentPlayers(FBlueprintSessionResult Result,int ReturnValue) { return default; }
	public int GetMaxPlayers(FBlueprintSessionResult Result,int ReturnValue) { return default; }
}
