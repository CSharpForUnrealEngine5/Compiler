#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScriptableInteractiveTool.h")]
///<summary>UScriptableInteractiveTool is an extension of UInteractiveTool that allows the Tool functionality to be</summary>
public partial class UScriptableInteractiveTool : UInteractiveTool {
// ScriptableInteractiveTool
	public sbyte ToolName;
	public sbyte ToolLongName;
	public sbyte ToolCategory;
	public sbyte ToolTooltip;
	public bool bShowToolInEditor;
	public EScriptableToolShutdownType ToolShutdownType;
	public void OnScriptSetup() {}
	public void OnScriptTick(float DeltaTime) {}
	public bool OnScriptCanAccept(bool ReturnValue) { return default; }
	public void OnScriptShutdown(EToolShutdownType ShutdownType) {}
	public void RequestToolShutdown(bool bAccept,bool bShowUserPopupMessage,sbyte UserMessage) {}
	public TWeakObjectPtr<UWorld> TargetWorld;
	public UObject GetToolWorld(UObject ReturnValue) { return default; }
	public void OnScriptRender(UObject RenderAPI) {}
	public void OnScriptDrawHUD(UObject DrawHUDAPI) {}
	public UScriptableTool_RenderAPI RenderHelper;
	public UScriptableTool_HUDAPI DrawHUDHelper;
	public UObject AddPropertySetOfType(UClass PropertySetType,sbyte Identifier,EToolsFrameworkOutcomePins Outcome,UObject ReturnValue) { return default; }
	public void RemovePropertySetByName(sbyte Identifier,EToolsFrameworkOutcomePins Outcome) {}
	public void SetPropertySetVisibleByName(sbyte Identifier,bool bVisible) {}
	public void ForcePropertySetUpdateByName(sbyte Identifier) {}
	public UObject RestorePropertySetSettings(UObject PropertySet,sbyte SaveKey,UObject ReturnValue) { return default; }
	public UObject SavePropertySetSettings(UObject PropertySet,sbyte SaveKey,UObject ReturnValue) { return default; }
	public UObject WatchFloatProperty(UObject PropertySet,sbyte PropertyName,FToolFloatPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchIntProperty(UObject PropertySet,sbyte PropertyName,FToolIntPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchBoolProperty(UObject PropertySet,sbyte PropertyName,FToolBoolPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchEnumProperty(UObject PropertySet,sbyte PropertyName,FToolEnumPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchStringProperty(UObject PropertySet,sbyte PropertyName,FToolStringPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchNameProperty(UObject PropertySet,sbyte PropertyName,FToolFNamePropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchObjectProperty(UObject PropertySet,sbyte PropertyName,FToolObjectPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public UObject WatchProperty(UObject PropertySet,sbyte PropertyName,FToolPropertyModifiedDelegate OnModified,UObject ReturnValue) { return default; }
	public void CreateTRSGizmo(sbyte Identifier,FTransform InitialTransform,FScriptableToolGizmoOptions GizmoOptions,EToolsFrameworkOutcomePins Outcome) {}
	public void DestroyTRSGizmo(sbyte Identifier,EToolsFrameworkOutcomePins Outcome) {}
	public void SetGizmoVisible(sbyte Identifier,bool bVisible) {}
	public void SetGizmoTransform(sbyte Identifier,FTransform NewTransform,bool bUndoable) {}
	public FTransform GetGizmoTransform(sbyte Identifier,FTransform ReturnValue) { return default; }
	public void OnGizmoTransformChanged(sbyte GizmoIdentifier,FTransform NewTransform) {}
	public TMap<sbyte,UCombinedTransformGizmo> Gizmos;
	public void AddLogMessage(sbyte Message,bool bHighlighted=false) {}
	public void DisplayUserHelpMessage(sbyte Message) {}
	public void DisplayUserWarningMessage(sbyte Message) {}
	public void ClearUserMessages(bool bHelpMessage=true,bool bWarningMessage=true) {}
}
