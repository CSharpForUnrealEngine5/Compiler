#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectBlueprintFunctionLibrary.h")]
public partial class USmartObjectBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// SmartObjectBlueprintFunctionLibrary
	public FSmartObjectClaimHandle GetValueAsSOClaimHandle(UObject BlackboardComponent,sbyte KeyName,FSmartObjectClaimHandle ReturnValue) { return default; }
	public void SetValueAsSOClaimHandle(UObject BlackboardComponent,sbyte KeyName,FSmartObjectClaimHandle Value) {}
	public bool IsValidSmartObjectClaimHandle(FSmartObjectClaimHandle Handle,bool ReturnValue) { return default; }
	public bool AddOrRemoveSmartObject(UObject SmartObject,bool bEnabled,bool ReturnValue) { return default; }
	public bool AddOrRemoveMultipleSmartObjects(TArray<UObject> SmartObjectActors,bool bAdd,bool ReturnValue) { return default; }
	public bool AddSmartObject(UObject SmartObjectActor,bool ReturnValue) { return default; }
	public bool AddMultipleSmartObjects(TArray<UObject> SmartObjectActors,bool ReturnValue) { return default; }
	public bool RemoveSmartObject(UObject SmartObjectActor,bool ReturnValue) { return default; }
	public bool RemoveMultipleSmartObjects(TArray<UObject> SmartObjectActors,bool ReturnValue) { return default; }
	public bool SetSmartObjectEnabled(UObject SmartObjectActor,bool bEnabled,bool ReturnValue) { return default; }
	public bool SetMultipleSmartObjectsEnabled(TArray<UObject> SmartObjectActors,bool bEnabled,bool ReturnValue) { return default; }
	public void SetBlackboardValueAsSOClaimHandle(UObject NodeOwner,FBlackboardKeySelector Key,FSmartObjectClaimHandle Value) {}
	public FSmartObjectClaimHandle GetBlackboardValueAsSOClaimHandle(UObject NodeOwner,FBlackboardKeySelector Key,FSmartObjectClaimHandle ReturnValue) { return default; }
}
