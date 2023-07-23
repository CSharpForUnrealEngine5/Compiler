#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyController.h")]
public partial class URigHierarchyController : UObject {
// RigHierarchyController
	public UObject GetHierarchy(UObject ReturnValue) { return default; }
	public void SetHierarchy(UObject InHierarchy) {}
	public bool SelectElement(FRigElementKey InKey,bool bSelect=true,bool bClearSelection=false,bool ReturnValue) { return default; }
	public bool DeselectElement(FRigElementKey InKey,bool ReturnValue) { return default; }
	public bool SetSelection(TArray<FRigElementKey> InKeys,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool ClearSelection(bool ReturnValue) { return default; }
	public FRigElementKey AddBone(sbyte InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal=true,ERigBoneType InBoneType=ERigBoneType,bool bSetupUndo=false,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey AddNull(sbyte InName,FRigElementKey InParent,FTransform InTransform,bool bTransformInGlobal=true,bool bSetupUndo=false,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey AddControl_ForBlueprint(sbyte InName,FRigElementKey InParent,FRigControlSettings InSettings,FRigControlValue InValue,bool bSetupUndo=true,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey AddAnimationChannel_ForBlueprint(sbyte InName,FRigElementKey InParentControl,FRigControlSettings InSettings,bool bSetupUndo=true,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey AddCurve(sbyte InName,float InValue=0.f,bool bSetupUndo=true,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigElementKey AddRigidBody(sbyte InName,FRigElementKey InParent,FRigRigidBodySettings InSettings,FTransform InLocalTransform,bool bSetupUndo=false,bool bPrintPythonCommand=false,FRigElementKey ReturnValue) { return default; }
	public FRigControlSettings GetControlSettings(FRigElementKey InKey,FRigControlSettings ReturnValue) { return default; }
	public bool SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo=false,bool ReturnValue) { return default; }
	public TArray<FRigElementKey> ImportBones(UObject InSkeleton,sbyte InNameSpace=NAME_None,bool bReplaceExistingBones=true,bool bRemoveObsoleteBones=true,bool bSelectBones=false,bool bSetupUndo=false,bool bPrintPythonCommand=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> ImportBonesFromAsset(sbyte InAssetPath,sbyte InNameSpace=NAME_None,bool bReplaceExistingBones=true,bool bRemoveObsoleteBones=true,bool bSelectBones=false,bool bSetupUndo=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> ImportCurves(UObject InSkeleton,sbyte InNameSpace=NAME_None,bool bSelectCurves=false,bool bSetupUndo=false,bool bPrintPythonCommand=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> ImportCurvesFromAsset(sbyte InAssetPath,sbyte InNameSpace=NAME_None,bool bSelectCurves=false,bool bSetupUndo=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public sbyte ExportSelectionToText(sbyte ReturnValue) { return default; }
	public sbyte ExportToText(TArray<FRigElementKey> InKeys,sbyte ReturnValue) { return default; }
	public TArray<FRigElementKey> ImportFromText(sbyte InContent,bool bReplaceExistingElements=false,bool bSelectNewElements=true,bool bSetupUndo=false,bool bPrintPythonCommands=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public bool RemoveElement(FRigElementKey InElement,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public FRigElementKey RenameElement(FRigElementKey InElement,sbyte InName,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool bClearSelection=true,FRigElementKey ReturnValue) { return default; }
	public bool ReorderElement(FRigElementKey InElement,int InIndex,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public sbyte SetDisplayName(FRigElementKey InControl,sbyte InDisplayName,bool bRenameElement=false,bool bSetupUndo=false,bool bPrintPythonCommand=false,sbyte ReturnValue) { return default; }
	public bool AddParent(FRigElementKey InChild,FRigElementKey InParent,float InWeight=0.f,bool bMaintainGlobalTransform=true,bool bSetupUndo=false,bool ReturnValue) { return default; }
	public bool RemoveParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform=true,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool RemoveAllParents(FRigElementKey InChild,bool bMaintainGlobalTransform=true,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public bool SetParent(FRigElementKey InChild,FRigElementKey InParent,bool bMaintainGlobalTransform=true,bool bSetupUndo=false,bool bPrintPythonCommand=false,bool ReturnValue) { return default; }
	public TArray<FRigElementKey> DuplicateElements(TArray<FRigElementKey> InKeys,bool bSelectNewElements=true,bool bSetupUndo=false,bool bPrintPythonCommands=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public TArray<FRigElementKey> MirrorElements(TArray<FRigElementKey> InKeys,FRigVMMirrorSettings InSettings,bool bSelectNewElements=true,bool bSetupUndo=false,bool bPrintPythonCommands=false,TArray<FRigElementKey> ReturnValue) { return default; }
	public bool bReportWarningsAndErrors;
	public TArray<sbyte> GeneratePythonCommands(TArray<sbyte> ReturnValue) { return default; }
	public TWeakObjectPtr<URigHierarchy> Hierarchy;
}
