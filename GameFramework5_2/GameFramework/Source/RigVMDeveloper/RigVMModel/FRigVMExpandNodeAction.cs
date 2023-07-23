#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action to expand a library node into its content</summary>
public partial struct FRigVMExpandNodeAction {
// RigVMExpandNodeAction
	public sbyte LibraryNodePath;
	public sbyte LibraryNodeContent;
	public TArray<sbyte> LibraryNodeLinks;
	public TArray<sbyte> ExpandedNodePaths;
}
