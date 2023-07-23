#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to collapse a selection of nodes</summary>
public partial struct FRigVMCollapseNodesAction {
// RigVMCollapseNodesAction
	public sbyte LibraryNodePath;
	public sbyte CollapsedNodesContent;
	public TArray<sbyte> CollapsedNodesPaths;
	public TArray<sbyte> CollapsedNodesLinks;
	public bool bIsAggregate;
}
