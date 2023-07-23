#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSAssetImportData.h")]
public partial struct FUAssetMeta {
// UAssetMeta
	public sbyte assetID;
	public sbyte assetName;
	public sbyte assetType;
	public sbyte assetSubType;
	public short assetTier;
	public sbyte assetRootPath;
	public TArray<FMeshInfo> meshList;
	public TArray<sbyte> foliageAssetPaths;
	public TArray<FMaterialInstanceInfo> materialInstances;
	public TArray<FTexturesList> textureSets;
	public TArray<FMasterMaterialInfo> masterMaterials;
}
