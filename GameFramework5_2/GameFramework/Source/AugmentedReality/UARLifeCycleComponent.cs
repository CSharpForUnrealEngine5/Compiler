#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARLifeCycleComponent.h")]
public partial class UARLifeCycleComponent : USceneComponent {
// ARLifeCycleComponent
	public void FInstanceARActorSpawnedDelegate(UClass ComponentClass,FGuid NativeID,UObject SpawnedActor) {}
	public FInstanceARActorSpawnedDelegate OnARActorSpawnedDelegate;
	public void FInstanceARActorToBeDestroyedDelegate(UObject Actor) {}
	public FInstanceARActorToBeDestroyedDelegate OnARActorToBeDestroyedDelegate;
	public void ServerSpawnARActor(UClass ComponentClass,FGuid NativeID) {}
	public void ServerDestroyARActor(UObject Actor) {}
}
