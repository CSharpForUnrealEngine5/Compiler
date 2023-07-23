#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action setting a pin's default value in the graph.</summary>
public partial struct FRigVMSetPinDefaultValueAction {
// RigVMSetPinDefaultValueAction
	public sbyte PinPath;
	public sbyte OldDefaultValue;
	public sbyte NewDefaultValue;
}
