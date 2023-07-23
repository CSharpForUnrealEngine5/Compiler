#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/FilterBarConfig.h")]
public partial struct FFilterBarSettings {
// FilterBarSettings
	public TMap<sbyte,bool> CustomFilters;
	public TMap<sbyte,bool> TypeFilters;
	public TArray<FCustomTextFilterState> CustomTextFilters;
	public bool bIsLayoutSaved;
	public EFilterBarLayout FilterBarLayout;
}
