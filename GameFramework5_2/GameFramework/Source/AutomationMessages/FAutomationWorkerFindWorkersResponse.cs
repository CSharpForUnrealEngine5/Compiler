#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that is sent in response to FAutomationWorkerFindWorkers.</summary>
public partial struct FAutomationWorkerFindWorkersResponse {
// AutomationWorkerFindWorkersResponse
	public sbyte DeviceName;
	public sbyte InstanceName;
	public sbyte Platform;
	public sbyte OSVersionName;
	public sbyte ModelName;
	public sbyte GPUName;
	public sbyte CPUModelName;
	public uint RAMInGB;
	public sbyte RenderModeName;
	public FGuid SessionId;
	public sbyte RHIName;
}
