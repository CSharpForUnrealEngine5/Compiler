#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A struct to serve as a filter for Asset Registry queries. (mirrored in ARFilter.h)</summary>
public partial struct FARFilter {
// ARFilter
	public TArray<sbyte> PackageNames;
	public TArray<sbyte> PackagePaths;
	public TArray<sbyte> ObjectPaths;
	public TArray<FSoftObjectPath> SoftObjectPaths;
	public TArray<sbyte> ClassNames;
	public TArray<FTopLevelAssetPath> ClassPaths;
	public TSet<sbyte> RecursiveClassesExclusionSet;
	public TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet;
	public bool bRecursivePaths;
	public bool bRecursiveClasses;
	public bool bIncludeOnlyOnDiskAssets;
}
