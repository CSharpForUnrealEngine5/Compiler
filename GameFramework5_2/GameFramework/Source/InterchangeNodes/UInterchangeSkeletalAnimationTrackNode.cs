#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetNode.h")]
///<summary>* Class to hold onto the relationships between a set of animation tracks and the bones, morph targets of a skeleton.</summary>
public partial class UInterchangeSkeletalAnimationTrackNode : UInterchangeAnimationTrackBaseNode {
// InterchangeSkeletalAnimationTrackNode
	public bool GetCustomSkeletonNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomSkeletonNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomSkeletalMeshNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomSkeletalMeshNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomAnimationSampleRate(double SampleRate,bool ReturnValue) { return default; }
	public bool GetCustomAnimationSampleRate(double SampleRate,bool ReturnValue) { return default; }
	public bool SetCustomAnimationStartTime(double StartTime,bool ReturnValue) { return default; }
	public bool GetCustomAnimationStartTime(double StartTime,bool ReturnValue) { return default; }
	public bool SetCustomAnimationStopTime(double StopTime,bool ReturnValue) { return default; }
	public bool GetCustomAnimationStopTime(double StopTime,bool ReturnValue) { return default; }
	public void GetSceneNodeAnimationPayloadKeys(TMap<sbyte,sbyte> OutSceneNodeAnimationPayloadKeys) {}
	public bool GetAnimationPayloadKeyFromSceneNodeUid(sbyte SceneNodeUid,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool SetAnimationPayloadKeyForSceneNodeUid(sbyte SceneNodeUid,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(sbyte SceneNodeUid,bool ReturnValue) { return default; }
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<sbyte,sbyte> OutMorphTargetNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(sbyte MorphTargetNodeUid,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(sbyte MorphTargetNodeUid,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(sbyte MorphTargetNodeUid,bool ReturnValue) { return default; }
}
