#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCServer.h")]
public partial class UOSCServer : UObject {
// OSCServer
	public bool GetMulticastLoopback(bool ReturnValue) { return default; }
	public bool IsActive(bool ReturnValue) { return default; }
	public void Listen() {}
	public bool SetAddress(sbyte ReceiveIPAddress,int Port,bool ReturnValue) { return default; }
	public void SetMulticastLoopback(bool bMulticastLoopback) {}
	public void Stop() {}
	public FOSCReceivedMessageEvent OnOscMessageReceived;
	public FOSCReceivedBundleEvent OnOscBundleReceived;
	public void SetAllowlistClientsEnabled(bool bEnabled) {}
	public void AddAllowlistedClient(sbyte IPAddress) {}
	public void RemoveAllowlistedClient(sbyte IPAddress) {}
	public void ClearAllowlistedClients() {}
	public sbyte GetIpAddress(bool bIncludePort,sbyte ReturnValue) { return default; }
	public int GetPort(int ReturnValue) { return default; }
	public TSet<sbyte> GetAllowlistedClients(TSet<sbyte> ReturnValue) { return default; }
	public void BindEventToOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	public void UnbindEventFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern,FOSCDispatchMessageEventBP Event) {}
	public void UnbindAllEventsFromOnOSCAddressPatternMatchesPath(FOSCAddress OSCAddressPattern) {}
	public void UnbindAllEventsFromOnOSCAddressPatternMatching() {}
	public TArray<FOSCAddress> GetBoundOSCAddressPatterns(TArray<FOSCAddress> ReturnValue) { return default; }
	public void SetTickInEditor(bool bInTickInEditor) {}
}
