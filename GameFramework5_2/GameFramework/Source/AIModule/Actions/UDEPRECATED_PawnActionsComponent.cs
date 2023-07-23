#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnActionsComponent.h")]
public partial class UDEPRECATED_PawnActionsComponent : UActorComponent {
// PawnActionsComponent
	public APawn ControlledPawn;
	public TArray<FPawnActionStack> ActionStacks;
	public TArray<FPawnActionEvent> ActionEvents;
	public UDEPRECATED_PawnAction CurrentAction_DEPRECATED;
	public bool K2_PerformAction(UObject Pawn,UObject Action,byte Priority=EAIRequestPriority,bool ReturnValue) { return default; }
	public bool K2_PushAction(UObject NewAction,EAIRequestPriority Priority,UObject Instigator=NULL,bool ReturnValue) { return default; }
	public EPawnActionAbortState K2_AbortAction(UObject ActionToAbort,EPawnActionAbortState ReturnValue) { return default; }
	public EPawnActionAbortState K2_ForceAbortAction(UObject ActionToAbort,EPawnActionAbortState ReturnValue) { return default; }
}
