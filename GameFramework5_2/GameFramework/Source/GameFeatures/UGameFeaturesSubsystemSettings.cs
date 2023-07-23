#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFeaturesSubsystemSettings.h")]
///<summary>Settings for the Game Features framework</summary>
public partial class UGameFeaturesSubsystemSettings : UDeveloperSettings {
// GameFeaturesSubsystemSettings
	public FSoftClassPath GameFeaturesManagerClassName;
	public TArray<sbyte> DisabledPlugins;
	public TArray<sbyte> AdditionalPluginMetadataKeys;
}
