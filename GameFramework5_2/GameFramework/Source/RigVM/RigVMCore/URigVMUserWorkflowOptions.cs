#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial class URigVMUserWorkflowOptions : UObject {
// RigVMUserWorkflowOptions
	public bool IsValid(bool ReturnValue) { return default; }
	public bool RequiresDialog(bool ReturnValue) { return default; }
	public void ReportError(sbyte InMessage) {}
	public void ReportWarning(sbyte InMessage) {}
	public void ReportInfo(sbyte InMessage) {}
	public UObject Subject;
	public FRigVMUserWorkflow Workflow;
}
