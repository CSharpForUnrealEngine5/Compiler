#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationWorkerMessages.h")]
///<summary>Implements a message to request the running of automation tests on a worker.</summary>
public partial struct FAutomationWorkerRunTests {
// AutomationWorkerRunTests
	public uint ExecutionCount;
	public int RoleIndex;
	public sbyte TestName;
	public sbyte BeautifiedTestName;
	public sbyte FullTestPath;
	public bool bSendAnalytics;
}
