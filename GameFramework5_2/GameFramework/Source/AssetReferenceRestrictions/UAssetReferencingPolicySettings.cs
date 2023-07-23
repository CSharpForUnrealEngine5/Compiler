#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
///<summary>Settings for the Asset Referencing Policy, these settings are used to determine which plugins and game folders can reference content from each other</summary>
public partial class UAssetReferencingPolicySettings : UDeveloperSettings {
// AssetReferencingPolicySettings
	public FARPDomainSettingsForPlugins EnginePlugins;
	public FARPDomainSettingsForPlugins ProjectPlugins;
	public FARPDefaultProjectDomainRules DefaultProjectContentRule;
	public TArray<FARPDomainDefinitionByContentRoot> AdditionalDomains;
	public TArray<sbyte> GetListOfDomains_All(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetListOfDomains_NoEngine(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetListOfDomains_NoEngineOrGame(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetListOfDomains_NoPluginsOrEngine(TArray<sbyte> ReturnValue) { return default; }
}
