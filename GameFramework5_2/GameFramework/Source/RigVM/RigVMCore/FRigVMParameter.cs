#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVM.h")]
///<summary>The RigVMParameter define an input or output of the RigVM.</summary>
public partial struct FRigVMParameter {
// RigVMParameter
	public ERigVMParameterType Type;
	public sbyte Name;
	public int RegisterIndex;
	public sbyte CPPType;
	public UScriptStruct ScriptStruct;
	public sbyte ScriptStructPath;
}
