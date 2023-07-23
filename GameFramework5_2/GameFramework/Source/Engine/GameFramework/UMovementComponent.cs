#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/MovementComponent.h")]
///<summary>MovementComponent is an abstract component class that defines functionality for moving a PrimitiveComponent (our UpdatedComponent) each tick.</summary>
public partial class UMovementComponent : UActorComponent {
// MovementComponent
	public USceneComponent UpdatedComponent;
	public UPrimitiveComponent UpdatedPrimitive;
	public FVector Velocity;
	public FVector PlaneConstraintNormal;
	public FVector PlaneConstraintOrigin;
	public bool bUpdateOnlyIfRendered;
	public bool bAutoUpdateTickRegistration;
	public bool bTickBeforeOwner;
	public bool bAutoRegisterUpdatedComponent;
	public bool bConstrainToPlane;
	public bool bSnapToPlaneAtStart;
	public bool bAutoRegisterPhysicsVolumeUpdates;
	public bool bComponentShouldUpdatePhysicsVolume;
	public EPlaneConstraintAxisSetting PlaneConstraintAxisSetting;
	public float GetGravityZ(float ReturnValue) { return default; }
	public float GetMaxSpeed(float ReturnValue) { return default; }
	public bool IsExceedingMaxSpeed(float MaxSpeed,bool ReturnValue) { return default; }
	public void StopMovementImmediately() {}
	public UObject GetPhysicsVolume(UObject ReturnValue) { return default; }
	public void PhysicsVolumeChanged(UObject NewVolume) {}
	public void SetUpdatedComponent(UObject NewUpdatedComponent) {}
	public bool K2_MoveUpdatedComponent(FVector Delta,FRotator NewRotation,FHitResult OutHit,bool bSweep=true,bool bTeleport=false,bool ReturnValue) { return default; }
	public void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting) {}
	public EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting ReturnValue) { return default; }
	public void SetPlaneConstraintNormal(FVector PlaneNormal) {}
	public void SetPlaneConstraintFromVectors(FVector Forward,FVector Up) {}
	public void SetPlaneConstraintOrigin(FVector PlaneOrigin) {}
	public void SetPlaneConstraintEnabled(bool bEnabled) {}
	public FVector GetPlaneConstraintNormal(FVector ReturnValue) { return default; }
	public FVector GetPlaneConstraintOrigin(FVector ReturnValue) { return default; }
	public FVector ConstrainDirectionToPlane(FVector Direction,FVector ReturnValue) { return default; }
	public FVector ConstrainLocationToPlane(FVector Location,FVector ReturnValue) { return default; }
	public FVector ConstrainNormalToPlane(FVector Normal,FVector ReturnValue) { return default; }
	public void SnapUpdatedComponentToPlane() {}
}
