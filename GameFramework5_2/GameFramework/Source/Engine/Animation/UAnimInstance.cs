#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimInstance.h")]
public partial class UAnimInstance : UObject {
// AnimInstance
	public USkeleton CurrentSkeleton;
	public byte RootMotionMode;
	public bool bUseMultiThreadedAnimationUpdate;
	public bool bUsingCopyPoseFromMesh;
	public bool bReceiveNotifiesFromLinkedInstances;
	public bool bPropagateNotifiesToLinkedInstances;
	public bool bUseMainInstanceMontageEvaluationData;
	public bool bQueueMontageEvents;
	public UObject TryGetPawnOwner(UObject ReturnValue) { return default; }
	public void SavePoseSnapshot(sbyte SnapshotName) {}
	public void RemovePoseSnapshot(sbyte SnapshotName) {}
	public void SnapshotPose(FPoseSnapshot Snapshot) {}
	public bool GetReceiveNotifiesFromLinkedInstances(bool ReturnValue) { return default; }
	public void SetReceiveNotifiesFromLinkedInstances(bool bSet) {}
	public bool GetPropagateNotifiesToLinkedInstances(bool ReturnValue) { return default; }
	public void SetPropagateNotifiesToLinkedInstances(bool bSet) {}
	public bool IsUsingMainInstanceMontageEvaluationData(bool ReturnValue) { return default; }
	public void SetUseMainInstanceMontageEvaluationData(bool bSet) {}
	public UObject GetOwningActor(UObject ReturnValue) { return default; }
	public UObject GetOwningComponent(UObject ReturnValue) { return default; }
	public void BlueprintInitializeAnimation() {}
	public void BlueprintUpdateAnimation(float DeltaTimeX) {}
	public void BlueprintPostEvaluateAnimation() {}
	public void BlueprintBeginPlay() {}
	public void BlueprintLinkedAnimationLayersInitialized() {}
	public void BlueprintThreadSafeUpdateAnimation(float DeltaTime) {}
	public UObject PlaySlotAnimationAsDynamicMontage(UObject Asset,sbyte SlotNodeName,float BlendInTime=0.25f,float BlendOutTime=0.25f,float InPlayRate=1.f,int LoopCount=1,float BlendOutTriggerTime=-1.f,float InTimeToStartMontageAt=0.f,UObject ReturnValue) { return default; }
	public UObject PlaySlotAnimationAsDynamicMontage_WithBlendArgs(UObject Asset,sbyte SlotNodeName,FAlphaBlendArgs BlendIn,FAlphaBlendArgs BlendOut,float InPlayRate=1.f,int LoopCount=1,float BlendOutTriggerTime=-1.f,float InTimeToStartMontageAt=0.f,UObject ReturnValue) { return default; }
	public UObject PlaySlotAnimationAsDynamicMontage_WithBlendSettings(UObject Asset,sbyte SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate=1.f,int LoopCount=1,float BlendOutTriggerTime=-1.f,float InTimeToStartMontageAt=0.f,UObject ReturnValue) { return default; }
	public void StopSlotAnimation(float InBlendOutTime=0.25f,sbyte SlotNodeName=NAME_None) {}
	public bool IsPlayingSlotAnimation(UObject Asset,sbyte SlotNodeName,bool ReturnValue) { return default; }
	public float Montage_Play(UObject MontageToPlay,float InPlayRate=1.f,EMontagePlayReturnType ReturnValueType=EMontagePlayReturnType,float InTimeToStartMontageAt=0.f,bool bStopAllMontages=true,float ReturnValue) { return default; }
	public float Montage_PlayWithBlendIn(UObject MontageToPlay,FAlphaBlendArgs BlendIn,float InPlayRate=1.f,EMontagePlayReturnType ReturnValueType=EMontagePlayReturnType,float InTimeToStartMontageAt=0.f,bool bStopAllMontages=true,float ReturnValue) { return default; }
	public float Montage_PlayWithBlendSettings(UObject MontageToPlay,FMontageBlendSettings BlendInSettings,float InPlayRate=1.f,EMontagePlayReturnType ReturnValueType=EMontagePlayReturnType,float InTimeToStartMontageAt=0.f,bool bStopAllMontages=true,float ReturnValue) { return default; }
	public void Montage_Stop(float InBlendOutTime,UObject Montage=NULL) {}
	public void Montage_StopWithBlendOut(FAlphaBlendArgs BlendOut,UObject Montage=nullptr) {}
	public void Montage_StopWithBlendSettings(FMontageBlendSettings BlendOutSettings,UObject Montage=nullptr) {}
	public void Montage_StopGroupByName(float InBlendOutTime,sbyte GroupName) {}
	public void Montage_Pause(UObject Montage=NULL) {}
	public void Montage_Resume(UObject Montage) {}
	public void Montage_JumpToSection(sbyte SectionName,UObject Montage=NULL) {}
	public void Montage_JumpToSectionsEnd(sbyte SectionName,UObject Montage=NULL) {}
	public void Montage_SetNextSection(sbyte SectionNameToChange,sbyte NextSection,UObject Montage=NULL) {}
	public void Montage_SetPlayRate(UObject Montage,float NewPlayRate=1.f) {}
	public bool Montage_IsActive(UObject Montage,bool ReturnValue) { return default; }
	public bool Montage_IsPlaying(UObject Montage,bool ReturnValue) { return default; }
	public sbyte Montage_GetCurrentSection(UObject Montage=NULL,sbyte ReturnValue) { return default; }
	public float Montage_GetPosition(UObject Montage,float ReturnValue) { return default; }
	public void Montage_SetPosition(UObject Montage,float NewPosition) {}
	public bool Montage_GetIsStopped(UObject Montage,bool ReturnValue) { return default; }
	public float Montage_GetBlendTime(UObject Montage,float ReturnValue) { return default; }
	public float Montage_GetPlayRate(UObject Montage,float ReturnValue) { return default; }
	public float Montage_GetEffectivePlayRate(UObject Montage,float ReturnValue) { return default; }
	public void MontageSync_Follow(UObject MontageFollower,UObject OtherAnimInstance,UObject MontageLeader) {}
	public void MontageSync_StopFollowing(UObject MontageFollower) {}
	public bool IsAnyMontagePlaying(bool ReturnValue) { return default; }
	public UObject GetCurrentActiveMontage(UObject ReturnValue) { return default; }
	public FOnMontageBlendingOutStartedMCDelegate OnMontageBlendingOut;
	public FOnMontageStartedMCDelegate OnMontageStarted;
	public FOnMontageEndedMCDelegate OnMontageEnded;
	public FOnAllMontageInstancesEndedMCDelegate OnAllMontageInstancesEnded;
	public UObject GetLinkedAnimGraphInstanceByTag(sbyte InTag,UObject ReturnValue) { return default; }
	public void GetLinkedAnimGraphInstancesByTag(sbyte InTag,TArray<UObject> OutLinkedInstances) {}
	public void LinkAnimGraphByTag(sbyte InTag,UClass InClass) {}
	public void LinkAnimClassLayers(UClass InClass) {}
	public void UnlinkAnimClassLayers(UClass InClass) {}
	public UObject GetLinkedAnimLayerInstanceByGroup(sbyte InGroup,UObject ReturnValue) { return default; }
	public void GetLinkedAnimLayerInstancesByGroup(sbyte InGroup,TArray<UObject> OutLinkedInstances) {}
	public UObject GetLinkedAnimLayerInstanceByGroupAndClass(sbyte InGroup,UClass InClass,UObject ReturnValue) { return default; }
	public UObject GetLinkedAnimLayerInstanceByClass(UClass InClass,UObject ReturnValue) { return default; }
	public void RequestSlotGroupInertialization(sbyte InSlotGroupName,float Duration,UObject BlendProfile=nullptr) {}
	public void SetRootMotionMode(byte Value) {}
	public float GetInstanceAssetPlayerLength(int AssetPlayerIndex,float ReturnValue) { return default; }
	public float GetInstanceAssetPlayerTime(int AssetPlayerIndex,float ReturnValue) { return default; }
	public float GetInstanceAssetPlayerTimeFraction(int AssetPlayerIndex,float ReturnValue) { return default; }
	public float GetInstanceAssetPlayerTimeFromEnd(int AssetPlayerIndex,float ReturnValue) { return default; }
	public float GetInstanceAssetPlayerTimeFromEndFraction(int AssetPlayerIndex,float ReturnValue) { return default; }
	public float GetInstanceMachineWeight(int MachineIndex,float ReturnValue) { return default; }
	public float GetInstanceStateWeight(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public float GetInstanceCurrentStateElapsedTime(int MachineIndex,float ReturnValue) { return default; }
	public float GetInstanceTransitionCrossfadeDuration(int MachineIndex,int TransitionIndex,float ReturnValue) { return default; }
	public float GetInstanceTransitionTimeElapsed(int MachineIndex,int TransitionIndex,float ReturnValue) { return default; }
	public float GetInstanceTransitionTimeElapsedFraction(int MachineIndex,int TransitionIndex,float ReturnValue) { return default; }
	public float GetRelevantAnimTimeRemaining(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public float GetRelevantAnimTimeRemainingFraction(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public float GetRelevantAnimLength(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public float GetRelevantAnimTime(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public float GetRelevantAnimTimeFraction(int MachineIndex,int StateIndex,float ReturnValue) { return default; }
	public bool WasAnimNotifyStateActiveInAnyState(UClass AnimNotifyStateType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyStateActiveInStateMachine(int MachineIndex,UClass AnimNotifyStateType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyStateActiveInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyStateType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyTriggeredInSourceState(int MachineIndex,int StateIndex,UClass AnimNotifyType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyNameTriggeredInSourceState(int MachineIndex,int StateIndex,sbyte NotifyName,bool ReturnValue) { return default; }
	public bool WasAnimNotifyTriggeredInStateMachine(int MachineIndex,UClass AnimNotifyType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyNameTriggeredInStateMachine(int MachineIndex,sbyte NotifyName,bool ReturnValue) { return default; }
	public bool WasAnimNotifyTriggeredInAnyState(UClass AnimNotifyType,bool ReturnValue) { return default; }
	public bool WasAnimNotifyNameTriggeredInAnyState(sbyte NotifyName,bool ReturnValue) { return default; }
	public float GetCurveValue(sbyte CurveName,float ReturnValue) { return default; }
	public bool GetCurveValueWithDefault(sbyte CurveName,float DefaultValue,float OutValue,bool ReturnValue) { return default; }
	public void GetActiveCurveNames(EAnimCurveType CurveType,TArray<sbyte> OutNames) {}
	public void GetAllCurveNames(TArray<sbyte> OutNames) {}
	public sbyte GetCurrentStateName(int MachineIndex,sbyte ReturnValue) { return default; }
	public void SetMorphTarget(sbyte MorphTargetName,float Value) {}
	public void ClearMorphTargets() {}
	public float CalculateDirection(FVector Velocity,FRotator BaseRotation,float ReturnValue) { return default; }
	public void LockAIResources(bool bLockMovement,bool LockAILogic) {}
	public void UnlockAIResources(bool bUnlockMovement,bool UnlockAILogic) {}
	public bool GetTimeToClosestMarker(sbyte SyncGroup,sbyte MarkerName,float OutMarkerTime,bool ReturnValue) { return default; }
	public bool HasMarkerBeenHitThisFrame(sbyte SyncGroup,sbyte MarkerName,bool ReturnValue) { return default; }
	public bool IsSyncGroupBetweenMarkers(sbyte InSyncGroupName,sbyte PreviousMarker,sbyte NextMarker,bool bRespectMarkerOrder=true,bool ReturnValue) { return default; }
	public FMarkerSyncAnimPosition GetSyncGroupPosition(sbyte InSyncGroupName,FMarkerSyncAnimPosition ReturnValue) { return default; }
	public bool RequestTransitionEvent(sbyte EventName,double RequestTimeout,ETransitionRequestQueueMode QueueMode,ETransitionRequestOverwriteMode OverwriteMode,bool ReturnValue) { return default; }
	public void ClearTransitionEvents(sbyte EventName) {}
	public void ClearAllTransitionEvents() {}
	public bool QueryTransitionEvent(int MachineIndex,int TransitionIndex,sbyte EventName,bool ReturnValue) { return default; }
	public bool QueryAndMarkTransitionEvent(int MachineIndex,int TransitionIndex,sbyte EventName,bool ReturnValue) { return default; }
	public FSoftClassPath PostCompileValidationClassName;
	public void ResetDynamics(ETeleportType InTeleportType) {}
	public FAnimNotifyQueue NotifyQueue;
	public TArray<FAnimNotifyEvent> ActiveAnimNotifyState;
	public TArray<FAnimNotifyEventReference> ActiveAnimNotifyEventReference;
	public float GetDeltaSeconds(float ReturnValue) { return default; }
}
