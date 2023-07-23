#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMGraphFunctionDefinition.h")]
public partial struct FRigVMFunctionCompilationData {
// RigVMFunctionCompilationData
	public FRigVMByteCode ByteCode;
	public TArray<sbyte> FunctionNames;
	public TArray<FRigVMFunctionCompilationPropertyDescription> WorkPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> WorkPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> LiteralPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> LiteralPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> DebugPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> DebugPropertyPathDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyDescription> ExternalPropertyDescriptions;
	public TArray<FRigVMFunctionCompilationPropertyPath> ExternalPropertyPathDescriptions;
	public TMap<int,sbyte> ExternalRegisterIndexToVariable;
	public TMap<sbyte,FRigVMOperand> Operands;
	public uint Hash;
}
