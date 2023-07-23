#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataFilter.h")]
///<summary>Data used to filter object instances by their package.</summary>
public partial struct FContentBrowserDataPackageFilter {
// ContentBrowserDataPackageFilter
	public TArray<sbyte> PackageNamesToInclude;
	public TArray<sbyte> PackageNamesToExclude;
	public TArray<sbyte> PackagePathsToInclude;
	public TArray<sbyte> PackagePathsToExclude;
	public bool bRecursivePackagePathsToInclude;
	public bool bRecursivePackagePathsToExclude;
}
