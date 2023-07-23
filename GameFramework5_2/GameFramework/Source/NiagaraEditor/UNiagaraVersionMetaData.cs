#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraVersionMetaData.h")]
public partial class UNiagaraVersionMetaData : UObject {
// NiagaraVersionMetaData
	public bool bIsExposedVersion;
	public sbyte ChangeDescription;
	public bool bIsVisibleInVersionSelector;
	public bool bDeprecated;
	public sbyte DeprecationMessage;
	public FGuid VersionGuid;
	public ENiagaraPythonUpdateScriptReference UpdateScriptExecution;
	public sbyte PythonUpdateScript;
	public FFilePath ScriptAsset;
}
