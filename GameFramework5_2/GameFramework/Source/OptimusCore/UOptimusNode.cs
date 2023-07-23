#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNode.h")]
public partial class UOptimusNode : UObject {
// OptimusNode
	public sbyte GetNodeCategory(sbyte ReturnValue) { return default; }
	public sbyte GetNodeName(sbyte ReturnValue) { return default; }
	public sbyte GetDisplayName(sbyte ReturnValue) { return default; }
	public bool SetGraphPosition(FVector2D InPosition,bool ReturnValue) { return default; }
	public FVector2D GetGraphPosition(FVector2D ReturnValue) { return default; }
	public sbyte DisplayName;
	public FVector2D GraphPosition;
	public TArray<UOptimusNodePin> Pins;
	public TSet<sbyte> ExpandedPins;
	public EOptimusDiagnosticLevel DiagnosticLevel;
}
