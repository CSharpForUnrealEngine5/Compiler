#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial class UCustomizableObject : UObject {
// CustomizableObject
	public USkeletalMesh ReferenceSkeletalMesh_DEPRECATED;
	public TArray<USkeletalMesh> ReferenceSkeletalMeshes;
	public TArray<FMutableRefSkeletalMeshData> ReferenceSkeletalMeshesData;
	public UStaticMesh ReferenceStaticMesh;
	public TArray<TSoftObjectPtr<UMaterialInterface>> ReferencedMaterials;
	public TArray<sbyte> ReferencedMaterialSlotNames;
	public TArray<TSoftObjectPtr<USkeleton>> ReferencedSkeletons;
	public FMutableLODSettings LODSettings;
	public TArray<FMutableModelImageProperties> ImageProperties;
	public TArray<FMorphTargetInfo> ContributingMorphTargetsInfo;
	public TArray<FMorphTargetVertexData> MorphTargetReconstructionData;
	public TArray<FCustomizableObjectClothConfigData> ClothSharedConfigsData;
	public TArray<FCustomizableObjectClothingAssetData> ContributingClothingAssetsData;
	public TArray<FCustomizableObjectMeshToMeshVertData> ClothMeshToMeshVertData;
	public TArray<FMutableSkinWeightProfileInfo> SkinWeightProfilesInfo;
	public ECustomizableObjectRelevancy Relevancy;
	public FCompilationOptions CompileOptions;
	public bool bDisableTextureLayoutManagement;
	public bool bEnableRealTimeMorphTargets;
	public bool bEnableClothing;
	public bool bEnable16BitBoneWeights;
	public bool bEnableAltSkinWeightProfiles;
	public bool bEnablePhysicsAssetMerge;
	public EMutableCompileMeshType MeshCompileType;
	public TArray<TSoftObjectPtr<UCustomizableObject>> WorkingSet;
	public UEdGraph Source;
	public FGuid VersionId;
	public TSet<FGuid> CustomizableObjectGuidsInCompilation;
	public TMap<sbyte,sbyte> CustomizableObjectPathMap;
	public TMap<sbyte,FCustomizableObjectIdPair> GroupNodeMap;
	public TArray<FProfileParameterDat> InstancePropertiesProfiles;
	public int NumMeshComponentsInRoot;
	public int GetComponentCount(int ReturnValue) { return default; }
	public int GetParameterCount(int ReturnValue) { return default; }
	public int FindParameter(sbyte Name,int ReturnValue) { return default; }
	public EMutableParameterType GetParameterType(int ParamIndex,EMutableParameterType ReturnValue) { return default; }
	public EMutableParameterType GetParameterTypeByName(sbyte Name,EMutableParameterType ReturnValue) { return default; }
	public sbyte GetParameterName(int ParamIndex,sbyte ReturnValue) { return default; }
	public int GetParameterDescriptionCount(sbyte ParamName,int ReturnValue) { return default; }
	public int GetIntParameterNumOptions(int ParamIndex,int ReturnValue) { return default; }
	public sbyte GetIntParameterAvailableOption(int ParamIndex,int K,sbyte ReturnValue) { return default; }
	public void LoadMaskOutCache() {}
	public void UnloadMaskOutCache() {}
	public TArray<FMutableModelParameterProperties> ParameterProperties;
	public int GetStateCount(int ReturnValue) { return default; }
	public sbyte GetStateName(int StateIndex,sbyte ReturnValue) { return default; }
	public int GetStateParameterCount(sbyte StateName,int ReturnValue) { return default; }
	public sbyte GetStateParameterName(sbyte StateName,int ParameterIndex,sbyte ReturnValue) { return default; }
	public FParameterUIData GetStateUIMetadata(sbyte StateName,FParameterUIData ReturnValue) { return default; }
	public FParameterUIData GetStateUIMetadataFromIndex(int StateIndex,FParameterUIData ReturnValue) { return default; }
	public FParameterUIData GetParameterUIMetadata(sbyte ParamName,FParameterUIData ReturnValue) { return default; }
	public FParameterUIData GetParameterUIMetadataFromIndex(int ParamIndex,FParameterUIData ReturnValue) { return default; }
	public TMap<sbyte,FParameterUIData> ParameterUIDataMap;
	public TMap<sbyte,FParameterUIData> StateUIDataMap;
	public TMap<sbyte,TSoftObjectPtr<UPhysicsAsset>> PhysicsAssetsMap;
	public TMap<sbyte,TSoftObjectPtr<UClass>> AnimBPAssetsMap;
	public TArray<FMutableRefSocket> SocketArray;
	public TSoftObjectPtr<UMutableMaskOutCache> MaskOutCache;
	public TMap<ulong,FMutableStreamableBlock> HashToStreamableBlock;
	public TArray<sbyte> CustomizableObjectClassTags;
	public TArray<sbyte> PopulationClassTags;
	public TMap<sbyte,FParameterTags> CustomizableObjectParametersTags;
	public bool bIsChildObject;
	public UObject CreateInstance(UObject ReturnValue) { return default; }
	public bool IsCompiled(bool ReturnValue) { return default; }
	public UMutableMaskOutCache MaskOutCache_HardRef;
	public FGuid Identifier;
	public FGuid CompilationGuid;
	public UCustomizableObjectBulk BulkData;
}
