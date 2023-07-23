#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/AIBlueprintHelperLibrary.h")]
public partial class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary {
// AIBlueprintHelperLibrary
	public UObject CreateMoveToProxyObject(UObject WorldContextObject,UObject Pawn,FVector Destination,UObject TargetActor=NULL,float AcceptanceRadius=5.f,bool bStopOnOverlap=false,UObject ReturnValue) { return default; }
	public void SendAIMessage(UObject Target,sbyte Message,UObject MessageSource,bool bSuccess=true) {}
	public UObject SpawnAIFromClass(UObject WorldContextObject,UClass PawnClass,UObject BehaviorTree,FVector Location,FRotator Rotation=FRotator,bool bNoCollisionFail=false,UObject Owner=nullptr,UObject ReturnValue) { return default; }
	public UObject GetAIController(UObject ControlledActor,UObject ReturnValue) { return default; }
	public UObject GetBlackboard(UObject Target,UObject ReturnValue) { return default; }
	public void LockAIResourcesWithAnimation(UObject AnimInstance,bool bLockMovement,bool LockAILogic) {}
	public void UnlockAIResourcesWithAnimation(UObject AnimInstance,bool bUnlockMovement,bool UnlockAILogic) {}
	public bool IsValidAILocation(FVector Location,bool ReturnValue) { return default; }
	public bool IsValidAIDirection(FVector DirectionVector,bool ReturnValue) { return default; }
	public bool IsValidAIRotation(FRotator Rotation,bool ReturnValue) { return default; }
	public UObject GetCurrentPath(UObject Controller,UObject ReturnValue) { return default; }
	public TArray<FVector> GetCurrentPathPoints(UObject Controller,TArray<FVector> ReturnValue) { return default; }
	public int GetCurrentPathIndex(UObject Controller,int ReturnValue) { return default; }
	public int GetNextNavLinkIndex(UObject Controller,int ReturnValue) { return default; }
	public void SimpleMoveToActor(UObject Controller,UObject Goal) {}
	public void SimpleMoveToLocation(UObject Controller,FVector Goal) {}
}
