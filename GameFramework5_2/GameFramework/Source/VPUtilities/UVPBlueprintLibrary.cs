#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBlueprintLibrary.h")]
///<summary>Functionality added to prototype the VR scouting tools</summary>
public partial class UVPBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBlueprintLibrary
	public void Refresh3DEditorViewport() {}
	public UObject SpawnVPTickableActor(UObject ContextObject,UClass ActorClass,FVector Location,FRotator Rotation,UObject ReturnValue) { return default; }
	public UObject SpawnBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation=true,UObject ReturnValue) { return default; }
	public bool JumpToBookmarkInLevelEditor(UObject Bookmark,bool ReturnValue) { return default; }
	public FGameplayTagContainer GetVirtualProductionRole(FGameplayTagContainer ReturnValue) { return default; }
	public FTransform GetEditorViewportTransform(FTransform ReturnValue) { return default; }
	public FTransform GetEditorVRHeadTransform(FTransform ReturnValue) { return default; }
	public FTransform GetEditorVRRoomTransform(FTransform ReturnValue) { return default; }
	public void SetGrabSpeed(float Speed) {}
	public bool IsVREditorModeActive(bool ReturnValue) { return default; }
	public FVector GetVREditorLaserHoverLocation(FVector ReturnValue) { return default; }
	public bool EditorUndo(bool ReturnValue) { return default; }
	public bool EditorRedo(bool ReturnValue) { return default; }
	public bool EditorDuplicate(bool ReturnValue) { return default; }
	public bool EditorDeleteSelectedObjects(bool ReturnValue) { return default; }
	public UObject GetEditorWorld(UObject ReturnValue) { return default; }
	public void VPBookmarkSplineMeshIndicatorSetStartAndEnd(UObject SplineMesh) {}
	public void VPBookmarkSplineMeshIndicatorDisable(UObject SplineMesh) {}
}
