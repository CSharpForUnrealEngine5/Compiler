#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/AITask_MoveTo.h")]
public partial class UAITask_MoveTo : UAITask {
// AITask_MoveTo
	public UObject AIMoveTo(UObject Controller,FVector GoalLocation,UObject GoalActor=nullptr,float AcceptanceRadius=-1.f,EAIOptionFlag StopOnOverlap=EAIOptionFlag,EAIOptionFlag AcceptPartialPath=EAIOptionFlag,bool bUsePathfinding=true,bool bLockAILogic=true,bool bUseContinuousGoalTracking=false,EAIOptionFlag ProjectGoalOnNavigation=EAIOptionFlag,UObject ReturnValue) { return default; }
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FMoveTaskCompletedSignature OnMoveFinished;
	public FAIMoveRequest MoveRequest;
}
