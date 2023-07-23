#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
public partial class UPathFollowingComponent : UActorComponent {
// PathFollowingComponent
	public void OnActorBump(UObject SelfActor,UObject OtherActor,FVector NormalImpulse,FHitResult Hit) {}
	public EPathFollowingAction GetPathActionType(EPathFollowingAction ReturnValue) { return default; }
	public FVector GetPathDestination(FVector ReturnValue) { return default; }
	public UNavMovementComponent MovementComp;
	public ANavigationData MyNavData;
	public void OnNavDataRegistered(UObject NavData) {}
}
