#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineQueueSubsystem.h")]
public partial class UMoviePipelineQueueSubsystem : UEditorSubsystem {
// MoviePipelineQueueSubsystem
	public UObject GetQueue(UObject ReturnValue) { return default; }
	public UObject GetActiveExecutor(UObject ReturnValue) { return default; }
	public UObject RenderQueueWithExecutor(UClass InExecutorType,UObject ReturnValue) { return default; }
	public void RenderQueueWithExecutorInstance(UObject InExecutor) {}
	public bool IsRendering(bool ReturnValue) { return default; }
	public UMoviePipelineExecutorBase ActiveExecutor;
	public UMoviePipelineQueue CurrentQueue;
}
