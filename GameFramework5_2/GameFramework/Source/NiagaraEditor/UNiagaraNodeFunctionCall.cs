#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeFunctionCall.h")]
public partial class UNiagaraNodeFunctionCall : UNiagaraNodeWithDynamicPins {
// NiagaraNodeFunctionCall
	public UNiagaraScript FunctionScript;
	public FGuid SelectedScriptVersion;
	public sbyte FunctionScriptAssetObjectPath;
	public FNiagaraFunctionSignature Signature;
	public TMap<sbyte,sbyte> FunctionSpecifiers;
	public TArray<FNiagaraPropagatedVariable> PropagatedStaticSwitchParameters;
	public FGuid PreviousScriptVersion;
	public sbyte PythonUpgradeScriptWarnings;
	public ENiagaraFunctionDebugState DebugState;
	public bool bInheritDebugStatus;
	public FGuid CachedChangeId;
	public FGuid InvalidScriptVersionReference;
	public sbyte FunctionDisplayName;
	public TMap<FGuid,UNiagaraMessageData> MessageKeyToMessageMap;
	public TArray<FNiagaraStackMessage> StackMessages;
	public TMap<FGuid,sbyte> BoundPinNames;
}
