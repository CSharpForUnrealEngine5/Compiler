#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_BlueprintBase.h")]
///<summary>Base class for blueprint based task nodes. Do NOT use it for creating native c++ classes!</summary>
public partial class UBTTask_BlueprintBase : UBTTaskNode {
// BTTask_BlueprintBase
	public AAIController AIOwner;
	public AActor ActorOwner;
	public FIntervalCountdown TickInterval;
	public sbyte CustomDescription;
	public bool bShowPropertyDetails;
	public void ReceiveExecute(UObject OwnerActor) {}
	public void ReceiveAbort(UObject OwnerActor) {}
	public void ReceiveTick(UObject OwnerActor,float DeltaSeconds) {}
	public void ReceiveExecuteAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveAbortAI(UObject OwnerController,UObject ControlledPawn) {}
	public void ReceiveTickAI(UObject OwnerController,UObject ControlledPawn,float DeltaSeconds) {}
	public void FinishExecute(bool bSuccess) {}
	public void FinishAbort() {}
	public void SetFinishOnMessage(sbyte MessageName) {}
	public void SetFinishOnMessageWithId(sbyte MessageName,int RequestID=-1) {}
	public bool IsTaskExecuting(bool ReturnValue) { return default; }
	public bool IsTaskAborting(bool ReturnValue) { return default; }
}
