#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetRegistry/AssetRegistryHelpers.h")]
public partial class UAssetRegistryHelpers : UObject {
// AssetRegistryHelpers
	public object /*ReturnValue*/ GetAssetRegistry(object /*ReturnValue*/ ReturnValue) { return default; }
	public FAssetData CreateAssetData(UObject InAsset,bool bAllowBlueprintClass=false,FAssetData ReturnValue) { return default; }
	public bool IsValid(FAssetData InAssetData,bool ReturnValue) { return default; }
	public bool IsUAsset(FAssetData InAssetData,bool ReturnValue) { return default; }
	public bool IsRedirector(FAssetData InAssetData,bool ReturnValue) { return default; }
	public sbyte GetFullName(FAssetData InAssetData,sbyte ReturnValue) { return default; }
	public FSoftObjectPath ToSoftObjectPath(FAssetData InAssetData,FSoftObjectPath ReturnValue) { return default; }
	public UClass GetClass(FAssetData InAssetData,UClass ReturnValue) { return default; }
	public UObject GetAsset(FAssetData InAssetData,UObject ReturnValue) { return default; }
	public bool IsAssetLoaded(FAssetData InAssetData,bool ReturnValue) { return default; }
	public sbyte GetExportTextName(FAssetData InAssetData,sbyte ReturnValue) { return default; }
	public bool GetTagValue(FAssetData InAssetData,sbyte InTagName,sbyte OutTagValue,bool ReturnValue) { return default; }
	public FARFilter SetFilterTagsAndValues(FARFilter InFilter,TArray<FTagAndValue> InTagsAndValues,FARFilter ReturnValue) { return default; }
	public void GetBlueprintAssets(FARFilter InFilter,TArray<FAssetData> OutAssetData) {}
	public UClass FindAssetNativeClass(FAssetData AssetData,UClass ReturnValue) { return default; }
}
