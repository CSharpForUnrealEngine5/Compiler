#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlueprintEditorLibrary.h")]
public partial class UBlueprintEditorLibrary : UBlueprintFunctionLibrary {
// BlueprintEditorLibrary
	public void ReplaceVariableReferences(UObject Blueprint,sbyte OldVarName,sbyte NewVarName) {}
	public UObject FindEventGraph(UObject Blueprint,UObject ReturnValue) { return default; }
	public UObject FindGraph(UObject Blueprint,sbyte GraphName,UObject ReturnValue) { return default; }
	public void UpgradeOperatorNodes(UObject Blueprint) {}
	public void CompileBlueprint(UObject Blueprint) {}
	public UObject AddFunctionGraph(UObject Blueprint,sbyte FuncName=FString,UObject ReturnValue) { return default; }
	public void RemoveFunctionGraph(UObject Blueprint,sbyte FuncName) {}
	public void RemoveUnusedNodes(UObject Blueprint) {}
	public void RemoveGraph(UObject Blueprint,UObject Graph) {}
	public void RenameGraph(UObject Graph,sbyte NewNameStr=FString) {}
	public UObject GetBlueprintAsset(UObject Object,UObject ReturnValue) { return default; }
	public void RefreshOpenEditorsForBlueprint(UObject BP) {}
	public void RefreshAllOpenBlueprintEditors() {}
	public void ReparentBlueprint(UObject Blueprint,UClass NewParentClass) {}
	public int RemoveUnusedVariables(UObject Blueprint,int ReturnValue) { return default; }
	public UClass GeneratedClass(UObject BlueprintObj,UClass ReturnValue) { return default; }
	public void SetBlueprintVariableExposeOnSpawn(UObject Blueprint,sbyte VariableName,bool bExposeOnSpawn) {}
	public void SetBlueprintVariableExposeToCinematics(UObject Blueprint,sbyte VariableName,bool bExposeToCinematics) {}
	public void SetBlueprintVariableInstanceEditable(UObject Blueprint,sbyte VariableName,bool bInstanceEditable) {}
}
