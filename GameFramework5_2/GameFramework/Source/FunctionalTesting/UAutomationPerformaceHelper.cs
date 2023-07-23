#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTest.h")]
///<summary>Class for use with functional tests which provides various performance measuring features.</summary>
public partial class UAutomationPerformaceHelper : UObject {
// AutomationPerformaceHelper
	public void Tick(float DeltaSeconds) {}
	public void Sample(float DeltaSeconds) {}
	public void BeginRecordingBaseline(sbyte RecordName) {}
	public void EndRecordingBaseline() {}
	public void BeginRecording(sbyte RecordName,float InGPUBudget,float InRenderThreadBudget,float InGameThreadBudget) {}
	public void EndRecording() {}
	public void WriteLogFile(sbyte CaptureDir,sbyte CaptureExtension) {}
	public bool IsRecording(bool ReturnValue) { return default; }
	public void OnBeginTests() {}
	public void OnAllTestsComplete() {}
	public bool IsCurrentRecordWithinGPUBudget(bool ReturnValue) { return default; }
	public bool IsCurrentRecordWithinGameThreadBudget(bool ReturnValue) { return default; }
	public bool IsCurrentRecordWithinRenderThreadBudget(bool ReturnValue) { return default; }
	public void StartCPUProfiling() {}
	public void StopCPUProfiling() {}
	public void TriggerGPUTraceIfRecordFallsBelowBudget() {}
	public void BeginStatsFile(sbyte RecordName) {}
	public void EndStatsFile() {}
}
