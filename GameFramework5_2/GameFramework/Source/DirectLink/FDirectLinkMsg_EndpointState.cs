#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DirectLinkMessages.h")]
public partial struct FDirectLinkMsg_EndpointState {
// DirectLinkMsg_EndpointState
	public uint StateRevision;
	public uint MinProtocolVersion;
	public uint ProtocolVersion;
	public sbyte UEVersion;
	public sbyte ComputerName;
	public sbyte UserName;
	public uint ProcessId;
	public sbyte ExecutableName;
	public sbyte NiceName;
	public TArray<FNamedId> Destinations;
	public TArray<FNamedId> Sources;
}
