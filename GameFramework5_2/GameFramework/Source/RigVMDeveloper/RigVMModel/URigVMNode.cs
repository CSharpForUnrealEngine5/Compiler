#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMNode.h")]
///<summary>The Node represents a single statement within a Graph.</summary>
public partial class URigVMNode : UObject {
// RigVMNode
	public sbyte GetNodePath(bool bRecursive=false,sbyte ReturnValue) { return default; }
	public int GetNodeIndex(int ReturnValue) { return default; }
	public TArray<UObject> GetPins(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAllPinsRecursively(TArray<UObject> ReturnValue) { return default; }
	public UObject FindPin(sbyte InPinPath,UObject ReturnValue) { return default; }
	public TArray<UObject> GetOrphanedPins(TArray<UObject> ReturnValue) { return default; }
	public bool HasOrphanedPins(bool ReturnValue) { return default; }
	public UObject GetGraph(UObject ReturnValue) { return default; }
	public UObject GetRootGraph(UObject ReturnValue) { return default; }
	public UObject GetInjectionInfo(UObject ReturnValue) { return default; }
	public sbyte GetNodeTitle(sbyte ReturnValue) { return default; }
	public FVector2D GetPosition(FVector2D ReturnValue) { return default; }
	public FVector2D GetSize(FVector2D ReturnValue) { return default; }
	public FLinearColor GetNodeColor(FLinearColor ReturnValue) { return default; }
	public sbyte GetToolTipText(sbyte ReturnValue) { return default; }
	public bool IsSelected(bool ReturnValue) { return default; }
	public bool IsInjected(bool ReturnValue) { return default; }
	public bool IsVisibleInUI(bool ReturnValue) { return default; }
	public bool IsPure(bool ReturnValue) { return default; }
	public bool IsDefinedAsConstant(bool ReturnValue) { return default; }
	public bool IsDefinedAsVarying(bool ReturnValue) { return default; }
	public bool IsMutable(bool ReturnValue) { return default; }
	public bool IsEvent(bool ReturnValue) { return default; }
	public sbyte GetEventName(sbyte ReturnValue) { return default; }
	public bool CanOnlyExistOnce(bool ReturnValue) { return default; }
	public bool HasInputPin(bool bIncludeIO=true,bool ReturnValue) { return default; }
	public bool HasIOPin(bool ReturnValue) { return default; }
	public bool HasLazyPin(bool bOnlyConsiderPinsWithLinks=false,bool ReturnValue) { return default; }
	public bool HasOutputPin(bool bIncludeIO=true,bool ReturnValue) { return default; }
	public bool HasPinOfDirection(ERigVMPinDirection InDirection,bool ReturnValue) { return default; }
	public bool IsLinkedTo(UObject InNode,bool ReturnValue) { return default; }
	public TArray<UObject> GetLinks(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetLinkedSourceNodes(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetLinkedTargetNodes(TArray<UObject> ReturnValue) { return default; }
	public sbyte GetPreviousFName(sbyte ReturnValue) { return default; }
	public bool IsLoopNode(bool ReturnValue) { return default; }
	public bool IsControlFlowNode(bool ReturnValue) { return default; }
	public bool CanBeUpgraded(bool ReturnValue) { return default; }
	public TArray<FRigVMUserWorkflow> GetSupportedWorkflows(ERigVMUserWorkflowType InType,UObject InSubject,TArray<FRigVMUserWorkflow> ReturnValue) { return default; }
	public bool HasBreakpoint(bool ReturnValue) { return default; }
	public void SetHasBreakpoint(bool bValue) {}
	public bool ExecutionIsHaltedAtThisNode(bool ReturnValue) { return default; }
	public void SetExecutionIsHaltedAtThisNode(bool bValue) {}
	public bool IsAggregate(bool ReturnValue) { return default; }
	public UObject GetFirstAggregatePin(UObject ReturnValue) { return default; }
	public UObject GetSecondAggregatePin(UObject ReturnValue) { return default; }
	public UObject GetOppositeAggregatePin(UObject ReturnValue) { return default; }
	public bool IsInputAggregate(bool ReturnValue) { return default; }
	public TArray<UObject> GetAggregateInputs(TArray<UObject> ReturnValue) { return default; }
	public TArray<UObject> GetAggregateOutputs(TArray<UObject> ReturnValue) { return default; }
	public sbyte GetNextAggregateName(sbyte InLastAggregatePinName,sbyte ReturnValue) { return default; }
	public UObject FindFunctionForNode(UObject ReturnValue) { return default; }
	public sbyte NodeTitle;
	public FVector2D Position;
	public FVector2D Size;
	public FLinearColor NodeColor;
	public sbyte PreviousName;
	public bool bHasBreakpoint;
	public bool bHaltedAtThisNode;
	public TArray<URigVMPin> Pins;
	public TArray<URigVMPin> OrphanedPins;
}
