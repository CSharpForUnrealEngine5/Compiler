#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/IDisplayClusterBlueprintAPI.h")]
public partial class UDisplayClusterBlueprintAPI : UInterface {
// DisplayClusterBlueprintAPI
	public bool IsModuleInitialized(bool ReturnValue) { return default; }
	public EDisplayClusterOperationMode GetOperationMode(EDisplayClusterOperationMode ReturnValue) { return default; }
	public UObject GetRootActor(UObject ReturnValue) { return default; }
	public sbyte GetNodeId(sbyte ReturnValue) { return default; }
	public void GetActiveNodeIds(TArray<sbyte> OutNodeIds) {}
	public int GetActiveNodesAmount(int ReturnValue) { return default; }
	public bool IsPrimary(bool ReturnValue) { return default; }
	public bool IsSecondary(bool ReturnValue) { return default; }
	public bool IsBackup(bool ReturnValue) { return default; }
	public EDisplayClusterNodeRole GetClusterRole(EDisplayClusterNodeRole ReturnValue) { return default; }
	public void AddClusterEventListener(object /*Listener*/ Listener) {}
	public void RemoveClusterEventListener(object /*Listener*/ Listener) {}
	public void EmitClusterEventJson(FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	public void EmitClusterEventBinary(FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
	public void SendClusterEventJsonTo(sbyte Address,int Port,FDisplayClusterClusterEventJson Event,bool bPrimaryOnly) {}
	public void SendClusterEventBinaryTo(sbyte Address,int Port,FDisplayClusterClusterEventBinary Event,bool bPrimaryOnly) {}
}
