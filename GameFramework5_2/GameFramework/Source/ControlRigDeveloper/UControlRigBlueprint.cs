#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigBlueprint.h")]
public partial class UControlRigBlueprint : UBlueprint {
// ControlRigBlueprint
	public void SetPreviewMesh(UObject PreviewMesh,bool bMarkAsDirty=true) {}
	public UObject GetPreviewMesh(UObject ReturnValue) { return default; }
	public void RecompileVM() {}
	public void RecompileVMIfRequired() {}
	public void RequestAutoVMRecompilation() {}
	public void SetAutoVMRecompile(bool bAutoRecompile) {}
	public void RequestControlRigInit() {}
	public UObject GetModel(UObject InEdGraph=nullptr,UObject ReturnValue) { return default; }
	public UObject GetDefaultModel(UObject ReturnValue) { return default; }
	public TArray<UObject> GetAllModels(TArray<UObject> ReturnValue) { return default; }
	public UObject GetLocalFunctionLibrary(UObject ReturnValue) { return default; }
	public UObject AddModel(sbyte InName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=true,UObject ReturnValue) { return default; }
	public bool RemoveModel(sbyte InName=TEXT,bool bSetupUndoRedo=true,bool bPrintPythonCommand=true,bool ReturnValue) { return default; }
	public UObject GetController(UObject InGraph=nullptr,UObject ReturnValue) { return default; }
	public UObject GetControllerByName(sbyte InGraphName=TEXT,UObject ReturnValue) { return default; }
	public UObject GetOrCreateController(UObject InGraph=nullptr,UObject ReturnValue) { return default; }
	public TArray<sbyte> GeneratePythonCommands(sbyte InNewBlueprintName,TArray<sbyte> ReturnValue) { return default; }
	public UControlRigGraph FunctionLibraryEdGraph;
	public FRigGraphDisplaySettings RigGraphDisplaySettings;
	public FRigHierarchySettings HierarchySettings;
	public FRigVMRuntimeSettings VMRuntimeSettings;
	public FRigVMCompileSettings VMCompileSettings;
	public FControlRigPythonSettings PythonLogSettings;
	public URigVMGraph Model_DEPRECATED;
	public URigVMFunctionLibrary FunctionLibrary_DEPRECATED;
	public FRigVMClient RigVMClient;
	public TArray<FControlRigPublicFunctionData> PublicFunctions_DEPRECATED;
	public TArray<FRigVMGraphFunctionHeader> PublicGraphFunctions;
	public TArray<FRigVMReferenceNodeData> FunctionReferenceNodeData;
	public URigVMGraph TemplateModel;
	public URigVMController TemplateController;
	public TMap<sbyte,FRigVMOperand> PinToOperandMap;
	public TArray<UObject> GetCurrentlyOpenRigBlueprints(TArray<UObject> ReturnValue) { return default; }
	public UClass GetControlRigClass(UClass ReturnValue) { return default; }
	public UObject CreateControlRig(UObject ReturnValue) { return default; }
	public TArray<UObject> GetAvailableRigUnits(TArray<UObject> ReturnValue) { return default; }
	public TArray<FRigVMGraphVariableDescription> GetMemberVariables(TArray<FRigVMGraphVariableDescription> ReturnValue) { return default; }
	public sbyte AddMemberVariable(sbyte InName,sbyte InCPPType,bool bIsPublic=false,bool bIsReadOnly=false,sbyte InDefaultValue=TEXT,sbyte ReturnValue) { return default; }
	public bool RemoveMemberVariable(sbyte InName,bool ReturnValue) { return default; }
	public bool RenameMemberVariable(sbyte InOldName,sbyte InNewName,bool ReturnValue) { return default; }
	public bool ChangeMemberVariableType(sbyte InName,sbyte InCPPType,bool bIsPublic=false,bool bIsReadOnly=false,sbyte InDefaultValue=TEXT,bool ReturnValue) { return default; }
	public TSoftObjectPtr<UControlRigShapeLibrary> GizmoLibrary_DEPRECATED;
	public TArray<TSoftObjectPtr<UControlRigShapeLibrary>> ShapeLibraries;
	public FRigVMStatistics Statistics_DEPRECATED;
	public FRigVMDrawContainer DrawContainer;
	public FRigInfluenceMapPerEvent Influences;
	public FRigHierarchyContainer HierarchyContainer_DEPRECATED;
	public URigHierarchy Hierarchy;
	public UObject GetHierarchyController(UObject ReturnValue) { return default; }
	public bool bSupportsInversion;
	public bool bSupportsControls;
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public TSoftObjectPtr<UObject> SourceHierarchyImport;
	public TSoftObjectPtr<UObject> SourceCurveImport;
	public TArray<sbyte> SupportedEventNames;
	public bool bExposesAnimatableControls;
	public bool bAutoRecompileVM;
	public bool bVMRecompilationRequired;
	public bool bIsCompiling;
	public int VMRecompilationBracket;
	public void SuspendNotifications(bool bSuspendNotifs) {}
	public UControlRigValidator Validator;
	public float DebugBoneRadius;
}
