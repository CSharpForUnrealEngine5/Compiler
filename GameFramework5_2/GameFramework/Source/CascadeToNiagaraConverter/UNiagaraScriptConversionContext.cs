#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>Wrapper for programmatically adding scripts to a UNiagaraEmitter through a UNiagaraEmitterConversionContext.</summary>
public partial class UNiagaraScriptConversionContext : UObject {
// NiagaraScriptConversionContext
	public bool SetParameter(sbyte ParameterName,UObject ParameterInput,bool bInHasEditCondition=false,bool bInEditConditionValue=false,bool ReturnValue) { return default; }
	public void Log(sbyte Message,ENiagaraMessageSeverity Severity,bool bIsVerbose=false) {}
	public void SetModuleEnabled(bool bInModuleEnabled) {}
	public bool GetModuleEnabled(bool ReturnValue) { return default; }
}
