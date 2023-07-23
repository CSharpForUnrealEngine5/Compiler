#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/Determinism/PCGDeterminismTestsCommon.h")]
public partial struct FDeterminismTestResult {
// DeterminismTestResult
	public sbyte TestResultTitle;
	public sbyte TestResultName;
	public int Seed;
	public EPCGDataType DataTypesTested;
	public TMap<sbyte,EDeterminismLevel> TestResults;
	public TArray<sbyte> AdditionalDetails;
	public bool bFlagRaised;
}
