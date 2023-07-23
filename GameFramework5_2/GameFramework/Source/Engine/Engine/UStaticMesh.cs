#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMesh.h")]
///<summary>A StaticMesh is a piece of geometry that consists of a static set of polygons.</summary>
public partial class UStaticMesh : UStreamableRenderAsset {
// StaticMesh
	public TArray<FStaticMeshSourceModel> SourceModels;
	public FStaticMeshSourceModel HiResSourceModel;
	public FMeshSectionInfoMap SectionInfoMap;
	public FMeshSectionInfoMap OriginalSectionInfoMap;
	public sbyte LODGroup;
	public FPerPlatformInt NumStreamedLODs;
	public int ImportVersion;
	public TArray<FMaterialRemapIndex> MaterialRemapIndexPerImportVersion;
	public int LightmapUVVersion;
	public bool bAutoComputeLODScreenSize;
	public TArray<UMaterialInterface> Materials_DEPRECATED;
	public FMeshNaniteSettings NaniteSettings;
	public bool IsLODScreenSizeAutoComputed(bool ReturnValue) { return default; }
	public FPerQualityLevelInt MinQualityLevelLOD;
	public void GetMinimumLODForQualityLevels(TMap<sbyte,int> QualityLevelMinimumLODs) {}
	public int GetMinimumLODForQualityLevel(sbyte QualityLevel,int ReturnValue) { return default; }
	public void SetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default=-1) {}
	public void GetMinLODForQualityLevels(TMap<EPerQualityLevels,int> QualityLevelMinimumLODs,int Default) {}
	public FPerPlatformInt MinLOD;
	public void GetMinimumLODForPlatforms(TMap<sbyte,int> PlatformMinimumLODs) {}
	public int GetMinimumLODForPlatform(sbyte PlatformName,int ReturnValue) { return default; }
	public void SetMinimumLODForPlatforms(TMap<sbyte,int> PlatformMinimumLODs) {}
	public void SetMinimumLODForPlatform(sbyte PlatformName,int InMinLOD) {}
	public TArray<FStaticMaterial> StaticMaterials;
	public TArray<FStaticMaterial> GetStaticMaterials(TArray<FStaticMaterial> ReturnValue) { return default; }
	public void SetStaticMaterials(TArray<FStaticMaterial> InStaticMaterials) {}
	public float LightmapUVDensity;
	public int LightMapResolution;
	public int LightMapCoordinateIndex;
	public float DistanceFieldSelfShadowBias;
	public UBodySetup BodySetup;
	public int LODForCollision;
	public bool bGenerateMeshDistanceField;
	public bool bStripComplexCollisionForConsole_DEPRECATED;
	public bool bHasNavigationData;
	public bool bSupportUniformlyDistributedSampling;
	public bool bSupportPhysicalMaterialMasks;
	public bool bSupportRayTracing;
	public bool bDoFastBuild;
	public bool bIsBuiltAtRuntime_DEPRECATED;
	public bool bAllowCPUAccess;
	public bool bSupportGpuUniformlyDistributedSampling;
	public UAssetImportData AssetImportData;
	public sbyte SourceFilePath_DEPRECATED;
	public sbyte SourceFileTimestamp_DEPRECATED;
	public UThumbnailInfo ThumbnailInfo;
	public FAssetEditorOrbitCameraPosition EditorCameraPosition;
	public bool bCustomizedCollision;
	public TArray<UStaticMeshSocket> Sockets;
	public FVector PositiveBoundsExtension;
	public FVector NegativeBoundsExtension;
	public FBoxSphereBounds ExtendedBounds;
	public int ElementToIgnoreForTexFactor;
	public TArray<UAssetUserData> AssetUserData;
	public UObject EditableMesh_DEPRECATED;
	public UStaticMesh ComplexCollisionMesh;
	public UObject CreateStaticMeshDescription(UObject Outer=nullptr,UObject ReturnValue) { return default; }
	public void BuildFromStaticMeshDescriptions(TArray<UObject> StaticMeshDescriptions,bool bBuildSimpleCollision=false,bool bFastBuild=true) {}
	public UObject GetStaticMeshDescription(int LODIndex,UObject ReturnValue) { return default; }
	public UNavCollisionBase NavCollision;
	public void SetNumSourceModels(int Num) {}
	public int GetNumTriangles(int LODIndex,int ReturnValue) { return default; }
	public int GetNumLODs(int ReturnValue) { return default; }
	public FBoxSphereBounds GetBounds(FBoxSphereBounds ReturnValue) { return default; }
	public FBox GetBoundingBox(FBox ReturnValue) { return default; }
	public int GetNumSections(int InLOD,int ReturnValue) { return default; }
	public UObject GetMaterial(int MaterialIndex,UObject ReturnValue) { return default; }
	public sbyte AddMaterial(UObject Material,sbyte ReturnValue) { return default; }
	public int GetMaterialIndex(sbyte MaterialSlotName,int ReturnValue) { return default; }
	public void AddSocket(UObject Socket) {}
	public UObject FindSocket(sbyte InSocketName,UObject ReturnValue) { return default; }
	public void RemoveSocket(UObject Socket) {}
	public TArray<UObject> GetSocketsByTag(sbyte InSocketTag,TArray<UObject> ReturnValue) { return default; }
	public void SetMaterial(int MaterialIndex,UObject NewMaterial) {}
}
