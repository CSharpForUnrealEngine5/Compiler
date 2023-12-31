#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitter.h")]
public partial struct FNiagaraEventScriptProperties {
// NiagaraEventScriptProperties
	public EScriptExecutionMode ExecutionMode;
	public uint SpawnNumber;
	public uint MaxEventsPerFrame;
	public FGuid SourceEmitterID;
	public string SourceEventName;
	public bool bRandomSpawnNumber;
	public uint MinSpawnNumber;
	public bool UpdateAttributeInitialValues;
}
