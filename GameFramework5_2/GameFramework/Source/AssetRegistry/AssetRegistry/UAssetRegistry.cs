#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/IAssetRegistry.h")]
public partial class UAssetRegistry : UInterface {
// AssetRegistry
	public bool HasAssets(sbyte PackagePath,bool bRecursive=false,bool ReturnValue) { return default; }
	public bool GetAssetsByPackageName(sbyte PackageName,TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets=false,bool bSkipARFilteredAssets=true,bool ReturnValue) { return default; }
	public bool GetAssetsByPath(sbyte PackagePath,TArray<FAssetData> OutAssetData,bool bRecursive=false,bool bIncludeOnlyOnDiskAssets=false,bool ReturnValue) { return default; }
	public bool GetAssetsByPaths(TArray<sbyte> PackagePaths,TArray<FAssetData> OutAssetData,bool bRecursive=false,bool bIncludeOnlyOnDiskAssets=false,bool ReturnValue) { return default; }
	public bool GetAssetsByClass(FTopLevelAssetPath ClassPathName,TArray<FAssetData> OutAssetData,bool bSearchSubClasses=false,bool ReturnValue) { return default; }
	public bool GetAssets(FARFilter Filter,TArray<FAssetData> OutAssetData,bool bSkipARFilteredAssets=true,bool ReturnValue) { return default; }
	public FAssetData GetAssetByObjectPath(sbyte ObjectPath,bool bIncludeOnlyOnDiskAssets=false,FAssetData ReturnValue) { return default; }
	public FAssetData K2_GetAssetByObjectPath(FSoftObjectPath ObjectPath,bool bIncludeOnlyOnDiskAssets=false,FAssetData ReturnValue) { return default; }
	public bool GetAllAssets(TArray<FAssetData> OutAssetData,bool bIncludeOnlyOnDiskAssets=false,bool ReturnValue) { return default; }
	public bool K2_GetDependencies(sbyte PackageName,FAssetRegistryDependencyOptions DependencyOptions,TArray<sbyte> OutDependencies,bool ReturnValue) { return default; }
	public bool K2_GetReferencers(sbyte PackageName,FAssetRegistryDependencyOptions ReferenceOptions,TArray<sbyte> OutReferencers,bool ReturnValue) { return default; }
	public bool GetAncestorClassNames(FTopLevelAssetPath ClassPathName,TArray<FTopLevelAssetPath> OutAncestorClassNames,bool ReturnValue) { return default; }
	public void GetDerivedClassNames(TArray<FTopLevelAssetPath> ClassNames,TSet<FTopLevelAssetPath> ExcludedClassNames,TSet<FTopLevelAssetPath> OutDerivedClassNames) {}
	public void GetAllCachedPaths(TArray<sbyte> OutPathList) {}
	public void GetSubPaths(sbyte InBasePath,TArray<sbyte> OutPathList,bool bInRecurse) {}
	public void RunAssetsThroughFilter(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	public void UseFilterToExcludeAssets(TArray<FAssetData> AssetDataList,FARFilter Filter) {}
	public void ScanPathsSynchronous(TArray<sbyte> InPaths,bool bForceRescan=false,bool bIgnoreDenyListScanFilters=false) {}
	public void ScanFilesSynchronous(TArray<sbyte> InFilePaths,bool bForceRescan=false) {}
	public void SearchAllAssets(bool bSynchronousSearch) {}
	public bool IsSearchAllAssets(bool ReturnValue) { return default; }
	public bool IsSearchAsync(bool ReturnValue) { return default; }
	public void WaitForCompletion() {}
	public void WaitForPackage(sbyte PackageName) {}
	public void PrioritizeSearchPath(sbyte PathToPrioritize) {}
	public void ScanModifiedAssetFiles(TArray<sbyte> InFilePaths) {}
	public bool IsLoadingAssets(bool ReturnValue) { return default; }
}
