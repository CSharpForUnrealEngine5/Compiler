#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockCharacterAbilitySimulation.h")]
///<summary>ActorComponent for running Mock Ability Simulation for CharacterMotion example</summary>
public partial class UMockCharacterAbilityComponent : UCharacterMotionComponent {
// MockCharacterAbilityComponent
	public void FMockCharacterAbilityNotifyStateChange(bool bNewStateValue) {}
	public FMockCharacterAbilityNotifyStateChange OnSprintStateChange;
	public FMockCharacterAbilityNotifyStateChange OnDashStateChange;
	public FMockCharacterAbilityNotifyStateChange OnBlinkStateChange;
	public FMockCharacterAbilityNotifyStateChange OnJumpStateChange;
	public bool IsSprinting(bool ReturnValue) { return default; }
	public bool IsDashing(bool ReturnValue) { return default; }
	public bool IsBlinking(bool ReturnValue) { return default; }
	public bool IsJumping(bool ReturnValue) { return default; }
	public void FMockCharacterAbilityBlinkCueEvent(FVector DestinationLocation,int RandomValue,float ElapsedTimeSeconds) {}
	public FMockCharacterAbilityBlinkCueEvent OnBlinkActivateEvent;
	public void FMockCharacterAbilityBlinkCueRollback() {}
	public FMockCharacterAbilityBlinkCueRollback OnBlinkActivateEventRollback;
	public float GetBlinkWarmupTimeSeconds(float ReturnValue) { return default; }
	public float GetStamina(float ReturnValue) { return default; }
	public float GetMaxStamina(float ReturnValue) { return default; }
}
