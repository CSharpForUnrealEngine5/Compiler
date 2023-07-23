#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationDeviceClusterManager.h")]
///<summary>Hold information about the Device</summary>
public partial struct FAutomationDeviceInfo {
// AutomationDeviceInfo
	public sbyte DeviceName;
	public sbyte Instance;
	public sbyte Platform;
	public sbyte OSVersion;
	public sbyte Model;
	public sbyte GPU;
	public sbyte CPUModel;
	public uint RAMInGB;
	public sbyte RenderMode;
	public sbyte RHI;
	public sbyte AppInstanceLog;
}
