#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSettings.h")]
public partial struct FVisualLoggerFiltersData {
// VisualLoggerFiltersData
	public sbyte SearchBoxFilter;
	public sbyte ObjectNameFilter;
	public TArray<FCategoryFilter> Categories;
	public TArray<sbyte> SelectedClasses;
}
