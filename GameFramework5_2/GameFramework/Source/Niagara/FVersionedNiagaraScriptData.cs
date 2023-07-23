#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Struct containing all of the data that can be different between different script versions.</summary>
public partial struct FVersionedNiagaraScriptData {
// VersionedNiagaraScriptData
	public FNiagaraAssetVersion Version;
	public sbyte VersionChangeDescription;
	public int ModuleUsageBitmask;
	public sbyte Category;
	public bool bSuggested;
	public TArray<sbyte> ProvidedDependencies;
	public TArray<FNiagaraModuleDependency> RequiredDependencies;
	public bool bDeprecated;
	public sbyte DeprecationMessage;
	public UNiagaraScript DeprecationRecommendation;
	public UClass ConversionUtility;
	public bool bExperimental;
	public sbyte ExperimentalMessage;
	public sbyte NoteMessage;
	public ENiagaraScriptLibraryVisibility LibraryVisibility;
	public ENiagaraNumericOutputTypeSelectionMode NumericOutputTypeSelectionMode;
	public sbyte Description;
	public sbyte Keywords;
	public sbyte CollapsedViewFormat;
	public bool bCanBeUsedForTypeConversions;
	public TMap<sbyte,sbyte> ScriptMetaData;
	public TArray<FNiagaraStackSection> InputSections;
	public FNiagaraVMExecutableDataId LastGeneratedVMId;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public sbyte PythonUpdateScript;
	public FFilePath ScriptAsset;
	public TArray<FParameterDefinitionsSubscription> ParameterDefinitionsSubscriptions;
	public UNiagaraScriptSourceBase Source;
}
