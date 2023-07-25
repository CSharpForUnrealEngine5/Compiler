#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Engine.h")]
///<summary>Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems.</summary>
public partial class UEngine : UObject {
// Engine
	public UFont TinyFont;
	public FSoftObjectPath TinyFontName;
	public UFont SmallFont;
	public FSoftObjectPath SmallFontName;
	public UFont MediumFont;
	public FSoftObjectPath MediumFontName;
	public UFont LargeFont;
	public FSoftObjectPath LargeFontName;
	public UFont SubtitleFont;
	public FSoftObjectPath SubtitleFontName;
	public TArray<UFont> AdditionalFonts;
	public TArray<string> AdditionalFontNames;
	public UClass ConsoleClass;
	public FSoftClassPath ConsoleClassName;
	public UClass GameViewportClientClass;
	public FSoftClassPath GameViewportClientClassName;
	public UClass LocalPlayerClass;
	public FSoftClassPath LocalPlayerClassName;
	public UClass WorldSettingsClass;
	public FSoftClassPath WorldSettingsClassName;
	public FSoftClassPath NavigationSystemClassName;
	public UClass NavigationSystemClass;
	public FSoftClassPath NavigationSystemConfigClassName;
	public UClass NavigationSystemConfigClass;
	public FSoftClassPath AvoidanceManagerClassName;
	public UClass AvoidanceManagerClass;
	public FSoftClassPath AIControllerClassName;
	public UClass PhysicsCollisionHandlerClass;
	public FSoftClassPath PhysicsCollisionHandlerClassName;
	public FSoftClassPath GameUserSettingsClassName;
	public UClass GameUserSettingsClass;
	public UGameUserSettings GameUserSettings;
	public UClass LevelScriptActorClass;
	public FSoftClassPath LevelScriptActorClassName;
	public FSoftClassPath DefaultBlueprintBaseClassName;
	public FSoftClassPath GameSingletonClassName;
	public UObject GameSingleton;
	public FSoftClassPath AssetManagerClassName;
	public UAssetManager AssetManager;
	public UTexture2D DefaultTexture;
	public FSoftObjectPath DefaultTextureName;
	public UTexture DefaultDiffuseTexture;
	public FSoftObjectPath DefaultDiffuseTextureName;
	public UTexture2D DefaultBSPVertexTexture;
	public FSoftObjectPath DefaultBSPVertexTextureName;
	public UTexture2D HighFrequencyNoiseTexture;
	public FSoftObjectPath HighFrequencyNoiseTextureName;
	public UTexture2D DefaultBokehTexture;
	public FSoftObjectPath DefaultBokehTextureName;
	public UTexture2D DefaultBloomKernelTexture;
	public FSoftObjectPath DefaultBloomKernelTextureName;
	public UTexture2D DefaultFilmGrainTexture;
	public FSoftObjectPath DefaultFilmGrainTextureName;
	public UMaterial WireframeMaterial;
	public string WireframeMaterialName;
	public UMaterial GeomMaterial;
	public FSoftObjectPath GeomMaterialName;
	public UMaterial DebugMeshMaterial;
	public FSoftObjectPath DebugMeshMaterialName;
	public UMaterial NaniteHiddenSectionMaterial;
	public string NaniteHiddenSectionMaterialName;
	public UMaterial EmissiveMeshMaterial;
	public FSoftObjectPath EmissiveMeshMaterialName;
	public UMaterial LevelColorationLitMaterial;
	public string LevelColorationLitMaterialName;
	public UMaterial LevelColorationUnlitMaterial;
	public string LevelColorationUnlitMaterialName;
	public UMaterial LightingTexelDensityMaterial;
	public string LightingTexelDensityName;
	public UMaterial ShadedLevelColorationLitMaterial;
	public string ShadedLevelColorationLitMaterialName;
	public UMaterial ShadedLevelColorationUnlitMaterial;
	public string ShadedLevelColorationUnlitMaterialName;
	public UMaterial RemoveSurfaceMaterial;
	public FSoftObjectPath RemoveSurfaceMaterialName;
	public UMaterial VertexColorMaterial;
	public string VertexColorMaterialName;
	public UMaterial VertexColorViewModeMaterial_ColorOnly;
	public string VertexColorViewModeMaterialName_ColorOnly;
	public UMaterial VertexColorViewModeMaterial_AlphaAsColor;
	public string VertexColorViewModeMaterialName_AlphaAsColor;
	public UMaterial VertexColorViewModeMaterial_RedOnly;
	public string VertexColorViewModeMaterialName_RedOnly;
	public UMaterial VertexColorViewModeMaterial_GreenOnly;
	public string VertexColorViewModeMaterialName_GreenOnly;
	public UMaterial VertexColorViewModeMaterial_BlueOnly;
	public string VertexColorViewModeMaterialName_BlueOnly;
	public UMaterial BoneWeightMaterial;
	public FSoftObjectPath BoneWeightMaterialName;
	public UMaterial ClothPaintMaterial;
	public UMaterial ClothPaintMaterialWireframe;
	public UMaterialInstanceDynamic ClothPaintMaterialInstance;
	public UMaterialInstanceDynamic ClothPaintMaterialWireframeInstance;
	public FSoftObjectPath ClothPaintMaterialName;
	public FSoftObjectPath ClothPaintMaterialWireframeName;
	public UMaterial PhysicalMaterialMaskMaterial;
	public FSoftObjectPath PhysicalMaterialMaskMaterialName;
	public UMaterial DebugEditorMaterial;
	public FSoftObjectPath DefaultFlattenMaterialName;
	public FSoftObjectPath DefaultHLODFlattenMaterialName;
	public FSoftObjectPath DefaultLandscapeFlattenMaterialName;
	public UMaterial DefaultFlattenMaterial;
	public UMaterial DefaultHLODFlattenMaterial;
	public UMaterial DefaultLandscapeFlattenMaterial;
	public FSoftObjectPath DebugEditorMaterialName;
	public UMaterial ConstraintLimitMaterial;
	public UMaterialInstanceDynamic ConstraintLimitMaterialX;
	public UMaterialInstanceDynamic ConstraintLimitMaterialXAxis;
	public UMaterialInstanceDynamic ConstraintLimitMaterialY;
	public UMaterialInstanceDynamic ConstraintLimitMaterialYAxis;
	public UMaterialInstanceDynamic ConstraintLimitMaterialZ;
	public UMaterialInstanceDynamic ConstraintLimitMaterialZAxis;
	public UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic;
	public UMaterial InvalidLightmapSettingsMaterial;
	public FSoftObjectPath InvalidLightmapSettingsMaterialName;
	public UMaterial PreviewShadowsIndicatorMaterial;
	public FSoftObjectPath PreviewShadowsIndicatorMaterialName;
	public UMaterial ArrowMaterial;
	public UMaterialInstanceDynamic ArrowMaterialYellow;
	public FSoftObjectPath ArrowMaterialName;
	public FLinearColor LightingOnlyBrightness;
	public TArray<FLinearColor> ShaderComplexityColors;
	public TArray<FLinearColor> QuadComplexityColors;
	public TArray<FLinearColor> LightComplexityColors;
	public TArray<FLinearColor> StationaryLightOverlapColors;
	public TArray<FLinearColor> LODColorationColors;
	public TArray<FLinearColor> HLODColorationColors;
	public TArray<FLinearColor> StreamingAccuracyColors;
	public FLinearColor GPUSkinCacheVisualizationExcludedColor;
	public FLinearColor GPUSkinCacheVisualizationIncludedColor;
	public FLinearColor GPUSkinCacheVisualizationRecomputeTangentsColor;
	public float GPUSkinCacheVisualizationLowMemoryThresholdInMB;
	public float GPUSkinCacheVisualizationHighMemoryThresholdInMB;
	public FLinearColor GPUSkinCacheVisualizationLowMemoryColor;
	public FLinearColor GPUSkinCacheVisualizationMidMemoryColor;
	public FLinearColor GPUSkinCacheVisualizationHighMemoryColor;
	public TArray<FLinearColor> GPUSkinCacheVisualizationRayTracingLODOffsetColors;
	public float MaxPixelShaderAdditiveComplexityCount;
	public float MaxES3PixelShaderAdditiveComplexityCount;
	public float MinLightMapDensity;
	public float IdealLightMapDensity;
	public float MaxLightMapDensity;
	public bool bRenderLightMapDensityGrayscale;
	public float RenderLightMapDensityGrayscaleScale;
	public float RenderLightMapDensityColorScale;
	public FLinearColor LightMapDensityVertexMappedColor;
	public FLinearColor LightMapDensitySelectedColor;
	public TArray<FStatColorMapping> StatColorMappings;
	public UMaterial EditorBrushMaterial;
	public FSoftObjectPath EditorBrushMaterialName;
	public UPhysicalMaterial DefaultPhysMaterial;
	public FSoftObjectPath DefaultPhysMaterialName;
	public UPhysicalMaterial DefaultDestructiblePhysMaterial;
	public FSoftObjectPath DefaultDestructiblePhysMaterialName;
	public TArray<FGameNameRedirect> ActiveGameNameRedirects;
	public TArray<FClassRedirect> ActiveClassRedirects;
	public TArray<FPluginRedirect> ActivePluginRedirects;
	public TArray<FStructRedirect> ActiveStructRedirects;
	public UTexture2D PreIntegratedSkinBRDFTexture;
	public FSoftObjectPath PreIntegratedSkinBRDFTextureName;
	public UTexture2D BlueNoiseScalarTexture;
	public UTexture2D BlueNoiseVec2Texture;
	public FSoftObjectPath BlueNoiseScalarTextureName;
	public FSoftObjectPath BlueNoiseVec2TextureName;
	public UTexture2D MiniFontTexture;
	public FSoftObjectPath MiniFontTextureName;
	public UTexture WeightMapPlaceholderTexture;
	public FSoftObjectPath WeightMapPlaceholderTextureName;
	public UTexture2D LightMapDensityTexture;
	public FSoftObjectPath LightMapDensityTextureName;
	public UGameViewportClient GameViewport;
	public TArray<string> DeferredCommands;
	public float NearClipPlane;
	public bool bSubtitlesEnabled;
	public bool bSubtitlesForcedOff;
	public int MaximumLoopIterationCount;
	public bool bCanBlueprintsTickByDefault;
	public bool bOptimizeAnimBlueprintMemberVariableAccess;
	public bool bAllowMultiThreadedAnimationUpdate;
	public bool bEnableEditorPSysRealtimeLOD;
	public bool bSmoothFrameRate;
	public bool bUseFixedFrameRate;
	public float FixedFrameRate;
	public FFloatRange SmoothedFrameRateRange;
	public UEngineCustomTimeStep CustomTimeStep;
	public FSoftClassPath CustomTimeStepClassName;
	public UTimecodeProvider TimecodeProvider;
	public FSoftClassPath TimecodeProviderClassName;
	public bool bGenerateDefaultTimecode;
	public FFrameRate GenerateDefaultTimecodeFrameRate;
	public float GenerateDefaultTimecodeFrameDelay;
	public bool bCheckForMultiplePawnsSpawnedInAFrame;
	public int NumPawnsAllowedToBeSpawnedInAFrame;
	public bool bShouldGenerateLowQualityLightmaps_DEPRECATED;
	public FColor C_WorldBox;
	public FColor C_BrushWire;
	public FColor C_AddWire;
	public FColor C_SubtractWire;
	public FColor C_SemiSolidWire;
	public FColor C_NonSolidWire;
	public FColor C_WireBackground;
	public FColor C_ScaleBoxHi;
	public FColor C_VolumeCollision;
	public FColor C_BSPCollision;
	public FColor C_OrthoBackground;
	public FColor C_Volume;
	public FColor C_BrushShape;
	public FDirectoryPath GameScreenshotSaveDirectory;
	public bool UseStaticMeshMinLODPerQualityLevels;
	public bool UseSkeletalMeshMinLODPerQualityLevels;
	public bool UseGrassVarityPerQualityLevels;
	public ETransitionType TransitionType;
	public string TransitionDescription;
	public string TransitionGameMode;
	public bool bAllowMatureLanguage;
	public float CameraRotationThreshold;
	public float CameraTranslationThreshold;
	public float PrimitiveProbablyVisibleTime;
	public float MaxOcclusionPixelsFraction;
	public bool bPauseOnLossOfFocus;
	public int MaxParticleResize;
	public int MaxParticleResizeWarn;
	public TArray<FDropNoteInfo> PendingDroppedNotes;
	public float NetClientTicksPerSecond;
	public float DisplayGamma;
	public float MinDesiredFrameRate;
	public FLinearColor DefaultSelectedMaterialColor;
	public FLinearColor SelectedMaterialColor;
	public FLinearColor SelectionOutlineColor;
	public FLinearColor SubduedSelectionOutlineColor;
	public FLinearColor SelectedMaterialColorOverride;
	public bool bIsOverridingSelectedColor;
	public bool bEnableOnScreenDebugMessages;
	public bool bEnableOnScreenDebugMessagesDisplay;
	public bool bSuppressMapWarnings;
	public bool bDisableAILogging;
	public uint bEnableVisualLogRecordingOnStart;
	public int ScreenSaverInhibitorSemaphore;
	public bool bLockReadOnlyLevels;
	public string ParticleEventManagerClassPath;
	public float SelectionHighlightIntensity;
	public float BSPSelectionHighlightIntensity;
	public float SelectionHighlightIntensityBillboards;
	public uint GlobalNetTravelCount;
	public TArray<FNetDriverDefinition> NetDriverDefinitions;
	public TArray<FIrisNetDriverConfig> IrisNetDriverConfigs;
	public TArray<string> ServerActors;
	public TArray<string> RuntimeServerActors;
	public float NetErrorLogInterval;
	public bool bStartedLoadMapMovie;
	public int NextWorldContextHandle;
}
