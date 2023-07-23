#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Layers/LayersSubsystem.h")]
public partial class ULayersSubsystem : UEditorSubsystem {
// LayersSubsystem
	public void AddLevelLayerInformation(UObject Level) {}
	public void RemoveLevelLayerInformation(UObject Level) {}
	public bool IsActorValidForLayer(UObject Actor,bool ReturnValue) { return default; }
	public bool InitializeNewActorLayers(UObject Actor,bool ReturnValue) { return default; }
	public bool DisassociateActorFromLayers(UObject Actor,bool ReturnValue) { return default; }
	public bool AddActorToLayer(UObject Actor,sbyte LayerName,bool ReturnValue) { return default; }
	public bool AddActorToLayers(UObject Actor,TArray<sbyte> LayerNames,bool ReturnValue) { return default; }
	public bool RemoveActorFromLayer(UObject Actor,sbyte LayerToRemove,bool bUpdateStats=true,bool ReturnValue) { return default; }
	public bool RemoveActorFromLayers(UObject Actor,TArray<sbyte> LayerNames,bool bUpdateStats=true,bool ReturnValue) { return default; }
	public bool AddActorsToLayer(TArray<UObject> Actors,sbyte LayerName,bool ReturnValue) { return default; }
	public bool AddActorsToLayers(TArray<UObject> Actors,TArray<sbyte> LayerNames,bool ReturnValue) { return default; }
	public bool DisassociateActorsFromLayers(TArray<UObject> Actors,bool ReturnValue) { return default; }
	public bool RemoveActorsFromLayer(TArray<UObject> Actors,sbyte LayerName,bool bUpdateStats=true,bool ReturnValue) { return default; }
	public bool RemoveActorsFromLayers(TArray<UObject> Actors,TArray<sbyte> LayerNames,bool bUpdateStats=true,bool ReturnValue) { return default; }
	public TArray<UObject> GetSelectedActors(TArray<UObject> ReturnValue) { return default; }
	public bool AddSelectedActorsToLayer(sbyte LayerName,bool ReturnValue) { return default; }
	public bool AddSelectedActorsToLayers(TArray<sbyte> LayerNames,bool ReturnValue) { return default; }
	public bool RemoveSelectedActorsFromLayer(sbyte LayerName,bool ReturnValue) { return default; }
	public bool RemoveSelectedActorsFromLayers(TArray<sbyte> LayerNames,bool ReturnValue) { return default; }
	public bool SelectActorsInLayer(sbyte LayerName,bool bSelect,bool bNotify,bool bSelectEvenIfHidden=false,bool ReturnValue) { return default; }
	public bool SelectActorsInLayers(TArray<sbyte> LayerNames,bool bSelect,bool bNotify,bool bSelectEvenIfHidden=false,bool ReturnValue) { return default; }
	public void UpdateAllViewVisibility(sbyte LayerThatChanged) {}
	public void UpdateActorAllViewsVisibility(UObject Actor) {}
	public bool UpdateActorVisibility(UObject Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports,bool ReturnValue) { return default; }
	public bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports,bool ReturnValue) { return default; }
	public void AppendActorsFromLayer(sbyte LayerName,TArray<UObject> InOutActors) {}
	public void AppendActorsFromLayers(TArray<sbyte> LayerNames,TArray<UObject> InOutActors) {}
	public TArray<UObject> GetActorsFromLayer(sbyte LayerName,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetActorsFromLayers(TArray<sbyte> LayerNames,TArray<UObject> ReturnValue) { return default; }
	public void SetLayerVisibility(sbyte LayerName,bool bIsVisible) {}
	public void SetLayersVisibility(TArray<sbyte> LayerNames,bool bIsVisible) {}
	public void ToggleLayerVisibility(sbyte LayerName) {}
	public void ToggleLayersVisibility(TArray<sbyte> LayerNames) {}
	public void MakeAllLayersVisible() {}
	public UObject GetLayer(sbyte LayerName,UObject ReturnValue) { return default; }
	public bool IsLayer(sbyte LayerName,bool ReturnValue) { return default; }
	public bool TryGetLayer(sbyte LayerName,UObject OutLayer,bool ReturnValue) { return default; }
	public void AddAllLayerNamesTo(TArray<sbyte> OutLayerNames) {}
	public void AddAllLayersTo(TArray<UObject> OutLayers) {}
	public UObject CreateLayer(sbyte LayerName,UObject ReturnValue) { return default; }
	public void DeleteLayers(TArray<sbyte> LayersToDelete) {}
	public void DeleteLayer(sbyte LayerToDelete) {}
	public bool RenameLayer(sbyte OriginalLayerName,sbyte NewLayerName,bool ReturnValue) { return default; }
	public UObject GetWorld(UObject ReturnValue) { return default; }
	public void EditorMapChange() {}
	public void EditorRefreshLayerBrowser() {}
}
