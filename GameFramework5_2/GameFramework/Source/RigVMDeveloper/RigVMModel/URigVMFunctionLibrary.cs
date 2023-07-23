#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMFunctionLibrary.h")]
///<summary>The Function Library is a graph used only to store</summary>
public partial class URigVMFunctionLibrary : URigVMGraph {
// RigVMFunctionLibrary
	public TArray<UObject> GetFunctions(TArray<UObject> ReturnValue) { return default; }
	public UObject FindFunction(sbyte InFunctionName,UObject ReturnValue) { return default; }
	public UObject FindFunctionForNode(UObject InNode,UObject ReturnValue) { return default; }
	public TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> GetReferencesForFunction(sbyte InFunctionName,TArray<TSoftObjectPtr<URigVMFunctionReferenceNode>> ReturnValue) { return default; }
	public TArray<sbyte> GetReferencePathsForFunction(sbyte InFunctionName,TArray<sbyte> ReturnValue) { return default; }
	public TArray<sbyte> PublicFunctionNames;
	public TMap<URigVMLibraryNode,FRigVMFunctionReferenceArray> FunctionReferences_DEPRECATED;
	public TMap<sbyte,URigVMLibraryNode> LocalizedFunctions;
}
