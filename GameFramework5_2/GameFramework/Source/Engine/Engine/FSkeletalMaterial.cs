#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAssetCommon.h")]
public partial struct FSkeletalMaterial {
// SkeletalMaterial
	public UMaterialInterface MaterialInterface;
	public sbyte MaterialSlotName;
	public bool bEnableShadowCasting_DEPRECATED;
	public bool bRecomputeTangent_DEPRECATED;
	public sbyte ImportedMaterialSlotName;
	public FMeshUVChannelInfo UVChannelData;
}
