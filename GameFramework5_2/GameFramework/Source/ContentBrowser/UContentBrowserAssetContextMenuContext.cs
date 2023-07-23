#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserMenuContexts.h")]
public partial class UContentBrowserAssetContextMenuContext : UObject {
// ContentBrowserAssetContextMenuContext
	public UAssetDefinition CommonAssetDefinition;
	public TArray<FAssetData> SelectedAssets;
	public UClass CommonClass;
	public bool bCanBeModified;
	public TArray<UObject> GetSelectedObjects(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> LoadSelectedObjectsIfNeeded(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> LoadSelectedObjects(TSet<sbyte> LoadTags,TArray<UObject> ReturnValue) { return default; }
}
