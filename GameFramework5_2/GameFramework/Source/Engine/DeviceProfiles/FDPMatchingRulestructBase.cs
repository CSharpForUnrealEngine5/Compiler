#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfileMatching.h")]
public partial struct FDPMatchingRulestructBase {
// DPMatchingRulestructBase
	public sbyte RuleName;
	public TArray<FDPMatchingIfCondition> IfConditions;
	public sbyte AppendFragments;
	public sbyte SetUserVar;
}
