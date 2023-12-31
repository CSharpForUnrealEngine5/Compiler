#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
///<summary>A Material is an asset which can be applied to a mesh to control the visual look of the scene.</summary>
public partial class UMaterial : UMaterialInterface {
// Material
	public UPhysicalMaterial PhysMaterial;
	public UPhysicalMaterialMask PhysMaterialMask;
	public UPhysicalMaterial PhysicalMaterialMap;
	public TArray<UPhysicalMaterial> RenderTracePhysicalMaterialOutputs;
	public byte MaterialDomain;
	public byte BlendMode;
	public byte DecalBlendMode;
	public byte MaterialDecalResponse;
	public FMaterialOverrideNanite NaniteOverrideMaterial;
	public uint CachedConnectedInputs;
	public byte ShadingModel;
	public bool bCastDynamicShadowAsMasked;
	public FMaterialShadingModelField ShadingModels;
	public string UsedShadingModels;
	public float OpacityMaskClipValue;
	public bool bEnableSeparateTranslucency_DEPRECATED;
	public bool bEnableResponsiveAA;
	public bool bScreenSpaceReflections;
	public bool bContactShadows;
	public bool TwoSided;
	public bool bIsThinSurface;
	public bool DitheredLODTransition;
	public bool DitherOpacityMask;
	public bool bAllowNegativeEmissiveColor;
	public byte TranslucencyPass;
	public byte TranslucencyLightingMode;
	public bool bEnableMobileSeparateTranslucency;
	public int NumCustomizedUVs;
	public float TranslucencyDirectionalLightingIntensity;
	public float TranslucentShadowDensityScale;
	public float TranslucentSelfShadowDensityScale;
	public float TranslucentSelfShadowSecondDensityScale;
	public float TranslucentSelfShadowSecondOpacity;
	public float TranslucentBackscatteringExponent;
	public FLinearColor TranslucentMultipleScatteringExtinction;
	public float TranslucentShadowStartOffset;
	public bool bDisableDepthTest;
	public bool bWriteOnlyAlpha;
	public bool bGenerateSphericalParticleNormals;
	public bool bTangentSpaceNormal;
	public bool bUseEmissiveForDynamicAreaLighting;
	public bool bUsedAsSpecialEngineMaterial;
	public bool bUsedWithSkeletalMesh;
	public bool bUsedWithEditorCompositing;
	public bool bUsedWithParticleSprites;
	public bool bUsedWithBeamTrails;
	public bool bUsedWithMeshParticles;
	public bool bUsedWithNiagaraSprites;
	public bool bUsedWithNiagaraRibbons;
	public bool bUsedWithNiagaraMeshParticles;
	public bool bUsedWithGeometryCache;
	public bool bUsedWithStaticLighting;
	public bool bUsedWithMorphTargets;
	public bool bUsedWithSplineMeshes;
	public bool bUsedWithInstancedStaticMeshes;
	public bool bUsedWithGeometryCollections;
	public bool bUsesDistortion;
	public bool bRootNodeOverridesDefaultDistortion;
	public bool bUsedWithClothing;
	public bool bUsedWithWater;
	public bool bUsedWithHairStrands;
	public bool bUsedWithLidarPointCloud;
	public bool bUsedWithVirtualHeightfieldMesh;
	public bool bUsedWithNanite;
	public bool bUsedWithVolumetricCloud;
	public bool bUsedWithUI_DEPRECATED;
	public bool bAutomaticallySetUsageInEditor;
	public bool bFullyRough;
	public bool bUseFullPrecision_DEPRECATED;
	public byte FloatPrecisionMode;
	public bool bUseLightmapDirectionality;
	public bool bMobileEnableHighQualityBRDF;
	public bool bUseAlphaToCoverage;
	public bool bForwardRenderUsePreintegratedGFForSimpleIBL;
	public bool bUseHQForwardReflections;
	public bool bForwardBlendsSkyLightCubemaps;
	public bool bUsePlanarForwardReflections;
	public bool bNormalCurvatureToRoughness;
	public bool AllowTranslucentCustomDepthWrites;
	public bool bAllowFrontLayerTranslucency;
	public bool Wireframe;
	public byte ShadingRate;
	public int EditorX;
	public int EditorY;
	public int EditorPitch;
	public int EditorYaw;
	public bool bCanMaskedBeAssumedOpaque;
	public bool bIsMasked_DEPRECATED;
	public bool bIsPreviewMaterial;
	public bool bIsFunctionPreviewMaterial;
	public bool bUseMaterialAttributes;
	public bool bEnableExecWire;
	public bool bEnableNewHLSLGenerator;
	public bool bCastRayTracedShadows;
	public bool bUseTranslucencyVertexFog;
	public bool bApplyCloudFogging;
	public bool bIsSky;
	public bool bComputeFogPerPixel;
	public bool bOutputTranslucentVelocity;
	public bool bAllowDevelopmentShaderCompile;
	public bool bIsMaterialEditorStatsMaterial;
	public byte BlendableLocation;
	public bool BlendableOutputAlpha;
	public bool bEnableStencilTest;
	public byte StencilCompare;
	public byte StencilRefValue;
	public byte RefractionMode_DEPRECATED;
	public byte RefractionMethod;
	public int BlendablePriority;
	public bool bIsBlendable;
	public uint UsageFlagWarnings;
	public float RefractionDepthBias;
	public float MaxWorldPositionOffsetDisplacement;
	public FGuid StateId;
	public bool bSavedCachedExpressionData_DEPRECATED;
	public TArray<FGuid> ReferencedTextureGuids;
	public TArray<UMaterialExpressionComment> EditorComments_DEPRECATED;
	public UMaterialExpressionExecBegin ExpressionExecBegin_DEPRECATED;
	public UMaterialExpressionExecEnd ExpressionExecEnd_DEPRECATED;
	public TArray<UMaterialExpression> Expressions_DEPRECATED;
	public TArray<FParameterGroupData> ParameterGroupData_DEPRECATED;
	public FColorMaterialInput DiffuseColor_DEPRECATED;
	public FColorMaterialInput SpecularColor_DEPRECATED;
	public FColorMaterialInput BaseColor_DEPRECATED;
	public FScalarMaterialInput Metallic_DEPRECATED;
	public FScalarMaterialInput Specular_DEPRECATED;
	public FScalarMaterialInput Roughness_DEPRECATED;
	public FScalarMaterialInput Anisotropy_DEPRECATED;
	public FVectorMaterialInput Normal_DEPRECATED;
	public FVectorMaterialInput Tangent_DEPRECATED;
	public FColorMaterialInput EmissiveColor_DEPRECATED;
	public FScalarMaterialInput Opacity_DEPRECATED;
	public FScalarMaterialInput OpacityMask_DEPRECATED;
	public FVectorMaterialInput WorldPositionOffset_DEPRECATED;
	public FColorMaterialInput SubsurfaceColor_DEPRECATED;
	public FScalarMaterialInput ClearCoat_DEPRECATED;
	public FScalarMaterialInput ClearCoatRoughness_DEPRECATED;
	public FScalarMaterialInput AmbientOcclusion_DEPRECATED;
	public FScalarMaterialInput Refraction_DEPRECATED;
	public FVector2MaterialInput CustomizedUVs_DEPRECATED;
	public FMaterialAttributesInput MaterialAttributes_DEPRECATED;
	public FScalarMaterialInput PixelDepthOffset_DEPRECATED;
	public FShadingModelMaterialInput ShadingModelFromMaterialExpression_DEPRECATED;
	public FStrataMaterialInput FrontMaterial_DEPRECATED;
}
