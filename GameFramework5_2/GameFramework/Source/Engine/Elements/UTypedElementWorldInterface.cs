#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/Interfaces/TypedElementWorldInterface.h")]
public partial class UTypedElementWorldInterface : UInterface {
// TypedElementWorldInterface
	public bool IsTemplateElement(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public bool CanEditElement(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public UObject GetOwnerLevel(FScriptTypedElementHandle InElementHandle,UObject ReturnValue) { return default; }
	public UObject GetOwnerWorld(FScriptTypedElementHandle InElementHandle,UObject ReturnValue) { return default; }
	public bool GetBounds(FScriptTypedElementHandle InElementHandle,FBoxSphereBounds OutBounds,bool ReturnValue) { return default; }
	public bool CanMoveElement(FScriptTypedElementHandle InElementHandle,ETypedElementWorldType InWorldType,bool ReturnValue) { return default; }
	public bool GetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform,bool ReturnValue) { return default; }
	public bool SetWorldTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform,bool ReturnValue) { return default; }
	public bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform OutTransform,bool ReturnValue) { return default; }
	public bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle,FTransform InTransform,bool ReturnValue) { return default; }
	public bool GetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector OutPivotOffset,bool ReturnValue) { return default; }
	public bool SetPivotOffset(FScriptTypedElementHandle InElementHandle,FVector InPivotOffset,bool ReturnValue) { return default; }
	public void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle) {}
	public void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle) {}
	public void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle) {}
	public bool CanDeleteElement(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public bool DeleteElement(FScriptTypedElementHandle InElementHandle,UObject InWorld,UObject InSelectionSet,FTypedElementDeletionOptions InDeletionOptions,bool ReturnValue) { return default; }
	public bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle,UObject InWorld,FVector InLocationOffset,FScriptTypedElementHandle ReturnValue) { return default; }
	public bool CanPromoteElement(FScriptTypedElementHandle InElementHandle,bool ReturnValue) { return default; }
	public FScriptTypedElementHandle PromoteElement(FScriptTypedElementHandle InElementHandle,UObject OverrideWorld=nullptr,FScriptTypedElementHandle ReturnValue) { return default; }
}
