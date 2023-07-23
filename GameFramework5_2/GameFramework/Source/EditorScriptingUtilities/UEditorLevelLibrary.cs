#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorLevelLibrary.h")]
///<summary>Utility class to do most of the common functionalities in the World Editor.</summary>
public partial class UEditorLevelLibrary : UBlueprintFunctionLibrary {
// EditorLevelLibrary
	public TArray<UObject> GetAllLevelActors(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllLevelActorsComponents(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetSelectedLevelActors(TArray<UObject> ReturnValue) { return default; }
	public void SetSelectedLevelActors(TArray<UObject> ActorsToSelect) {}
	public void PilotLevelActor(UObject ActorToPilot) {}
	public void EjectPilotLevelActor() {}
	public void EditorPlaySimulate() {}
	public void EditorEndPlay() {}
	public void EditorInvalidateViewports() {}
	public void ReplaceSelectedActors(sbyte InAssetPath) {}
	public bool GetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation,bool ReturnValue) { return default; }
	public void SetLevelViewportCameraInfo(FVector CameraLocation,FRotator CameraRotation) {}
	public void ClearActorSelectionSet() {}
	public void SelectNothing() {}
	public void SetActorSelectionState(UObject Actor,bool bShouldBeSelected) {}
	public UObject GetActorReference(sbyte PathToActor,UObject ReturnValue) { return default; }
	public void EditorSetGameView(bool bGameView) {}
	public UObject SpawnActorFromObject(UObject ObjectToUse,FVector Location,FRotator Rotation=FRotator,bool bTransient=false,UObject ReturnValue) { return default; }
	public UObject SpawnActorFromClass(UClass ActorClass,FVector Location,FRotator Rotation=FRotator,bool bTransient=false,UObject ReturnValue) { return default; }
	public bool DestroyActor(UObject ActorToDestroy,bool ReturnValue) { return default; }
	public UObject GetEditorWorld(UObject ReturnValue) { return default; }
	public UObject GetGameWorld(UObject ReturnValue) { return default; }
	public TArray<UObject> GetPIEWorlds(bool bIncludeDedicatedServer,TArray<UObject> ReturnValue) { return default; }
	public bool NewLevel(sbyte AssetPath,bool ReturnValue) { return default; }
	public bool NewLevelFromTemplate(sbyte AssetPath,sbyte TemplateAssetPath,bool ReturnValue) { return default; }
	public bool LoadLevel(sbyte AssetPath,bool ReturnValue) { return default; }
	public bool SaveCurrentLevel(bool ReturnValue) { return default; }
	public bool SaveAllDirtyLevels(bool ReturnValue) { return default; }
	public bool SetCurrentLevelByName(sbyte LevelName,bool ReturnValue) { return default; }
	public void ReplaceMeshComponentsMaterials(TArray<UObject> MeshComponents,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMaterialsOnActors(TArray<UObject> Actors,UObject MaterialToBeReplaced,UObject NewMaterial) {}
	public void ReplaceMeshComponentsMeshes(TArray<UObject> MeshComponents,UObject MeshToBeReplaced,UObject NewMesh) {}
	public void ReplaceMeshComponentsMeshesOnActors(TArray<UObject> Actors,UObject MeshToBeReplaced,UObject NewMesh) {}
	public TArray<UObject> ConvertActors(TArray<UObject> Actors,UClass ActorClass,sbyte StaticMeshPackagePath,TArray<UObject> ReturnValue) { return default; }
	public UObject JoinStaticMeshActors(TArray<UObject> ActorsToJoin,FJoinStaticMeshActorsOptions JoinOptions,UObject ReturnValue) { return default; }
	public bool MergeStaticMeshActors(TArray<UObject> ActorsToMerge,FMergeStaticMeshActorsOptions MergeOptions,UObject OutMergedActor,bool ReturnValue) { return default; }
	public bool CreateProxyMeshActor(TArray<UObject> ActorsToMerge,FCreateProxyMeshActorOptions MergeOptions,UObject OutMergedActor,bool ReturnValue) { return default; }
}
