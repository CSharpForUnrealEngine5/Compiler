#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DisplayClusterConfigurationTypes.h")]
public partial class UDisplayClusterConfigurationCluster : UDisplayClusterConfigurationData_Base {
// DisplayClusterConfigurationCluster
	public FDisplayClusterConfigurationPrimaryNode PrimaryNode;
	public FDisplayClusterConfigurationClusterSync Sync;
	public FDisplayClusterConfigurationNetworkSettings Network;
	public FDisplayClusterConfigurationFailoverSettings Failover;
	public TMap<sbyte,UDisplayClusterConfigurationClusterNode> Nodes;
	public TMap<sbyte,UDisplayClusterConfigurationHostDisplayData> HostDisplayData;
	public void GetReferencedMeshNames(TArray<sbyte> OutMeshNames) {}
	public void GetNodeIds(TArray<sbyte> OutNodeIds) {}
	public UObject GetNode(sbyte NodeId,UObject ReturnValue) { return default; }
}
