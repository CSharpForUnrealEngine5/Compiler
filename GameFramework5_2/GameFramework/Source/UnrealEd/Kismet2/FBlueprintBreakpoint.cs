#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet2/Breakpoint.h")]
public partial struct FBlueprintBreakpoint {
// BlueprintBreakpoint
	public bool bEnabled;
	public TSoftObjectPtr<UEdGraphNode> Node;
	public bool bStepOnce;
	public bool bStepOnce_WasPreviouslyDisabled;
	public bool bStepOnce_RemoveAfterHit;
}
