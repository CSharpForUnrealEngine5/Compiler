#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectSubsystem.h")]
///<summary>Subsystem that holds all registered smart object instances and offers the API for spatial queries and reservations.</summary>
public partial class USmartObjectSubsystem : UWorldSubsystem {
// SmartObjectSubsystem
	public bool SetEnabled(FSmartObjectHandle Handle,bool bEnabled,bool ReturnValue) { return default; }
	public UObject GetSmartObjectComponent(FSmartObjectClaimHandle ClaimHandle,UObject ReturnValue) { return default; }
	public UObject GetSmartObjectComponentByRequestResult(FSmartObjectRequestResult Result,UObject ReturnValue) { return default; }
	public FSmartObjectRequestResult FindSmartObject(FSmartObjectRequest Request,FSmartObjectRequestResult ReturnValue) { return default; }
	public bool FindSmartObjects(FSmartObjectRequest Request,TArray<FSmartObjectRequestResult> OutResults,bool ReturnValue) { return default; }
	public FSmartObjectClaimHandle Claim(FSmartObjectRequestResult RequestResult,FSmartObjectClaimHandle ReturnValue) { return default; }
	public UObject Use(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass,UObject ReturnValue) { return default; }
	public bool Release(FSmartObjectClaimHandle ClaimHandle,bool ReturnValue) { return default; }
	public UObject GetBehaviorDefinition(FSmartObjectClaimHandle ClaimHandle,UClass DefinitionClass,UObject ReturnValue) { return default; }
	public UObject GetBehaviorDefinitionByRequestResult(FSmartObjectRequestResult RequestResult,UClass DefinitionClass,UObject ReturnValue) { return default; }
	public bool GetSlotLocation(FSmartObjectClaimHandle ClaimHandle,FVector OutSlotLocation,bool ReturnValue) { return default; }
	public bool GetSlotTransform(FSmartObjectClaimHandle ClaimHandle,FTransform OutSlotTransform,bool ReturnValue) { return default; }
	public bool GetSlotTransformFromRequestResult(FSmartObjectRequestResult RequestResult,FTransform OutSlotTransform,bool ReturnValue) { return default; }
	public FGameplayTagContainer GetInstanceTags(FSmartObjectHandle Handle,FGameplayTagContainer ReturnValue) { return default; }
	public void AddTagToInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	public void RemoveTagFromInstance(FSmartObjectHandle Handle,FGameplayTag Tag) {}
	public FGameplayTagContainer GetSlotTags(FSmartObjectSlotHandle SlotHandle,FGameplayTagContainer ReturnValue) { return default; }
	public void AddTagToSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag) {}
	public bool RemoveTagFromSlot(FSmartObjectSlotHandle SlotHandle,FGameplayTag Tag,bool ReturnValue) { return default; }
	public bool SetSlotEnabled(FSmartObjectSlotHandle SlotHandle,bool bEnabled,bool ReturnValue) { return default; }
	public FSoftClassPath SpacePartitionClassName;
	public UClass SpacePartitionClass;
	public USmartObjectSpacePartition SpacePartition;
	public ASmartObjectSubsystemRenderingActor RenderingActor;
	public FSmartObjectContainer SmartObjectContainer;
	public TMap<FSmartObjectHandle,FSmartObjectRuntime> RuntimeSmartObjects;
	public TMap<FSmartObjectSlotHandle,FSmartObjectRuntimeSlot> RuntimeSlots;
	public TArray<USmartObjectComponent> RegisteredSOComponents;
	public TArray<USmartObjectComponent> PendingSmartObjectRegistration;
}
