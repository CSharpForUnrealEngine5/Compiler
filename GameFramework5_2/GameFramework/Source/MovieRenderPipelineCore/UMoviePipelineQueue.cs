#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueue.h")]
///<summary>A queue is a list of jobs that have been executed, are executing and are waiting to be executed. These can be saved</summary>
public partial class UMoviePipelineQueue : UObject {
// MoviePipelineQueue
	public UObject AllocateNewJob(UClass InJobType,UObject ReturnValue) { return default; }
	public void DeleteJob(UObject InJob) {}
	public void DeleteAllJobs() {}
	public UObject DuplicateJob(UObject InJob,UObject ReturnValue) { return default; }
	public TArray<UObject> GetJobs(TArray<UObject> ReturnValue) { return default; }
	public UObject GetQueueOrigin(UObject ReturnValue) { return default; }
	public void SetQueueOrigin(UObject InConfig) {}
	public void CopyFrom(UObject InQueue) {}
	public void SetJobIndex(UObject InJob,int Index) {}
	public bool IsDirty(bool ReturnValue) { return default; }
	public void SetIsDirty(bool bNewDirtyState) {}
	public TArray<UMoviePipelineExecutorJob> Jobs;
	public TSoftObjectPtr<UMoviePipelineQueue> QueueOrigin;
}
