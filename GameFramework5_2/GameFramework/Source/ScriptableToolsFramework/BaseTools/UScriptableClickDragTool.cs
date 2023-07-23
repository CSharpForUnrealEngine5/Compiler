#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseTools/ScriptableClickDragTool.h")]
///<summary>UScriptableClickDragTool is an extension of UScriptableInteractiveTool that supports</summary>
public partial class UScriptableClickDragTool : UScriptableInteractiveTool {
// ScriptableClickDragTool
	public bool bWantMouseHover;
	public bool bUpdateModifiersDuringDrag;
	public FInputRayHit TestIfCanBeginClickDrag(FInputDeviceRay ClickPos,FScriptableToolModifierStates Modifiers,FInputRayHit ReturnValue) { return default; }
	public void OnDragBegin(FInputDeviceRay StartPosition,FScriptableToolModifierStates Modifiers) {}
	public void OnDragUpdatePosition(FInputDeviceRay NewPosition,FScriptableToolModifierStates Modifiers) {}
	public void OnDragEnd(FInputDeviceRay EndPosition,FScriptableToolModifierStates Modifiers) {}
	public void OnDragSequenceCancelled() {}
	public bool InActiveClickDrag(bool ReturnValue) { return default; }
	public FInputRayHit OnHoverHitTest(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers,FInputRayHit ReturnValue) { return default; }
	public void OnHoverBegin(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers) {}
	public bool OnHoverUpdate(FInputDeviceRay HoverPos,FScriptableToolModifierStates Modifiers,bool ReturnValue) { return default; }
	public void OnHoverEnd(FScriptableToolModifierStates Modifiers) {}
	public bool InActiveHover(bool ReturnValue) { return default; }
	public bool IsShiftDown(bool ReturnValue) { return default; }
	public bool IsCtrlDown(bool ReturnValue) { return default; }
	public bool IsAltDown(bool ReturnValue) { return default; }
	public FScriptableToolModifierStates GetActiveModifiers(FScriptableToolModifierStates ReturnValue) { return default; }
	public UClickDragInputBehavior ClickDragBehavior;
	public UMouseHoverBehavior MouseHoverBehavior;
}
