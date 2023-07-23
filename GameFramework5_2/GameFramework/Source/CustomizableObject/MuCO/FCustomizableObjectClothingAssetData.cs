#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectClothingTypes.h")]
public partial struct FCustomizableObjectClothingAssetData {
// CustomizableObjectClothingAssetData
	public TArray<FClothLODDataCommon> LodData;
	public TArray<int> LodMap;
	public TArray<sbyte> UsedBoneNames;
	public TArray<int> UsedBoneIndices;
	public int ReferenceBoneIndex;
	public TArray<FCustomizableObjectClothConfigData> ConfigsData;
	public sbyte PhysicsAssetPath;
	public sbyte Name;
	public FGuid OriginalAssetGuid;
}
