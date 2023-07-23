#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationControllerManager.h")]
public partial struct FAutomatedTestResult {
// AutomatedTestResult
	public sbyte TestDisplayName;
	public sbyte FullTestPath;
	public EAutomationState State;
	public TArray<sbyte> DeviceInstance;
	public float Duration;
	public FDateTime DateTime;
	public TArray<FAutomationExecutionEntry> Entries;
	public int Warnings;
	public int Errors;
	public TArray<FAutomationArtifact> Artifacts;
}
