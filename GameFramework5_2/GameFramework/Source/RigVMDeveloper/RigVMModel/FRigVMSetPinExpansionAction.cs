#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a pin's expansion state in the graph.</summary>
public partial struct FRigVMSetPinExpansionAction {
// RigVMSetPinExpansionAction
	public sbyte PinPath;
	public bool OldIsExpanded;
	public bool NewIsExpanded;
}
