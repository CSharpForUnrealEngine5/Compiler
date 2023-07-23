#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDAssetCache2.h")]
///<summary>Owns the assets generated and reused by USD Stages, allowing thread-safe retrieval/storage.</summary>
public partial class UUsdAssetCache2 : UObject {
// UsdAssetCache2
	public double UnreferencedAssetStorageSizeMB;
	public double PersistentAssetStorageSizeMB;
	public void CacheAsset(sbyte Hash,UObject Asset,UObject Referencer=nullptr) {}
	public bool CanRemoveAsset(sbyte Hash,bool ReturnValue) { return default; }
	public UObject RemoveAsset(sbyte Hash,UObject ReturnValue) { return default; }
	public UObject GetCachedAsset(sbyte Hash,UObject ReturnValue) { return default; }
	public bool AddAssetReference(UObject Asset,UObject Referencer,bool ReturnValue) { return default; }
	public bool RemoveAssetReference(UObject Asset,UObject Referencer,bool ReturnValue) { return default; }
	public bool RemoveAllAssetReferences(UObject Referencer,bool ReturnValue) { return default; }
	public sbyte GetHashForAsset(UObject Asset,sbyte ReturnValue) { return default; }
	public bool IsAssetOwnedByCache(sbyte AssetPath,bool ReturnValue) { return default; }
	public int GetNumAssets(int ReturnValue) { return default; }
	public TArray<sbyte> GetAllAssetHashes(TArray<sbyte> ReturnValue) { return default; }
	public TArray<UObject> GetAllLoadedAssets(TArray<UObject> ReturnValue) { return default; }
	public TArray<sbyte> GetAllCachedAssetPaths(TArray<sbyte> ReturnValue) { return default; }
	public void Reset() {}
	public void RefreshStorage() {}
	public TMap<sbyte,UObject> AssetStorage;
}
