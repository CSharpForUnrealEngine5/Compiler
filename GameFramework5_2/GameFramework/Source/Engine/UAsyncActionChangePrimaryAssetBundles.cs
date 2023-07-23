#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AsyncActionLoadPrimaryAsset.h")]
public partial class UAsyncActionChangePrimaryAssetBundles : UAsyncActionLoadPrimaryAssetBase {
// AsyncActionChangePrimaryAssetBundles
	public UObject AsyncChangeBundleStateForMatchingPrimaryAssets(UObject WorldContextObject,TArray<sbyte> NewBundles,TArray<sbyte> OldBundles,UObject ReturnValue) { return default; }
	public UObject AsyncChangeBundleStateForPrimaryAssetList(UObject WorldContextObject,TArray<FPrimaryAssetId> PrimaryAssetList,TArray<sbyte> AddBundles,TArray<sbyte> RemoveBundles,UObject ReturnValue) { return default; }
	public FOnPrimaryAssetBundlesChanged Completed;
}
