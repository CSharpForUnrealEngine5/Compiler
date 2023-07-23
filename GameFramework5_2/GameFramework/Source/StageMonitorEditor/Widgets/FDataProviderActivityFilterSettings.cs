#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/SDataProviderActivityFilter.h")]
///<summary>Filter settings used live and also load/saved to ini config</summary>
public partial struct FDataProviderActivityFilterSettings {
// DataProviderActivityFilterSettings
	public TArray<UScriptStruct> ExistingPeriodicTypes;
	public TArray<UScriptStruct> RestrictedTypes;
	public TArray<sbyte> RestrictedProviders;
	public TArray<sbyte> RestrictedRoles;
	public TArray<sbyte> RestrictedSources;
	public bool bEnableCriticalStateFilter;
	public bool bEnableTimeFilter;
	public uint MaxMessageAgeInMinutes;
}
