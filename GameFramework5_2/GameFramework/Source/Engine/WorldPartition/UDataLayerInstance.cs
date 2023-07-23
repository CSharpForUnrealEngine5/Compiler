#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/DataLayer/DataLayerInstance.h")]
public partial class UDataLayerInstance : UObject {
// DataLayerInstance
	public EDataLayerType GetType(EDataLayerType ReturnValue) { return default; }
	public bool IsInitiallyVisible(bool ReturnValue) { return default; }
	public bool IsVisible(bool ReturnValue) { return default; }
	public bool IsEffectiveVisible(bool ReturnValue) { return default; }
	public bool IsRuntime(bool ReturnValue) { return default; }
	public FColor GetDebugColor(FColor ReturnValue) { return default; }
	public EDataLayerRuntimeState GetInitialRuntimeState(EDataLayerRuntimeState ReturnValue) { return default; }
	public bool bIsVisible;
	public bool bIsInitiallyVisible;
	public bool bIsInitiallyLoadedInEditor;
	public bool bIsLoadedInEditor;
	public bool bIsLoadedInEditorChangedByUserOperation;
	public bool bIsLocked;
	public EDataLayerRuntimeState InitialRuntimeState;
	public UDataLayerInstance Parent;
	public TArray<UDataLayerInstance> Children;
}
