#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDefaultPluginDomainRules {
// ARPDefaultPluginDomainRules
	public TArray<sbyte> CanReferenceTheseDomains;
	public bool bCanProjectAccessThesePlugins;
	public bool bCanBeSeenByOtherDomainsWithoutDependency;
}
