#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/GameplayStatics.h")]
///<summary>Static class with useful gameplay utility functions that can be called from both Blueprint and C++</summary>
public partial class UGameplayStatics : UBlueprintFunctionLibrary {
// GameplayStatics
	public UObject SpawnObject(UClass ObjectClass,UObject Outer,UObject ReturnValue) { return default; }
	public UObject BeginSpawningActorFromBlueprint(UObject WorldContextObject,UObject Blueprint,FTransform SpawnTransform,bool bNoCollisionFail,UObject ReturnValue) { return default; }
	public UObject BeginDeferredActorSpawnFromClass(UObject WorldContextObject,UClass ActorClass,FTransform SpawnTransform,ESpawnActorCollisionHandlingMethod CollisionHandlingOverride=ESpawnActorCollisionHandlingMethod,UObject Owner=nullptr,ESpawnActorScaleMethod TransformScaleMethod=ESpawnActorScaleMethod,UObject ReturnValue) { return default; }
	public UObject FinishSpawningActor(UObject Actor,FTransform SpawnTransform,ESpawnActorScaleMethod TransformScaleMethod=ESpawnActorScaleMethod,UObject ReturnValue) { return default; }
	public FVector GetActorArrayAverageLocation(TArray<UObject> Actors,FVector ReturnValue) { return default; }
	public void GetActorArrayBounds(TArray<UObject> Actors,bool bOnlyCollidingComponents,FVector Center,FVector BoxExtent) {}
	public UObject GetActorOfClass(UObject WorldContextObject,UClass ActorClass,UObject ReturnValue) { return default; }
	public void GetAllActorsOfClass(UObject WorldContextObject,UClass ActorClass,TArray<UObject> OutActors) {}
	public void GetAllActorsWithInterface(UObject WorldContextObject,UClass Interface,TArray<UObject> OutActors) {}
	public void GetAllActorsWithTag(UObject WorldContextObject,sbyte Tag,TArray<UObject> OutActors) {}
	public void GetAllActorsOfClassWithTag(UObject WorldContextObject,UClass ActorClass,sbyte Tag,TArray<UObject> OutActors) {}
	public UObject FindNearestActor(FVector Origin,TArray<UObject> ActorsToCheck,float Distance,UObject ReturnValue) { return default; }
	public UObject GetGameInstance(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public int GetNumPlayerStates(UObject WorldContextObject,int ReturnValue) { return default; }
	public UObject GetPlayerState(UObject WorldContextObject,int PlayerStateIndex,UObject ReturnValue) { return default; }
	public UObject GetPlayerStateFromUniqueNetId(UObject WorldContextObject,FUniqueNetIdRepl UniqueId,UObject ReturnValue) { return default; }
	public int GetNumPlayerControllers(UObject WorldContextObject,int ReturnValue) { return default; }
	public int GetNumLocalPlayerControllers(UObject WorldContextObject,int ReturnValue) { return default; }
	public UObject GetPlayerController(UObject WorldContextObject,int PlayerIndex,UObject ReturnValue) { return default; }
	public UObject GetPlayerPawn(UObject WorldContextObject,int PlayerIndex,UObject ReturnValue) { return default; }
	public UObject GetPlayerCharacter(UObject WorldContextObject,int PlayerIndex,UObject ReturnValue) { return default; }
	public UObject GetPlayerCameraManager(UObject WorldContextObject,int PlayerIndex,UObject ReturnValue) { return default; }
	public UObject GetPlayerControllerFromID(UObject WorldContextObject,int ControllerID,UObject ReturnValue) { return default; }
	public UObject GetPlayerControllerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId,UObject ReturnValue) { return default; }
	public UObject CreatePlayer(UObject WorldContextObject,int ControllerId=-1,bool bSpawnPlayerController=true,UObject ReturnValue) { return default; }
	public UObject CreatePlayerFromPlatformUser(UObject WorldContextObject,FPlatformUserId UserId,bool bSpawnPlayerController=true,UObject ReturnValue) { return default; }
	public void RemovePlayer(UObject Player,bool bDestroyPawn) {}
	public int GetPlayerControllerID(UObject Player,int ReturnValue) { return default; }
	public void SetPlayerControllerID(UObject Player,int ControllerId) {}
	public void SetPlayerPlatformUserId(UObject PlayerController,FPlatformUserId UserId) {}
	public void LoadStreamLevel(UObject WorldContextObject,sbyte LevelName,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public void LoadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bMakeVisibleAfterLoad,bool bShouldBlockOnLoad,FLatentActionInfo LatentInfo) {}
	public void UnloadStreamLevel(UObject WorldContextObject,sbyte LevelName,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public void UnloadStreamLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,FLatentActionInfo LatentInfo,bool bShouldBlockOnUnload) {}
	public UObject GetStreamingLevel(UObject WorldContextObject,sbyte PackageName,UObject ReturnValue) { return default; }
	public void FlushLevelStreaming(UObject WorldContextObject) {}
	public void CancelAsyncLoading() {}
	public void OpenLevel(UObject WorldContextObject,sbyte LevelName,bool bAbsolute=true,sbyte Options=FString) {}
	public void OpenLevelBySoftObjectPtr(UObject WorldContextObject,TSoftObjectPtr<UWorld> Level,bool bAbsolute=true,sbyte Options=FString) {}
	public sbyte GetCurrentLevelName(UObject WorldContextObject,bool bRemovePrefixString=true,sbyte ReturnValue) { return default; }
	public UObject GetGameMode(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public UObject GetGameState(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public UClass GetObjectClass(UObject Object,UClass ReturnValue) { return default; }
	public bool ObjectIsA(UObject Object,UClass ObjectClass,bool ReturnValue) { return default; }
	public float GetGlobalTimeDilation(UObject WorldContextObject,float ReturnValue) { return default; }
	public void SetGlobalTimeDilation(UObject WorldContextObject,float TimeDilation) {}
	public bool SetGamePaused(UObject WorldContextObject,bool bPaused,bool ReturnValue) { return default; }
	public bool IsGamePaused(UObject WorldContextObject,bool ReturnValue) { return default; }
	public void SetForceDisableSplitscreen(UObject WorldContextObject,bool bDisable) {}
	public bool IsSplitscreenForceDisabled(UObject WorldContextObject,bool ReturnValue) { return default; }
	public void SetEnableWorldRendering(UObject WorldContextObject,bool bEnable) {}
	public bool GetEnableWorldRendering(UObject WorldContextObject,bool ReturnValue) { return default; }
	public EMouseCaptureMode GetViewportMouseCaptureMode(UObject WorldContextObject,EMouseCaptureMode ReturnValue) { return default; }
	public void SetViewportMouseCaptureMode(UObject WorldContextObject,EMouseCaptureMode MouseCaptureMode) {}
	public bool ApplyRadialDamage(UObject WorldContextObject,float BaseDamage,FVector Origin,float DamageRadius,UClass DamageTypeClass,TArray<UObject> IgnoreActors,UObject DamageCauser=NULL,UObject InstigatedByController=NULL,bool bDoFullDamage=false,ECollisionChannel DamagePreventionChannel=ECC_Visibility,bool ReturnValue) { return default; }
	public bool ApplyRadialDamageWithFalloff(UObject WorldContextObject,float BaseDamage,float MinimumDamage,FVector Origin,float DamageInnerRadius,float DamageOuterRadius,float DamageFalloff,UClass DamageTypeClass,TArray<UObject> IgnoreActors,UObject DamageCauser=NULL,UObject InstigatedByController=NULL,ECollisionChannel DamagePreventionChannel=ECC_Visibility,bool ReturnValue) { return default; }
	public float ApplyPointDamage(UObject DamagedActor,float BaseDamage,FVector HitFromDirection,FHitResult HitInfo,UObject EventInstigator,UObject DamageCauser,UClass DamageTypeClass,float ReturnValue) { return default; }
	public float ApplyDamage(UObject DamagedActor,float BaseDamage,UObject EventInstigator,UObject DamageCauser,UClass DamageTypeClass,float ReturnValue) { return default; }
	public void PlayWorldCameraShake(UObject WorldContextObject,UClass Shake,FVector Epicenter,float InnerRadius,float OuterRadius,float Falloff=1.f,bool bOrientShakeTowardsEpicenter=false) {}
	public UObject SpawnEmitterAtLocation(UObject WorldContextObject,UObject EmitterTemplate,FVector Location,FRotator Rotation=FRotator,FVector Scale=FVector,bool bAutoDestroy=true,EPSCPoolMethod PoolingMethod=EPSCPoolMethod,bool bAutoActivateSystem=true,UObject ReturnValue) { return default; }
	public UObject SpawnEmitterAttached(UObject EmitterTemplate,UObject AttachToComponent,sbyte AttachPointName=NAME_None,FVector Location=FVector,FRotator Rotation=FRotator,FVector Scale=FVector,EAttachLocation LocationType=EAttachLocation,bool bAutoDestroy=true,EPSCPoolMethod PoolingMethod=EPSCPoolMethod,bool bAutoActivate=true,UObject ReturnValue) { return default; }
	public bool AreAnyListenersWithinRange(UObject WorldContextObject,FVector Location,float MaximumRange,bool ReturnValue) { return default; }
	public bool GetClosestListenerLocation(UObject WorldContextObject,FVector Location,float MaximumRange,bool bAllowAttenuationOverride,FVector ListenerPosition,bool ReturnValue) { return default; }
	public void SetGlobalPitchModulation(UObject WorldContextObject,float PitchModulation,float TimeSec) {}
	public void SetSoundClassDistanceScale(UObject WorldContextObject,UObject SoundClass,float DistanceAttenuationScale,float TimeSec=0.0f) {}
	public void SetGlobalListenerFocusParameters(UObject WorldContextObject,float FocusAzimuthScale=1.0f,float NonFocusAzimuthScale=1.0f,float FocusDistanceScale=1.0f,float NonFocusDistanceScale=1.0f,float FocusVolumeScale=1.0f,float NonFocusVolumeScale=1.0f,float FocusPriorityScale=1.0f,float NonFocusPriorityScale=1.0f) {}
	public void PlaySound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject ConcurrencySettings=nullptr,UObject OwningActor=nullptr,bool bIsUISound=true) {}
	public UObject SpawnSound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject ConcurrencySettings=nullptr,bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public UObject CreateSound2D(UObject WorldContextObject,UObject Sound,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject ConcurrencySettings=nullptr,bool bPersistAcrossLevelTransition=false,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public void PlaySoundAtLocation(UObject WorldContextObject,UObject Sound,FVector Location,FRotator Rotation,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,UObject ConcurrencySettings=nullptr,UObject OwningActor=nullptr,UObject InitialParams=nullptr) {}
	public UObject SpawnSoundAtLocation(UObject WorldContextObject,UObject Sound,FVector Location,FRotator Rotation=FRotator,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,UObject ConcurrencySettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public UObject SpawnSoundAttached(UObject Sound,UObject AttachToComponent,sbyte AttachPointName=NAME_None,FVector Location=FVector,FRotator Rotation=FRotator,EAttachLocation LocationType=EAttachLocation,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,UObject ConcurrencySettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public void PlayDialogue2D(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f) {}
	public UObject SpawnDialogue2D(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public void PlayDialogueAtLocation(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr) {}
	public UObject SpawnDialogueAtLocation(UObject WorldContextObject,UObject Dialogue,FDialogueContext Context,FVector Location,FRotator Rotation=FRotator,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public UObject SpawnDialogueAttached(UObject Dialogue,FDialogueContext Context,UObject AttachToComponent,sbyte AttachPointName=NAME_None,FVector Location=FVector,FRotator Rotation=FRotator,EAttachLocation LocationType=EAttachLocation,bool bStopWhenAttachedToDestroyed=false,float VolumeMultiplier=1.f,float PitchMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public UObject SpawnForceFeedbackAtLocation(UObject WorldContextObject,UObject ForceFeedbackEffect,FVector Location,FRotator Rotation=FRotator,bool bLooping=false,float IntensityMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public UObject SpawnForceFeedbackAttached(UObject ForceFeedbackEffect,UObject AttachToComponent,sbyte AttachPointName=NAME_None,FVector Location=FVector,FRotator Rotation=FRotator,EAttachLocation LocationType=EAttachLocation,bool bStopWhenAttachedToDestroyed=false,bool bLooping=false,float IntensityMultiplier=1.f,float StartTime=0.f,UObject AttenuationSettings=nullptr,bool bAutoDestroy=true,UObject ReturnValue) { return default; }
	public void SetSubtitlesEnabled(bool bEnabled) {}
	public bool AreSubtitlesEnabled(bool ReturnValue) { return default; }
	public void SetBaseSoundMix(UObject WorldContextObject,UObject InSoundMix) {}
	public void PrimeSound(UObject InSound) {}
	public TArray<sbyte> GetAvailableSpatialPluginNames(UObject WorldContextObject,TArray<sbyte> ReturnValue) { return default; }
	public sbyte GetActiveSpatialPluginName(UObject WorldContextObject,sbyte ReturnValue) { return default; }
	public bool SetActiveSpatialPluginByName(UObject WorldContextObject,sbyte InPluginName,bool ReturnValue) { return default; }
	public void PrimeAllSoundsInSoundClass(UObject InSoundClass) {}
	public void UnRetainAllSoundsInSoundClass(UObject InSoundClass) {}
	public void SetSoundMixClassOverride(UObject WorldContextObject,UObject InSoundMixModifier,UObject InSoundClass,float Volume=1.0f,float Pitch=1.0f,float FadeInTime=1.0f,bool bApplyToChildren=true) {}
	public void ClearSoundMixClassOverride(UObject WorldContextObject,UObject InSoundMixModifier,UObject InSoundClass,float FadeOutTime=1.0f) {}
	public void PushSoundMixModifier(UObject WorldContextObject,UObject InSoundMixModifier) {}
	public void PopSoundMixModifier(UObject WorldContextObject,UObject InSoundMixModifier) {}
	public void ClearSoundMixModifiers(UObject WorldContextObject) {}
	public void ActivateReverbEffect(UObject WorldContextObject,UObject ReverbEffect,sbyte TagName,float Priority=0.f,float Volume=0.5f,float FadeTime=2.f) {}
	public void DeactivateReverbEffect(UObject WorldContextObject,sbyte TagName) {}
	public UObject GetCurrentReverbEffect(UObject WorldContextObject,UObject ReturnValue) { return default; }
	public void SetMaxAudioChannelsScaled(UObject WorldContextObject,float MaxChannelCountScale) {}
	public int GetMaxAudioChannelCount(UObject WorldContextObject,int ReturnValue) { return default; }
	public UObject SpawnDecalAtLocation(UObject WorldContextObject,UObject DecalMaterial,FVector DecalSize,FVector Location,FRotator Rotation=FRotator,float LifeSpan=0,UObject ReturnValue) { return default; }
	public UObject SpawnDecalAttached(UObject DecalMaterial,FVector DecalSize,UObject AttachToComponent,sbyte AttachPointName=NAME_None,FVector Location=FVector,FRotator Rotation=FRotator,EAttachLocation LocationType=EAttachLocation,float LifeSpan=0,UObject ReturnValue) { return default; }
	public void BreakHitResult(FHitResult Hit,bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UObject PhysMat,UObject HitActor,UObject HitComponent,sbyte HitBoneName,sbyte BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd) {}
	public FHitResult MakeHitResult(bool bBlockingHit,bool bInitialOverlap,float Time,float Distance,FVector Location,FVector ImpactPoint,FVector Normal,FVector ImpactNormal,UObject PhysMat,UObject HitActor,UObject HitComponent,sbyte HitBoneName,sbyte BoneName,int HitItem,int ElementIndex,int FaceIndex,FVector TraceStart,FVector TraceEnd,FHitResult ReturnValue) { return default; }
	public EPhysicalSurface GetSurfaceType(FHitResult Hit,EPhysicalSurface ReturnValue) { return default; }
	public bool FindCollisionUV(FHitResult Hit,int UVChannel,FVector2D UV,bool ReturnValue) { return default; }
	public UObject CreateSaveGameObject(UClass SaveGameClass,UObject ReturnValue) { return default; }
	public bool SaveGameToSlot(UObject SaveGameObject,sbyte SlotName,int UserIndex,bool ReturnValue) { return default; }
	public bool DoesSaveGameExist(sbyte SlotName,int UserIndex,bool ReturnValue) { return default; }
	public UObject LoadGameFromSlot(sbyte SlotName,int UserIndex,UObject ReturnValue) { return default; }
	public bool DeleteGameInSlot(sbyte SlotName,int UserIndex,bool ReturnValue) { return default; }
	public double GetWorldDeltaSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public double GetTimeSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public double GetUnpausedTimeSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public double GetRealTimeSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public double GetAudioTimeSeconds(UObject WorldContextObject,double ReturnValue) { return default; }
	public void GetAccurateRealTime(int Seconds,double PartialSeconds) {}
	public void EnableLiveStreaming(bool Enable) {}
	public sbyte GetPlatformName(sbyte ReturnValue) { return default; }
	public bool BlueprintSuggestProjectileVelocity(UObject WorldContextObject,FVector TossVelocity,FVector StartLocation,FVector EndLocation,float LaunchSpeed,float OverrideGravityZ,ESuggestProjVelocityTraceOption TraceOption,float CollisionRadius,bool bFavorHighArc,bool bDrawDebug,bool ReturnValue) { return default; }
	public bool Blueprint_PredictProjectilePath_ByObjectType(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.f,float MaxSimTime=2.f,float OverrideGravityZ=0,bool ReturnValue) { return default; }
	public bool Blueprint_PredictProjectilePath_ByTraceChannel(UObject WorldContextObject,FHitResult OutHit,TArray<FVector> OutPathPositions,FVector OutLastTraceDestination,FVector StartPos,FVector LaunchVelocity,bool bTracePath,float ProjectileRadius,byte TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,float DrawDebugTime,float SimFrequency=15.f,float MaxSimTime=2.f,float OverrideGravityZ=0,bool ReturnValue) { return default; }
	public bool Blueprint_PredictProjectilePath_Advanced(UObject WorldContextObject,FPredictProjectilePathParams PredictParams,FPredictProjectilePathResult PredictResult,bool ReturnValue) { return default; }
	public bool SuggestProjectileVelocity_CustomArc(UObject WorldContextObject,FVector OutLaunchVelocity,FVector StartPos,FVector EndPos,float OverrideGravityZ=0,float ArcParam=0.5f,bool ReturnValue) { return default; }
	public FIntVector GetWorldOriginLocation(UObject WorldContextObject,FIntVector ReturnValue) { return default; }
	public void SetWorldOriginLocation(UObject WorldContextObject,FIntVector NewLocation) {}
	public FVector RebaseLocalOriginOntoZero(UObject WorldContextObject,FVector WorldLocation,FVector ReturnValue) { return default; }
	public FVector RebaseZeroOriginOntoLocal(UObject WorldContextObject,FVector WorldLocation,FVector ReturnValue) { return default; }
	public int GrassOverlappingSphereCount(UObject WorldContextObject,UObject StaticMesh,FVector CenterPosition,float Radius,int ReturnValue) { return default; }
	public bool DeprojectScreenToWorld(UObject Player,FVector2D ScreenPosition,FVector WorldPosition,FVector WorldDirection,bool ReturnValue) { return default; }
	public bool DeprojectSceneCaptureToWorld(UObject SceneCapture2D,FVector2D TargetUV,FVector WorldPosition,FVector WorldDirection,bool ReturnValue) { return default; }
	public bool ProjectWorldToScreen(UObject Player,FVector WorldPosition,FVector2D ScreenPosition,bool bPlayerViewportRelative=false,bool ReturnValue) { return default; }
	public void GetViewProjectionMatrix(FMinimalViewInfo DesiredView,FMatrix ViewMatrix,FMatrix ProjectionMatrix,FMatrix ViewProjectionMatrix) {}
	public void GetKeyValue(sbyte Pair,sbyte Key,sbyte Value) {}
	public sbyte ParseOption(sbyte Options,sbyte Key,sbyte ReturnValue) { return default; }
	public bool HasOption(sbyte Options,sbyte InKey,bool ReturnValue) { return default; }
	public int GetIntOption(sbyte Options,sbyte Key,int DefaultValue,int ReturnValue) { return default; }
	public bool HasLaunchOption(sbyte OptionToCheck,bool ReturnValue) { return default; }
	public void AnnounceAccessibleString(sbyte AnnouncementString) {}
}
