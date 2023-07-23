#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMUserWorkflowRegistry.h")]
public partial class URigVMUserWorkflowRegistry : UObject {
// RigVMUserWorkflowRegistry
	public UObject Get(UObject ReturnValue) { return default; }
	public int RegisterProvider(UObject InStruct,FRigVMUserWorkflowProvider InProvider,int ReturnValue) { return default; }
	public void UnregisterProvider(int InHandle) {}
	public TArray<FRigVMUserWorkflow> GetWorkflows(ERigVMUserWorkflowType InType,UObject InStruct,UObject InSubject,TArray<FRigVMUserWorkflow> ReturnValue) { return default; }
}
