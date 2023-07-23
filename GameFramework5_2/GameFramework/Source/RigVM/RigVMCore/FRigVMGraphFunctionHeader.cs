#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMGraphFunctionHeader {
// RigVMGraphFunctionHeader
	public FRigVMGraphFunctionIdentifier LibraryPointer;
	public sbyte Name;
	public sbyte NodeTitle;
	public FLinearColor NodeColor;
	public sbyte Tooltip;
	public sbyte Category;
	public sbyte Keywords;
	public TArray<FRigVMGraphFunctionArgument> Arguments;
	public TMap<FRigVMGraphFunctionIdentifier,uint> Dependencies;
	public TArray<FRigVMExternalVariable> ExternalVariables;
}
