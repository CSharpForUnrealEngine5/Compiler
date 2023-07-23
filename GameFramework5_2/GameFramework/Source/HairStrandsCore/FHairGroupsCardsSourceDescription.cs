#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetCards.h")]
public partial struct FHairGroupsCardsSourceDescription {
// HairGroupsCardsSourceDescription
	public UMaterialInterface Material;
	public sbyte MaterialSlotName;
	public EHairCardsSourceType SourceType;
	public UStaticMesh ProceduralMesh;
	public sbyte ProceduralMeshKey;
	public UStaticMesh ImportedMesh;
	public FHairGroupsProceduralCards ProceduralSettings;
	public FHairGroupCardsTextures Textures;
	public int GroupIndex;
	public int LODIndex;
	public UHairCardGenerationSettings GenerationSettings;
	public FHairGroupCardsInfo CardsInfo;
	public sbyte ImportedMeshKey;
}
