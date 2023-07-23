#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMCore/RigVMUserWorkflow.h")]
public partial struct FRigVMUserWorkflow {
// RigVMUserWorkflow
	public sbyte Title;
	public sbyte Tooltip;
	public ERigVMUserWorkflowType Type;
	public FRigVMPeformUserWorkflowDynamicDelegate PerformDynamicDelegate;
	public UClass OptionsClass;
}
