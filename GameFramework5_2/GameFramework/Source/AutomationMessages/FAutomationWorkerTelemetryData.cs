#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message that contains telemetry data.</summary>
public partial struct FAutomationWorkerTelemetryData {
// AutomationWorkerTelemetryData
	public sbyte Storage;
	public sbyte Configuration;
	public sbyte Platform;
	public sbyte TestName;
	public TArray<FAutomationWorkerTelemetryItem> Items;
}
