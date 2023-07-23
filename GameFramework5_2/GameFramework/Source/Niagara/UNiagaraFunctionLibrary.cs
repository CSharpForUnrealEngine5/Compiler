#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraFunctionLibrary.h")]
///<summary>A C++ and Blueprint accessible library of utility functions for accessing Niagara simulations</summary>
public partial class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary {
// NiagaraFunctionLibrary
	public UObject SpawnSystemAtLocationWithParams(FFXSystemSpawnParameters SpawnParams,UObject ReturnValue) { return default; }
	public UObject SpawnSystemAttachedWithParams(FFXSystemSpawnParameters SpawnParams,UObject ReturnValue) { return default; }
	public UObject SpawnSystemAtLocation(UObject WorldContextObject,UObject SystemTemplate,FVector Location,FRotator Rotation=FRotator,FVector Scale=FVector,bool bAutoDestroy=true,bool bAutoActivate=true,ENCPoolMethod PoolingMethod=ENCPoolMethod,bool bPreCullCheck=true,UObject ReturnValue) { return default; }
	public UObject SpawnSystemAttached(UObject SystemTemplate,UObject AttachToComponent,sbyte AttachPointName,FVector Location,FRotator Rotation,EAttachLocation LocationType,bool bAutoDestroy,bool bAutoActivate=true,ENCPoolMethod PoolingMethod=ENCPoolMethod,bool bPreCullCheck=true,UObject ReturnValue) { return default; }
	public void OverrideSystemUserVariableStaticMeshComponent(UObject NiagaraSystem,sbyte OverrideName,UObject StaticMeshComponent) {}
	public void OverrideSystemUserVariableStaticMesh(UObject NiagaraSystem,sbyte OverrideName,UObject StaticMesh) {}
	public void OverrideSystemUserVariableSkeletalMeshComponent(UObject NiagaraSystem,sbyte OverrideName,UObject SkeletalMeshComponent) {}
	public void SetSkeletalMeshDataInterfaceSamplingRegions(UObject NiagaraSystem,sbyte OverrideName,TArray<sbyte> SamplingRegions) {}
	public void SetSkeletalMeshDataInterfaceFilteredBones(UObject NiagaraSystem,sbyte OverrideName,TArray<sbyte> FilteredBones) {}
	public void SetSkeletalMeshDataInterfaceFilteredSockets(UObject NiagaraSystem,sbyte OverrideName,TArray<sbyte> FilteredSockets) {}
	public void SetTextureObject(UObject NiagaraSystem,sbyte OverrideName,UObject Texture) {}
	public void SetTexture2DArrayObject(UObject NiagaraSystem,sbyte OverrideName,UObject Texture) {}
	public void SetVolumeTextureObject(UObject NiagaraSystem,sbyte OverrideName,UObject Texture) {}
	public UObject GetNiagaraParameterCollection(UObject WorldContextObject,UObject Collection,UObject ReturnValue) { return default; }
	public void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UObject Primitive,int CollisionGroup) {}
	public void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,UObject Actor,int CollisionGroup) {}
	public int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,int ReturnValue) { return default; }
	public void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject,int CollisionGroup) {}
}
