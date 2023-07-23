#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayer.h")]
public partial class UDEPRECATED_DataLayer : UObject {
// DataLayer
	public bool Equals(FActorDataLayer ActorDataLayer,bool ReturnValue) { return default; }
	public sbyte GetDataLayerLabel(sbyte ReturnValue) { return default; }
	public bool IsInitiallyVisible(bool ReturnValue) { return default; }
	public bool IsVisible(bool ReturnValue) { return default; }
	public bool IsEffectiveVisible(bool ReturnValue) { return default; }
	public FColor GetDebugColor(FColor ReturnValue) { return default; }
	public bool IsRuntime(bool ReturnValue) { return default; }
	public EDataLayerRuntimeState GetInitialRuntimeState(EDataLayerRuntimeState ReturnValue) { return default; }
	public bool IsDynamicallyLoaded(bool ReturnValue) { return default; }
	public bool IsInitiallyActive(bool ReturnValue) { return default; }
	public EDataLayerState GetInitialState(EDataLayerState ReturnValue) { return default; }
	public bool bIsInitiallyActive_DEPRECATED;
	public bool bIsVisible;
	public bool bIsInitiallyVisible;
	public bool bIsInitiallyLoadedInEditor;
	public bool bIsLoadedInEditor;
	public bool bIsLoadedInEditorChangedByUserOperation;
	public bool bIsLocked;
	public sbyte DataLayerLabel;
	public bool bIsRuntime;
	public EDataLayerRuntimeState InitialRuntimeState;
	public FColor DebugColor;
	public UDEPRECATED_DataLayer Parent_DEPRECATED;
	public TArray<UDEPRECATED_DataLayer> Children_DEPRECATED;
}
