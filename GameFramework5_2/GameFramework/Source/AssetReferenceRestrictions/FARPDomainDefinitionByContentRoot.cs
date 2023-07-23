#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionByContentRoot {
// ARPDomainDefinitionByContentRoot
	public sbyte DomainName;
	public sbyte DomainDisplayName;
	public sbyte ErrorMessageIfUsedElsewhere;
	public TArray<FDirectoryPath> ContentRoots;
	public TArray<sbyte> SpecificAssets;
	public EARPDomainAllowedToReferenceMode ReferenceMode;
	public TArray<sbyte> CanReferenceTheseDomains;
}
