#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRig.h")]
///<summary>Runs logic for mapping input data to transforms (the "Rig")</summary>
public partial class UControlRig : URigVMHost {
// ControlRig
	public void FOnControlSelectedBP(UObject Rig,FRigControlElement Control,bool bSelected) {}
	public TArray<UObject> FindControlRigs(UObject Outer,UClass OptionalClass) { return default; }
	public UObject CreateTransformableControlHandle(UObject Outer,string ControlName) { return default; }
	public UObject GetHostingActor() { return default; }
	public UObject GetHierarchy() { return default; }
	public ERigExecutionType ExecutionType;
	public FRigHierarchySettings HierarchySettings;
	public void RequestConstruction() {}
	public void SelectControl(string InControlName,bool bSelect/*=true*/) {}
	public bool ClearControlSelection() { return default; }
	public TArray<string> CurrentControlSelection() { return default; }
	public bool IsControlSelected(string InControlName) { return default; }
	public TMap<FRigElementKey,FRigControlElementCustomization> ControlCustomizations;
	public URigHierarchy DynamicHierarchy;
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	public TMap<string,FCachedPropertyPath> InputProperties_DEPRECATED;
	public TMap<string,FCachedPropertyPath> OutputProperties_DEPRECATED;
	public UAnimationDataSourceRegistry DataSourceRegistry;
	public FRigInfluenceMapPerEvent Influences;
	public UControlRig InteractionRig;
	public UClass InteractionRigClass;
	public UObject GetInteractionRig() { return default; }
	public void SetInteractionRig(UObject InInteractionRig) {}
	public UClass GetInteractionRigClass() { return default; }
	public void SetInteractionRigClass(UClass InInteractionRigClass) {}
	public FOnControlSelectedBP OnControlSelected_BP;
	public bool bControlsVisible;
}
