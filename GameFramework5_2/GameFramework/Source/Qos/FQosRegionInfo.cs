#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosRegionManager.h")]
///<summary>Metadata about regions made up of datacenters</summary>
public partial struct FQosRegionInfo {
// QosRegionInfo
	public sbyte DisplayName;
	public sbyte RegionId;
	public bool bEnabled;
	public bool bVisible;
	public bool bAutoAssignable;
	public bool bAllowSubspaceBias;
	public FQosSubspaceComparisonParams SubspaceBiasParams;
}
