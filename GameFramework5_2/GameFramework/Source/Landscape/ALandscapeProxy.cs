#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeProxy.h")]
public partial class ALandscapeProxy : APartitionActor {
// LandscapeProxy
	public ULandscapeSplinesComponent SplineComponent;
	public FGuid LandscapeGuid;
	public TArray<FLandscapePerLODMaterialOverride> PerLODOverrideMaterials;
	public TArray<FLandscapePerLODMaterialOverride> PreEditPerLODOverrideMaterials;
	public FIntPoint LandscapeSectionOffset;
	public int MaxLODLevel;
	public float LODDistanceFactor_DEPRECATED;
	public byte LODFalloff_DEPRECATED;
	public float ComponentScreenSizeToUseSubSections;
	public float LOD0ScreenSize;
	public float LOD0DistributionSetting;
	public float LODDistributionSetting;
	public int ExportLOD;
	public TArray<sbyte> TargetDisplayOrderList;
	public ELandscapeLayerDisplayMode TargetDisplayOrder;
	public int StaticLightingLOD;
	public UPhysicalMaterial DefaultPhysMaterial;
	public float StreamingDistanceMultiplier;
	public UMaterialInterface LandscapeMaterial;
	public UMaterialInterface LandscapeHoleMaterial;
	public TArray<FLandscapeProxyMaterialOverride> LandscapeMaterialsOverride_DEPRECATED;
	public UMaterialInterface PreEditLandscapeMaterial;
	public UMaterialInterface PreEditLandscapeHoleMaterial;
	public bool bIsPerformingInteractiveActionOnLandscapeMaterialOverride;
	public TArray<URuntimeVirtualTexture> RuntimeVirtualTextures;
	public bool bSetCreateRuntimeVirtualTextureVolumes;
	public bool bVirtualTextureRenderWithQuad;
	public bool bVirtualTextureRenderWithQuadHQ;
	public int VirtualTextureNumLods;
	public int VirtualTextureLodBias;
	public ERuntimeVirtualTextureMainPassType VirtualTextureRenderPassType;
	public void SetVirtualTextureRenderPassType(ERuntimeVirtualTextureMainPassType InType) {}
	public float NegativeZBoundsExtension;
	public float PositiveZBoundsExtension;
	public TArray<ULandscapeComponent> LandscapeComponents;
	public TArray<ULandscapeHeightfieldCollisionComponent> CollisionComponents;
	public TArray<UHierarchicalInstancedStaticMeshComponent> FoliageComponents;
	public ULandscapeNaniteComponent NaniteComponent;
	public bool bHasLandscapeGrass;
	public float StaticLightingResolution;
	public bool CastShadow;
	public bool bCastDynamicShadow;
	public bool bCastStaticShadow;
	public bool bCastContactShadow;
	public bool bCastFarShadow;
	public bool bCastHiddenShadow;
	public bool bCastShadowAsTwoSided;
	public bool bAffectDistanceFieldLighting;
	public FLightingChannels LightingChannels;
	public bool bUseMaterialPositionOffsetInStaticLighting;
	public bool bRenderCustomDepth;
	public ERendererStencilMask CustomDepthStencilWriteMask;
	public int CustomDepthStencilValue;
	public float LDMaxDrawDistance;
	public FLightmassPrimitiveSettings LightmassSettings;
	public int CollisionMipLevel;
	public int SimpleCollisionMipLevel;
	public FBodyInstance BodyInstance;
	public bool bGenerateOverlapEvents;
	public bool bBakeMaterialPositionOffsetIntoCollision;
	public TArray<ULandscapeLayerInfoObject> EditorCachedLayerInfos_DEPRECATED;
	public sbyte ReimportHeightmapFilePath;
	public FGuid ReimportDestinationLayerGuid;
	public TArray<FLandscapeEditorLayerSettings> EditorLayerSettings;
	public TMap<UTexture2D,ULandscapeWeightmapUsage> WeightmapUsageMap;
	public int ComponentSizeQuads;
	public int SubsectionSizeQuads;
	public int NumSubsections;
	public bool bUsedForNavigation;
	public bool bFillCollisionUnderLandscapeForNavmesh;
	public bool bUseDynamicMaterialInstance;
	public ENavDataGatheringMode NavigationGeometryGatheringMode;
	public int MaxPaintedLayersPerComponent;
	public bool bUseLandscapeForCullingInvisibleHLODVertices;
	public bool bHasLayersContent;
	public void ChangeLODDistanceFactor(float InLODDistanceFactor) {}
	public void ChangeComponentScreenSizeToUseSubSections(float InComponentScreenSizeToUseSubSections) {}
	public void EditorSetLandscapeMaterial(UObject NewLandscapeMaterial) {}
	public void EditorApplySpline(UObject InSplineComponent,float StartWidth=200,float EndWidth=200,float StartSideFalloff=200,float EndSideFalloff=200,float StartRoll=0,float EndRoll=0,int NumSubdivisions=20,bool bRaiseHeights=true,bool bLowerHeights=true,UObject PaintLayer=nullptr,sbyte EditLayerName=TEXT) {}
	public void SetLandscapeMaterialTextureParameterValue(sbyte ParameterName,UObject Value) {}
	public void SetLandscapeMaterialVectorParameterValue(sbyte ParameterName,FLinearColor Value) {}
	public void SetLandscapeMaterialScalarParameterValue(sbyte ParameterName,float Value) {}
	public UObject GetLandscapeActor(UObject ReturnValue) { return default; }
	public bool LandscapeExportHeightmapToRenderTarget(UObject InRenderTarget,bool InExportHeightIntoRGChannel=false,bool InExportLandscapeProxies=true,bool ReturnValue) { return default; }
	public bool LandscapeImportHeightmapFromRenderTarget(UObject InRenderTarget,bool InImportHeightFromRGChannel=false,bool ReturnValue) { return default; }
	public bool LandscapeImportWeightmapFromRenderTarget(UObject InRenderTarget,sbyte InLayerName,bool ReturnValue) { return default; }
	public bool LandscapeExportWeightmapToRenderTarget(UObject InRenderTarget,sbyte InLayerName,bool ReturnValue) { return default; }
}
