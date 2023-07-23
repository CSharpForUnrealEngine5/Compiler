#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action exposing a pin as a parameter</summary>
public partial struct FRigVMAddExposedPinAction {
// RigVMAddExposedPinAction
	public sbyte PinName;
	public ERigVMPinDirection Direction;
	public sbyte CPPType;
	public sbyte CPPTypeObjectPath;
	public sbyte DefaultValue;
}
