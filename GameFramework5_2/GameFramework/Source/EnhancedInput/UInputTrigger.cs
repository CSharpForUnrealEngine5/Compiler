#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputTriggers.h")]
///<summary>Base class for building triggers.</summary>
public partial class UInputTrigger : UObject {
// InputTrigger
	public float ActuationThreshold;
	public bool bShouldAlwaysTick;
	public bool IsActuated(FInputActionValue ForValue,bool ReturnValue) { return default; }
	public FInputActionValue LastValue;
	public ETriggerType GetTriggerType(ETriggerType ReturnValue) { return default; }
	public ETriggerState UpdateState(UObject PlayerInput,FInputActionValue ModifiedValue,float DeltaTime,ETriggerState ReturnValue) { return default; }
}
