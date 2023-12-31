#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkinnedAssetCommon.h")]
///<summary>Struct containing information for a particular LOD level, such as materials and info for when to use it.</summary>
public partial struct FSkeletalMeshLODInfo {
// SkeletalMeshLODInfo
	public FPerPlatformFloat ScreenSize;
	public float LODHysteresis;
	public TArray<int> LODMaterialMap;
	public TArray<bool> bEnableShadowCasting_DEPRECATED;
	public TArray<string> RemovedBones_DEPRECATED;
	public FSkeletalMeshBuildSettings BuildSettings;
	public FSkeletalMeshOptimizationSettings ReductionSettings;
	public TArray<FBoneReference> BonesToRemove;
	public TArray<FBoneReference> BonesToPrioritize;
	public TArray<FSectionReference> SectionsToPrioritize;
	public float WeightOfPrioritization;
	public UAnimSequence BakePose;
	public UAnimSequence BakePoseOverride;
	public string SourceImportFilename;
	public ESkinCacheUsage SkinCacheUsage;
	public float MorphTargetPositionErrorTolerance;
	public bool bHasBeenSimplified;
	public bool bHasPerLODVertexColors;
	public bool bAllowCPUAccess;
	public bool bSupportUniformlyDistributedSampling;
	public bool bImportWithBaseMesh;
}
