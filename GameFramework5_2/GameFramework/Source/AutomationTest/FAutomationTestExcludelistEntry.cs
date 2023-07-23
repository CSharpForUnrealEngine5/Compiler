#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomationTestExcludelist.h")]
public partial struct FAutomationTestExcludelistEntry {
// AutomationTestExcludelistEntry
	public sbyte Map;
	public sbyte Test;
	public sbyte Reason;
	public TSet<sbyte> RHIs;
	public bool Warn;
}
