#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/NavMovementComponent.h")]
///<summary>NavMovementComponent defines base functionality for MovementComponents that move any 'agent' that may be involved in AI pathfinding.</summary>
public partial class UNavMovementComponent : UMovementComponent {
// NavMovementComponent
	public FNavAgentProperties NavAgentProps;
	public float FixedPathBrakingDistance;
	public bool bUpdateNavAgentWithOwnersCollision;
	public bool bUseAccelerationForPaths;
	public bool bUseFixedBrakingDistanceForPaths;
	public FMovementProperties MovementState;
	public UObject PathFollowingComp;
	public void StopActiveMovement() {}
	public void StopMovementKeepPathing() {}
	public bool IsCrouching(bool ReturnValue) { return default; }
	public bool IsFalling(bool ReturnValue) { return default; }
	public bool IsMovingOnGround(bool ReturnValue) { return default; }
	public bool IsSwimming(bool ReturnValue) { return default; }
	public bool IsFlying(bool ReturnValue) { return default; }
}
