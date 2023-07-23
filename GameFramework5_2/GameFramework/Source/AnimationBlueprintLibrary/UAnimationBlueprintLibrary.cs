#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationBlueprintLibrary.h")]
///<summary>Blueprint library for altering and analyzing animation / skeletal data</summary>
public partial class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary {
// AnimationBlueprintLibrary
	public void GetNumFrames(UObject AnimationSequenceBase,int NumFrames) {}
	public void GetNumKeys(UObject AnimationSequenceBase,int NumKeys) {}
	public void GetAnimationTrackNames(UObject AnimationSequenceBase,TArray<sbyte> TrackNames) {}
	public void GetMontageSlotNames(UObject AnimationMontage,TArray<sbyte> SlotNames) {}
	public void GetAnimationCurveNames(UObject AnimationSequence,ERawCurveTrackTypes CurveType,TArray<sbyte> CurveNames) {}
	public void GetRawTrackPositionData(UObject AnimationSequenceBase,sbyte TrackName,TArray<FVector> PositionData) {}
	public void GetRawTrackRotationData(UObject AnimationSequenceBase,sbyte TrackName,TArray<FQuat> RotationData) {}
	public void GetRawTrackScaleData(UObject AnimationSequenceBase,sbyte TrackName,TArray<FVector> ScaleData) {}
	public void GetRawTrackData(UObject AnimationSequenceBase,sbyte TrackName,TArray<FVector> PositionKeys,TArray<FQuat> RotationKeys,TArray<FVector> ScalingKeys) {}
	public bool IsValidRawAnimationTrackName(UObject AnimationSequenceBase,sbyte TrackName,bool ReturnValue) { return default; }
	public void GetBoneCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void SetBoneCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void GetCurveCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void SetCurveCompressionSettings(UObject AnimationSequence,UObject CompressionSettings) {}
	public void GetAdditiveAnimationType(UObject AnimationSequence,byte AdditiveAnimationType) {}
	public void SetAdditiveAnimationType(UObject AnimationSequence,byte AdditiveAnimationType) {}
	public void GetAdditiveBasePoseType(UObject AnimationSequence,byte AdditiveBasePoseType) {}
	public void SetAdditiveBasePoseType(UObject AnimationSequence,byte AdditiveBasePoseType) {}
	public void GetAnimationInterpolationType(UObject AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public void SetAnimationInterpolationType(UObject AnimationSequence,EAnimInterpolationType InterpolationType) {}
	public bool IsRootMotionEnabled(UObject AnimationSequence,bool ReturnValue) { return default; }
	public void SetRootMotionEnabled(UObject AnimationSequence,bool bEnabled) {}
	public void GetRootMotionLockType(UObject AnimationSequence,byte LockType) {}
	public void SetRootMotionLockType(UObject AnimationSequence,byte RootMotionLockType) {}
	public bool IsRootMotionLockForced(UObject AnimationSequence,bool ReturnValue) { return default; }
	public void SetIsRootMotionLockForced(UObject AnimationSequence,bool bForced) {}
	public void GetAnimationSyncMarkers(UObject AnimationSequence,TArray<FAnimSyncMarker> Markers) {}
	public void GetUniqueMarkerNames(UObject AnimationSequence,TArray<sbyte> MarkerNames) {}
	public void AddAnimationSyncMarker(UObject AnimationSequence,sbyte MarkerName,float Time,sbyte NotifyTrackName) {}
	public bool IsValidAnimationSyncMarkerName(UObject AnimationSequence,sbyte MarkerName,bool ReturnValue) { return default; }
	public int RemoveAnimationSyncMarkersByName(UObject AnimationSequence,sbyte MarkerName,int ReturnValue) { return default; }
	public int RemoveAnimationSyncMarkersByTrack(UObject AnimationSequence,sbyte NotifyTrackName,int ReturnValue) { return default; }
	public void RemoveAllAnimationSyncMarkers(UObject AnimationSequence) {}
	public void GetAnimationNotifyEvents(UObject AnimationSequenceBase,TArray<FAnimNotifyEvent> NotifyEvents) {}
	public void GetAnimationNotifyEventNames(UObject AnimationSequenceBase,TArray<sbyte> EventNames) {}
	public UObject AddAnimationNotifyEvent(UObject AnimationSequenceBase,sbyte NotifyTrackName,float StartTime,UClass NotifyClass,UObject ReturnValue) { return default; }
	public UObject AddAnimationNotifyStateEvent(UObject AnimationSequenceBase,sbyte NotifyTrackName,float StartTime,float Duration,UClass NotifyStateClass,UObject ReturnValue) { return default; }
	public void AddAnimationNotifyEventObject(UObject AnimationSequenceBase,float StartTime,UObject Notify,sbyte NotifyTrackName) {}
	public void AddAnimationNotifyStateEventObject(UObject AnimationSequenceBase,float StartTime,float Duration,UObject NotifyState,sbyte NotifyTrackName) {}
	public int RemoveAnimationNotifyEventsByName(UObject AnimationSequenceBase,sbyte NotifyName,int ReturnValue) { return default; }
	public int RemoveAnimationNotifyEventsByTrack(UObject AnimationSequenceBase,sbyte NotifyTrackName,int ReturnValue) { return default; }
	public void ReplaceAnimNotifyStates(UObject AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyStateReplaced OnNotifyStateReplaced) {}
	public void ReplaceAnimNotifies(UObject AnimationSequenceBase,UClass OldNotifyClass,UClass NewNotifyClass,FOnNotifyReplaced OnNotifyReplaced) {}
	public void CopyAnimNotifiesFromSequence(UObject SourceAnimationSequenceBase,UObject DestinationAnimationSequenceBase,bool bDeleteExistingNotifies=false) {}
	public void GetAnimationNotifyTrackNames(UObject AnimationSequenceBase,TArray<sbyte> TrackNames) {}
	public void AddAnimationNotifyTrack(UObject AnimationSequenceBase,sbyte NotifyTrackName,FLinearColor TrackColor=FLinearColor) {}
	public void RemoveAnimationNotifyTrack(UObject AnimationSequenceBase,sbyte NotifyTrackName) {}
	public void RemoveAllAnimationNotifyTracks(UObject AnimationSequenceBase) {}
	public bool IsValidAnimNotifyTrackName(UObject AnimationSequenceBase,sbyte NotifyTrackName,bool ReturnValue) { return default; }
	public float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent,float ReturnValue) { return default; }
	public float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent,float ReturnValue) { return default; }
	public void GetAnimationSyncMarkersForTrack(UObject AnimationSequence,sbyte NotifyTrackName,TArray<FAnimSyncMarker> Markers) {}
	public void GetAnimationNotifyEventsForTrack(UObject AnimationSequenceBase,sbyte NotifyTrackName,TArray<FAnimNotifyEvent> Events) {}
	public void AddCurve(UObject AnimationSequence,sbyte CurveName,ERawCurveTrackTypes CurveType=ERawCurveTrackTypes,bool bMetaDataCurve=false) {}
	public void RemoveCurve(UObject AnimationSequence,sbyte CurveName,bool bRemoveNameFromSkeleton=false) {}
	public void RemoveAllCurveData(UObject AnimationSequence) {}
	public void AddTransformationCurveKey(UObject AnimationSequence,sbyte CurveName,float Time,FTransform Transform) {}
	public void AddTransformationCurveKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<FTransform> Transforms) {}
	public void AddFloatCurveKey(UObject AnimationSequence,sbyte CurveName,float Time,float Value) {}
	public void AddFloatCurveKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<float> Values) {}
	public void AddVectorCurveKey(UObject AnimationSequence,sbyte CurveName,float Time,FVector Vector) {}
	public void AddVectorCurveKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<FVector> Vectors) {}
	public void DoesBoneNameExist(UObject AnimationSequence,sbyte BoneName,bool bExists) {}
	public void GetFloatKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<float> Values) {}
	public void GetVectorKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<FVector> Values) {}
	public void GetTransformationKeys(UObject AnimationSequence,sbyte CurveName,TArray<float> Times,TArray<FTransform> Values) {}
	public void CopyAnimationCurveNamesToSkeleton(UObject OldSkeleton,UObject NewSkeleton,UObject SequenceBase,ERawCurveTrackTypes CurveType) {}
	public void RemoveBoneAnimation(UObject AnimationSequence,sbyte BoneName,bool bIncludeChildren=true,bool bFinalize=true) {}
	public void RemoveAllBoneAnimation(UObject AnimationSequence) {}
	public void FinalizeBoneAnimation(UObject AnimationSequence) {}
	public bool DoesCurveExist(UObject AnimationSequence,sbyte CurveName,ERawCurveTrackTypes CurveType,bool ReturnValue) { return default; }
	public void AddMetaData(UObject AnimationAsset,UClass MetaDataClass,UObject MetaDataInstance) {}
	public void AddMetaDataObject(UObject AnimationAsset,UObject MetaDataObject) {}
	public void RemoveAllMetaData(UObject AnimationAsset) {}
	public void RemoveMetaData(UObject AnimationAsset,UObject MetaDataObject) {}
	public void RemoveMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass) {}
	public void GetMetaData(UObject AnimationAsset,TArray<UObject> MetaData) {}
	public void GetMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass,TArray<UObject> MetaDataOfClass) {}
	public bool ContainsMetaDataOfClass(UObject AnimationAsset,UClass MetaDataClass,bool ReturnValue) { return default; }
	public void GetBonePoseForTime(UObject AnimationSequenceBase,sbyte BoneName,float Time,bool bExtractRootMotion,FTransform Pose) {}
	public void GetBonePoseForFrame(UObject AnimationSequenceBase,sbyte BoneName,int Frame,bool bExtractRootMotion,FTransform Pose) {}
	public void GetBonePosesForTime(UObject AnimationSequenceBase,TArray<sbyte> BoneNames,float Time,bool bExtractRootMotion,TArray<FTransform> Poses,UObject PreviewMesh=nullptr) {}
	public void GetBonePosesForFrame(UObject AnimationSequenceBase,TArray<sbyte> BoneNames,int Frame,bool bExtractRootMotion,TArray<FTransform> Poses,UObject PreviewMesh=nullptr) {}
	public void AddVirtualBone(UObject AnimationSequence,sbyte SourceBoneName,sbyte TargetBoneName,sbyte VirtualBoneName) {}
	public void RemoveVirtualBone(UObject AnimationSequence,sbyte VirtualBoneName) {}
	public void RemoveVirtualBones(UObject AnimationSequence,TArray<sbyte> VirtualBoneNames) {}
	public void RemoveAllVirtualBones(UObject AnimationSequence) {}
	public void GetSequenceLength(UObject AnimationSequenceBase,float Length) {}
	public void GetRateScale(UObject AnimationSequenceBase,float RateScale) {}
	public void SetRateScale(UObject AnimationSequenceBase,float RateScale) {}
	public void GetFrameAtTime(UObject AnimationSequenceBase,float Time,int Frame) {}
	public void GetTimeAtFrame(UObject AnimationSequenceBase,int Frame,float Time) {}
	public void IsValidTime(UObject AnimationSequenceBase,float Time,bool IsValid) {}
	public bool EvaluateRootBoneTimecodeAttributesAtTime(UObject AnimationSequenceBase,float EvalTime,FQualifiedFrameTime OutQualifiedFrameTime,bool ReturnValue) { return default; }
	public bool EvaluateRootBoneTimecodeSubframeAttributeAtTime(UObject AnimationSequenceBase,float EvalTime,float OutSubframe,bool ReturnValue) { return default; }
	public void FindBonePathToRoot(UObject AnimationSequenceBase,sbyte BoneName,TArray<sbyte> BonePath) {}
	public void GetAnimationGraphs(UObject AnimationBlueprint,TArray<UObject> AnimationGraphs) {}
	public void GetNodesOfClass(UObject AnimationBlueprint,UClass NodeClass,TArray<UObject> GraphNodes,bool bIncludeChildClasses=true) {}
	public void AddNodeAssetOverride(UObject AnimBlueprint,UObject Target,UObject Override,bool bPrintAppliedOverrides=false) {}
}
