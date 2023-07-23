#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsControlComponent.h")]
///<summary>This is the main Physics Control Component class which manages Controls and Body Modifiers associated</summary>
public partial class UPhysicsControlComponent : USceneComponent {
// PhysicsControlComponent
	public sbyte CreateControl(UObject ParentMeshComponent,sbyte ParentBoneName,UObject ChildMeshComponent,sbyte ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,sbyte Set,bool bEnabled=true,sbyte ReturnValue) { return default; }
	public bool CreateNamedControl(sbyte Name,UObject ParentMeshComponent,sbyte ParentBoneName,UObject ChildMeshComponent,sbyte ChildBoneName,FPhysicsControlData ControlData,FPhysicsControlTarget ControlTarget,FPhysicsControlSettings ControlSettings,sbyte Set,bool bEnabled=true,bool ReturnValue) { return default; }
	public TArray<sbyte> CreateControlsFromSkeletalMeshBelow(UObject SkeletalMeshComponent,sbyte BoneName,bool bIncludeSelf,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,sbyte Set,bool bEnabled=true,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> CreateControlsFromSkeletalMeshAndConstraintProfileBelow(UObject SkeletalMeshComponent,sbyte BoneName,bool bIncludeSelf,sbyte ConstraintProfile,sbyte Set,bool bEnabled=true,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> CreateControlsFromSkeletalMesh(UObject SkeletalMeshComponent,TArray<sbyte> BoneNames,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,sbyte Set,bool bEnabled=true,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> CreateControlsFromSkeletalMeshAndConstraintProfile(UObject SkeletalMeshComponent,TArray<sbyte> BoneNames,sbyte ConstraintProfile,sbyte Set,bool bEnabled=true,TArray<sbyte> ReturnValue) { return default; }
	public TMap<sbyte,FPhysicsControlLimbBones> GetLimbBonesFromSkeletalMesh(UObject SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData,TMap<sbyte,FPhysicsControlLimbBones> ReturnValue) { return default; }
	public TMap<sbyte,FPhysicsControlNames> CreateControlsFromLimbBones(FPhysicsControlNames AllControls,TMap<sbyte,FPhysicsControlLimbBones> LimbBones,EPhysicsControlType ControlType,FPhysicsControlData ControlData,FPhysicsControlSettings ControlSettings,bool bEnabled=true,TMap<sbyte,FPhysicsControlNames> ReturnValue) { return default; }
	public TMap<sbyte,FPhysicsControlNames> CreateControlsFromLimbBonesAndConstraintProfile(FPhysicsControlNames AllControls,TMap<sbyte,FPhysicsControlLimbBones> LimbBones,sbyte ConstraintProfile,bool bEnabled=true,TMap<sbyte,FPhysicsControlNames> ReturnValue) { return default; }
	public bool DestroyControl(sbyte Name,bool ReturnValue) { return default; }
	public void DestroyControls(TArray<sbyte> Names) {}
	public void DestroyControlsInSet(sbyte Set) {}
	public bool SetControlData(sbyte Name,FPhysicsControlData ControlData,bool bEnableControl=true,bool ReturnValue) { return default; }
	public void SetControlDatas(TArray<sbyte> Names,FPhysicsControlData ControlData,bool bEnableControl=true) {}
	public void SetControlDatasInSet(sbyte Set,FPhysicsControlData ControlData,bool bEnableControl=true) {}
	public bool SetControlMultiplier(sbyte Name,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl=true,bool ReturnValue) { return default; }
	public void SetControlMultipliers(TArray<sbyte> Names,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl=true) {}
	public void SetControlMultipliersInSet(sbyte Set,FPhysicsControlMultiplier ControlMultiplier,bool bEnableControl=true) {}
	public bool SetControlLinearData(sbyte Name,float Strength=1.0f,float DampingRatio=1.0f,float ExtraDamping=0.0f,float MaxForce=0.0f,bool bEnableControl=true,bool ReturnValue) { return default; }
	public bool SetControlAngularData(sbyte Name,float Strength=1.0f,float DampingRatio=1.0f,float ExtraDamping=0.0f,float MaxTorque=0.0f,bool bEnableControl=true,bool ReturnValue) { return default; }
	public bool SetControlPoint(sbyte Name,FVector Position,bool ReturnValue) { return default; }
	public bool ResetControlPoint(sbyte Name,bool ReturnValue) { return default; }
	public bool SetControlTarget(sbyte Name,FPhysicsControlTarget ControlTarget,bool bEnableControl=true,bool ReturnValue) { return default; }
	public void SetControlTargets(TArray<sbyte> Names,FPhysicsControlTarget ControlTarget,bool bEnableControl=true) {}
	public void SetControlTargetsInSet(sbyte Set,FPhysicsControlTarget ControlTarget,bool bEnableControl=true) {}
	public bool SetControlTargetPositionAndOrientation(sbyte Name,FVector Position,FRotator Orientation,float VelocityDeltaTime,bool bEnableControl=true,bool bApplyControlPointToTarget=false,bool ReturnValue) { return default; }
	public bool SetControlTargetPosition(sbyte Name,FVector Position,float VelocityDeltaTime,bool bEnableControl=true,bool bApplyControlPointToTarget=false,bool ReturnValue) { return default; }
	public bool SetControlTargetOrientation(sbyte Name,FRotator Orientation,float AngularVelocityDeltaTime,bool bEnableControl=true,bool bApplyControlPointToTarget=false,bool ReturnValue) { return default; }
	public bool SetControlTargetPoses(sbyte Name,FVector ParentPosition,FRotator ParentOrientation,FVector ChildPosition,FRotator ChildOrientation,float VelocityDeltaTime,bool bEnableControl=true,bool ReturnValue) { return default; }
	public bool SetControlUseSkeletalAnimation(sbyte Name,bool bUseSkeletalAnimation=true,float SkeletalAnimationVelocityMultiplier=1.0f,bool ReturnValue) { return default; }
	public void SetControlsUseSkeletalAnimation(TArray<sbyte> Names,bool bUseSkeletalAnimation=true,float SkeletalAnimationVelocityMultiplier=1.0f) {}
	public void SetControlsInSetUseSkeletalAnimation(sbyte Set,bool bUseSkeletalAnimation=true,float SkeletalAnimationVelocityMultiplier=1.0f) {}
	public bool SetControlEnabled(sbyte Name,bool bEnable=true,bool ReturnValue) { return default; }
	public void SetControlsEnabled(TArray<sbyte> Names,bool bEnable=true) {}
	public void SetControlsInSetEnabled(sbyte Set,bool bEnable=true) {}
	public bool SetControlAutoDisable(sbyte Name,bool bAutoDisable,bool ReturnValue) { return default; }
	public void SetControlsAutoDisable(TArray<sbyte> Names,bool bAutoDisable) {}
	public void SetControlsInSetAutoDisable(sbyte Set,bool bAutoDisable) {}
	public bool SetControlDisableCollision(sbyte Name,bool bDisableCollision,bool ReturnValue) { return default; }
	public void SetControlsDisableCollision(TArray<sbyte> Names,bool bDisableCollision) {}
	public void SetControlsInSetDisableCollision(sbyte Set,bool bDisableCollision) {}
	public bool GetControlData(sbyte Name,FPhysicsControlData ControlData,bool ReturnValue) { return default; }
	public bool GetControlMultiplier(sbyte Name,FPhysicsControlMultiplier ControlMultiplier,bool ReturnValue) { return default; }
	public bool GetControlTarget(sbyte Name,FPhysicsControlTarget ControlTarget,bool ReturnValue) { return default; }
	public bool GetControlAutoDisable(sbyte Name,bool ReturnValue) { return default; }
	public bool GetControlEnabled(sbyte Name,bool ReturnValue) { return default; }
	public sbyte CreateBodyModifier(UObject MeshComponent,sbyte BoneName,sbyte Set,EPhysicsMovementType MovementType=EPhysicsMovementType,ECollisionEnabled CollisionType=ECollisionEnabled,float GravityMultiplier=1.0f,bool bUseSkeletalAnimation=true,sbyte ReturnValue) { return default; }
	public bool CreateNamedBodyModifier(sbyte Name,UObject MeshComponent,sbyte BoneName,sbyte Set,EPhysicsMovementType MovementType=EPhysicsMovementType,ECollisionEnabled CollisionType=ECollisionEnabled,float GravityMultiplier=1.0f,bool bUseSkeletalAnimation=true,bool ReturnValue) { return default; }
	public TArray<sbyte> CreateBodyModifiersFromSkeletalMeshBelow(UObject SkeletalMeshComponent,sbyte BoneName,bool bIncludeSelf,sbyte Set,EPhysicsMovementType MovementType=EPhysicsMovementType,ECollisionEnabled CollisionType=ECollisionEnabled,float GravityMultiplier=1.0f,bool bUseSkeletalAnimation=true,TArray<sbyte> ReturnValue) { return default; }
	public TMap<sbyte,FPhysicsControlNames> CreateBodyModifiersFromLimbBones(FPhysicsControlNames AllBodyModifiers,TMap<sbyte,FPhysicsControlLimbBones> LimbBones,EPhysicsMovementType MovementType=EPhysicsMovementType,ECollisionEnabled CollisionType=ECollisionEnabled,float GravityMultiplier=1.0f,bool bUseSkeletalAnimation=true,TMap<sbyte,FPhysicsControlNames> ReturnValue) { return default; }
	public bool DestroyBodyModifier(sbyte Name,bool ReturnValue) { return default; }
	public void DestroyBodyModifiers(TArray<sbyte> Names) {}
	public void DestroyBodyModifiersInSet(sbyte Set) {}
	public bool SetBodyModifierKinematicTarget(sbyte Name,FVector KinematicTargetPosition,FRotator KinematicTargetOrienation,bool bMakeKinematic,bool ReturnValue) { return default; }
	public bool SetBodyModifierMovementType(sbyte Name,EPhysicsMovementType MovementType=EPhysicsMovementType,bool ReturnValue) { return default; }
	public void SetBodyModifiersMovementType(TArray<sbyte> Names,EPhysicsMovementType MovementType=EPhysicsMovementType) {}
	public void SetBodyModifiersInSetMovementType(sbyte Set,EPhysicsMovementType MovementType=EPhysicsMovementType) {}
	public bool SetBodyModifierCollisionType(sbyte Name,ECollisionEnabled CollisionType=ECollisionEnabled,bool ReturnValue) { return default; }
	public void SetBodyModifiersCollisionType(TArray<sbyte> Names,ECollisionEnabled CollisionType=ECollisionEnabled) {}
	public void SetBodyModifiersInSetCollisionType(sbyte Set,ECollisionEnabled CollisionType=ECollisionEnabled) {}
	public bool SetBodyModifierGravityMultiplier(sbyte Name,float GravityMultiplier=1.0f,bool ReturnValue) { return default; }
	public void SetBodyModifiersGravityMultiplier(TArray<sbyte> Names,float GravityMultiplier=1.0f) {}
	public void SetBodyModifiersInSetGravityMultiplier(sbyte Set,float GravityMultiplier=1.0f) {}
	public bool SetBodyModifierUseSkeletalAnimation(sbyte Name,bool bUseSkeletalAnimation,bool ReturnValue) { return default; }
	public void SetBodyModifiersUseSkeletalAnimation(TArray<sbyte> Names,bool bUseSkeletalAnimation) {}
	public void SetBodyModifiersInSetUseSkeletalAnimation(sbyte Set,bool bUseSkeletalAnimation) {}
	public void CreateControlsAndBodyModifiersFromLimbBones(FPhysicsControlNames AllWorldSpaceControls,TMap<sbyte,FPhysicsControlNames> LimbWorldSpaceControls,FPhysicsControlNames AllParentSpaceControls,TMap<sbyte,FPhysicsControlNames> LimbParentSpaceControls,FPhysicsControlNames AllBodyModifiers,TMap<sbyte,FPhysicsControlNames> LimbBodyModifiers,UObject SkeletalMeshComponent,TArray<FPhysicsControlLimbSetupData> LimbSetupData,FPhysicsControlData WorldSpaceControlData,FPhysicsControlSettings WorldSpaceControlSettings,bool bEnableWorldSpaceControls,FPhysicsControlData ParentSpaceControlData,FPhysicsControlSettings ParentSpaceControlSettings,bool bEnableParentSpaceControls,EPhysicsMovementType PhysicsMovementType=EPhysicsMovementType,float GravityMultiplier=1.0f) {}
	public void AddControlToSet(FPhysicsControlNames NewSet,sbyte Control,sbyte Set) {}
	public void AddControlsToSet(FPhysicsControlNames NewSet,TArray<sbyte> Controls,sbyte Set) {}
	public TArray<sbyte> GetAllControlNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetControlNamesInSet(sbyte Set,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetAllBodyModifierNames(TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetBodyModifierNamesInSet(sbyte Set,TArray<sbyte> ReturnValue) { return default; }
	public void AddBodyModifierToSet(FPhysicsControlNames NewSet,sbyte BodyModifier,sbyte Set) {}
	public void AddBodyModifiersToSet(FPhysicsControlNames NewSet,TArray<sbyte> BodyModifiers,sbyte Set) {}
	public TArray<sbyte> GetSetsContainingControl(sbyte Control,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> GetSetsContainingBodyModifier(sbyte Control,TArray<sbyte> ReturnValue) { return default; }
	public float TeleportDistanceThreshold;
	public float TeleportRotationThreshold;
	public bool bShowDebugVisualization;
	public float VisualizationSizeScale;
	public bool bShowDebugControlList;
	public sbyte DebugControlDetailFilter;
	public bool bShowDebugBodyModifierList;
	public sbyte DebugBodyModifierDetailFilter;
	public float VelocityPredictionTime;
	public int MaxNumControlsOrModifiersPerName;
}
