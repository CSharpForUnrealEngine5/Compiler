#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMControllerActions.h")]
///<summary>An action removing an array pin from the graph.</summary>
public partial struct FRigVMRemoveArrayPinAction {
// RigVMRemoveArrayPinAction
	public sbyte ArrayPinPath;
	public int Index;
	public sbyte DefaultValue;
}