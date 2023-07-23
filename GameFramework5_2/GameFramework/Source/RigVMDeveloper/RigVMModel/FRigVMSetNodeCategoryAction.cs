#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a node's category in the graph.</summary>
public partial struct FRigVMSetNodeCategoryAction {
// RigVMSetNodeCategoryAction
	public sbyte NodePath;
	public sbyte OldCategory;
	public sbyte NewCategory;
}
