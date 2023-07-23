#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSection.h")]
///<summary>Base class for movie scene sections</summary>
public partial class UMovieSceneSection : UMovieSceneSignedObject {
// MovieSceneSection
	public FMovieSceneSectionEvalOptions EvalOptions;
	public EMovieSceneCompletionMode GetCompletionMode(EMovieSceneCompletionMode ReturnValue) { return default; }
	public void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode) {}
	public FOptionalMovieSceneBlendType GetBlendType(FOptionalMovieSceneBlendType ReturnValue) { return default; }
	public void SetBlendType(EMovieSceneBlendType InBlendType) {}
	public void SetRowIndex(int NewRowIndex) {}
	public int GetRowIndex(int ReturnValue) { return default; }
	public void SetOverlapPriority(int NewPriority) {}
	public int GetOverlapPriority(int ReturnValue) { return default; }
	public void SetIsActive(bool bInIsActive) {}
	public bool IsActive(bool ReturnValue) { return default; }
	public void SetIsLocked(bool bInIsLocked) {}
	public bool IsLocked(bool ReturnValue) { return default; }
	public void SetPreRollFrames(int InPreRollFrames) {}
	public int GetPreRollFrames(int ReturnValue) { return default; }
	public void SetPostRollFrames(int InPostRollFrames) {}
	public int GetPostRollFrames(int ReturnValue) { return default; }
	public void SetColorTint(FColor InColorTint) {}
	public FColor GetColorTint(FColor ReturnValue) { return default; }
	public FMovieSceneEasingSettings Easing;
	public FMovieSceneFrameRange SectionRange;
	public FMovieSceneTimecodeSource TimecodeSource;
	public FFrameNumber PreRollFrames;
	public FFrameNumber PostRollFrames;
	public int RowIndex;
	public int OverlapPriority;
	public bool bIsActive;
	public bool bIsLocked;
	public FColor ColorTint;
	public float StartTime_DEPRECATED;
	public float EndTime_DEPRECATED;
	public float PreRollTime_DEPRECATED;
	public float PostRollTime_DEPRECATED;
	public bool bIsInfinite_DEPRECATED;
	public bool bSupportsInfiniteRange;
	public FOptionalMovieSceneBlendType BlendType;
}
