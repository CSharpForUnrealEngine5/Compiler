#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkeletalMeshComponent.h")]
///<summary>SkeletalMeshComponent is used to create an instance of an animated SkeletalMesh asset.</summary>
public partial class USkeletalMeshComponent : USkinnedMeshComponent {
// SkeletalMeshComponent
	public USkeletalMesh SkeletalMeshAsset;
	public void SetSkeletalMeshAsset(UObject NewMesh) {}
	public UObject GetSkeletalMeshAsset(UObject ReturnValue) { return default; }
	public UAnimBlueprint AnimationBlueprint_DEPRECATED;
	public UAnimBlueprintGeneratedClass AnimBlueprintGeneratedClass;
	public UClass AnimClass;
	public UAnimInstance AnimScriptInstance;
	public TArray<UAnimInstance> SubInstances;
	public UAnimInstance PostProcessAnimInstance;
	public void ToggleDisablePostProcessBlueprint() {}
	public bool GetDisablePostProcessBlueprint(bool ReturnValue) { return default; }
	public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess) {}
	public FSingleAnimationPlayData AnimationData;
	public FVector RootBoneTranslation;
	public FVector LineCheckBoundsScale;
	public TArray<UAnimInstance> LinkedInstances;
	public TArray<FTransform> CachedBoneSpaceTransforms;
	public TArray<FTransform> CachedComponentSpaceTransforms;
	public bool GetFloatAttribute_Ref(sbyte BoneName,sbyte AttributeName,float OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetTransformAttribute_Ref(sbyte BoneName,sbyte AttributeName,FTransform OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetIntegerAttribute_Ref(sbyte BoneName,sbyte AttributeName,int OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetStringAttribute_Ref(sbyte BoneName,sbyte AttributeName,sbyte OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetFloatAttribute(sbyte BoneName,sbyte AttributeName,float DefaultValue,float OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetTransformAttribute(sbyte BoneName,sbyte AttributeName,FTransform DefaultValue,FTransform OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetIntegerAttribute(sbyte BoneName,sbyte AttributeName,int DefaultValue,int OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public bool GetStringAttribute(sbyte BoneName,sbyte AttributeName,sbyte DefaultValue,sbyte OutValue,ECustomBoneAttributeLookup LookupType=ECustomBoneAttributeLookup,bool ReturnValue) { return default; }
	public float GlobalAnimRateScale;
	public byte KinematicBonesUpdateType;
	public byte PhysicsTransformUpdateMode;
	public byte AnimationMode;
	public bool bDisablePostProcessBlueprint;
	public bool bUpdateOverlapsOnAnimationFinalize;
	public bool bHasValidBodies;
	public bool bBlendPhysics;
	public bool bEnablePhysicsOnDedicatedServer;
	public bool bUpdateMeshWhenKinematic;
	public bool bUpdateJointsFromAnimation;
	public bool bAllowClothActors;
	public bool bDisableClothSimulation;
	public bool bDisableRigidBodyAnimNode;
	public bool bAllowAnimCurveEvaluation;
	public bool bDisableAnimCurves_DEPRECATED;
	public bool bCollideWithEnvironment;
	public bool bCollideWithAttachedChildren;
	public bool bForceCollisionUpdate;
	public bool bLocalSpaceSimulation;
	public bool bResetAfterTeleport;
	public bool bDeferKinematicBoneUpdate;
	public bool bNoSkeletonUpdate;
	public bool bPauseAnims;
	public bool bUseRefPoseOnInitAnim;
	public bool bEnablePerPolyCollision;
	public bool bForceRefpose;
	public bool bOnlyAllowAutonomousTickPose;
	public bool bIsAutonomousTickPose;
	public bool bOldForceRefPose;
	public bool bShowPrePhysBones;
	public bool bRequiredBonesUpToDate;
	public bool bAnimTreeInitialised;
	public bool bIncludeComponentLocationIntoBounds;
	public bool bEnableLineCheckWithBounds;
	public bool bPropagateCurvesToFollowers;
	public bool bSkipKinematicUpdateWhenInterpolating;
	public bool bSkipBoundsUpdateWhenInterpolating;
	public bool bUpdateAnimationInEditor;
	public bool bUpdateClothInEditor;
	public bool bOverrideDefaultAnimatingRig;
	public bool bNeedsQueuedAnimEventsDispatched;
	public ushort CachedAnimCurveUidVersion;
	public float ClothBlendWeight;
	public bool bWaitForParallelClothTask;
	public TArray<sbyte> DisallowedAnimCurves;
	public UBodySetup BodySetup;
	public float ClothMaxDistanceScale;
	public FConstraintBrokenSignature OnConstraintBroken;
	public FPlasticDeformationEventSignature OnPlasticDeformation;
	public UClass ClothingSimulationFactory;
	public void SetAnimClass(UClass NewClass) {}
	public UClass GetAnimClass(UClass ReturnValue) { return default; }
	public UObject GetAnimInstance(UObject ReturnValue) { return default; }
	public UObject GetPostProcessInstance(UObject ReturnValue) { return default; }
	public UObject GetLinkedAnimGraphInstanceByTag(sbyte InTag,UObject ReturnValue) { return default; }
	public void GetLinkedAnimGraphInstancesByTag(sbyte InTag,TArray<UObject> OutLinkedInstances) {}
	public void LinkAnimGraphByTag(sbyte InTag,UClass InClass) {}
	public void LinkAnimClassLayers(UClass InClass) {}
	public void UnlinkAnimClassLayers(UClass InClass) {}
	public UObject GetLinkedAnimLayerInstanceByGroup(sbyte InGroup,UObject ReturnValue) { return default; }
	public UObject GetLinkedAnimLayerInstanceByClass(UClass InClass,UObject ReturnValue) { return default; }
	public bool HasValidAnimationInstance(bool ReturnValue) { return default; }
	public void ResetAnimInstanceDynamics(ETeleportType InTeleportType=ETeleportType) {}
	public void SetAnimationMode(EAnimationMode InAnimationMode) {}
	public EAnimationMode GetAnimationMode(EAnimationMode ReturnValue) { return default; }
	public void PlayAnimation(UObject NewAnimToPlay,bool bLooping) {}
	public void SetAnimation(UObject NewAnimToPlay) {}
	public void Play(bool bLooping) {}
	public void Stop() {}
	public bool IsPlaying(bool ReturnValue) { return default; }
	public void SetPosition(float InPos,bool bFireNotifies=true) {}
	public float GetPosition(float ReturnValue) { return default; }
	public void SetPlayRate(float Rate) {}
	public float GetPlayRate(float ReturnValue) { return default; }
	public void OverrideAnimationData(UObject InAnimToPlay,bool bIsLooping=true,bool bIsPlaying=true,float Position=0.f,float PlayRate=1.f) {}
	public void SetMorphTarget(sbyte MorphTargetName,float Value,bool bRemoveZeroWeight=true) {}
	public void ClearMorphTargets() {}
	public float GetMorphTarget(sbyte MorphTargetName,float ReturnValue) { return default; }
	public void SnapshotPose(FPoseSnapshot Snapshot) {}
	public void SetAllowClothActors(bool bInAllow) {}
	public bool GetAllowClothActors(bool ReturnValue) { return default; }
	public float GetClothMaxDistanceScale(float ReturnValue) { return default; }
	public void SetClothMaxDistanceScale(float Scale) {}
	public void ForceClothNextUpdateTeleport() {}
	public void ForceClothNextUpdateTeleportAndReset() {}
	public void SuspendClothingSimulation() {}
	public void ResumeClothingSimulation() {}
	public bool IsClothingSimulationSuspended(bool ReturnValue) { return default; }
	public void ResetClothTeleportMode() {}
	public void BindClothToLeaderPoseComponent() {}
	public void UnbindClothFromLeaderPoseComponent(bool bRestoreSimulationSpace=true) {}
	public void SetAllowRigidBodyAnimNode(bool bInAllow,bool bReinitAnim=true) {}
	public bool GetAllowRigidBodyAnimNode(bool ReturnValue) { return default; }
	public void SetUpdateAnimationInEditor(bool NewUpdateState) {}
	public void SetUpdateClothInEditor(bool NewUpdateState) {}
	public void SetDisableAnimCurves(bool bInDisableAnimCurves) {}
	public bool GetDisableAnimCurves(bool ReturnValue) { return default; }
	public void SetAllowAnimCurveEvaluation(bool bInAllow) {}
	public bool GetAllowedAnimCurveEvaluate(bool ReturnValue) { return default; }
	public void AllowAnimCurveEvaluation(sbyte NameOfCurve,bool bAllow) {}
	public void ResetAllowedAnimCurveEvaluation() {}
	public void SetAllowedAnimCurvesEvaluation(TArray<sbyte> List,bool bAllow) {}
	public float GetTeleportRotationThreshold(float ReturnValue) { return default; }
	public void SetTeleportRotationThreshold(float Threshold) {}
	public float GetTeleportDistanceThreshold(float ReturnValue) { return default; }
	public void SetTeleportDistanceThreshold(float Threshold) {}
	public float TeleportDistanceThreshold;
	public float TeleportRotationThreshold;
	public uint LastPoseTickFrame;
	public UObject GetClothingSimulationInteractor(UObject ReturnValue) { return default; }
	public UClothingSimulationInteractor ClothingInteractor;
	public FOnAnimInitialized OnAnimInitialized;
	public void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision,sbyte BoneName=NAME_None) {}
	public void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision,sbyte BoneName=NAME_None,bool bIncludeSelf=true) {}
	public void SetEnableBodyGravity(bool bEnableGravity,sbyte BoneName) {}
	public bool IsBodyGravityEnabled(sbyte BoneName,bool ReturnValue) { return default; }
	public void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity,sbyte BoneName,bool bIncludeSelf=true) {}
	public bool K2_GetClosestPointOnPhysicsAsset(FVector WorldPosition,FVector ClosestWorldPosition,FVector Normal,sbyte BoneName,float Distance,bool ReturnValue) { return default; }
	public float GetBoneMass(sbyte BoneName=NAME_None,bool bScaleMass=true,float ReturnValue) { return default; }
	public FVector GetSkeletalCenterOfMass(FVector ReturnValue) { return default; }
	public void AddForceToAllBodiesBelow(FVector Force,sbyte BoneName=NAME_None,bool bAccelChange=false,bool bIncludeSelf=true) {}
	public void AddImpulseToAllBodiesBelow(FVector Impulse,sbyte BoneName=NAME_None,bool bVelChange=false,bool bIncludeSelf=true) {}
	public void TermBodiesBelow(sbyte ParentBoneName) {}
	public void SetAllBodiesSimulatePhysics(bool bNewSimulate) {}
	public void SetPhysicsBlendWeight(float PhysicsBlendWeight) {}
	public void SetEnablePhysicsBlending(bool bNewBlendPhysics) {}
	public void SetAllBodiesBelowPhysicsDisabled(sbyte InBoneName,bool bDisabled,bool bIncludeSelf=true) {}
	public void SetAllBodiesBelowLinearVelocity(sbyte InBoneName,FVector LinearVelocity,bool bIncludeSelf=true) {}
	public FVector GetBoneLinearVelocity(sbyte InBoneName,FVector ReturnValue) { return default; }
	public void SetAllBodiesBelowSimulatePhysics(sbyte InBoneName,bool bNewSimulate,bool bIncludeSelf=true) {}
	public void ResetAllBodiesSimulatePhysics() {}
	public void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false) {}
	public void SetAllBodiesBelowPhysicsBlendWeight(sbyte InBoneName,float PhysicsBlendWeight,bool bSkipCustomPhysicsType=false,bool bIncludeSelf=true) {}
	public void AccumulateAllBodiesBelowPhysicsBlendWeight(sbyte InBoneName,float AddPhysicsBlendWeight,bool bSkipCustomPhysicsType=false) {}
	public void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false) {}
	public void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive,bool bEnableTwistDrive,bool bSkipCustomPhysicsType=false) {}
	public void SetAllMotorsAngularDriveParams(float InSpring,float InDamping,float InForceLimit,bool bSkipCustomPhysicsType=false) {}
	public void SetConstraintProfile(sbyte JointName,sbyte ProfileName,bool bDefaultIfNotFound=false) {}
	public void SetConstraintProfileForAll(sbyte ProfileName,bool bDefaultIfNotFound=false) {}
	public sbyte FindConstraintBoneName(int ConstraintIndex,sbyte ReturnValue) { return default; }
	public void BreakConstraint(FVector Impulse,FVector HitLocation,sbyte InBoneName) {}
	public FConstraintInstanceAccessor GetConstraintByName(sbyte ConstraintName,bool bIncludesTerminated,FConstraintInstanceAccessor ReturnValue) { return default; }
	public void GetConstraints(bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	public void GetConstraintsFromBody(sbyte BodyName,bool bParentConstraints,bool bChildConstraints,bool bIncludesTerminated,TArray<FConstraintInstanceAccessor> OutConstraints) {}
	public void SetAngularLimits(sbyte InBoneName,float Swing1LimitAngle,float TwistLimitAngle,float Swing2LimitAngle) {}
	public void GetCurrentJointAngles(sbyte InBoneName,float Swing1Angle,float TwistAngle,float Swing2Angle) {}
	public UAnimSequence SequenceToPlay_DEPRECATED;
	public UAnimationAsset AnimToPlay_DEPRECATED;
	public bool bDefaultLooping_DEPRECATED;
	public bool bDefaultPlaying_DEPRECATED;
	public float DefaultPosition_DEPRECATED;
	public float DefaultPlayRate_DEPRECATED;
	public TSoftObjectPtr<UObject> DefaultAnimatingRigOverride;
	public void SetDefaultAnimatingRigOverride(TSoftObjectPtr<UObject> InAnimatingRig) {}
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRigOverride(TSoftObjectPtr<UObject> ReturnValue) { return default; }
	public TSoftObjectPtr<UObject> GetDefaultAnimatingRig(TSoftObjectPtr<UObject> ReturnValue) { return default; }
}
