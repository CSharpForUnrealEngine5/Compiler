#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/Nodes/RigVMParameterNode.h")]
///<summary>The parameter description is used to convey information</summary>
public partial struct FRigVMGraphParameterDescription {
// RigVMGraphParameterDescription
	public sbyte Name;
	public bool bIsInput;
	public sbyte CPPType;
	public UObject CPPTypeObject;
	public sbyte DefaultValue;
}
