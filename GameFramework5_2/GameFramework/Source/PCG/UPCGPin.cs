#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGPin.h")]
public partial class UPCGPin : UObject {
// PCGPin
	public UPCGNode Node;
	public sbyte Label_DEPRECATED;
	public TArray<UPCGEdge> Edges;
	public FPCGPinProperties Properties;
	public sbyte GetTooltip(sbyte ReturnValue) { return default; }
	public void SetTooltip(sbyte InTooltip) {}
}
