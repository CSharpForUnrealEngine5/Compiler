#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON500/DisplayClusterConfigurationJsonTypes_500.h")]
public partial struct FDisplayClusterConfigurationJsonCluster_500 {
// DisplayClusterConfigurationJsonCluster_500
	public FDisplayClusterConfigurationJsonPrimaryNode_500 PrimaryNode;
	public FDisplayClusterConfigurationJsonClusterSync_500 Sync;
	public TMap<sbyte,sbyte> Network;
	public FDisplayClusterConfigurationFailoverSettings_500 Failover;
	public TMap<sbyte,FDisplayClusterConfigurationJsonClusterNode_500> Nodes;
}
