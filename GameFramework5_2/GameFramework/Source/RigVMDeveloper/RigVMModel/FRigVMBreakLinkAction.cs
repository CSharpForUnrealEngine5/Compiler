#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action removing a link from the graph.</summary>
public partial struct FRigVMBreakLinkAction {
// RigVMBreakLinkAction
	public FSoftObjectPath GraphPath;
	public sbyte OutputPinPath;
	public sbyte InputPinPath;
}
