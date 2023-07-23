#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraFunctionSignature {
// NiagaraFunctionSignature
	public sbyte Name;
	public TArray<FNiagaraVariable> Inputs;
	public TArray<FNiagaraVariable> Outputs;
	public sbyte OwnerName;
	public bool bRequiresContext;
	public bool bRequiresExecPin;
	public bool bMemberFunction;
	public bool bExperimental;
	public sbyte ExperimentalMessage;
	public uint FunctionVersion;
	public bool bSupportsCPU;
	public bool bSupportsGPU;
	public bool bWriteFunction;
	public bool bReadFunction;
	public bool bSoftDeprecatedFunction;
	public bool bIsCompileTagGenerator;
	public bool bHidden;
	public int ModuleUsageBitmask;
	public int ContextStageIndex;
	public short RequiredInputs;
	public short RequiredOutputs;
	public TMap<sbyte,sbyte> FunctionSpecifiers;
	public sbyte Description;
	public TMap<FNiagaraVariableBase,sbyte> InputDescriptions;
	public TMap<FNiagaraVariableBase,sbyte> OutputDescriptions;
}
