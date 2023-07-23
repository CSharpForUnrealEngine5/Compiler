#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial class UNiagaraSimCache : UObject {
// NiagaraSimCache
	public bool IsCacheValid(bool ReturnValue) { return default; }
	public bool IsEmpty(bool ReturnValue) { return default; }
	public ENiagaraSimCacheAttributeCaptureMode GetAttributeCaptureMode(ENiagaraSimCacheAttributeCaptureMode ReturnValue) { return default; }
	public float GetStartSeconds(float ReturnValue) { return default; }
	public int GetNumFrames(int ReturnValue) { return default; }
	public int GetNumEmitters(int ReturnValue) { return default; }
	public sbyte GetEmitterName(int EmitterIndex,sbyte ReturnValue) { return default; }
	public TArray<sbyte> GetEmitterNames(TArray<sbyte> ReturnValue) { return default; }
	public void ReadIntAttribute(TArray<int> OutValues,sbyte AttributeName,sbyte EmitterName,int FrameIndex=0) {}
	public void ReadFloatAttribute(TArray<float> OutValues,sbyte AttributeName,sbyte EmitterName,int FrameIndex=0) {}
	public void ReadVector2Attribute(TArray<FVector2D> OutValues,sbyte AttributeName,sbyte EmitterName,int FrameIndex=0) {}
	public void ReadVectorAttribute(TArray<FVector> OutValues,sbyte AttributeName,sbyte EmitterName,int FrameIndex=0) {}
	public void ReadVector4Attribute(TArray<FVector4> OutValues,sbyte AttributeName,sbyte EmitterName,int FrameIndex=0) {}
	public void ReadColorAttribute(TArray<FLinearColor> OutValues,sbyte AttributeName=FName,sbyte EmitterName=NAME_None,int FrameIndex=0) {}
	public void ReadPositionAttribute(TArray<FVector> OutValues,sbyte AttributeName=FName,sbyte EmitterName=NAME_None,bool bLocalSpaceToWorld=true,int FrameIndex=0) {}
	public void ReadPositionAttributeWithRebase(TArray<FVector> OutValues,FTransform Transform,sbyte AttributeName=FName,sbyte EmitterName=NAME_None,int FrameIndex=0) {}
	public void ReadQuatAttribute(TArray<FQuat> OutValues,sbyte AttributeName=FName,sbyte EmitterName=NAME_None,bool bLocalSpaceToWorld=true,int FrameIndex=0) {}
	public void ReadQuatAttributeWithRebase(TArray<FQuat> OutValues,FQuat Quat,sbyte AttributeName=FName,sbyte EmitterName=NAME_None,int FrameIndex=0) {}
	public FGuid CacheGuid;
	public TSoftObjectPtr<UNiagaraSystem> SoftNiagaraSystem;
	public float StartSeconds;
	public float DurationSeconds;
	public FNiagaraSimCacheCreateParameters CreateParameters;
	public bool bNeedsReadComponentMappingRecache;
	public TArray<FNiagaraVMExecutableDataId> CachedScriptVMIds;
	public FNiagaraSimCacheLayout CacheLayout;
	public TArray<FNiagaraSimCacheFrame> CacheFrames;
	public TMap<FNiagaraVariableBase,UObject> DataInterfaceStorage;
}
