#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraComponent.h")]
///<summary>UNiagaraComponent is the primitive component for a Niagara System.</summary>
public partial class UNiagaraComponent : UFXSystemComponent {
// NiagaraComponent
	public UNiagaraSystem Asset;
	public ENiagaraTickBehavior TickBehavior;
	public int RandomSeedOffset;
	public FNiagaraUserRedirectionParameterStore OverrideParameters;
	public TMap<sbyte,bool> EditorOverridesValue_DEPRECATED;
	public TMap<FNiagaraVariableBase,FNiagaraVariant> TemplateParameterOverrides;
	public TMap<FNiagaraVariableBase,FNiagaraVariant> InstanceParameterOverrides;
	public bool bForceSolo;
	public bool bEnableGpuComputeDebug;
	public bool bOverrideWarmupSettings;
	public int WarmupTickCount;
	public float WarmupTickDelta;
	public bool bAutoDestroy;
	public bool bRenderingEnabled;
	public bool bAutoManageAttachment;
	public bool bAutoAttachWeldSimulatedBodies;
	public float MaxTimeBeforeForceUpdateTransform;
	public void SetAsset(UObject InAsset,bool bResetExistingOverrideParameters=true) {}
	public UObject GetAsset(UObject ReturnValue) { return default; }
	public void SetForceSolo(bool bInForceSolo) {}
	public bool GetForceSolo(bool ReturnValue) { return default; }
	public void SetGpuComputeDebug(bool bEnableDebug) {}
	public void SetCustomTimeDilation(float Dilation=1.0f) {}
	public float GetCustomTimeDilation(float ReturnValue) { return default; }
	public ENiagaraAgeUpdateMode GetAgeUpdateMode(ENiagaraAgeUpdateMode ReturnValue) { return default; }
	public void SetAgeUpdateMode(ENiagaraAgeUpdateMode InAgeUpdateMode) {}
	public float GetDesiredAge(float ReturnValue) { return default; }
	public void SetDesiredAge(float InDesiredAge) {}
	public void SeekToDesiredAge(float InDesiredAge) {}
	public void SetCanRenderWhileSeeking(bool bInCanRenderWhileSeeking) {}
	public float GetSeekDelta(float ReturnValue) { return default; }
	public void SetSeekDelta(float InSeekDelta) {}
	public bool GetLockDesiredAgeDeltaTimeToSeekDelta(bool ReturnValue) { return default; }
	public void SetLockDesiredAgeDeltaTimeToSeekDelta(bool bLock) {}
	public float GetMaxSimTime(float ReturnValue) { return default; }
	public void SetMaxSimTime(float InMaxTime) {}
	public void SetAutoDestroy(bool bInAutoDestroy) {}
	public void SetTickBehavior(ENiagaraTickBehavior NewTickBehavior) {}
	public ENiagaraTickBehavior GetTickBehavior(ENiagaraTickBehavior ReturnValue) { return default; }
	public void SetSystemFixedBounds(FBox LocalBounds) {}
	public FBox GetSystemFixedBounds(FBox ReturnValue) { return default; }
	public void ClearSystemFixedBounds() {}
	public void SetEmitterFixedBounds(sbyte EmitterName,FBox LocalBounds) {}
	public FBox GetEmitterFixedBounds(sbyte EmitterName,FBox ReturnValue) { return default; }
	public void ClearEmitterFixedBounds(sbyte EmitterName) {}
	public void SetRandomSeedOffset(int NewRandomSeedOffset) {}
	public int GetRandomSeedOffset(int ReturnValue) { return default; }
	public void SetNiagaraVariableLinearColor(sbyte InVariableName,FLinearColor InValue) {}
	public void SetVariableLinearColor(sbyte InVariableName,FLinearColor InValue) {}
	public void SetNiagaraVariableVec4(sbyte InVariableName,FVector4 InValue) {}
	public void SetVariableVec4(sbyte InVariableName,FVector4 InValue) {}
	public void SetNiagaraVariableQuat(sbyte InVariableName,FQuat InValue) {}
	public void SetVariableQuat(sbyte InVariableName,FQuat InValue) {}
	public void SetNiagaraVariableMatrix(sbyte InVariableName,FMatrix InValue) {}
	public void SetVariableMatrix(sbyte InVariableName,FMatrix InValue) {}
	public void SetNiagaraVariableVec3(sbyte InVariableName,FVector InValue) {}
	public void SetVariableVec3(sbyte InVariableName,FVector InValue) {}
	public void SetNiagaraVariablePosition(sbyte InVariableName,FVector InValue) {}
	public void SetVariablePosition(sbyte InVariableName,FVector InValue) {}
	public void SetNiagaraVariableVec2(sbyte InVariableName,FVector2D InValue) {}
	public void SetVariableVec2(sbyte InVariableName,FVector2D InValue) {}
	public void SetNiagaraVariableFloat(sbyte InVariableName,float InValue) {}
	public void SetVariableFloat(sbyte InVariableName,float InValue) {}
	public void SetNiagaraVariableInt(sbyte InVariableName,int InValue) {}
	public void SetVariableInt(sbyte InVariableName,int InValue) {}
	public void SetNiagaraVariableBool(sbyte InVariableName,bool InValue) {}
	public void SetVariableBool(sbyte InVariableName,bool InValue) {}
	public void SetNiagaraVariableActor(sbyte InVariableName,UObject Actor) {}
	public void SetVariableActor(sbyte InVariableName,UObject Actor) {}
	public void SetNiagaraVariableObject(sbyte InVariableName,UObject Object) {}
	public void SetVariableObject(sbyte InVariableName,UObject Object) {}
	public void SetVariableMaterial(sbyte InVariableName,UObject Object) {}
	public void SetVariableStaticMesh(sbyte InVariableName,UObject InValue) {}
	public void SetVariableTexture(sbyte InVariableName,UObject Texture) {}
	public void SetVariableTextureRenderTarget(sbyte InVariableName,UObject TextureRenderTarget) {}
	public TArray<FVector> GetNiagaraParticlePositions_DebugOnly(sbyte InEmitterName,TArray<FVector> ReturnValue) { return default; }
	public TArray<float> GetNiagaraParticleValues_DebugOnly(sbyte InEmitterName,sbyte InValueName,TArray<float> ReturnValue) { return default; }
	public TArray<FVector> GetNiagaraParticleValueVec3_DebugOnly(sbyte InEmitterName,sbyte InValueName,TArray<FVector> ReturnValue) { return default; }
	public void ResetSystem() {}
	public void ReinitializeSystem() {}
	public void SetRenderingEnabled(bool bInRenderingEnabled) {}
	public void AdvanceSimulation(int TickCount,float TickDeltaSeconds) {}
	public void AdvanceSimulationByTime(float SimulateTime,float TickDeltaSeconds) {}
	public void SetPaused(bool bInPaused) {}
	public bool IsPaused(bool ReturnValue) { return default; }
	public UObject GetDataInterface(sbyte Name,UObject ReturnValue) { return default; }
	public void SetPreviewLODDistance(bool bEnablePreviewLODDistance,float PreviewLODDistance,float PreviewMaxDistance) {}
	public bool GetPreviewLODDistanceEnabled(bool ReturnValue) { return default; }
	public float GetPreviewLODDistance(float ReturnValue) { return default; }
	public void InitForPerformanceBaseline() {}
	public FOnNiagaraSystemFinished OnSystemFinished;
	public TWeakObjectPtr<USceneComponent> AutoAttachParent;
	public sbyte AutoAttachSocketName;
	public EAttachmentRule AutoAttachLocationRule;
	public EAttachmentRule AutoAttachRotationRule;
	public EAttachmentRule AutoAttachScaleRule;
	public bool bWaitForCompilationOnActivate;
	public void SetSimCache(UObject SimCache,bool bResetSystem=false) {}
	public UObject GetSimCache(UObject ReturnValue) { return default; }
	public void ClearSimCache(bool bResetSystem=false) {}
	public void SetAllowScalability(bool bAllow) {}
	public bool GetAllowScalability(bool ReturnValue) { return default; }
	public void SetForceLocalPlayerEffect(bool bIsPlayerEffect) {}
	public bool GetForceLocalPlayerEffect(bool ReturnValue) { return default; }
	public bool bAllowScalability;
	public UNiagaraSimCache SimCache;
	public UNiagaraCullProxyComponent CullProxy;
}
