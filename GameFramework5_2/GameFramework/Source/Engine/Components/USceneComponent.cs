#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SceneComponent.h")]
///<summary>A SceneComponent has a transform and supports attachment, but has no rendering or collision capabilities.</summary>
public partial class USceneComponent : UActorComponent {
// SceneComponent
	public TWeakObjectPtr<APhysicsVolume> PhysicsVolume;
	public USceneComponent AttachParent;
	public sbyte AttachSocketName;
	public TArray<USceneComponent> AttachChildren;
	public TArray<USceneComponent> ClientAttachedChildren;
	public FVector RelativeLocation;
	public FRotator RelativeRotation;
	public FVector RelativeScale3D;
	public FVector ComponentVelocity;
	public bool bComponentToWorldUpdated;
	public bool bAbsoluteLocation;
	public bool bAbsoluteRotation;
	public bool bAbsoluteScale;
	public bool bVisible;
	public bool bShouldBeAttached;
	public bool bShouldSnapLocationWhenAttached;
	public bool bShouldSnapRotationWhenAttached;
	public bool bShouldSnapScaleWhenAttached;
	public bool bShouldUpdatePhysicsVolume;
	public bool bHiddenInGame;
	public bool bBoundsChangeTriggersStreamingDataRebuild;
	public bool bUseAttachParentBound;
	public bool bComputeFastLocalBounds;
	public bool bComputeBoundsOnceForGame;
	public bool bComputedBoundsOnceForGame;
	public bool GetShouldUpdatePhysicsVolume(bool ReturnValue) { return default; }
	public void SetShouldUpdatePhysicsVolume(bool bInShouldUpdatePhysicsVolume) {}
	public bool bIsNotRenderAttachmentRoot;
	public bool bVisualizeComponent;
	public byte Mobility;
	public byte DetailMode;
	public FPhysicsVolumeChanged PhysicsVolumeChangedDelegate;
	public USceneComponent ReplacementSceneComponent;
	public void OnRep_Transform() {}
	public void OnRep_AttachParent() {}
	public void OnRep_AttachChildren() {}
	public void OnRep_AttachSocketName() {}
	public void OnRep_Visibility(bool OldValue) {}
	public void K2_SetRelativeLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetRelativeRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetRelativeTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public FTransform GetRelativeTransform(FTransform ReturnValue) { return default; }
	public void ResetRelativeTransform() {}
	public void SetRelativeScale3D(FVector NewScale3D) {}
	public void K2_AddRelativeLocation(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddRelativeRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddLocalOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddLocalRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddLocalTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetWorldLocation(FVector NewLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_SetWorldRotation(FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void SetWorldScale3D(FVector NewScale) {}
	public void K2_SetWorldTransform(FTransform NewTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddWorldOffset(FVector DeltaLocation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddWorldRotation(FRotator DeltaRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddWorldTransform(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void K2_AddWorldTransformKeepScale(FTransform DeltaTransform,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public FVector K2_GetComponentLocation(FVector ReturnValue) { return default; }
	public FRotator K2_GetComponentRotation(FRotator ReturnValue) { return default; }
	public FVector K2_GetComponentScale(FVector ReturnValue) { return default; }
	public FTransform K2_GetComponentToWorld(FTransform ReturnValue) { return default; }
	public FVector GetForwardVector(FVector ReturnValue) { return default; }
	public FVector GetUpVector(FVector ReturnValue) { return default; }
	public FVector GetRightVector(FVector ReturnValue) { return default; }
	public bool IsSimulatingPhysics(sbyte BoneName=NAME_None,bool ReturnValue) { return default; }
	public bool IsAnySimulatingPhysics(bool ReturnValue) { return default; }
	public UObject GetAttachParent(UObject ReturnValue) { return default; }
	public sbyte GetAttachSocketName(sbyte ReturnValue) { return default; }
	public void GetParentComponents(TArray<UObject> Parents) {}
	public int GetNumChildrenComponents(int ReturnValue) { return default; }
	public UObject GetChildComponent(int ChildIndex,UObject ReturnValue) { return default; }
	public void GetChildrenComponents(bool bIncludeAllDescendants,TArray<UObject> Children) {}
	public bool K2_AttachTo(UObject InParent,sbyte InSocketName=NAME_None,EAttachLocation AttachType=EAttachLocation,bool bWeldSimulatedBodies=true,bool ReturnValue) { return default; }
	public bool K2_AttachToComponent(UObject Parent,sbyte SocketName,EAttachmentRule LocationRule,EAttachmentRule RotationRule,EAttachmentRule ScaleRule,bool bWeldSimulatedBodies,bool ReturnValue) { return default; }
	public void DetachFromParent(bool bMaintainWorldPosition=false,bool bCallModify=true) {}
	public void K2_DetachFromComponent(EDetachmentRule LocationRule=EDetachmentRule,EDetachmentRule RotationRule=EDetachmentRule,EDetachmentRule ScaleRule=EDetachmentRule,bool bCallModify=true) {}
	public TArray<sbyte> GetAllSocketNames(TArray<sbyte> ReturnValue) { return default; }
	public FTransform GetSocketTransform(sbyte InSocketName,ERelativeTransformSpace TransformSpace=RTS_World,FTransform ReturnValue) { return default; }
	public FVector GetSocketLocation(sbyte InSocketName,FVector ReturnValue) { return default; }
	public FRotator GetSocketRotation(sbyte InSocketName,FRotator ReturnValue) { return default; }
	public FQuat GetSocketQuaternion(sbyte InSocketName,FQuat ReturnValue) { return default; }
	public bool DoesSocketExist(sbyte InSocketName,bool ReturnValue) { return default; }
	public FVector GetComponentVelocity(FVector ReturnValue) { return default; }
	public bool IsVisible(bool ReturnValue) { return default; }
	public void SetVisibility(bool bNewVisibility,bool bPropagateToChildren=false) {}
	public void ToggleVisibility(bool bPropagateToChildren=false) {}
	public void SetHiddenInGame(bool NewHidden,bool bPropagateToChildren=false) {}
	public UObject GetPhysicsVolume(UObject ReturnValue) { return default; }
	public void K2_SetRelativeLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void SetAbsolute(bool bNewAbsoluteLocation=false,bool bNewAbsoluteRotation=false,bool bNewAbsoluteScale=false) {}
	public void K2_SetWorldLocationAndRotation(FVector NewLocation,FRotator NewRotation,bool bSweep,FHitResult SweepHitResult,bool bTeleport) {}
	public void SetMobility(EComponentMobility NewMobility) {}
}
