#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraClipboard.h")]
public partial class UNiagaraClipboardFunctionInput : UObject {
// NiagaraClipboardFunctionInput
	public sbyte InputName;
	public FNiagaraTypeDefinition InputType;
	public bool bHasEditCondition;
	public bool bEditConditionValue;
	public ENiagaraClipboardFunctionInputValueMode ValueMode;
	public TArray<byte> Local;
	public sbyte Linked;
	public UNiagaraDataInterface Data;
	public sbyte Expression;
	public UNiagaraClipboardFunction Dynamic;
}
