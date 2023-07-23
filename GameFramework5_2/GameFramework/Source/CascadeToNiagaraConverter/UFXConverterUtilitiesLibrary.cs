#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>A C++ and Blueprint accessible library for converting fx type assets (Cascade and Niagara)</summary>
public partial class UFXConverterUtilitiesLibrary : UBlueprintFunctionLibrary {
// FXConverterUtilitiesLibrary
	public sbyte GetLongPackagePath(sbyte InLongPackageName,sbyte ReturnValue) { return default; }
	public TArray<UObject> GetCascadeSystemEmitters(UObject System,TArray<UObject> ReturnValue) { return default; }
	public UObject GetCascadeEmitterLodLevel(UObject Emitter,int Idx,UObject ReturnValue) { return default; }
	public bool GetLodLevelIsEnabled(UObject LodLevel,bool ReturnValue) { return default; }
	public TArray<UObject> GetLodLevelModules(UObject LodLevel,TArray<UObject> ReturnValue) { return default; }
	public UObject GetLodLevelSpawnModule(UObject LodLevel,UObject ReturnValue) { return default; }
	public UObject GetLodLevelRequiredModule(UObject LodLevel,UObject ReturnValue) { return default; }
	public UObject GetLodLevelTypeDataModule(UObject LodLevel,UObject ReturnValue) { return default; }
	public sbyte GetCascadeEmitterName(UObject Emitter,sbyte ReturnValue) { return default; }
	public UObject CreateScriptContext(FCreateScriptContextArgs Args,UObject ReturnValue) { return default; }
	public FAssetData CreateAssetData(sbyte InPath,FAssetData ReturnValue) { return default; }
	public UObject CreateScriptInputLinkedParameter(sbyte ParameterNameString,ENiagaraScriptInputType InputType,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputFloat(float Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputVec2(FVector2D Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputVector(FVector Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputStruct(UObject Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputEnum(sbyte UserDefinedEnumAssetPath,sbyte UserDefinedEnumValueNameString,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputInt(int Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputDynamic(UObject Value,ENiagaraScriptInputType InputType,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputDI(UObject Value,UObject ReturnValue) { return default; }
	public UObject CreateScriptInputBool(bool Value,UObject ReturnValue) { return default; }
	public UObject CreateRibbonRendererProperties(UObject ReturnValue) { return default; }
	public UObject CreateMeshRendererProperties(UObject ReturnValue) { return default; }
	public UObject CreateLightRendererProperties(UObject ReturnValue) { return default; }
	public UObject CreateComponentRendererProperties(UObject ReturnValue) { return default; }
	public UObject CreateSkeletalMeshDataInterface(UObject ReturnValue) { return default; }
	public UObject CreateFloatCurveDI(TArray<FRichCurveKeyBP> Keys,UObject ReturnValue) { return default; }
	public UObject CreateVec2CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,UObject ReturnValue) { return default; }
	public UObject CreateVec3CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys,UObject ReturnValue) { return default; }
	public UObject CreateVec4CurveDI(TArray<FRichCurveKeyBP> X_Keys,TArray<FRichCurveKeyBP> Y_Keys,TArray<FRichCurveKeyBP> Z_Keys,TArray<FRichCurveKeyBP> W_Keys,UObject ReturnValue) { return default; }
	public UObject CreateSystemConversionContext(UObject InSystem,UObject ReturnValue) { return default; }
	public void GetParticleModuleTypeDataGpuProps(UObject ParticleModule) {}
	public void GetParticleModuleTypeDataMeshProps(UObject ParticleModule,UObject OutMesh,float OutLODSizeScale,bool bOutUseStaticMeshLODs,bool bOutCastShadows,bool bOutDoCollisions,byte OutMeshAlignment,bool bOutOverrideMaterial,bool bOutOverrideDefaultMotionBlurSettings,bool bOutEnableMotionBlur,UObject OutRollPitchYawRange,byte OutAxisLockOption,bool bOutCameraFacing,byte OutCameraFacingUpAxisOption_DEPRECATED,byte OutCameraFacingOption,bool bOutApplyParticleRotationAsSpin,bool bOutFacingCameraDirectionRatherThanPosition,bool bOutCollisionsConsiderParticleSize) {}
	public UClass GetParticleModuleTypeDataRibbonClass(UClass ReturnValue) { return default; }
	public void GetParticleModuleTypeDataRibbonProps(UObject ParticleModule,int OutMaxTessellationBetweenParticles,int OutSheetsPerTrail,int OutMaxTrailCount,int OutMaxParticleInTrailCount,bool bOutDeadTrailsOnDeactivate,bool bOutClipSourceSegment,bool bOutEnablePreviousTangentRecalculation,bool bOutTangentRecalculationEveryFrame,bool bOutSpawnInitialParticle,byte OutRenderAxis,float OutTangentSpawningScalar,bool bOutRenderGeometry,bool bOutRenderSpawnPoints,bool bOutRenderTangents,bool bOutRenderTessellation,float OutTilingDistance,float OutDistanceTessellationStepSize,bool bOutEnableTangentDiffInterpScale,float OutTangentTessellationScalar) {}
	public void GetParticleModuleSpawnProps(UObject ParticleModuleSpawn,UObject OutRate,UObject OutRateScale,byte OutBurstMethod,TArray<FParticleBurstBlueprint> OutBurstList,UObject OutBurstScale,bool bOutApplyGlobalSpawnRateScale,bool bOutProcessSpawnRate,bool bOutProcessSpawnBurst) {}
	public void GetParticleModuleSpawnPerUnitProps(UObject ParticleModule,float OutUnitScalar,float OutMovementTolerance,UObject OutSpawnPerUnit,float OutMaxFrameDistance,bool bOutIgnoreSpawnRateWhenMoving,bool bOutIgnoreMovementAlongX,bool bOutIgnoreMovementAlongY,bool bOutIgnoreMovementAlongZ,bool bOutProcessSpawnRate,bool bOutProcessBurstList) {}
	public void GetParticleModuleRequiredPerRendererProps(UObject ParticleModuleRequired,UObject OutMaterialInterface,byte OutScreenAlignment,int OutSubImages_Horizontal,int OutSubImages_Vertical,byte OutSortMode,byte OutInterpolationMethod,byte bOutRemoveHMDRoll,float OutMinFacingCameraBlendDistance,float OutMaxFacingCameraBlendDistance,UObject OutCutoutTexture,byte OutBoundingMode,byte OutOpacitySourceMode,byte OutEmitterNormalsMode,float OutAlphaThreshold) {}
	public void GetParticleModuleRequiredPerModuleProps(UObject ParticleModuleRequired,bool bOutOrbitModuleAffectsVelocityAlignment,float OutRandomImageTime,int OutRandomImageChanges,bool bOutOverrideSystemMacroUV,FVector OutMacroUVPosition,float OutMacroUVRadius) {}
	public void GetParticleModuleRequiredPerEmitterProps(UObject ParticleModuleRequired,FVector OutEmitterOrigin,FRotator OutEmitterRotation,bool bOutUseLocalSpace,bool bOutKillOnDeactivate,bool bOutKillOnCompleted,bool bOutUseLegacyEmitterTime,bool bOutEmitterDurationUseRange,float OutEmitterDuration,float OutEmitterDurationLow,bool bOUtEmitterDelayUseRange,bool bOutDelayFirstLoopOnly,float OutEmitterDelay,float OutEmitterDelayLow,bool bOutDurationRecalcEachLoop,int OutEmitterLoops) {}
	public void GetParticleModuleColorProps(UObject ParticleModule,UObject OutStartColor,UObject OutStartAlpha,bool bOutClampAlpha) {}
	public void GetParticleModuleColorOverLifeProps(UObject ParticleModule,UObject OutColorOverLife,UObject OutAlphaOverLife,bool bOutClampAlpha) {}
	public void GetParticleModuleLifetimeProps(UObject ParticleModule,UObject OutLifetime) {}
	public void GetParticleModuleSizeProps(UObject ParticleModule,UObject OutStartSize) {}
	public void GetParticleModuleVelocityProps(UObject ParticleModule,UObject OutStartVelocity,UObject OutStartVelocityRadial,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public void GetParticleModuleVelocityOverLifetimeProps(UObject ParticleModule,UObject OutVelOverLife,bool bOutAbsolute,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public void GetParticleModuleConstantAccelerationProps(UObject ParticleModule,FVector OutConstAcceleration) {}
	public void GetParticleModuleLocationPrimitiveSphereProps(UObject ParticleModule,UObject OutStartRadius,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UObject OutVelocityScale,UObject OutStartLocation) {}
	public void GetParticleModuleLocationPrimitiveCylinderProps(UObject ParticleModule,bool bOutRadialVelocity,UObject OutStartRadius,UObject OutStartHeight,byte OutHeightAxis,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ,bool bOutSurfaceOnly,bool bOutVelocity,UObject OutVelocityScale,UObject OutStartLocation) {}
	public void GetParticleModuleOrientationAxisLockProps(UObject ParticleModule,byte OutLockAxisFlags) {}
	public void GetParticleModuleVelocityInheritParentProps(UObject ParticleModule,UObject OutScale,bool bOutInWorldSpace,bool bOutApplyOwnerScale) {}
	public void GetParticleModuleMeshRotationProps(UObject ParticleModule,UObject OutStartRotation,bool bOutInheritParentRotation) {}
	public void GetParticleModuleCollisionProps(UObject ParticleModule,UObject OutDampingFactor,UObject OutDampingFactorRotation,UObject OutMaxCollisions,byte OutCollisionCompleteOption,TArray<byte> OutCollisionTypes,bool bOutApplyPhysics,bool bOutIgnoreTriggerVolumes,UObject OutParticleMass,float OutDirScalar,bool bOutPawnsDoNotDecrementCount,bool bOutOnlyVerticalNormalsDecrementCount,float OutVerticalFudgeFactor,UObject OutDelayAmount,bool bOutDropDetail,bool bOutCollideOnlyIfVisible,bool bOutIgnoreSourceActor,float OutMaxCollisionDistance) {}
	public void GetParticleModuleSizeScaleProps(UObject ParticleModule,UObject OutSizeScale) {}
	public void GetParticleModuleSizeScaleBySpeedProps(UObject ParticleModule,FVector2D OutSpeedScale,FVector2D OutMaxScale) {}
	public void GetParticleModuleVectorFieldLocalProps(UObject ParticleModule,UObject OutVectorField,FVector OutRelativeTranslation,FRotator OutRelativeRotation,FVector OutRelativeScale3D,float OutIntensity,float OutTightness,bool bOutIgnoreComponentTransform,bool bOutTileX,bool bOutTileY,bool bOutTileZ,bool bOutUseFixDT) {}
	public void GetParticleModuleVectorFieldRotationRateProps(UObject ParticleModule,FVector OutRotationRate) {}
	public void GetParticleModuleOrbitProps(UObject ParticleModule,byte OutChainMode,UObject OutOffsetAmount,FOrbitOptionsBP OutOffsetOptions,UObject OutRotationAmount,FOrbitOptionsBP OutRotationOptions,UObject OutRotationRateAmount,FOrbitOptionsBP OutRotationRateOptions) {}
	public void GetParticleModuleSizeMultiplyLifeProps(UObject ParticleModule,UObject OutLifeMultiplier,bool OutMultiplyX,bool OutMultiplyY,bool OutMultiplyZ) {}
	public void GetParticleModuleColorScaleOverLifeProps(UObject ParticleModule,UObject OutColorScaleOverLife,UObject OutAlphaScaleOverLife,bool bOutEmitterTime) {}
	public void GetParticleModuleRotationProps(UObject ParticleModule,UObject OutStartRotation) {}
	public void GetParticleModuleRotationRateProps(UObject ParticleModule,UObject OutStartRotationRate) {}
	public void GetParticleModuleMeshRotationRateProps(UObject ParticleModule,UObject OutStartRotationRate) {}
	public void GetParticleModuleRotationOverLifetimeProps(UObject ParticleModule,UObject OutRotationOverLife,bool bOutScale) {}
	public void GetParticleModuleMeshRotationRateMultiplyLifeProps(UObject ParticleModule,UObject OutLifeMultiplier) {}
	public void GetParticleModulePivotOffsetProps(UObject ParticleModule,FVector2D OutPivotOffset) {}
	public void GetParticleModuleSubUVProps(UObject ParticleModule,UObject OutAnimation,UObject OutSubImageIndex,bool bOutUseRealTime) {}
	public void GetParticleModuleCameraOffsetProps(UObject ParticleModule,UObject OutCameraOffset,bool bOutSpawnTimeOnly,byte OutUpdateMethod) {}
	public void GetParticleModuleSubUVMovieProps(UObject ParticleModule,bool bOutUseEmitterTime,UObject OutFrameRate,int OutStartingFrame) {}
	public void GetParticleModuleParameterDynamicProps(UObject ParticleModule,TArray<FEmitterDynamicParameterBP> OutDynamicParams,bool bOutUsesVelocity) {}
	public void GetParticleModuleAccelerationDragProps(UObject ParticleModule,UObject OutDragCoefficientRaw) {}
	public void GetParticleModuleAccelerationDragScaleOverLifeProps(UObject ParticleModule,UObject OutDragScaleRaw) {}
	public void GetParticleModuleAccelerationProps(UObject ParticleModule,UObject OutAcceleration,bool bOutApplyOwnerScale) {}
	public void GetParticleModuleAccelerationOverLifetimeProps(UObject ParticleModule,UObject OutAccelOverLife) {}
	public void GetParticleModuleTrailSourceProps(UObject ParticleModule,byte OutSourceMethod,sbyte OutSourceName,UObject OutSourceStrength,bool bOutLockSourceStrength,int OutSourceOffsetCount,TArray<FVector> OutSourceOffsetDefaults,byte OutSelectionMethod,bool bOutInheritRotation) {}
	public void GetParticleModuleAttractorParticleProps(UObject ParticleModule,sbyte OutEmitterName,UObject OutRange,bool bOutStrengthByDistance,UObject OutStrength,bool bOutAffectBaseVelocity,byte OutSelectionMethod,bool bOutRenewSource,bool bOutInheritSourceVelocity) {}
	public void GetParticleModuleAttractorPointProps(UObject ParticleModule,UObject OutPosition,UObject OutRange,UObject OutStrength,bool boutStrengthByDistance,bool bOutAffectsBaseVelocity,bool bOutOverrideVelocity,bool bOutUseWorldSpacePosition,bool bOutPositiveX,bool bOutPositiveY,bool bOutPositiveZ,bool bOutNegativeX,bool bOutNegativeY,bool bOutNegativeZ) {}
	public void GetParticleModuleAttractorLineProps(UObject ParticleModule,FVector OutStartPoint,FVector OutEndPoint,UObject OutRange,UObject OutStrength) {}
	public void GetParticleModuleLocationDirectProps(UObject ParticleModule,UObject OutLocation,UObject OutLocationOffset,UObject OutScaleFactor) {}
	public void GetParticleModuleLocationProps(UObject ParticleModule,UObject OutStartLocation,float OutDistributeOverNPoints,float OutDistributeThreshold) {}
	public void GetParticleModuleLocationBoneSocketProps(UObject ParticleModule,byte OutSourceType,FVector OutUniversalOffset,TArray<FLocationBoneSocketInfoBP> OutSourceLocations,byte OutSelectionMethod,bool bOutUpdatePositionEachFrame,bool bOutOrientMeshEmitters,bool bOutInheritBoneVelocity,float OutInheritVelocityScale,sbyte OutSkelMeshActorParamName,int OutNumPreSelectedIndices,UObject OutEditorSkelMesh) {}
	public void GetParticleModuleKillBoxProps(UObject ParticleModule,UObject OutLowerLeftCorner,UObject OutUpperRightCorner,bool bOutWorldSpaceCoords,bool bOutKillInside,bool bOutAxisAlignedAndFixedSize) {}
	public void GetParticleModuleLightProps(UObject ParticleModule,bool bOutUseInverseSquaredFalloff,bool bOutAffectsTranslucency,bool bOutPreviewLightRadius,float OutSpawnFraction,UObject OutColorScaleOverLife,UObject OutBrightnessOverLife,UObject OutRadiusScale,UObject OutLightExponent,FLightingChannels OutLightingChannels,float OutVolumetricScatteringIntensity,bool bOutHighQualityLights,bool bOutShadowCastingLights) {}
	public void GetParticleModuleMeshMaterialProps(UObject ParticleModule,TArray<UObject> OutMeshMaterials) {}
	public void SetMeshRendererMaterialOverridesFromCascade(UObject MeshRendererProps,TArray<UObject> MeshMaterials) {}
	public void GetDistributionMinMaxValues(UObject Distribution,bool bOutSuccess,FVector OutMinValue,FVector OutMaxValue) {}
	public TArray<byte> GetDistributionLockedAxes(UObject Distribution,TArray<byte> ReturnValue) { return default; }
	public void GetDistributionType(UObject Distribution,EDistributionType OutDistributionType,EDistributionValueType OutCascadeDistributionValueType) {}
	public void GetFloatDistributionConstValues(UObject Distribution,float OutConstFloat) {}
	public void GetVectorDistributionConstValues(UObject Distribution,FVector OutConstVector) {}
	public void GetFloatDistributionUniformValues(UObject Distribution,float OutMin,float OutMax) {}
	public void GetVectorDistributionUniformValues(UObject Distribution,FVector OutMin,FVector OutMax) {}
	public void GetFloatDistributionConstCurveValues(UObject Distribution,FInterpCurveFloat OutInterpCurveFloat) {}
	public void GetVectorDistributionConstCurveValues(UObject Distribution,FInterpCurveVector OutInterpCurveVector) {}
	public void GetFloatDistributionUniformCurveValues(UObject Distribution,FInterpCurveVector2D OutInterpCurveVector2D) {}
	public void GetVectorDistributionUniformCurveValues(UObject Distribution,FInterpCurveTwoVectors OutInterpCurveTwoVectors) {}
	public void GetFloatDistributionParameterValues(UObject Distribution,sbyte OutParameterName,float OutMinInput,float OutMaxInput,float OutMinOutput,float OutMaxOutput) {}
	public void GetVectorDistributionParameterValues(UObject Distribution,sbyte OutParameterName,FVector OutMinInput,FVector OutMaxInput,FVector OutMinOutput,FVector OutMaxOutput) {}
	public TArray<FRichCurveKeyBP> KeysFromInterpCurveFloat(FInterpCurveFloat Curve,TArray<FRichCurveKeyBP> ReturnValue) { return default; }
	public TArray<FRichCurveKeyBP> KeysFromInterpCurveVector(FInterpCurveVector Curve,int ComponentIdx,TArray<FRichCurveKeyBP> ReturnValue) { return default; }
	public TArray<FRichCurveKeyBP> KeysFromInterpCurveVector2D(FInterpCurveVector2D Curve,int ComponentIdx,TArray<FRichCurveKeyBP> ReturnValue) { return default; }
	public TArray<FRichCurveKeyBP> KeysFromInterpCurveTwoVectors(FInterpCurveTwoVectors Curve,int ComponentIdx,TArray<FRichCurveKeyBP> ReturnValue) { return default; }
}
