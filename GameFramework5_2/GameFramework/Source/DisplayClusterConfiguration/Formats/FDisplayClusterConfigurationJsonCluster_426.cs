#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Formats/JSON426/DisplayClusterConfigurationJsonTypes_426.h")]
public partial struct FDisplayClusterConfigurationJsonCluster_426 {
// DisplayClusterConfigurationJsonCluster_426
	public FDisplayClusterConfigurationJsonPrimaryNode_426 MasterNode;
	public FDisplayClusterConfigurationJsonClusterSync_426 Sync;
	public TMap<sbyte,sbyte> Network;
	public TMap<sbyte,FDisplayClusterConfigurationJsonClusterNode_426> Nodes;
}
