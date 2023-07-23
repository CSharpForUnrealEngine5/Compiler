#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Struct containing all of the data needed to run a Niagara VM executable script.</summary>
public partial struct FNiagaraVMExecutableData {
// NiagaraVMExecutableData
	public FNiagaraVMExecutableByteCode ByteCode;
	public FNiagaraVMExecutableByteCode OptimizedByteCode;
	public int NumTempRegisters;
	public int NumUserPtrs;
	public FNiagaraParameters Parameters;
	public FNiagaraParameters InternalParameters;
	public TArray<FNiagaraCompileDependency> ExternalDependencies;
	public TArray<FNiagaraVariable> BakedRapidIterationParameters;
	public TArray<FNiagaraCompilerTag> CompileTags;
	public TArray<byte> ScriptLiterals;
	public TArray<FNiagaraVariable> Attributes;
	public FNiagaraScriptDataUsageInfo DataUsage;
	public TMap<sbyte,FNiagaraParameters> DataSetToParameters;
	public TArray<FNiagaraFunctionSignature> AdditionalExternalFunctions;
	public TArray<FNiagaraScriptDataInterfaceCompileInfo> DataInterfaceInfo;
	public TArray<FVMExternalFunctionBindingInfo> CalledVMExternalFunctions;
	public TArray<FNiagaraDataSetID> ReadDataSets;
	public TArray<FNiagaraDataSetProperties> WriteDataSets;
	public TArray<FNiagaraStatScope> StatScopes;
	public sbyte LastHlslTranslation;
	public sbyte LastHlslTranslationGPU;
	public sbyte LastAssemblyTranslation;
	public uint LastOpCount;
	public FNiagaraShaderScriptParametersMetadata ShaderScriptParametersMetadata;
	public TArray<sbyte> ParameterCollectionPaths;
	public ENiagaraScriptCompileStatus LastCompileStatus;
	public TArray<FSimulationStageMetaData> SimulationStageMetaData;
	public bool bReadsAttributeData;
	public TArray<FNiagaraVariableBase> AttributesWritten;
	public TArray<FNiagaraVariable> StaticVariablesWritten;
	public sbyte ErrorMsg;
	public TArray<FNiagaraCompileEvent> LastCompileEvents;
	public TArray<byte> ExperimentalContextData;
	public bool bReadsSignificanceIndex;
	public bool bNeedsGPUContextInit;
}
