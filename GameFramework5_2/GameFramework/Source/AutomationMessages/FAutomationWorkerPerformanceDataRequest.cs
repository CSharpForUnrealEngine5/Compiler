#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message to request the performance data for this hardware.</summary>
public partial struct FAutomationWorkerPerformanceDataRequest {
// AutomationWorkerPerformanceDataRequest
	public sbyte Platform;
	public sbyte Hardware;
	public sbyte TestName;
	public TArray<double> DataPoints;
}
