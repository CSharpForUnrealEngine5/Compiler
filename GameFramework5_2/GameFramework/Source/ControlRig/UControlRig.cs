#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRig.h")]
///<summary>Runs logic for mapping input data to transforms (the "Rig")</summary>
public partial class UControlRig : URigVMHost {
// ControlRig
	public void FOnControlSelectedBP(UObject Rig,FRigControlElement Control,bool bSelected) {}
	public TArray<UObject> FindControlRigs(UObject Outer,UClass OptionalClass,TArray<UObject> ReturnValue) { return default; }
	public UObject CreateTransformableControlHandle(UObject Outer,sbyte ControlName,UObject ReturnValue) { return default; }
	public UObject GetHostingActor(UObject ReturnValue) { return default; }
	public UObject GetHierarchy(UObject ReturnValue) { return default; }
	public ERigExecutionType ExecutionType;
	public FRigHierarchySettings HierarchySettings;
	public void RequestConstruction() {}
	public void SelectControl(sbyte InControlName,bool bSelect=true) {}
	public bool ClearControlSelection(bool ReturnValue) { return default; }
	public TArray<sbyte> CurrentControlSelection(TArray<sbyte> ReturnValue) { return default; }
	public bool IsControlSelected(sbyte InControlName,bool ReturnValue) { return default; }
	public TMap<FRigElementKey,FRigControlElementCustomization> ControlCustomizations;
	public URigHierarchy DynamicHierarchy;
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	public TMap<sbyte,FCachedPropertyPath> InputProperties_DEPRECATED;
	public TMap<sbyte,FCachedPropertyPath> OutputProperties_DEPRECATED;
	public UAnimationDataSourceRegistry DataSourceRegistry;
	public FRigInfluenceMapPerEvent Influences;
	public UControlRig InteractionRig;
	public UClass InteractionRigClass;
	public UObject GetInteractionRig(UObject ReturnValue) { return default; }
	public void SetInteractionRig(UObject InInteractionRig) {}
	public UClass GetInteractionRigClass(UClass ReturnValue) { return default; }
	public void SetInteractionRigClass(UClass InInteractionRigClass) {}
	public FOnControlSelectedBP OnControlSelected_BP;
	public bool bControlsVisible;
}
