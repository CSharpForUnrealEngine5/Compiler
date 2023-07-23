#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportEvents.h")]
public partial struct FConcertLog {
// ConcertLog
	public ulong Frame;
	public FGuid MessageId;
	public ushort MessageOrderIndex;
	public ushort ChannelId;
	public FDateTime Timestamp;
	public EConcertLogMessageAction MessageAction;
	public sbyte MessageTypeName;
	public FGuid OriginEndpointId;
	public FGuid DestinationEndpointId;
	public sbyte CustomPayloadTypename;
	public int CustomPayloadUncompressedByteSize;
	public sbyte StringPayload;
	public FConcertSessionSerializedPayload SerializedPayload;
}
