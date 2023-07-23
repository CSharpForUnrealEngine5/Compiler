#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/UdpMessagingSettings.h")]
public partial class UUdpMessagingSettings : UObject {
// UdpMessagingSettings
	public bool EnabledByDefault;
	public bool EnableTransport;
	public bool bAutoRepair;
	public float MaxSendRate;
	public uint AutoRepairAttemptLimit;
	public ushort WorkQueueSize;
	public bool bStopServiceWhenAppDeactivates;
	public sbyte UnicastEndpoint;
	public sbyte MulticastEndpoint;
	public EUdpMessageFormat MessageFormat;
	public byte MulticastTimeToLive;
	public TArray<sbyte> StaticEndpoints;
	public TArray<sbyte> ExcludedEndpoints;
	public bool EnableTunnel;
	public sbyte TunnelUnicastEndpoint;
	public sbyte TunnelMulticastEndpoint;
	public TArray<sbyte> RemoteTunnelEndpoints;
}
