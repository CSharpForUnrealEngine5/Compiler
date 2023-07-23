#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataController.h")]
public partial class UAnimationDataController : UInterface {
// AnimationDataController
	public void SetModel(object /*InModel*/ InModel) {}
	public object /*ReturnValue*/ GetModelInterface(object /*ReturnValue*/ ReturnValue) { return default; }
	public void OpenBracket(sbyte InTitle,bool bShouldTransact=true) {}
	public void CloseBracket(bool bShouldTransact=true) {}
	public void SetNumberOfFrames(FFrameNumber NewLengthInFrames,bool bShouldTransact=true) {}
	public void SetPlayLength(float Length,bool bShouldTransact=true) {}
	public void ResizeNumberOfFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact=true) {}
	public void ResizePlayLength(float NewLength,float T0,float T1,bool bShouldTransact=true) {}
	public void ResizeInFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact=true) {}
	public void Resize(float Length,float T0,float T1,bool bShouldTransact=true) {}
	public void SetFrameRate(FFrameRate FrameRate,bool bShouldTransact=true) {}
	public int AddBoneTrack(sbyte BoneName,bool bShouldTransact=true,int ReturnValue) { return default; }
	public bool AddBoneCurve(sbyte BoneName,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public int InsertBoneTrack(sbyte BoneName,int DesiredIndex,bool bShouldTransact=true,int ReturnValue) { return default; }
	public bool RemoveBoneTrack(sbyte BoneName,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public void RemoveAllBoneTracks(bool bShouldTransact=true) {}
	public bool SetBoneTrackKeys(sbyte BoneName,TArray<FVector> PositionalKeys,TArray<FQuat> RotationalKeys,TArray<FVector> ScalingKeys,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool AddCurve(FAnimationCurveIdentifier CurveId,int CurveFlags=0x00000004,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool RemoveCurve(FAnimationCurveIdentifier CurveId,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact=true) {}
	public bool SetCurveFlag(FAnimationCurveIdentifier CurveId,EAnimAssetCurveFlags Flag,bool bState=true,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetCurveFlags(FAnimationCurveIdentifier CurveId,int Flags,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FTransform> TransformValues,TArray<float> TimeKeys,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,FTransform Value,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetCurveColor(FAnimationCurveIdentifier CurveId,FLinearColor Color,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool ScaleCurve(FAnimationCurveIdentifier CurveId,float Origin,float Factor,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetCurveKey(FAnimationCurveIdentifier CurveId,FRichCurveKey Key,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool RemoveCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool SetCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FRichCurveKey> CurveKeys,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public void UpdateCurveNamesFromSkeleton(UObject Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact=true) {}
	public void FindOrAddCurveNamesOnSkeleton(UObject Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact=true) {}
	public bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public int RemoveAllAttributesForBone(sbyte BoneName,bool bShouldTransact=true,int ReturnValue) { return default; }
	public int RemoveAllAttributes(bool bShouldTransact=true,int ReturnValue) { return default; }
	public bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier,float Time,bool bShouldTransact=true,bool ReturnValue) { return default; }
	public bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier,FAnimationAttributeIdentifier NewAttributeIdentifier,bool bShouldTransact=true,bool ReturnValue) { return default; }
}
