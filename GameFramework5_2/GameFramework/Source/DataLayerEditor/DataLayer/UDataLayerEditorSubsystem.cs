#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataLayer/DataLayerEditorSubsystem.h")]
public partial class UDataLayerEditorSubsystem : UEditorSubsystem {
// DataLayerEditorSubsystem
	public bool IsActorValidForDataLayer(UObject Actor,bool ReturnValue) { return default; }
	public bool AddActorToDataLayer(UObject Actor,UObject DataLayer,bool ReturnValue) { return default; }
	public bool AddActorToDataLayers(UObject Actor,TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool RemoveActorFromDataLayer(UObject Actor,UObject DataLayerToRemove,bool ReturnValue) { return default; }
	public bool RemoveActorFromDataLayers(UObject Actor,TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool RemoveActorFromAllDataLayers(UObject Actor,bool ReturnValue) { return default; }
	public bool RemoveActorsFromAllDataLayers(TArray<UObject> Actors,bool ReturnValue) { return default; }
	public bool AddActorsToDataLayer(TArray<UObject> Actors,UObject DataLayer,bool ReturnValue) { return default; }
	public bool AddActorsToDataLayers(TArray<UObject> Actors,TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool RemoveActorsFromDataLayer(TArray<UObject> Actors,UObject DataLayer,bool ReturnValue) { return default; }
	public bool RemoveActorsFromDataLayers(TArray<UObject> Actors,TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool AddSelectedActorsToDataLayer(UObject DataLayer,bool ReturnValue) { return default; }
	public bool AddSelectedActorsToDataLayers(TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool RemoveSelectedActorsFromDataLayer(UObject DataLayer,bool ReturnValue) { return default; }
	public bool RemoveSelectedActorsFromDataLayers(TArray<UObject> DataLayers,bool ReturnValue) { return default; }
	public bool SelectActorsInDataLayer(UObject DataLayer,bool bSelect,bool bNotify,bool bSelectEvenIfHidden=false,bool ReturnValue) { return default; }
	public bool SelectActorsInDataLayers(TArray<UObject> DataLayers,bool bSelect,bool bNotify,bool bSelectEvenIfHidden=false,bool ReturnValue) { return default; }
	public bool UpdateActorVisibility(UObject Actor,bool bOutSelectionChanged,bool bOutActorModified,bool bNotifySelectionChange,bool bRedrawViewports,bool ReturnValue) { return default; }
	public bool UpdateAllActorsVisibility(bool bNotifySelectionChange,bool bRedrawViewports,bool ReturnValue) { return default; }
	public void AppendActorsFromDataLayer(UObject DataLayer,TArray<UObject> InOutActors) {}
	public void AppendActorsFromDataLayers(TArray<UObject> DataLayers,TArray<UObject> InOutActors) {}
	public TArray<UObject> GetActorsFromDataLayer(UObject DataLayer,TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetActorsFromDataLayers(TArray<UObject> DataLayers,TArray<UObject> ReturnValue) { return default; }
	public void SetDataLayerVisibility(UObject DataLayer,bool bIsVisible) {}
	public void SetDataLayersVisibility(TArray<UObject> DataLayers,bool bIsVisible) {}
	public void ToggleDataLayerVisibility(UObject DataLayer) {}
	public void ToggleDataLayersVisibility(TArray<UObject> DataLayers) {}
	public bool SetDataLayerIsLoadedInEditor(UObject DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool SetDataLayersIsLoadedInEditor(TArray<UObject> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool ToggleDataLayerIsLoadedInEditor(UObject DataLayer,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool ToggleDataLayersIsLoadedInEditor(TArray<UObject> DataLayers,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public void MakeAllDataLayersVisible() {}
	public UObject GetDataLayerInstance(UObject DataLayerAsset,UObject ReturnValue) { return default; }
	public TArray<UObject> GetDataLayerInstances(TArray<UObject> DataLayerAssets,TArray<UObject> ReturnValue) { return default; }
	public UObject CreateDataLayerInstance(FDataLayerCreationParameters Parameters,UObject ReturnValue) { return default; }
	public bool SetParentDataLayer(UObject DataLayer,UObject ParentDataLayer,bool ReturnValue) { return default; }
	public void DeleteDataLayers(TArray<UObject> DataLayersToDelete) {}
	public void DeleteDataLayer(UObject DataLayerToDelete) {}
	public TArray<UObject> GetAllDataLayers(TArray<UObject> ReturnValue) { return default; }
	public void UpdateAllViewVisibility(UObject DataLayerThatChanged) {}
	public void UpdateActorAllViewsVisibility(UObject Actor) {}
	public bool SetDataLayerIsDynamicallyLoadedInEditor(UObject DataLayer,bool bIsLoadedInEditor,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool SetDataLayersIsDynamicallyLoadedInEditor(TArray<UObject> DataLayers,bool bIsLoadedInEditor,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool ToggleDataLayerIsDynamicallyLoadedInEditor(UObject DataLayer,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public bool ToggleDataLayersIsDynamicallyLoadedInEditor(TArray<UObject> DataLayers,bool bIsFromUserChange,bool ReturnValue) { return default; }
	public UObject GetDataLayer(FActorDataLayer ActorDataLayer,UObject ReturnValue) { return default; }
	public UObject GetDataLayerFromLabel(sbyte DataLayerLabel,UObject ReturnValue) { return default; }
	public bool RenameDataLayer(UObject DataLayer,sbyte NewDataLayerLabel,bool ReturnValue) { return default; }
	public UObject CreateDataLayer(UObject ParentDataLayer=nullptr,UObject ReturnValue) { return default; }
}
