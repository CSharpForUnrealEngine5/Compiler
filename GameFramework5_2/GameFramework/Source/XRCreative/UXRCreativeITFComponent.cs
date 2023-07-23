#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeITFComponent.h")]
public partial class UXRCreativeITFComponent : UActorComponent {
// XRCreativeITFComponent
	public bool CanUndo(bool ReturnValue) { return default; }
	public bool CanRedo(bool ReturnValue) { return default; }
	public void Undo() {}
	public void Redo() {}
	public void LeftMousePressed() {}
	public void LeftMouseReleased() {}
	public UObject GetSelectionSet(UObject ReturnValue) { return default; }
	public bool HaveActiveTool(bool ReturnValue) { return default; }
	public EToolContextCoordinateSystem GetCurrentCoordinateSystem(EToolContextCoordinateSystem ReturnValue) { return default; }
	public void SetCurrentCoordinateSystem(EToolContextCoordinateSystem CoordSystem) {}
	public UClass FullTRSGizmoActorClass;
	public UXRCreativePointerComponent PointerComponent;
	public UInteractiveToolsContext ToolsContext;
	public UTypedElementSelectionSet SelectionSet;
	public UXRCreativeSelectionInteraction SelectionInteraction;
	public UXRCreativeTransformInteraction TransformInteraction;
	public UXRCreativeITFRenderComponent PDIRenderComponent;
	public EToolContextCoordinateSystem CurrentCoordinateSystem;
}
