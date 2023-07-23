#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorUtilitySubsystem.h")]
public partial class UEditorUtilitySubsystem : UEditorSubsystem {
// EditorUtilitySubsystem
	public TArray<FSoftObjectPath> LoadedUIs;
	public TArray<FSoftObjectPath> StartupObjects;
	public void ReleaseInstanceOfAsset(UObject Asset) {}
	public bool TryRun(UObject Asset,bool ReturnValue) { return default; }
	public bool CanRun(UObject Asset,bool ReturnValue) { return default; }
	public UObject SpawnAndRegisterTabAndGetID(UObject InBlueprint,sbyte NewTabID,UObject ReturnValue) { return default; }
	public UObject SpawnAndRegisterTab(UObject InBlueprint,UObject ReturnValue) { return default; }
	public UObject SpawnAndRegisterTabWithId(UObject InBlueprint,sbyte InTabID,UObject ReturnValue) { return default; }
	public void RegisterTabAndGetID(UObject InBlueprint,sbyte NewTabID) {}
	public bool SpawnRegisteredTabByID(sbyte NewTabID,bool ReturnValue) { return default; }
	public bool DoesTabExist(sbyte NewTabID,bool ReturnValue) { return default; }
	public bool CloseTabByID(sbyte NewTabID,bool ReturnValue) { return default; }
	public bool UnregisterTabByID(sbyte TabID,bool ReturnValue) { return default; }
	public UObject FindUtilityWidgetFromBlueprint(UObject InBlueprint,UObject ReturnValue) { return default; }
	public void RegisterAndExecuteTask(UObject NewTask,UObject OptionalParentTask=nullptr) {}
	public FOnEditorUtilityPIEEvent OnBeginPIE;
	public FOnEditorUtilityPIEEvent OnEndPIE;
	public TMap<UObject,UObject> ObjectInstances;
	public TArray<UEditorUtilityTask> ActiveTaskStack;
	public TSet<UObject> ReferencedObjects;
}
