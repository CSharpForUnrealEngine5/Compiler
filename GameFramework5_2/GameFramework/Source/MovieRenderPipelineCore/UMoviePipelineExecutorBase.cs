#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineExecutor.h")]
///<summary>A Movie Pipeline Executor is responsible for executing an array of Movie Pipelines,</summary>
public partial class UMoviePipelineExecutorBase : UObject {
// MoviePipelineExecutorBase
	public void Execute(UObject InPipelineQueue) {}
	public bool IsRendering(bool ReturnValue) { return default; }
	public void OnBeginFrame() {}
	public void SetStatusMessage(sbyte InStatus) {}
	public sbyte GetStatusMessage(sbyte ReturnValue) { return default; }
	public void SetStatusProgress(float InProgress) {}
	public float GetStatusProgress(float ReturnValue) { return default; }
	public void CancelCurrentJob() {}
	public void CancelAllJobs() {}
	public void SetMoviePipelineClass(UClass InPipelineClass) {}
	public void OnExecutorFinishedImpl() {}
	public void OnExecutorErroredImpl(UObject ErroredPipeline,bool bFatal,sbyte ErrorReason) {}
	public FOnMoviePipelineExecutorFinished OnExecutorFinishedDelegate;
	public FOnMoviePipelineExecutorErrored OnExecutorErroredDelegate;
	public bool ConnectSocket(sbyte InHostName,int InPort,bool ReturnValue) { return default; }
	public void DisconnectSocket() {}
	public bool SendSocketMessage(sbyte InMessage,bool ReturnValue) { return default; }
	public bool IsSocketConnected(bool ReturnValue) { return default; }
	public FMoviePipelineSocketMessageRecieved SocketMessageRecievedDelegate;
	public int SendHTTPRequest(sbyte InURL,sbyte InVerb,sbyte InMessage,TMap<sbyte,sbyte> InHeaders,int ReturnValue) { return default; }
	public FMoviePipelineHttpResponseRecieved HTTPResponseRecievedDelegate;
	public UClass DebugWidgetClass;
	public sbyte UserData;
	public UClass TargetPipelineClass;
}
