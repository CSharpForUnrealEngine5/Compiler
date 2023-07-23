#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayTask_MoveTo.h")]
public partial class UGameplayTask_MoveTo : UGameplayTask {
// GameplayTask_MoveTo
	public UObject MoveTo(UObject Actor,FVector GoalLocation,UObject GoalActor=nullptr,EGameplayTaskMoveToIntent EndOfPathIntent=EGameplayTaskMoveToIntent,float AcceptanceRadius=-1.f,EAIOptionFlag StopOnOverlap=EAIOptionFlag,EAIOptionFlag AcceptPartialPath=EAIOptionFlag,bool bUsePathfinding=true,bool bUseContinuousGoalTracking=false,EAIOptionFlag ProjectGoalOnNavigation=EAIOptionFlag,UObject ReturnValue) { return default; }
	public FGenericGameplayTaskDelegate OnRequestFailed;
	public FGameplayTaskActuationCompleted OnCompleted;
	public UCharacterMovementComponent MovementComponent;
	public UGameplayActuationComponent ActuationComponent;
	public FAIMoveRequest MoveRequest;
	public UGameplayTask StartTransitionTask;
	public UGameplayTask EndTransitionTask;
}
