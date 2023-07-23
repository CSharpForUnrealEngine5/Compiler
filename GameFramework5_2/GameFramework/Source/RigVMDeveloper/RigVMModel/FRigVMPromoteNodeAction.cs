#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to promote a function to collapse node or vice versa</summary>
public partial struct FRigVMPromoteNodeAction {
// RigVMPromoteNodeAction
	public sbyte LibraryNodePath;
	public sbyte FunctionDefinitionPath;
	public bool bFromFunctionToCollapseNode;
}
