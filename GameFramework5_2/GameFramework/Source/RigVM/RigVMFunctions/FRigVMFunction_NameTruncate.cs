#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/RigVMFunction_Name.h")]
///<summary>Returns the left or right most characters from the string chopping the given number of characters from the start or the end</summary>
public partial struct FRigVMFunction_NameTruncate {
// RigVMFunction_NameTruncate
	public sbyte Name;
	public int Count;
	public bool FromEnd;
	public sbyte Remainder;
	public sbyte Chopped;
}
