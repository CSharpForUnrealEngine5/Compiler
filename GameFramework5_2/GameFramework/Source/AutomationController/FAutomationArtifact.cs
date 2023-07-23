#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IAutomationReport.h")]
public partial struct FAutomationArtifact {
// AutomationArtifact
	public FGuid Id;
	public sbyte Name;
	public EAutomationArtifactType Type;
	public TMap<sbyte,sbyte> Files;
}
