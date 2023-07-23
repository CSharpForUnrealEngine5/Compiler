#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequence/LevelSequencePlaybackController.h")]
public partial class ULevelSequencePlaybackController : UObject {
// LevelSequencePlaybackController
	public void GetLevelSequences(TArray<FLevelSequenceData> OutLevelSequenceNames) {}
	public sbyte GetActiveLevelSequenceName(sbyte ReturnValue) { return default; }
	public UObject GetActiveLevelSequence(UObject ReturnValue) { return default; }
	public FFrameRate GetCurrentSequenceFrameRate(FFrameRate ReturnValue) { return default; }
	public bool IsSequencerLockedToCameraCut(bool ReturnValue) { return default; }
	public void SetSequencerLockedToCameraCut(bool bLockView) {}
	public FFrameNumber GetCurrentSequencePlaybackStart(FFrameNumber ReturnValue) { return default; }
	public FFrameNumber GetCurrentSequencePlaybackEnd(FFrameNumber ReturnValue) { return default; }
	public FFrameNumber GetCurrentSequenceDuration(FFrameNumber ReturnValue) { return default; }
	public FFrameTime GetCurrentSequencePlaybackPosition(FFrameTime ReturnValue) { return default; }
	public FTimecode GetCurrentSequencePlaybackTimecode(FTimecode ReturnValue) { return default; }
	public void JumpToPlaybackPosition(FFrameNumber InFrameNumber) {}
	public bool IsSequencePlaybackActive(bool ReturnValue) { return default; }
	public void PauseLevelSequence() {}
	public void PlayLevelSequence() {}
	public void PlayLevelSequenceReverse() {}
	public void StopLevelSequencePlay() {}
	public bool SetActiveLevelSequence(UObject InNewLevelSequence,bool ReturnValue) { return default; }
	public void ClearActiveLevelSequence() {}
	public ULevelSequence ActiveLevelSequence;
}
