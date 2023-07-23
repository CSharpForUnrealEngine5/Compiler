#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMGraph.h")]
///<summary>The Graph represents a Function definition</summary>
public partial class URigVMGraph : UObject {
// RigVMGraph
	public TArray<UObject> GetNodes(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetLinks(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetContainedGraphs(bool bRecursive=false,TArray<UObject> ReturnValue) { return default; }
	public UObject GetParentGraph(UObject ReturnValue) { return default; }
	public UObject GetRootGraph(UObject ReturnValue) { return default; }
	public bool IsRootGraph(bool ReturnValue) { return default; }
	public UObject GetEntryNode(UObject ReturnValue) { return default; }
	public UObject GetReturnNode(UObject ReturnValue) { return default; }
	public TArray<FRigVMGraphVariableDescription> GetVariableDescriptions(TArray<FRigVMGraphVariableDescription> ReturnValue) { return default; }
	public sbyte GetNodePath(sbyte ReturnValue) { return default; }
	public sbyte GetGraphName(sbyte ReturnValue) { return default; }
	public UObject FindNodeByName(sbyte InNodeName,UObject ReturnValue) { return default; }
	public UObject FindNode(sbyte InNodePath,UObject ReturnValue) { return default; }
	public UObject FindPin(sbyte InPinPath,UObject ReturnValue) { return default; }
	public UObject FindLink(sbyte InLinkPinPathRepresentation,UObject ReturnValue) { return default; }
	public bool IsNodeSelected(sbyte InNodeName,bool ReturnValue) { return default; }
	public TArray<sbyte> GetSelectNodes(TArray<sbyte> ReturnValue) { return default; }
	public bool IsTopLevelGraph(bool ReturnValue) { return default; }
	public UObject GetDefaultFunctionLibrary(UObject ReturnValue) { return default; }
	public void SetDefaultFunctionLibrary(UObject InFunctionLibrary) {}
	public TArray<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments=false,TArray<FRigVMGraphVariableDescription> ReturnValue) { return default; }
	public TArray<FRigVMGraphVariableDescription> GetInputArguments(TArray<FRigVMGraphVariableDescription> ReturnValue) { return default; }
	public TArray<FRigVMGraphVariableDescription> GetOutputArguments(TArray<FRigVMGraphVariableDescription> ReturnValue) { return default; }
	public TArray<URigVMNode> Nodes;
	public TArray<URigVMLink> Links;
	public TArray<sbyte> SelectedNodes;
	public TWeakObjectPtr<URigVMGraph> DefaultFunctionLibraryPtr;
	public UScriptStruct ExecuteContextStruct;
	public bool bEditable;
	public TArray<FRigVMGraphVariableDescription> LocalVariables;
}
