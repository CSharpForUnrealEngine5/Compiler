#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial class UAnimationDataModel : UInterface {
// AnimationDataModel
	public double GetPlayLength(double ReturnValue) { return default; }
	public int GetNumberOfFrames(int ReturnValue) { return default; }
	public int GetNumberOfKeys(int ReturnValue) { return default; }
	public FFrameRate GetFrameRate(FFrameRate ReturnValue) { return default; }
	public TArray<FBoneAnimationTrack> GetBoneAnimationTracks(TArray<FBoneAnimationTrack> ReturnValue) { return default; }
	public FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex,FBoneAnimationTrack ReturnValue) { return default; }
	public FBoneAnimationTrack GetBoneTrackByName(sbyte TrackName,FBoneAnimationTrack ReturnValue) { return default; }
	public int GetBoneTrackIndex(FBoneAnimationTrack Track,int ReturnValue) { return default; }
	public int GetBoneTrackIndexByName(sbyte TrackName,int ReturnValue) { return default; }
	public bool IsValidBoneTrackIndex(int TrackIndex,bool ReturnValue) { return default; }
	public bool IsValidBoneTrackName(sbyte TrackName,bool ReturnValue) { return default; }
	public int GetNumBoneTracks(int ReturnValue) { return default; }
	public void GetBoneTrackNames(TArray<sbyte> OutNames) {}
	public int GetNumberOfTransformCurves(int ReturnValue) { return default; }
	public int GetNumberOfFloatCurves(int ReturnValue) { return default; }
	public UObject GetAnimationSequence(UObject ReturnValue) { return default; }
}
