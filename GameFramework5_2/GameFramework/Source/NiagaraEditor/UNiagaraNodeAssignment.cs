#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeAssignment.h")]
public partial class UNiagaraNodeAssignment : UNiagaraNodeFunctionCall {
// NiagaraNodeAssignment
	public FNiagaraVariable AssignmentTarget_DEPRECATED;
	public sbyte AssignmentDefaultValue_DEPRECATED;
	public TArray<FNiagaraVariable> AssignmentTargets;
	public TArray<sbyte> AssignmentDefaultValues;
	public sbyte OldFunctionCallName;
}
