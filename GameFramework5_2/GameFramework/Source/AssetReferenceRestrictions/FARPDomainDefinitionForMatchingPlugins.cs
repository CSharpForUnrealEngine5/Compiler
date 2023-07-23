#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionForMatchingPlugins {
// ARPDomainDefinitionForMatchingPlugins
	public sbyte DisplayName;
	public sbyte ErrorMessageIfUsedElsewhere;
	public EARPPluginMatchMode MatchRule;
	public sbyte PluginPathPrefix;
	public sbyte PluginCategoryPrefix;
	public TArray<sbyte> CanReferenceTheseDomains;
}
