#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprintEditorLibrary.h")]
public partial class UControlRigBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// ControlRigBlueprintEditorLibrary
	public void CastToControlRigBlueprint(UObject Object,ECastToControlRigBlueprintCases Branches,UObject AsControlRigBlueprint) {}
	public void SetPreviewMesh(UObject InRigBlueprint,UObject PreviewMesh,bool bMarkAsDirty=true) {}
	public UObject GetPreviewMesh(UObject InRigBlueprint,UObject ReturnValue) { return default; }
	public void RecompileVM(UObject InRigBlueprint) {}
	public void RecompileVMIfRequired(UObject InRigBlueprint) {}
	public void RequestAutoVMRecompilation(UObject InRigBlueprint) {}
	public void RequestControlRigInit(UObject InRigBlueprint) {}
	public UObject GetModel(UObject InRigBlueprint,UObject ReturnValue) { return default; }
	public UObject GetController(UObject InRigBlueprint,UObject ReturnValue) { return default; }
	public TArray<UObject> GetCurrentlyOpenRigBlueprints(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAvailableRigUnits(TArray<UObject> ReturnValue) { return default; }
	public UObject GetHierarchy(UObject InRigBlueprint,UObject ReturnValue) { return default; }
	public UObject GetHierarchyController(UObject InRigBlueprint,UObject ReturnValue) { return default; }
}
