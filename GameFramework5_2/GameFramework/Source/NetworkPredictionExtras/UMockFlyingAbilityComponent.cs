#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockAbilitySimulation.h")]
///<summary>ActorComponent for running Mock Ability Simulation</summary>
public partial class UMockFlyingAbilityComponent : UFlyingMovementComponent {
// MockFlyingAbilityComponent
	public void FMockAbilityNotifyStateChange(bool bNewStateValue) {}
	public FMockAbilityNotifyStateChange OnSprintStateChange;
	public FMockAbilityNotifyStateChange OnDashStateChange;
	public FMockAbilityNotifyStateChange OnBlinkStateChange;
	public bool IsSprinting(bool ReturnValue) { return default; }
	public bool IsDashing(bool ReturnValue) { return default; }
	public bool IsBlinking(bool ReturnValue) { return default; }
	public void FMockAbilityBlinkCueEvent(FVector DestinationLocation,int RandomValue,float ElapsedTimeSeconds) {}
	public FMockAbilityBlinkCueEvent OnBlinkActivateEvent;
	public void FMockAbilityBlinkCueRollback() {}
	public FMockAbilityBlinkCueRollback OnBlinkActivateEventRollback;
	public void FMockAbilityPhysicsGunFireEvent(FVector Start,FVector End,bool bHasCooldown,TArray<FVector_NetQuantize100> HitLocations,float ElapsedTimeSeconds) {}
	public FMockAbilityPhysicsGunFireEvent OnPhysicsGunFirEvent;
	public float GetBlinkWarmupTimeSeconds(float ReturnValue) { return default; }
	public float GetStamina(float ReturnValue) { return default; }
	public float GetMaxStamina(float ReturnValue) { return default; }
}
