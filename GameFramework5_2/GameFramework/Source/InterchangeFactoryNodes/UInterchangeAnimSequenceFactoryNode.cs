#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimSequenceFactoryNode.h")]
///<summary>ns UE::Interchange</summary>
public partial class UInterchangeAnimSequenceFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeAnimSequenceFactoryNode
	public void InitializeAnimSequenceNode(sbyte UniqueID,sbyte DisplayLabel) {}
	public UClass GetObjectClass(UClass ReturnValue) { return default; }
	public bool GetCustomSkeletonFactoryNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomSkeletonFactoryNodeUid(sbyte AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomImportBoneTracks(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomImportBoneTracks(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomImportBoneTracksSampleRate(double AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomImportBoneTracksSampleRate(double AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomImportBoneTracksRangeStart(double AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomImportBoneTracksRangeStart(double AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomImportBoneTracksRangeStop(double AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomImportBoneTracksRangeStop(double AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomImportAttributeCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomImportAttributeCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomDoNotImportCurveWithZero(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomDoNotImportCurveWithZero(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomRemoveCurveRedundantKeys(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomRemoveCurveRedundantKeys(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomDeleteExistingMorphTargetCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomDeleteExistingMorphTargetCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public int GetAnimatedMorphTargetDependeciesCount(int ReturnValue) { return default; }
	public void GetAnimatedMorphTargetDependencies(TArray<sbyte> OutDependencies) {}
	public void GetAnimatedMorphTargetDependency(int Index,sbyte OutDependency) {}
	public bool SetAnimatedMorphTargetDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public bool RemoveAnimatedMorphTargetDependencyUid(sbyte DependencyUid,bool ReturnValue) { return default; }
	public int GetAnimatedAttributeCurveNamesCount(int ReturnValue) { return default; }
	public void GetAnimatedAttributeCurveNames(TArray<sbyte> OutAttributeCurveNames) {}
	public void GetAnimatedAttributeCurveName(int Index,sbyte OutAttributeCurveName) {}
	public bool SetAnimatedAttributeCurveName(sbyte AttributeCurveName,bool ReturnValue) { return default; }
	public bool RemoveAnimatedAttributeCurveName(sbyte AttributeCurveName,bool ReturnValue) { return default; }
	public bool GetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue,bool ReturnValue) { return default; }
	public int GetAnimatedMaterialCurveSuffixesCount(int ReturnValue) { return default; }
	public void GetAnimatedMaterialCurveSuffixes(TArray<sbyte> OutMaterialCurveSuffixes) {}
	public void GetAnimatedMaterialCurveSuffixe(int Index,sbyte OutMaterialCurveSuffixe) {}
	public bool SetAnimatedMaterialCurveSuffixe(sbyte MaterialCurveSuffixe,bool ReturnValue) { return default; }
	public bool RemoveAnimatedMaterialCurveSuffixe(sbyte MaterialCurveSuffixe,bool ReturnValue) { return default; }
	public int GetAnimatedAttributeStepCurveNamesCount(int ReturnValue) { return default; }
	public void GetAnimatedAttributeStepCurveNames(TArray<sbyte> OutAttributeStepCurveNames) {}
	public void GetAnimatedAttributeStepCurveName(int Index,sbyte OutAttributeStepCurveName) {}
	public bool SetAnimatedAttributeStepCurveName(sbyte AttributeStepCurveName,bool ReturnValue) { return default; }
	public bool RemoveAnimatedAttributeStepCurveName(sbyte AttributeStepCurveName,bool ReturnValue) { return default; }
	public bool GetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue,bool ReturnValue) { return default; }
	public bool GetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue,bool ReturnValue) { return default; }
	public bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue,bool ReturnValue) { return default; }
	public void GetSceneNodeAnimationPayloadKeys(TMap<sbyte,sbyte> OutSceneNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromSceneNodeUid(sbyte SceneNodeUid,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool SetAnimationPayloadKeyForSceneNodeUid(sbyte SceneNodeUid,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(sbyte SceneNodeUid,bool ReturnValue) { return default; }
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<sbyte,sbyte> OutMorphTargetNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(sbyte MorphTargetNodeUid,sbyte OutPayloadKey,bool ReturnValue) { return default; }
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(sbyte MorphTargetNodeUid,sbyte PayloadKey,bool ReturnValue) { return default; }
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(sbyte MorphTargetNodeUid,bool ReturnValue) { return default; }
}
