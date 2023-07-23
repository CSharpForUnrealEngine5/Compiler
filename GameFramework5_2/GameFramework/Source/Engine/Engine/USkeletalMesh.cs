#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SkeletalMesh.h")]
///<summary>SkeletalMesh is geometry bound to a hierarchical skeleton of bones which can be animated for the purpose of deforming the mesh.</summary>
public partial class USkeletalMesh : USkinnedAsset {
// SkeletalMesh
	public USkeletalMeshEditorData MeshEditorDataObject;
	public USkeleton Skeleton;
	public UObject GetSkeleton(UObject ReturnValue) { return default; }
	public void SetSkeleton(UObject InSkeleton) {}
	public FBoxSphereBounds ImportedBounds;
	public FBoxSphereBounds ExtendedBounds;
	public FVector PositiveBoundsExtension;
	public FVector NegativeBoundsExtension;
	public FBoxSphereBounds GetBounds(FBoxSphereBounds ReturnValue) { return default; }
	public FBoxSphereBounds GetImportedBounds(FBoxSphereBounds ReturnValue) { return default; }
	public TArray<FSkeletalMaterial> Materials;
	public TArray<FSkeletalMaterial> GetMaterials(TArray<FSkeletalMaterial> ReturnValue) { return default; }
	public void SetMaterials(TArray<FSkeletalMaterial> InMaterials) {}
	public TArray<FBoneMirrorInfo> SkelMirrorTable;
	public TArray<FSkeletalMeshLODInfo> LODInfo;
	public FPerQualityLevelInt MinQualityLevelLOD;
	public void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default=-1) {}
	public void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	public FPerPlatformInt MinLod;
	public FPerPlatformBool DisableBelowMinLodStripping;
	public bool bOverrideLODStreamingSettings;
	public FPerPlatformBool bSupportLODStreaming;
	public FPerPlatformInt MaxNumStreamedLODs;
	public FPerPlatformInt MaxNumOptionalLODs;
	public USkeletalMeshLODSettings LODSettings;
	public TSoftObjectPtr<UObject> DefaultAnimatingRig;
	public UObject GetLODSettings(UObject ReturnValue) { return default; }
	public void SetLODSettings(UObject InLODSettings) {}
	public void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig) {}
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRig(TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public byte SkelMirrorAxis;
	public byte SkelMirrorFlipAxis;
	public bool bUseFullPrecisionUVs_DEPRECATED;
	public bool bUseHighPrecisionTangentBasis_DEPRECATED;
	public bool bHasBeenSimplified;
	public bool bHasVertexColors;
	public bool bEnablePerPolyCollision;
	public FGuid VertexColorGuid;
	public UBodySetup BodySetup;
	public UPhysicsAsset PhysicsAsset;
	public UObject GetPhysicsAsset(UObject ReturnValue) { return default; }
	public UPhysicsAsset ShadowPhysicsAsset;
	public UObject GetShadowPhysicsAsset(UObject ReturnValue) { return default; }
	public TArray<UNodeMappingContainer> NodeMappingData;
	public TArray<UObject> GetNodeMappingData(TArray<UObject> ReturnValue) { return default; }
	public UObject GetNodeMappingContainer(UObject SourceAsset,UObject ReturnValue) { return default; }
	public UAssetImportData AssetImportData;
	public sbyte SourceFilePath_DEPRECATED;
	public sbyte SourceFileTimestamp_DEPRECATED;
	public UThumbnailInfo ThumbnailInfo;
	public bool bHasCustomDefaultEditorCamera;
	public FVector DefaultEditorCameraLocation;
	public FRotator DefaultEditorCameraRotation;
	public FVector DefaultEditorCameraLookAt;
	public float DefaultEditorCameraOrthoZoom;
	public FPreviewAssetAttachContainer PreviewAttachedAssetContainer;
	public bool bSupportRayTracing;
	public int RayTracingMinLOD;
	public EClothLODBiasMode ClothLODBiasMode;
	public TArray<UMorphTarget> MorphTargets;
	public TArray<UObject> GetMorphTargetsPtrConv(TArray<UObject> ReturnValue) { return default; }
	public void SetMorphTargets(TArray<UObject> InMorphTargets) {}
	public TArray<sbyte> K2_GetAllMorphTargetNames(TArray<sbyte> ReturnValue) { return default; }
	public float FloorOffset;
	public TArray<FTransform> RetargetBasePose;
	public TArray<FClothingAssetData_Legacy> ClothingAssets_DEPRECATED;
	public UClass PostProcessAnimBlueprint;
	public TArray<UClothingAssetBase> MeshClothingAssets;
	public TArray<UObject> GetMeshClothingAssets(TArray<UObject> ReturnValue) { return default; }
	public void SetMeshClothingAssets(TArray<UObject> InMeshClothingAssets) {}
	public FSkeletalMeshSamplingInfo SamplingInfo;
	public TArray<UAssetUserData> AssetUserData;
	public TArray<USkeletalMeshSocket> Sockets;
	public void AddSocket(UObject InSocket,bool bAddToSkeleton=false) {}
	public UObject FindSocketAndIndex(sbyte InSocketName,int OutIndex,UObject ReturnValue) { return default; }
	public int NumSockets(int ReturnValue) { return default; }
	public UObject GetSocketByIndex(int Index,UObject ReturnValue) { return default; }
	public bool IsSectionUsingCloth(int InSectionIndex,bool bCheckCorrespondingSections=true,bool ReturnValue) { return default; }
	public TArray<FSkinWeightProfileInfo> SkinWeightProfiles;
	public UMeshDeformer DefaultMeshDeformer;
}
