#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Runtime script for a Niagara system</summary>
public partial class UNiagaraScript : UNiagaraScriptBase {
// NiagaraScript
	public TArray<UNiagaraValidationRule> ValidationRules;
	public ENiagaraScriptUsage Usage;
	public FGuid UsageId;
	public FGuid ExposedVersion;
	public bool bVersioningEnabled;
	public TArray<FVersionedNiagaraScriptData> VersionData;
	public FNiagaraParameterStore RapidIterationParameters;
	public FNiagaraParameterStore RapidIterationParametersCookedEditorCache;
	public FGuid VersionToOpenInEditor;
	public int UsageIndex_DEPRECATED;
	public int ModuleUsageBitmask_DEPRECATED;
	public sbyte Category_DEPRECATED;
	public TArray<sbyte> ProvidedDependencies_DEPRECATED;
	public TArray<FNiagaraModuleDependency> RequiredDependencies_DEPRECATED;
	public bool bDeprecated_DEPRECATED;
	public sbyte DeprecationMessage_DEPRECATED;
	public UNiagaraScript DeprecationRecommendation_DEPRECATED;
	public UClass ConversionUtility_DEPRECATED;
	public bool bExperimental_DEPRECATED;
	public sbyte ExperimentalMessage_DEPRECATED;
	public sbyte NoteMessage_DEPRECATED;
	public bool bExposeToLibrary_DEPRECATED;
	public ENiagaraScriptLibraryVisibility LibraryVisibility_DEPRECATED;
	public ENiagaraNumericOutputTypeSelectionMode NumericOutputTypeSelectionMode_DEPRECATED;
	public sbyte Description_DEPRECATED;
	public sbyte Keywords_DEPRECATED;
	public sbyte CollapsedViewFormat_DEPRECATED;
	public TMap<sbyte,sbyte> ScriptMetaData_DEPRECATED;
	public UNiagaraScriptSourceBase Source_DEPRECATED;
	public void RaiseOnGPUCompilationComplete() {}
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreCPU;
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStoreGPU;
	public FNiagaraScriptExecutionParameterStore ScriptExecutionParamStore;
	public TArray<FNiagaraBoundParameter> ScriptExecutionBoundParameters;
	public FNiagaraVMExecutableDataId CachedScriptVMId;
	public TArray<UObject> ActiveCompileRoots;
	public FNiagaraVMExecutableData CachedScriptVM;
	public TArray<UNiagaraParameterCollection> CachedParameterCollectionReferences;
	public TArray<FNiagaraScriptDataInterfaceInfo> CachedDefaultDataInterfaces;
}
