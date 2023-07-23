#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PluginMetadataObject.h")]
///<summary>We use this object to display plugin properties using details view.</summary>
public partial class UPluginMetadataObject : UObject {
// PluginMetadataObject
	public int Version;
	public sbyte VersionName;
	public sbyte FriendlyName;
	public sbyte Description;
	public sbyte Category;
	public sbyte CreatedBy;
	public sbyte CreatedByURL;
	public sbyte DocsURL;
	public sbyte MarketplaceURL;
	public sbyte SupportURL;
	public bool bCanContainContent;
	public bool bIsBetaVersion;
	public bool bIsEnabledByDefault;
	public bool bExplicitlyLoaded;
	public TArray<FPluginReferenceMetadata> Plugins;
	public TArray<sbyte> GetAvailablePluginDependencies(TArray<sbyte> ReturnValue) { return default; }
}
