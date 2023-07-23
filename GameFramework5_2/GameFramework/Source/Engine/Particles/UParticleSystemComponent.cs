#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleSystemComponent.h")]
///<summary>A particle emitter.</summary>
public partial class UParticleSystemComponent : UFXSystemComponent {
// ParticleSystemComponent
	public UParticleSystem Template;
	public TArray<UMaterialInterface> EmitterMaterials;
	public TArray<USkeletalMeshComponent> SkelMeshComponents;
	public bool bResetOnDetach;
	public bool bUpdateOnDedicatedServer;
	public bool bAllowRecycling;
	public bool bAutoManageAttachment;
	public bool bAutoAttachWeldSimulatedBodies;
	public bool bWarmingUp;
	public bool bOverrideLODMethod;
	public bool bSkipUpdateDynamicDataDuringTick;
	public byte LODMethod;
	public EParticleSignificanceLevel RequiredSignificance;
	public TArray<FParticleSysParam> InstanceParameters;
	public FParticleSpawnSignature OnParticleSpawn;
	public FParticleBurstSignature OnParticleBurst;
	public FParticleDeathSignature OnParticleDeath;
	public FParticleCollisionSignature OnParticleCollide;
	public bool bOldPositionValid;
	public FVector OldPosition;
	public FVector PartSysVelocity;
	public float WarmupTime;
	public float WarmupTickRate;
	public float SecondsBeforeInactive;
	public float MaxTimeBeforeForceUpdateTransform;
	public int EditorLODLevel;
	public int EditorDetailMode;
	public TArray<UParticleSystemReplay> ReplayClips;
	public float CustomTimeDilation;
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	public sbyte AutoAttachSocketName;
	public byte AutoAttachLocationType_DEPRECATED;
	public EAttachmentRule AutoAttachLocationRule;
	public EAttachmentRule AutoAttachRotationRule;
	public EAttachmentRule AutoAttachScaleRule;
	public void SetAutoAttachParams(UObject Parent,sbyte SocketName=NAME_None,EAttachLocation LocationType=EAttachLocation) {}
	public FOnSystemFinished OnSystemFinished;
	public void SetBeamEndPoint(int EmitterIndex,FVector NewEndPoint) {}
	public void SetBeamSourcePoint(int EmitterIndex,FVector NewSourcePoint,int SourceIndex) {}
	public void SetBeamSourceTangent(int EmitterIndex,FVector NewTangentPoint,int SourceIndex) {}
	public void SetBeamSourceStrength(int EmitterIndex,float NewSourceStrength,int SourceIndex) {}
	public void SetBeamTargetPoint(int EmitterIndex,FVector NewTargetPoint,int TargetIndex) {}
	public void SetBeamTargetTangent(int EmitterIndex,FVector NewTangentPoint,int TargetIndex) {}
	public void SetBeamTargetStrength(int EmitterIndex,float NewTargetStrength,int TargetIndex) {}
	public bool GetBeamEndPoint(int EmitterIndex,FVector OutEndPoint,bool ReturnValue) { return default; }
	public bool GetBeamSourcePoint(int EmitterIndex,int SourceIndex,FVector OutSourcePoint,bool ReturnValue) { return default; }
	public bool GetBeamSourceTangent(int EmitterIndex,int SourceIndex,FVector OutTangentPoint,bool ReturnValue) { return default; }
	public bool GetBeamSourceStrength(int EmitterIndex,int SourceIndex,float OutSourceStrength,bool ReturnValue) { return default; }
	public bool GetBeamTargetPoint(int EmitterIndex,int TargetIndex,FVector OutTargetPoint,bool ReturnValue) { return default; }
	public bool GetBeamTargetTangent(int EmitterIndex,int TargetIndex,FVector OutTangentPoint,bool ReturnValue) { return default; }
	public bool GetBeamTargetStrength(int EmitterIndex,int TargetIndex,float OutTargetStrength,bool ReturnValue) { return default; }
	public void SetMaterialParameter(sbyte ParameterName,UObject Param) {}
	public void SetTemplate(UObject NewTemplate) {}
	public int GetNumActiveParticles(int ReturnValue) { return default; }
	public void BeginTrails(sbyte InFirstSocketName,sbyte InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth) {}
	public void EndTrails() {}
	public void SetTrailSourceData(sbyte InFirstSocketName,sbyte InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth) {}
	public UObject CreateNamedDynamicMaterialInstance(sbyte InName,UObject SourceMaterial=NULL,UObject ReturnValue) { return default; }
	public UObject GetNamedMaterial(sbyte InName,UObject ReturnValue) { return default; }
	public void GenerateParticleEvent(sbyte InEventName,float InEmitterTime,FVector InLocation,FVector InDirection,FVector InVelocity) {}
}
