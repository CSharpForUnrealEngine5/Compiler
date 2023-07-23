#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraphNode_CompositeDecorator.h")]
public partial class UBehaviorTreeGraphNode_CompositeDecorator : UBehaviorTreeGraphNode {
// BehaviorTreeGraphNode_CompositeDecorator
	public UEdGraph BoundGraph;
	public sbyte CompositeName;
	public bool bShowOperations;
	public bool bCanAbortFlow;
	public UBTCompositeNode ParentNodeInstance;
	public sbyte CachedDescription;
}
