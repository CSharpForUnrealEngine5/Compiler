#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action injecting a node into a pin</summary>
public partial struct FRigVMInjectNodeIntoPinAction {
// RigVMInjectNodeIntoPinAction
	public sbyte PinPath;
	public bool bAsInput;
	public sbyte InputPinName;
	public sbyte OutputPinName;
	public sbyte NodePath;
}
