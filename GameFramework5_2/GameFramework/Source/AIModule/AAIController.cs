#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AIController.h")]
///<summary>AIController is the base class of controllers for AI-controlled Pawns.</summary>
public partial class AAIController : AController {
// AIController
	public bool bStartAILogicOnPossess;
	public bool bStopAILogicOnUnposses;
	public bool bLOSflag;
	public bool bSkipExtraLOSChecks;
	public bool bAllowStrafe;
	public bool bWantsPlayerState;
	public bool bSetControlRotationFromPawnOrientation;
	public UPathFollowingComponent PathFollowingComponent;
	public UBrainComponent BrainComponent;
	public UAIPerceptionComponent PerceptionComponent;
	public UDEPRECATED_PawnActionsComponent ActionsComp_DEPRECATED;
	public UBlackboardComponent Blackboard;
	public UGameplayTasksComponent CachedGameplayTasksComponent;
	public UClass DefaultNavigationFilterClass;
	public EPathFollowingRequestResult MoveToActor(UObject Goal,float AcceptanceRadius=-1,bool bStopOnOverlap=true,bool bUsePathfinding=true,bool bCanStrafe=true,UClass FilterClass=NULL,bool bAllowPartialPath=true,EPathFollowingRequestResult ReturnValue) { return default; }
	public EPathFollowingRequestResult MoveToLocation(FVector Dest,float AcceptanceRadius=-1,bool bStopOnOverlap=true,bool bUsePathfinding=true,bool bProjectDestinationToNavigation=false,bool bCanStrafe=true,UClass FilterClass=NULL,bool bAllowPartialPath=true,EPathFollowingRequestResult ReturnValue) { return default; }
	public FAIMoveCompletedSignature ReceiveMoveCompleted;
	public EPathFollowingStatus GetMoveStatus(EPathFollowingStatus ReturnValue) { return default; }
	public bool HasPartialPath(bool ReturnValue) { return default; }
	public FVector GetImmediateMoveDestination(FVector ReturnValue) { return default; }
	public void SetMoveBlockDetection(bool bEnable) {}
	public bool RunBehaviorTree(UObject BTAsset,bool ReturnValue) { return default; }
	public bool UseBlackboard(UObject BlackboardAsset,UObject BlackboardComponent,bool ReturnValue) { return default; }
	public void ClaimTaskResource(UClass ResourceClass) {}
	public void UnclaimTaskResource(UClass ResourceClass) {}
	public void OnUsingBlackBoard(UObject BlackboardComp,UObject BlackboardAsset) {}
	public FVector GetFocalPoint(FVector ReturnValue) { return default; }
	public FVector GetFocalPointOnActor(UObject Actor,FVector ReturnValue) { return default; }
	public void K2_SetFocalPoint(FVector FP) {}
	public void K2_SetFocus(UObject NewFocus) {}
	public UObject GetFocusActor(UObject ReturnValue) { return default; }
	public void K2_ClearFocus() {}
	public void OnGameplayTaskResourcesClaimed(FGameplayResourceSet NewlyClaimed,FGameplayResourceSet FreshlyReleased) {}
	public UObject GetPathFollowingComponent(UObject ReturnValue) { return default; }
	public UObject GetAIPerceptionComponent(UObject ReturnValue) { return default; }
	public void SetPathFollowingComponent(UObject NewPFComponent) {}
	public UObject GetDeprecatedActionsComponent(UObject ReturnValue) { return default; }
}
