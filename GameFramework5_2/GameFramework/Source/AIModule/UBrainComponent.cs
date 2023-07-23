#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BrainComponent.h")]
public partial class UBrainComponent : UActorComponent {
// BrainComponent
	public UBlackboardComponent BlackboardComp;
	public AAIController AIOwner;
	public void StartLogic() {}
	public void RestartLogic() {}
	public void StopLogic(sbyte Reason) {}
	public bool IsRunning(bool ReturnValue) { return default; }
	public bool IsPaused(bool ReturnValue) { return default; }
}
