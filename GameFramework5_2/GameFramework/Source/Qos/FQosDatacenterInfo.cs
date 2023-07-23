#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosRegionManager.h")]
///<summary>Metadata about datacenters that can be queried</summary>
public partial struct FQosDatacenterInfo {
// QosDatacenterInfo
	public sbyte Id;
	public sbyte RegionId;
	public bool bEnabled;
	public TArray<FQosPingServerInfo> Servers;
}
