#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEmitterHandle.h")]
///<summary>Stores emitter information within the context of a System.</summary>
public partial struct FNiagaraEmitterHandle {
// NiagaraEmitterHandle
	public FGuid Id;
	public string IdName;
	public bool bIsEnabled;
	public string Name;
	public UNiagaraEmitter Source_DEPRECATED;
	public UNiagaraEmitter LastMergedSource_DEPRECATED;
	public bool bIsolated;
	public UNiagaraEmitter Instance_DEPRECATED;
	public FVersionedNiagaraEmitter VersionedInstance;
}
