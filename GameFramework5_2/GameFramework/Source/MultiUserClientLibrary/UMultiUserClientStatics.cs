#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MultiUserClientStatics.h")]
public partial class UMultiUserClientStatics : UBlueprintFunctionLibrary {
// MultiUserClientStatics
	public void SetMultiUserPresenceEnabled(bool IsEnabled=true) {}
	public void SetMultiUserPresenceVisibility(sbyte Name,bool Visibility,bool PropagateToAll=false) {}
	public void SetMultiUserPresenceVisibilityById(FGuid ClientEndpointId,bool Visibility,bool PropagateToAll=false) {}
	public FTransform GetMultiUserPresenceTransform(FGuid ClientEndpointId,FTransform ReturnValue) { return default; }
	public void JumpToMultiUserPresence(sbyte OtherUserName,FTransform TransformOffset) {}
	public void UpdateWorkspaceModifiedPackages() {}
	public void PersistMultiUserSessionChanges() {}
	public void PersistSpecifiedPackages(TArray<sbyte> PackagesToPersist) {}
	public TArray<sbyte> GatherSessionChanges(bool IgnorePersisted=true,TArray<sbyte> ReturnValue) { return default; }
	public UObject GetConcertSyncDatabase(UObject ReturnValue) { return default; }
	public FMultiUserClientInfo GetLocalMultiUserClientInfo(FMultiUserClientInfo ReturnValue) { return default; }
	public bool GetMultiUserClientInfoByName(sbyte ClientName,FMultiUserClientInfo ClientInfo,bool ReturnValue) { return default; }
	public bool GetRemoteMultiUserClientInfos(TArray<FMultiUserClientInfo> ClientInfos,bool ReturnValue) { return default; }
	public bool ConfigureMultiUserClient(FMultiUserClientConfig ClientConfig,bool ReturnValue) { return default; }
	public bool StartMultiUserDefaultConnection(bool ReturnValue) { return default; }
	public FMultiUserConnectionError GetLastMultiUserConnectionError(FMultiUserConnectionError ReturnValue) { return default; }
	public EMultiUserConnectionStatus GetMultiUserConnectionStatusDetail(EMultiUserConnectionStatus ReturnValue) { return default; }
	public bool GetMultiUserConnectionStatus(bool ReturnValue) { return default; }
}
