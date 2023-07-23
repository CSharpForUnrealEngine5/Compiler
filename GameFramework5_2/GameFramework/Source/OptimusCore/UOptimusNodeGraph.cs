#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeGraph.h")]
public partial class UOptimusNodeGraph : UObject {
// OptimusNodeGraph
	public EOptimusNodeGraphType GetGraphType(EOptimusNodeGraphType ReturnValue) { return default; }
	public bool IsExecutionGraph(bool ReturnValue) { return default; }
	public bool IsFunctionGraph(bool ReturnValue) { return default; }
	public int GetGraphIndex(int ReturnValue) { return default; }
	public UObject AddNode(UClass InNodeClass,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddValueNode(FOptimusDataTypeRef InDataTypeRef,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddDataInterfaceNode(UClass InDataInterfaceClass,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddResourceNode(UObject InResourceDesc,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddResourceGetNode(UObject InResourceDesc,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddResourceSetNode(UObject InResourceDesc,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddVariableGetNode(UObject InVariableDesc,FVector2D InPosition,UObject ReturnValue) { return default; }
	public UObject AddComponentBindingGetNode(UObject InComponentBinding,FVector2D InPosition,UObject ReturnValue) { return default; }
	public bool RemoveNode(UObject InNode,bool ReturnValue) { return default; }
	public bool RemoveNodes(TArray<UObject> InNodes,bool ReturnValue) { return default; }
	public UObject DuplicateNode(UObject InNode,FVector2D InPosition,UObject ReturnValue) { return default; }
	public bool DuplicateNodes(TArray<UObject> InNodes,FVector2D InPosition,bool ReturnValue) { return default; }
	public bool AddLink(UObject InNodeOutputPin,UObject InNodeInputPin,bool ReturnValue) { return default; }
	public bool RemoveLink(UObject InNodeOutputPin,UObject InNodeInputPin,bool ReturnValue) { return default; }
	public bool RemoveAllLinks(UObject InNodePin,bool ReturnValue) { return default; }
	public UObject ConvertCustomKernelToFunction(UObject InCustomKernel,UObject ReturnValue) { return default; }
	public UObject ConvertFunctionToCustomKernel(UObject InKernelFunction,UObject ReturnValue) { return default; }
	public UObject CollapseNodesToFunction(TArray<UObject> InNodes,UObject ReturnValue) { return default; }
	public UObject CollapseNodesToSubGraph(TArray<UObject> InNodes,UObject ReturnValue) { return default; }
	public TArray<UObject> ExpandCollapsedNodes(UObject InFunctionNode,TArray<UObject> ReturnValue) { return default; }
	public bool IsCustomKernel(UObject InNode,bool ReturnValue) { return default; }
	public bool IsKernelFunction(UObject InNode,bool ReturnValue) { return default; }
	public bool IsFunctionReference(UObject InNode,bool ReturnValue) { return default; }
	public bool IsSubGraphReference(UObject InNode,bool ReturnValue) { return default; }
	public TArray<UObject> GetGraphs(TArray<UObject> ReturnValue) { return default; }
	public bool MoveGraph(UObject InGraph,int InInsertBefore,bool ReturnValue) { return default; }
	public bool RenameGraph(UObject InGraph,sbyte InNewName,bool ReturnValue) { return default; }
	public EOptimusNodeGraphType GraphType;
	public TArray<UOptimusNode> Nodes;
	public TArray<UOptimusNodeLink> Links;
	public TArray<UOptimusNodeGraph> SubGraphs;
}
