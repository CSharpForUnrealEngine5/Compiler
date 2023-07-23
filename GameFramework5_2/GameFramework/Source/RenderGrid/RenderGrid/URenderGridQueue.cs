#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RenderGrid/RenderGridQueue.h")]
///<summary>This class is responsible for rendering the given render grid jobs.</summary>
public partial class URenderGridQueue : UObject {
// RenderGridQueue
	public void CloseEditorOnCompletion() {}
	public void AddJob(UObject Job) {}
	public void Pause() {}
	public void Resume() {}
	public void Cancel() {}
	public bool IsStarted(bool ReturnValue) { return default; }
	public bool IsPaused(bool ReturnValue) { return default; }
	public bool IsCanceled(bool ReturnValue) { return default; }
	public bool IsFinished(bool ReturnValue) { return default; }
	public bool IsCurrentlyRendering(bool ReturnValue) { return default; }
	public UObject GetRenderGrid(UObject ReturnValue) { return default; }
	public sbyte GetJobStatus(UObject Job,sbyte ReturnValue) { return default; }
	public TArray<UObject> GetJobs(TArray<UObject> ReturnValue) { return default; }
	public int GetJobsCount(int ReturnValue) { return default; }
	public int GetJobsCompletedCount(int ReturnValue) { return default; }
	public float GetStatusPercentage(float ReturnValue) { return default; }
	public int GetJobsRemainingCount(int ReturnValue) { return default; }
	public sbyte GetStatus(sbyte ReturnValue) { return default; }
	public TArray<URenderGridJob> RemainingJobs;
	public TMap<URenderGridJob,URenderGridMoviePipelineRenderJob> Entries;
	public URenderGrid RenderGrid;
	public bool bStarted;
	public bool bPaused;
	public bool bCanceled;
	public bool bFinished;
	public FRenderGridManagerPreviousPropValues PreviousProps;
	public FRenderGridPreviousEngineFpsSettings PreviousFrameLimitSettings;
}
