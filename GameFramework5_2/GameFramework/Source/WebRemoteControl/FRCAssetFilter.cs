#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlModels.h")]
public partial struct FRCAssetFilter {
// RCAssetFilter
	public TArray<sbyte> PackageNames;
	public TArray<sbyte> PackagePaths;
	public TArray<sbyte> ClassNames;
	public TSet<sbyte> RecursiveClassesExclusionSet;
	public TArray<sbyte> NativeParentClasses;
	public bool RecursiveClasses;
	public bool RecursivePaths;
	public bool EnableBlueprintNativeClassFiltering;
}
