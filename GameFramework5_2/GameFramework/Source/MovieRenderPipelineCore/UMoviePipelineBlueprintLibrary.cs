#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineBlueprintLibrary.h")]
public partial class UMoviePipelineBlueprintLibrary : UBlueprintFunctionLibrary {
// MoviePipelineBlueprintLibrary
	public UObject DuplicateSequence(UObject Outer,UObject InSequence,UObject ReturnValue) { return default; }
	public void ResolveFilenameFormatArguments(sbyte InFormatString,FMoviePipelineFilenameResolveParams InParams,sbyte OutFinalPath,FMoviePipelineFormatArgs OutMergedFormatArgs) {}
	public bool GetEstimatedTimeRemaining(UObject InPipeline,FTimespan OutEstimate,bool ReturnValue) { return default; }
	public FDateTime GetJobInitializationTime(UObject InMoviePipeline,FDateTime ReturnValue) { return default; }
	public EMovieRenderPipelineState GetPipelineState(UObject InPipeline,EMovieRenderPipelineState ReturnValue) { return default; }
	public EMovieRenderShotState GetCurrentSegmentState(UObject InMoviePipeline,EMovieRenderShotState ReturnValue) { return default; }
	public sbyte GetJobName(UObject InMoviePipeline,sbyte ReturnValue) { return default; }
	public sbyte GetJobAuthor(UObject InMoviePipeline,sbyte ReturnValue) { return default; }
	public void GetOverallOutputFrames(UObject InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public void GetCurrentSegmentName(UObject InMoviePipeline,sbyte OutOuterName,sbyte OutInnerName) {}
	public void GetOverallSegmentCounts(UObject InMoviePipeline,int OutCurrentIndex,int OutTotalCount) {}
	public FMoviePipelineSegmentWorkMetrics GetCurrentSegmentWorkMetrics(UObject InMoviePipeline,FMoviePipelineSegmentWorkMetrics ReturnValue) { return default; }
	public float GetCompletionPercentage(UObject InPipeline,float ReturnValue) { return default; }
	public FTimecode GetRootTimecode(UObject InMoviePipeline,FTimecode ReturnValue) { return default; }
	public FTimecode GetMasterTimecode(UObject InMoviePipeline,FTimecode ReturnValue) { return default; }
	public FFrameNumber GetRootFrameNumber(UObject InMoviePipeline,FFrameNumber ReturnValue) { return default; }
	public FFrameNumber GetMasterFrameNumber(UObject InMoviePipeline,FFrameNumber ReturnValue) { return default; }
	public FTimecode GetCurrentShotTimecode(UObject InMoviePipeline,FTimecode ReturnValue) { return default; }
	public FFrameNumber GetCurrentShotFrameNumber(UObject InMoviePipeline,FFrameNumber ReturnValue) { return default; }
	public float GetCurrentFocusDistance(UObject InMoviePipeline,float ReturnValue) { return default; }
	public float GetCurrentFocalLength(UObject InMoviePipeline,float ReturnValue) { return default; }
	public float GetCurrentAperture(UObject InMoviePipeline,float ReturnValue) { return default; }
	public sbyte GetMapPackageName(UObject InJob,sbyte ReturnValue) { return default; }
	public UObject LoadManifestFileFromString(sbyte InManifestFilePath,UObject ReturnValue) { return default; }
	public void UpdateJobShotListFromSequence(UObject InSequence,UObject InJob,bool bShotsChanged) {}
	public int ResolveVersionNumber(FMoviePipelineFilenameResolveParams InParams,bool bGetNextVersion=true,int ReturnValue) { return default; }
	public FIntPoint GetEffectiveOutputResolution(UObject InPrimaryConfig,UObject InPipelineExecutorShot,FIntPoint ReturnValue) { return default; }
	public UObject FindOrGetDefaultSettingForShot(UClass InSettingType,UObject InPrimaryConfig,UObject InShot,UObject ReturnValue) { return default; }
	public UObject GetCurrentSequence(UObject InMoviePipeline,UObject ReturnValue) { return default; }
	public UObject GetCurrentExecutorShot(UObject InMoviePipeline,UObject ReturnValue) { return default; }
	public sbyte GetMoviePipelineEngineChangelistLabel(UObject InMoviePipeline,sbyte ReturnValue) { return default; }
}
