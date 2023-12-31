#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
///<summary>Struct containing all of the data that can be different between different emitter versions.</summary>
public partial struct FVersionedNiagaraEmitterData {
// VersionedNiagaraEmitterData
	public FNiagaraAssetVersion Version;
	public string VersionChangeDescription;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public string PythonUpdateScript;
	public FFilePath ScriptAsset;
	public bool bDeprecated;
	public string DeprecationMessage;
	public bool bLocalSpace;
	public bool bDeterminism;
	public int RandomSeed;
	public bool bInterpolatedSpawning;
	public bool bGpuAlwaysRunParticleUpdateScript;
	public ENiagaraSimTarget SimTarget;
	public ENiagaraEmitterCalculateBoundMode CalculateBoundsMode;
	public FBox FixedBounds;
	public bool bRequiresPersistentIDs;
	public bool bCombineEventSpawn;
	public TArray<FNiagaraEventScriptProperties> EventHandlerScriptProps;
	public FNiagaraPlatformSet Platforms;
	public FNiagaraEmitterScalabilityOverrides ScalabilityOverrides;
	public bool bLimitDeltaTime;
	public int MaxGPUParticlesSpawnPerFrame;
	public float MaxDeltaTimePerTick;
	public EParticleAllocationMode AllocationMode;
	public int PreAllocationCount;
	public FNiagaraEmitterScriptProperties UpdateScriptProps;
	public FNiagaraEmitterScriptProperties SpawnScriptProps;
	public FNiagaraParameterStore RendererBindings;
	public TArray<string> AttributesToPreserve;
	public FNiagaraEmitterScriptProperties EmitterSpawnScriptProps;
	public FNiagaraEmitterScriptProperties EmitterUpdateScriptProps;
	public UNiagaraScriptSourceBase GraphSource;
	public UNiagaraScratchPadContainer ScratchPads;
	public UNiagaraScratchPadContainer ParentScratchPads;
	public FVersionedNiagaraEmitter VersionedParent;
	public FVersionedNiagaraEmitter VersionedParentAtLastMerge;
	public TArray<UNiagaraRendererProperties> RendererProperties;
	public TArray<UNiagaraSimulationStageBase> SimulationStages;
	public UNiagaraScript GPUComputeScript;
	public TArray<string> SharedEventGeneratorIds;
	public FNiagaraEmitterScalabilitySettings CurrentScalabilitySettings;
	public UNiagaraEditorDataBase EditorData;
	public UNiagaraEditorParametersAdapterBase EditorParameters;
}
