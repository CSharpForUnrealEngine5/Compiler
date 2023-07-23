#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DatasmithScene.h")]
public partial class UDatasmithScene : UObject {
// DatasmithScene
	public UDatasmithSceneImportData AssetImportData;
	public int BulkDataVersion;
	public TMap<sbyte,TSoftObjectPtr<UStaticMesh>> StaticMeshes;
	public TMap<sbyte,TSoftObjectPtr<UObject>> Clothes;
	public TMap<sbyte,TSoftObjectPtr<UTexture>> Textures;
	public TMap<sbyte,TSoftObjectPtr<UMaterialFunction>> MaterialFunctions;
	public TMap<sbyte,TSoftObjectPtr<UMaterialInterface>> Materials;
	public TMap<sbyte,TSoftObjectPtr<ULevelSequence>> LevelSequences;
	public TMap<sbyte,TSoftObjectPtr<ULevelVariantSets>> LevelVariantSets;
	public TArray<UAssetUserData> AssetUserData;
}
