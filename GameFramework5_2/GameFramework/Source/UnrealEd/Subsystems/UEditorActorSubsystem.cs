#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Subsystems/EditorActorSubsystem.h")]
///<summary>UEditorActorUtilitiesSubsystem</summary>
public partial class UEditorActorSubsystem : UEditorSubsystem {
// EditorActorSubsystem
	public FOnEditNewActorsDropped OnNewActorsDropped;
	public FOnEditNewActorsPlaced OnNewActorsPlaced;
	public FOnEditCutActorsBegin OnEditCutActorsBegin;
	public FOnEditCutActorsEnd OnEditCutActorsEnd;
	public FOnEditCopyActorsBegin OnEditCopyActorsBegin;
	public FOnEditCopyActorsEnd OnEditCopyActorsEnd;
	public FOnEditPasteActorsBegin OnEditPasteActorsBegin;
	public FOnEditPasteActorsEnd OnEditPasteActorsEnd;
	public FOnEditCutActorsBegin OnDuplicateActorsBegin;
	public FOnDuplicateActorsEnd OnDuplicateActorsEnd;
	public FOnDeleteActorsBegin OnDeleteActorsBegin;
	public FOnDeleteActorsEnd OnDeleteActorsEnd;
	public UObject DuplicateActor(UObject ActorToDuplicate,UObject ToWorld=nullptr,FVector Offset=FVector,UObject ReturnValue) { return default; }
	public TArray<UObject> DuplicateActors(TArray<UObject> ActorsToDuplicate,UObject ToWorld=nullptr,FVector Offset=FVector,TArray<UObject> ReturnValue) { return default; }
	public void DuplicateSelectedActors(UObject InWorld) {}
	public void DeleteSelectedActors(UObject InWorld) {}
	public void InvertSelection(UObject InWorld) {}
	public void SelectAll(UObject InWorld) {}
	public void SelectAllChildren(bool bRecurseChildren) {}
	public TArray<UObject> GetAllLevelActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllLevelActorsComponents(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetSelectedLevelActors(TArray<UObject> ReturnValue) { return default; }
	public void SetSelectedLevelActors(TArray<UObject> ActorsToSelect) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
	public UObject SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation=FRotator,bool bTransient=false,UObject ReturnValue) { return default; }
	public UObject SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation=FRotator,bool bTransient=false,UObject ReturnValue) { return default; }
	public bool DestroyActor(UObject ActorToDestroy,bool ReturnValue) { return default; }
	public bool DestroyActors(TArray<UObject> ActorsToDestroy,bool ReturnValue) { return default; }
	public TArray<UObject> ConvertActors(TArray<UObject> Actors,UClass ActorClass,sbyte StaticMeshPackagePath,TArray<UObject> ReturnValue) { return default; }
	public bool SetActorTransform(UObject InActor,FTransform InWorldTransform,bool ReturnValue) { return default; }
	public bool SetComponentTransform(UObject InSceneComponent,FTransform InWorldTransform,bool ReturnValue) { return default; }
}
