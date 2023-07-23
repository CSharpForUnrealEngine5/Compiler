#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraStackGraphUtilitiesAdapterLibrary.h")]
///<summary>Wrapper for modifying a UNiagaraEmitter by adding Scripts and Renderers through UNiagaraScriptConversionContexts and</summary>
public partial class UNiagaraEmitterConversionContext : UObject {
// NiagaraEmitterConversionContext
	public void FOnPasteScript(int ScriptIdx) {}
	public void Cleanup() {}
	public UObject FindOrAddModuleScript(sbyte ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,EScriptExecutionCategory ModuleScriptExecutionCategory,UObject ReturnValue) { return default; }
	public UObject FindOrAddModuleEventScript(sbyte ScriptNameString,FCreateScriptContextArgs CreateScriptContextArgs,FNiagaraEventHandlerAddAction EventScriptProps,UObject ReturnValue) { return default; }
	public UObject FindModuleScript(sbyte ScriptNameString,UObject ReturnValue) { return default; }
	public void AddModuleScript(sbyte ScriptNameString,UObject ScriptConversionContext,EScriptExecutionCategory ModuleScriptExecutionCategory) {}
	public void AddModuleEventScript(sbyte ScriptNameString,UObject ScriptConversionContext,FNiagaraEventHandlerAddAction EventScriptProps) {}
	public void SetParameterDirectly(sbyte ParameterNameString,UObject ParameterInput,EScriptExecutionCategory SetParameterExecutionCategory) {}
	public void AddRenderer(sbyte RendererNameString,UObject NewRendererProperties) {}
	public UObject FindRenderer(sbyte RendererNameString,UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllRenderers(TArray<UObject> ReturnValue) { return default; }
	public void Log(sbyte Message,ENiagaraMessageSeverity Severity,bool bIsVerbose=false) {}
	public void Finalize() {}
	public UObject GetEmitter(UObject ReturnValue) { return default; }
	public void SetSimTarget(ENiagaraSimTarget InTarget) {}
	public void SetLocalSpace(bool bLocalSpace) {}
	public void SetEnabled(bool bInEnabled) {}
	public bool GetEnabled(bool ReturnValue) { return default; }
	public void AddEventHandler(FNiagaraEventHandlerAddAction EventScriptPropertiesBP) {}
	public void SetRendererBinding(UObject InRendererProperties,sbyte BindingName,sbyte VariableToBindName,ENiagaraRendererSourceDataMode SourceDataMode) {}
	public void RemoveModuleScriptsForAssets(TArray<FAssetData> ScriptsToRemove) {}
	public void SetPastedFunctionCallNode(UObject InFunctionCallNode) {}
}
