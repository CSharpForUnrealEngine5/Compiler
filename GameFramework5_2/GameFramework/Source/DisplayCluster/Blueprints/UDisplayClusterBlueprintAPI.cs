#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IDisplayClusterBlueprintAPI.h")]
public partial class UDisplayClusterBlueprintAPI : UInterface {
// DisplayClusterBlueprintAPI
	public bool IsModuleInitialized() { return default; }
	public EDisplayClusterOperationMode GetOperationMode() { return default; }
	public UObject GetRootActor() { return default; }
	public string GetNodeId() { return default; }
	public void GetActiveNodeIds(TArray<string> OutNodeIds) {}
	public int GetActiveNodesAmount() { return default; }
	public bool IsPrimary() { return default; }
	public bool IsSecondary() { return default; }
	public bool IsBackup() { return default; }
	public EDisplayClusterNodeRole GetClusterRole() { return default; }
	public void AddClusterEventListener(object /*Listener*/ Listener) {}
	public void RemoveClusterEventListener(object /*Listener*/ Listener) {}
	public void EmitClusterEventJson(FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	public void EmitClusterEventBinary(FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
	public void SendClusterEventJsonTo(string Address,int Port,FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	public void SendClusterEventBinaryTo(string Address,int Port,FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
}
