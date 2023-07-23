#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SwarmMessages.h")]
public partial struct FSwarmTaskRequestSpecificationMessage {
// SwarmTaskRequestSpecificationMessage
	public FGuid TaskGuid;
	public sbyte Parameters;
	public byte Flags;
	public uint Cost;
	public TArray<sbyte> Dependencies;
}
