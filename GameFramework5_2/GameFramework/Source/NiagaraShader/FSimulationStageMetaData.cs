#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptBase.h")]
public partial struct FSimulationStageMetaData {
// SimulationStageMetaData
	public sbyte SimulationStageName;
	public sbyte EnabledBinding;
	public sbyte ElementCountXBinding;
	public sbyte ElementCountYBinding;
	public sbyte ElementCountZBinding;
	public ENiagaraIterationSource IterationSourceType;
	public sbyte IterationDataInterface;
	public sbyte IterationDirectBinding;
	public ENiagaraSimStageExecuteBehavior ExecuteBehavior;
	public bool bWritesParticles;
	public bool bPartialParticleUpdate;
	public bool bParticleIterationStateEnabled;
	public bool bGpuIndirectDispatch;
	public sbyte ParticleIterationStateBinding;
	public FIntPoint ParticleIterationStateRange;
	public TArray<sbyte> OutputDestinations;
	public TArray<sbyte> InputDataInterfaces;
	public int NumIterations;
	public sbyte NumIterationsBinding;
	public ENiagaraGpuDispatchType GpuDispatchType;
	public ENiagaraDirectDispatchElementType GpuDirectDispatchElementType;
	public FIntVector GpuDispatchNumThreads;
}
