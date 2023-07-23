#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMModel/RigVMLink.h")]
///<summary>The Link represents a connection between two Pins</summary>
public partial class URigVMLink : UObject {
// RigVMLink
	public int GetLinkIndex(int ReturnValue) { return default; }
	public UObject GetGraph(UObject ReturnValue) { return default; }
	public UObject GetSourcePin(UObject ReturnValue) { return default; }
	public UObject GetTargetPin(UObject ReturnValue) { return default; }
	public UObject GetOppositePin(UObject InPin,UObject ReturnValue) { return default; }
	public sbyte GetPinPathRepresentation(sbyte ReturnValue) { return default; }
	public sbyte SourcePinPath;
	public sbyte TargetPinPath;
}
