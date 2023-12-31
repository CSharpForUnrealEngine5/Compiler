#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_ApplyRootMotionMoveToForce.h")]
///<summary>Applies force to character's movement</summary>
public partial class UAbilityTask_ApplyRootMotionMoveToForce : UAbilityTask_ApplyRootMotion_Base {
// AbilityTask_ApplyRootMotionMoveToForce
	public FApplyRootMotionMoveToForceDelegate OnTimedOut;
	public FApplyRootMotionMoveToForceDelegate OnTimedOutAndDestinationReached;
	public UObject ApplyRootMotionMoveToForce(UObject OwningAbility,string TaskInstanceName,FVector TargetLocation,float Duration,bool bSetNewMovementMode,EMovementMode MovementMode,bool bRestrictSpeedToExpected,UObject PathOffsetCurve,ERootMotionFinishVelocityMode VelocityOnFinishMode,FVector SetVelocityOnFinish,float ClampVelocityOnFinish) { return default; }
	public FVector StartLocation;
	public FVector TargetLocation;
	public float Duration;
	public bool bSetNewMovementMode;
	public byte NewMovementMode;
	public bool bRestrictSpeedToExpected;
	public UCurveVector PathOffsetCurve;
}
